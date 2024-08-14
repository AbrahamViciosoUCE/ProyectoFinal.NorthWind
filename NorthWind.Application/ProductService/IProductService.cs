using NorthWind.Application.ViewModels;
using NorthWind.Infrastructure;

namespace NorthWind.Application.ProductService
{
    public interface IProductService
    {
        IEnumerable<ProductViewModel> GetAllProducts();
        IEnumerable<Product> CreateProduct(Product product);
    }
}