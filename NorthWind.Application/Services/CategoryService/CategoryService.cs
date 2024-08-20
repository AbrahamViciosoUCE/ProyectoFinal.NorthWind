using FluentValidation;
using FluentValidation.Results;
using NorthWind.Application.Abstractions;
using NorthWind.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Application.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public ICategoryRepository _categoryRepository;
        public IValidator<Category> validator;
        public CategoryService(ICategoryRepository categoryRepository, IValidator<Category> validator)
        {
            _categoryRepository = categoryRepository;
            this.validator = validator;
        }

        public IEnumerable<Category> CreateCategory(Category category)
        {
            ValidationResult validationResult = validator.Validate(category);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
            return _categoryRepository.CreateCategory(category);
        }

        public void DeleteCategory(Category category)
        {
            _categoryRepository.DeleteCategory(category);   
        }

        public IEnumerable<Category> EditCategory(Category category)
        {
            ValidationResult validationResult = validator.Validate(category);
            if (!validationResult.IsValid) {
                throw new ValidationException(validationResult.Errors);
            }
            return _categoryRepository.EditCategory(category);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRepository.GetCategories();
        }
    }
}
