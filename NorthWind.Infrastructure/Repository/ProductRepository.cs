using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<Product> CreateProduct(Product product)
        {
            _northWindContext.Products.Add(product);

            _northWindContext.SaveChanges();

            return _northWindContext.Products.Where(x => x.ProductId == product.ProductId);
        }

        public void DeleteProduct(Product product)
        {
            _northWindContext.Products.Remove(product);
            _northWindContext.SaveChanges();
        }

        public IEnumerable<Product> EditProduct(Product product)
        {
            _northWindContext.Products.Update(product);

            _northWindContext.SaveChanges();

            return _northWindContext.Products.Where(x => x.ProductId == product.ProductId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _northWindContext.Products
                .Include(x => x.Category)
                .Include(x => x.Supplier)
                .AsNoTracking();
        }
    }
}
