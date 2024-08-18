using NorthWind.Infrastructure;

namespace NorthWind.Application.Services.CategoryService
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();

    }
}