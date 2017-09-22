using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using DanubiusInfo.B4USApi.Data;
using DanubiusInfo.B4USApi.Providers.Interfaces;
using DanubiusInfo.B4USApi.Providers;
using DanubiusInfo.B4USApi.Services.Interfaces;
using DanubiusInfo.B4USApi.Services;
using DanubiusInfo.B4USApi.UOW;

namespace DanubiusInfo.B4USApi.Api
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add DbContext
            services.AddScoped(context => new B4USContext(this.Configuration.GetConnectionString("DefaultConnection")));
            
            // Add framework services.
            services.AddMvc();

            // Add own services
            services.AddTransient<ILocationProvider, LocationProvider>();
            services.AddTransient<IReservationProvider, ReservationProvider>();
            services.AddTransient<IServiceProvider, ServiceProvider>();
            services.AddTransient<IServiceAndLocationService, ServiceAndLocationService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
        }
    }
}
