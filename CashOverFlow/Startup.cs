using CashOverFlow.Brokers.Loggeings;
using CashOverFlow.Brokers.Loggings;
using CashOverFlow.Brokers.Storages;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace CashOverFlow;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {

        services.AddControllers();
        services.AddDbContext<StorageBroker>();

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc(name: "v1", info: new OpenApiInfo { Title = "CashOverFlow", Version = "v1" });
        });

        AddBrokers(services);
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(config => config.SwaggerEndpoint(url: "/swagger/v1/swagger.json", name: "CashOverFlow v1"));
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }

    private void AddBrokers( IServiceCollection services)
    {
        services.AddTransient<IStorageBroker, StorageBroker>();
        services.AddTransient<ILoggingBroker, LoggingBroker>();
    }
}
