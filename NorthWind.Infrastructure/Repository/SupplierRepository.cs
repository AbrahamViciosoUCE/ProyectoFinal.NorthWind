using NorthWind.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Infrastructure.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly NorthWindContext _northWindContext;

        public SupplierRepository(NorthWindContext northWindContext) {
            _northWindContext = northWindContext;
        }

        public IEnumerable<Supplier> CreateSupplier(Supplier supplier)
        {
            _northWindContext.Suppliers.Add(supplier);
            _northWindContext.SaveChanges();
            return _northWindContext.Suppliers.Where(x => supplier.SupplierId == x.SupplierId);
        }

        public void DeleteSupplier(Supplier supplier)
        {
            _northWindContext.Suppliers.Remove(supplier);
            _northWindContext.SaveChanges();
        }

        public IEnumerable<Supplier> EditSupplier(Supplier supplier)
        {
            _northWindContext.Suppliers.Update(supplier);
            _northWindContext.SaveChanges();
            return _northWindContext.Suppliers.Where(x => supplier.SupplierId == x.SupplierId);
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            return _northWindContext.Suppliers;
        }
    }
}
