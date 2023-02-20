using InventoryManagement.Models.Account;

namespace InventoryManagement.Repository.Abstract
{
    public interface IUserService
    {
        bool Add(User model);
        bool Update(User model);
        bool Delete(int id);
        User FindById(int id);
        IEnumerable<User> GetAll();
    }
}
