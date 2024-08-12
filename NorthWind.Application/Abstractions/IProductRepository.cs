using NorthWind.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Application.Abstractions
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
