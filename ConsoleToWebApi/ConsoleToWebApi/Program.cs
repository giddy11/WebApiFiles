// See https://aka.ms/new-console-template for more information
using ConsoleToWebApi;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
CreateHostBuilder(args).Build().Run();


static IHostBuilder CreateHostBuilder(string[] args) =>

    Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webHost =>
        {
            webHost.UseStartup<Startup>();
        });

