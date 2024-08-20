using FluentValidation;
using NorthWind.Application;
using NorthWind.Application.Abstractions;
using NorthWind.Application.Services.ProductService;
using NorthWind.Application.Validators;
using NorthWind.Application.ViewModels;
using NorthWind.Infrastructure;

namespace NorthWind.UnitTest
{
    [TestClass]
    public class ProductServiceTest
    {
        [TestMethod]
        public void Create_ProductServiceTest()
        {
            ProductService productService = GetProductService();

            Assert.ThrowsException<ValidationException>(() =>
            {
                productService.CreateProduct(new ProductViewModel());
            });
        }

        [TestMethod]
        public void Edit_ProductServiceTest()
        {
            ProductService productService = GetProductService();

            Assert.ThrowsException<ValidationException>(() =>
            {
                productService.CreateProduct(new ProductViewModel());
            });
        }

        public ProductService GetProductService()
        {
            return new ProductService(new ProductRepositoryMock(), new ProductValidator());
        }
    }

    public class ProductRepositoryMock : IProductRepository
    {
        private List<Product> products = new List<Product>();

        public IEnumerable<Product> CreateProduct(Product product)
        {
            products.Add(product);
            return products;
        }

        public void DeleteProduct(Product product)
        {
            products.Remove(product);
        }

        public IEnumerable<Product> EditProduct(Product product)
        {
            return products.Where(x => x.ProductId == product.ProductId);
        }

        IEnumerable<Product> IProductRepository.GetProducts()
        {
            return products;
        }
    }
}