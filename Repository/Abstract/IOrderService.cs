using InventoryManagement.Models.Domain;

namespace InventoryManagement.Repository.Abstract
{
    public interface IOrderService
    {
        bool Add(Order model);
        bool Update(Order model);
        bool Delete(int id);
        Order FindById(int id);
        IEnumerable<Order> GetAll();
    }
}
