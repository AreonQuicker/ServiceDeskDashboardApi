using Azure.Messaging.ServiceBus;
using Mapster;
using Newtonsoft.Json;
using ServiceDeskDashboardApi.Dtos;
using ServiceDeskDashboardApi.Interfaces;
using ServiceDeskDashboardApi.Models;
using Task = System.Threading.Tasks.Task;

namespace ServiceDeskDashboardApi.BackgroundServices;

public class AzureDevOpsReleaseBackgroundService : BackgroundService
{
    private readonly ServiceBusClient _serviceBusClient;
    private readonly IServiceProvider _serviceProvider;
    private ServiceBusProcessor _processor;

    public AzureDevOpsReleaseBackgroundService(ServiceBusClient serviceBusClient, IServiceProvider serviceProvider)
    {
        _serviceBusClient = serviceBusClient;
        _serviceProvider = serviceProvider;
    }

    protected async override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _processor = _serviceBusClient.CreateProcessor("azuredevopswebhook", new ServiceBusProcessorOptions());
        _processor.ProcessMessageAsync += MessageHandler;
        _processor.ProcessErrorAsync += ErrorHandler;

        await _processor.StartProcessingAsync(stoppingToken);
    }

    private async Task ErrorHandler(ProcessErrorEventArgs arg)
    {
    }

    private async Task MessageHandler(ProcessMessageEventArgs arg)
    {
        try
        {
            var body = arg.Message.Body.ToString();
            var dto = JsonConvert.DeserializeObject<AzureDevOpsWebHookRelease>(body);
            var request = dto.Adapt<AzureDevOpsWebHookReleaseRequest>();

            using var scope = _serviceProvider.CreateScope();
            var service = scope.ServiceProvider.GetRequiredService<IAzureDevOpsWebHookService>();

            await service.WebHookAsync(request);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            await arg.CompleteMessageAsync(arg.Message);
        }
    }

    public async override Task StopAsync(CancellationToken cancellationToken)
    {
        if (_processor is not null)
            await _processor.DisposeAsync();

        await base.StopAsync(cancellationToken);
    }
}
