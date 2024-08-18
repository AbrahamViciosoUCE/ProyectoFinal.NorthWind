using FluentValidation;
using NorthWind.Application.ViewModels;
using NorthWind.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Application.Validators
{
    public class ProductValidator: AbstractValidator<ProductViewModel>
    {
        public ProductValidator() {
            RuleFor(a => a.ProductName).NotNull();
        }
    }
}
