using Loja.Domain.Interfaces;
using Loja.Infrastruture;
using Loja.Infrastruture.EF;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Ioc
{
    public static class DependencyInjectionContainer
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {

            services.AddScoped<ITestRepository, TestRepository>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<Context>();
            

        }
    }
}
