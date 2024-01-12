using loja.data.Repositories;
using loja.data.Services;
using loja.domain.Interfaces.Repositories;
using loja.domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
    
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ISalesService, SalesService>();


            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ISalesRepository, SalesRepository>();
        }
    }
}

