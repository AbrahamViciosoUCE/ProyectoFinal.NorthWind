using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NorthWind.Application.Abstractions;
using NorthWind.Infrastructure.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Infrastructure
{
    public static class DependencyInjection
    {
        public static ServiceCollection AddInfrastructureLayer(this ServiceCollection services)
        {
            services.AddScoped<IProductRepository,ProductRepository>();

            services.AddDbContext<NorthWindContext>(options => {
                options.UseSqlServer("Data Source=localhost;Initial Catalog=NorthWind;Integrated Security=True;Trust Server Certificate=True");
            });

            return services;
        }
    }
}
