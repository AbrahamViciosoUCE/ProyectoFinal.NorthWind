using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NorthWind.Application.Abstractions;
using NorthWind.Application.Services.CategoryService;
using NorthWind.Application.Services.ProductService;
using NorthWind.Application.Services.SupplierService;
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
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<ICategoryService, CategoryService>();

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
