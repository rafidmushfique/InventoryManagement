using InventoryManagement.Models.Domain;

namespace InventoryManagement.Repository.Abstract
{
    public interface ICustomerService
    {
        bool Add(Customer model);
        bool Update(Customer model);
        bool Delete(int id);
        Customer FindById(int id);
        IEnumerable<Customer> GetAll();
    }
}
