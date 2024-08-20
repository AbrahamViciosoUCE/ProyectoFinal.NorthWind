using NorthWind.Infrastructure;

namespace NorthWind.Application.Services.CategoryService
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();
        IEnumerable<Category> CreateCategory(Category category);
        IEnumerable<Category> EditCategory(Category category);
        void DeleteCategory(Category category);
    }
}