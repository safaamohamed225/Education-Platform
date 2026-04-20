
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Management.Monitor.Fluent.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureAppConfiguration((context, config) =>
    {
        config.AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
              .AddEnvironmentVariables();
    })
    .ConfigureServices(services =>
    {
        services.AddHttpClient(); // Register HttpClient
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
    })
     .ConfigureLogging(logging =>
     {
         logging.AddConsole();
     })
    .Build();

host.Run();