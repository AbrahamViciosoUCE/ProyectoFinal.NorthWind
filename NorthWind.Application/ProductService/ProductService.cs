using FluentValidation;
using FluentValidation.Results;
using NorthWind.Application.Abstractions;
using NorthWind.Application.ViewModels;
using NorthWind.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Application.ProductService
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;
        private IValidator<Product> _validator;

        public ProductService(IProductRepository productRepository, IValidator<Product> validator)
        {
            _productRepository = productRepository;
            _validator = validator;
        }

        public IEnumerable<Product> CreateProduct(Product product)
        {
            ValidationResult validationResult = _validator.Validate(product);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            return _productRepository.CreateProduct(product);
        }

        public IEnumerable<ProductViewModel> GetAllProducts()
        {
            return _productRepository.GetProducts().Select(x => new ProductViewModel()
            {
                CategoryName = x.Category.CategoryName,
                ProductName = x.ProductName,
                SupplierName = x.Supplier.CompanyName,
                CategoryId = x.CategoryId,
                Discontinued = x.Discontinued,
                ProductId = x.ProductId, 
                QuantityPerUnit = x.QuantityPerUnit,
                ReorderLevel = x.ReorderLevel,
                SupplierId = x.SupplierId,
                UnitPrice = x.UnitPrice,
                UnitsInStock = x.UnitsInStock,
                UnitsOnOrder = x.UnitsOnOrder
            });
        }

    }
}
