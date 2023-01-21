using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RandomNamePicker;
using RandomNamePicker.Abstractions;
using RandomNamePicker.Invoker;

using IHost host = CreateHostBuilder(args).Build();

await host.RunAsync();

static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureServices((_, services) =>
        {
            services.AddSingleton<ICommandInvoker, CommandInvoker>();
            services.AddHostedService<RandomNameGame>();
        });



