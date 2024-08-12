using NorthWind.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Infrastructure.Respository
{
    internal class ProductRepository : IProductRepository
    {
        private NorthWindContext _northWindContext;

        public ProductRepository(NorthWindContext northWindContext) {
            _northWindContext = northWindContext;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _northWindContext.Products;
        }
    }
}
