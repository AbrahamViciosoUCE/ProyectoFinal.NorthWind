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

namespace NorthWind.Application.Services.ProductService
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;
        private IValidator<ProductViewModel> _validator;

        public ProductService(IProductRepository productRepository, IValidator<ProductViewModel> validator)
        {
            _productRepository = productRepository;
            _validator = validator;
        }

        public void CreateProduct(ProductViewModel product)
        {
            ValidationResult validationResult = _validator.Validate(product);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
            _productRepository.CreateProduct(viewModelToProduct(product));
        }

        public IEnumerable<Product> EditProduct(ProductViewModel product)
        {
            ValidationResult validationResult = _validator.Validate(product);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
            return _productRepository.EditProduct(viewModelToProduct(product));
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

        public Product viewModelToProduct(ProductViewModel productViewModel)
        {
            return new Product()
            {
                ProductId = productViewModel.ProductId,
                CategoryId = productViewModel.CategoryId,
                SupplierId = productViewModel.SupplierId,
                ProductName = productViewModel.ProductName,
                QuantityPerUnit = productViewModel.QuantityPerUnit,
                ReorderLevel = productViewModel.ReorderLevel,
                UnitsOnOrder = productViewModel.UnitsOnOrder,
                UnitPrice = productViewModel.UnitPrice,
                UnitsInStock = productViewModel.UnitsInStock,
                Discontinued = productViewModel.Discontinued,
            };
        }
    }
}
