using NorthWind.Application.ViewModels;
using NorthWind.Infrastructure;

namespace NorthWind.Application.Services.ProductService
{
    public interface IProductService
    {
        IEnumerable<ProductViewModel> GetAllProducts();
        void CreateProduct(ProductViewModel product);
        IEnumerable<Product> EditProduct(ProductViewModel product);
    }
}