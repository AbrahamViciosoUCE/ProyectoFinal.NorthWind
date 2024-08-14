using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NorthWind.Application.Abstractions;
using NorthWind.Application.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Infrastructure
{
    public static class DependencyInjection
    {
        public static ServiceCollection AddApplicationLayer(this ServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
