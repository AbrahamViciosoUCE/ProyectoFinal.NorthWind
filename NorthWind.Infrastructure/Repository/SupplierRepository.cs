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

        public IEnumerable<Supplier> GetSuppliers()
        {
            return _northWindContext.Suppliers;
        }
    }
}
