using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Azure;
using ServiceDeskDashboardApi.BackgroundServices;
using ServiceDeskDashboardApi.Context;
using ServiceDeskDashboardApi.Interfaces;
using ServiceDeskDashboardApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAzureDevOpsWebHookService, AzureDevOpsWebHookService>();
builder.Services.Configure<ApiBehaviorOptions>(options => { options.SuppressModelStateInvalidFilter = true; });


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

var serviceBusConnectionString = builder.Configuration.GetValue<string>("AzureServiceBusConnectionString");

//Add Azure service bus client
builder.Services.AddAzureClients(b =>
{
    b.AddServiceBusClient(
        serviceBusConnectionString);
});


builder.Services.AddHostedService<AzureDevOpsReleaseBackgroundService>();

builder.Services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
