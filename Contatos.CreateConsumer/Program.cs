using Contatos.CreateConsumer.Interfaces;
using Contatos.CreateConsumer.Repository;
using Contatos.CreateConsumer.Services;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using MassTransit;
using Serilog;
using Serilog.Events;

namespace Contatos.CreateConsumer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.File(path: "Logs/CreateConsumerLogs.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            try
            {
                var builder = WebApplication.CreateBuilder(args);

                builder.Services.AddSerilog();
                
                builder.Services.AddAuthorization();
                builder.Services.AddOpenApi();

                builder.Services.AddMassTransit(x =>
                {
                    x.AddConsumer<CadastrarContatoConsumer>();

                    x.UsingRabbitMq((context, cfg) =>
                    {
                        cfg.Host("rabbitmq");

                        //cfg.Host("localhost", "/", h =>
                        //{
                        //    h.Username("guest");
                        //    h.Password("guest");
                        //});

                        cfg.ConfigureEndpoints(context);
                    });
                });

                builder.Services.AddSingleton<IContatoRepository, ContatoRepository>();

                var app = builder.Build();

                if (app.Environment.IsDevelopment())
                {
                    app.MapOpenApi();
                }

                app.MapHealthChecks("/health/ready", new HealthCheckOptions()
                {
                    Predicate = (check) => check.Tags.Contains("ready"),
                });
                app.MapHealthChecks("/health/live", new HealthCheckOptions());

                app.MapGet("/", () => Results.Ok("Serviço disponível.")).WithName("HealthCheck");

                app.UseHttpsRedirection();
                app.UseAuthorization();

                app.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal($"O serviço Contatos.CreateConsumer encerrou inesperadamente. Exception: {ex.GetType()}. Message: {ex.Message}.");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
