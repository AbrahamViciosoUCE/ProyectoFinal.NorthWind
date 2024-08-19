using NorthWind.Infrastructure;

namespace NorthWind.Application.Services.SupplierService
{
    public interface ISupplierService
    {
        IEnumerable<Supplier> GetAllSuppliers();
        IEnumerable<Supplier> EditSupplier(Supplier supplier);
        IEnumerable<Supplier> CreateSupplier(Supplier supplier);
    }
}