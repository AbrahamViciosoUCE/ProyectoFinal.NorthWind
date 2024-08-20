using FluentValidation;
using NorthWind.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Application.Validators
{
    public class CategoryValidator: AbstractValidator<Category>
    {
        public CategoryValidator() {
            RuleFor(a => a.CategoryName).MaximumLength(15).NotNull();
        }
    }
}
