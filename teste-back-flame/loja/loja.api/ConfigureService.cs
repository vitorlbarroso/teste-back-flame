


using loja.domain.Interfaces;
using loja.domain.Repositories;

namespace loja.api
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection services, IConfiguration configuration)
        {
           
            services.AddScoped(typeof(IProductRepository), typeof(ProductRepository)).Reverse();
           // services.AddScoped(typeof(IEventUserRepository), typeof(EventUserRepository)).Reverse();
            

        }
    }
}
