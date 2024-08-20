using FluentValidation;
using NorthWind.Application.Abstractions;
using NorthWind.Application.Services.CategoryService;
using NorthWind.Application.Validators;
using NorthWind.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.UnitTest
{
    [TestClass]
    public class UnitTestCategory
    {
        [TestMethod]
        public void Create_CategoryServiceTest()
        {
            CategoryService categoryService = GetCategoryService();

            Assert.ThrowsException<ValidationException>(() =>
            {
                categoryService.CreateCategory(new Category());
            });
        }

        [TestMethod]
        public void Edit_CategoryServiceTest()
        {
            CategoryService categoryService = GetCategoryService();

            Assert.ThrowsException<ValidationException>(() =>
            {
                categoryService.EditCategory(new Category());
            });
        }

        public CategoryService GetCategoryService() {
            return new CategoryService(new CategoryRepositoryMock(), new CategoryValidator());
        }
    }

    public class CategoryRepositoryMock : ICategoryRepository
    {
        public List<Category> _categories = new List<Category>();
        public IEnumerable<Category> CreateCategory(Category category)
        {
            _categories.Add(category);
            return _categories;
        }

        public void DeleteCategory(Category category)
        {
            _categories.Remove(category);
        }

        public IEnumerable<Category> EditCategory(Category category)
        {
            Category _category = _categories.Find(x => category == x);
            _category = category;
            return _categories;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categories;
        }
    }
}
