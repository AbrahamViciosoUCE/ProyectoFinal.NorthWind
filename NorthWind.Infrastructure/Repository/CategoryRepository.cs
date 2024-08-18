using Microsoft.EntityFrameworkCore;
using NorthWind.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Infrastructure.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public NorthWindContext _northWindContext { get; }

        public CategoryRepository(NorthWindContext northWindContext)
        {
            _northWindContext = northWindContext;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _northWindContext.Categories.AsNoTracking();
        }

        public IEnumerable<Category> CreateCategory(Category category)
        {
            _northWindContext.Categories.Add(category);
            _northWindContext.SaveChanges();
            return _northWindContext.Categories;
        }

        public IEnumerable<Category> EditCategory(Category category)
        {
            _northWindContext.Categories.Update(category);
            _northWindContext.SaveChanges();
            return _northWindContext.Categories.Where(x => x.CategoryId == category.CategoryId);
        }
    }
}
