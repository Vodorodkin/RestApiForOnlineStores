using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace RestApiForOnlineStores.API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(ConfigureMvcOptions);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(ConfigureEndpoints);
        }

        private void ConfigureMvcOptions(MvcOptions options)
        {
            
        }

        private void ConfigureEndpoints(IEndpointRouteBuilder builder)
        {
            builder.MapDefaultControllerRoute();
        }
    }
}