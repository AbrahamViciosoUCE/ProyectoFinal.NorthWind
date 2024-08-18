using NorthWind.Infrastructure;

namespace NorthWind.Application.Services.CategoryService
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();
        void CreateCategory(Category category);
        IEnumerable<Category> EditCategory(Category category);
    }
}