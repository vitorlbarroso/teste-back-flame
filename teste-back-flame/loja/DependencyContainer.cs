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
            //Shop.Application
            services.AddScoped<IProductService, ProductService>();

            //Shop.Domain.Interfaces e Shop.Infra.Data.Repositories
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}

