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
    private readonly IConfiguration _configuration;
    private ServiceBusProcessor _processor;
    private ServiceBusReceiver _receiver;
    private PeriodicTimer _timer;

    public AzureDevOpsReleaseBackgroundService(ServiceBusClient serviceBusClient, IServiceProvider serviceProvider,
        IConfiguration configuration)
    {
        var queueName = configuration["AzureServiceBusQueueName"];
        _serviceBusClient = serviceBusClient;
        _serviceProvider = serviceProvider;
        _configuration = configuration;
        _receiver = _serviceBusClient.CreateReceiver(queueName);
        _timer = new PeriodicTimer(TimeSpan.FromMinutes(2));
    }

    protected async override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // _processor = _serviceBusClient.CreateProcessor(queueName, new ServiceBusProcessorOptions());
        // _processor.ProcessMessageAsync += MessageHandler;
        // _processor.ProcessErrorAsync += ErrorHandler;
        //
        // await _processor.StartProcessingAsync(stoppingToken);


        await ReceiveMessagesAsync(stoppingToken);
    }

    private async Task ReceiveMessagesAsync(CancellationToken stoppingToken)
    {
        while (await _timer.WaitForNextTickAsync(stoppingToken))
        {
            if (stoppingToken.IsCancellationRequested) break;

            try
            {
                var messages = await _receiver.ReceiveMessagesAsync(10, TimeSpan.FromSeconds(20), stoppingToken);

                if (messages.Count <= 0) continue;

                foreach (var message in messages)
                {
                    var body = message.Body.ToString();
                    var dto = JsonConvert.DeserializeObject<AzureDevOpsWebHookRelease>(body);
                    var request = dto.Adapt<AzureDevOpsWebHookReleaseRequest>();

                    using var scope = _serviceProvider.CreateScope();
                    var service = scope.ServiceProvider.GetRequiredService<IAzureDevOpsWebHookService>();

                    await service.WebHookAsync(request);

                    await _receiver.CompleteMessageAsync(message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
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
        // if (_processor is not null)
        //     await _processor.DisposeAsync();

        if (_receiver is not null)
            await _receiver.DisposeAsync();


        await base.StopAsync(cancellationToken);
    }
}
