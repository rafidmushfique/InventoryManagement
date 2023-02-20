using InventoryManagement.Models.Domain;

namespace InventoryManagement.Repository.Abstract
{
    public interface ISupplierService
    {
        bool Add(Supplier model);
        bool Update(Supplier model);
        bool Delete(int id);
        Supplier FindById(int id);
        IEnumerable<Supplier> GetAll();
    }
}
