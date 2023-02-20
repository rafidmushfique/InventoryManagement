using InventoryManagement.Models.Domain;

namespace InventoryManagement.Repository.Abstract
{
    public interface IProductService
    {
        bool Add(Product model);
        bool Update(Product model);
        bool Delete(int id);
        Product FindById(int id);
        IEnumerable<Product> GetAll();
    }
}
