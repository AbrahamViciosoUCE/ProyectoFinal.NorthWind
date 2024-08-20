using NorthWind.Application.ViewModels;
using NorthWind.Infrastructure;

namespace NorthWind.Application.Services.ProductService
{
    public interface IProductService
    {
        IEnumerable<ProductViewModel> GetAllProducts();
        IEnumerable<ProductViewModel> CreateProduct(ProductViewModel product);
        IEnumerable<ProductViewModel> EditProduct(ProductViewModel product);
        void DeleteProduct(ProductViewModel product);
    }
}