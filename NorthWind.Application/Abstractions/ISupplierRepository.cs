using NorthWind.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Application.Abstractions
{
    public interface ISupplierRepository
    {
        IEnumerable<Supplier> GetSuppliers();
        IEnumerable<Supplier> CreateSupplier(Supplier supplier);
        IEnumerable<Supplier> EditSupplier(Supplier supplier);
        void DeleteSupplier(Supplier supplier);
    }
}
