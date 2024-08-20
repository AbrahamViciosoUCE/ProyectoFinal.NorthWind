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

        public IEnumerable<ProductViewModel> CreateProduct(ProductViewModel product)
        {
            ValidationResult validationResult = _validator.Validate(product);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
            return _productRepository.CreateProduct(viewModelToProduct(product)).Select(x => productToViewModel(x));
        }

        public IEnumerable<ProductViewModel> EditProduct(ProductViewModel product)
        {
            ValidationResult validationResult = _validator.Validate(product);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
            return _productRepository.EditProduct(viewModelToProduct(product)).Select(x => productToViewModel(x));
        }

        public IEnumerable<ProductViewModel> GetAllProducts()
        {
            return _productRepository.GetProducts().Select(x => productToViewModel(x));
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

        public ProductViewModel productToViewModel(Product product)
        {
            return new ProductViewModel()
            {
                CategoryName = product.Category is not null? product.Category.CategoryName: "",
                ProductName = product.ProductName,
                SupplierName = product.Supplier is not null ? product.Supplier.CompanyName : "",
                CategoryId = product.CategoryId,
                Discontinued = product.Discontinued,
                ProductId = product.ProductId,
                QuantityPerUnit = product.QuantityPerUnit,
                ReorderLevel = product.ReorderLevel,
                SupplierId = product.SupplierId,
                UnitPrice = product.UnitPrice,
                UnitsInStock = product.UnitsInStock,
                UnitsOnOrder = product.UnitsOnOrder
            };
        }

        public void DeleteProduct(ProductViewModel product)
        {
            _productRepository.DeleteProduct(viewModelToProduct(product));
        }
    }
}
