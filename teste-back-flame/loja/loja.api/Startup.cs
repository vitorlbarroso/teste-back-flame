using Microsoft.OpenApi.Models;
using System.Reflection;

namespace loja.api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureService.ConfigureDependenciesService(services, Configuration);

            services.AddControllers();
         
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            //if (app.Environment.IsDevelopment())
            //{
            app.UseSwagger();
            app.UseSwaggerUI();
            //}

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
