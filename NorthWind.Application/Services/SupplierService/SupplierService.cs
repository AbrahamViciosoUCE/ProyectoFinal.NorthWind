using FluentValidation;
using FluentValidation.Results;
using NorthWind.Application.Abstractions;
using NorthWind.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Application.Services.SupplierService
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;
        public IValidator<Supplier> _validator { get; }

        public SupplierService(ISupplierRepository supplierRepository, IValidator<Supplier> validator)
        {
            _supplierRepository = supplierRepository;
            _validator = validator;
        }


        public IEnumerable<Supplier> CreateSupplier(Supplier supplier)
        {
            ValidationResult validationResult = _validator.Validate(supplier);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
            return _supplierRepository.CreateSupplier(supplier);
        }

        public IEnumerable<Supplier> EditSupplier(Supplier supplier)
        {
            ValidationResult validationResult = _validator.Validate(supplier);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
            return _supplierRepository.EditSupplier(supplier);
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _supplierRepository.GetSuppliers();
        }

        public void DeleteSupplier(Supplier supplier)
        {
            _supplierRepository.DeleteSupplier(supplier);
        }
    }
}
