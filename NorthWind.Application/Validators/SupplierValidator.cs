using FluentValidation;
using NorthWind.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Application.Validators
{
    public class SupplierValidator: AbstractValidator<Supplier>
    {
        public SupplierValidator() {
            RuleFor(a => a.CompanyName).NotNull().MaximumLength(40);
            RuleFor(a => a.ContactName).MaximumLength(30);
            RuleFor(a => a.ContactTitle).MaximumLength(30);
            RuleFor(a => a.Address).MaximumLength(60);
            RuleFor(a => a.City).MaximumLength(15);
            RuleFor(a => a.Region).MaximumLength(15);
            RuleFor(a => a.PostalCode).MaximumLength(10);
            RuleFor(a => a.Country).MaximumLength(15);
            RuleFor(a => a.Phone).MaximumLength(24);
            RuleFor(a => a.Fax).MaximumLength(24);
        }
    }
}
