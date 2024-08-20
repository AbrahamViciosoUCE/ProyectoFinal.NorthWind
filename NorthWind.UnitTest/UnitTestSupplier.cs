using FluentValidation;
using NorthWind.Application.Abstractions;
using NorthWind.Application.Services.SupplierService;
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
    public class UnitTestSupplier
    {
        [TestMethod]
        public void Create_SupplierServiceTest(){ 
        
            SupplierService supplierService = GetSupplierService();

            Assert.ThrowsException<ValidationException>(() =>
            {
                supplierService.CreateSupplier(new Supplier());
            });

        }

        [TestMethod]
        public void Edit_SupplierServiceTest()
        {

            SupplierService supplierService = GetSupplierService();

            Assert.ThrowsException<ValidationException>(() =>
            {
                supplierService.EditSupplier(new Supplier());
            });

        }

        public SupplierService GetSupplierService()
        {
            return new SupplierService(new SupplierRepositoryMock(), new SupplierValidator());
        }
    }

    public class SupplierRepositoryMock : ISupplierRepository
    {
        public List<Supplier> _suppliers = new List<Supplier>();

        public IEnumerable<Supplier> CreateSupplier(Supplier supplier)
        {
            _suppliers.Add(supplier);
            return _suppliers;
        }

        public void DeleteSupplier(Supplier supplier)
        {
            _suppliers.Remove(supplier);
        }

        public IEnumerable<Supplier> EditSupplier(Supplier supplier)
        {
            Supplier _supplier = _suppliers.Find(x => x == supplier);
            _supplier = supplier;
            return _suppliers;
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            return _suppliers;
        }
    }
}
