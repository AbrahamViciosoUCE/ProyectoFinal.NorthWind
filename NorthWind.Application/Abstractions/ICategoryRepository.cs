using NorthWind.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Application.Abstractions
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Category> CreateCategory(Category category);
        IEnumerable<Category> EditCategory(Category category);
    }
}
