using NorthWind.Infrastructure;

namespace NorthWind.Application.Services.SupplierService
{
    public interface ISupplierService
    {
        IEnumerable<Supplier> GetAllSuppliers();
    }
}