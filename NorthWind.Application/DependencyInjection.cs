using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NorthWind.Application.Abstractions;
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
        public static ServiceCollection AddApplicationLayer(this ServiceCollection services)
        {
            return services;
        }
    }
}
