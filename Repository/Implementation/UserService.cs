using InventoryManagement.Models.Account;
using InventoryManagement.Models.Domain;
using InventoryManagement.Repository.Abstract;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using InventoryManagement.Models;

namespace InventoryManagement.Repository.Implementation
{
    public class UserService : IUserService
    {
        private readonly INVDbContext dbc;

        public UserService(INVDbContext dbc)
        {
            this.dbc = dbc;
        }
        public bool Add(User model)
        {
            try {
                dbc.Users.Add(model);
                dbc.SaveChanges();
                return true;
            } 
            catch(Exception ex) { 
            return false;
            }

        }

        public bool Delete(int id)
        {
            var data = this.FindById(id);
            if (data == null) return false;
            else {
                data.ActionType = "Delete";
                dbc.Users.Update(data);
                dbc.SaveChanges();
                return true;
            }
            //else {
            //    dbc.Users.Remove(data);
            //    dbc.SaveChanges();
            //    return true;
            //}

        }

        public User FindById(int id) => dbc.Users.Find(id);

        public IEnumerable<User> GetAll()
        {
           return dbc.Users.ToList();
        }
        
        public bool Update(User model)
        {
            try
            {
                model.ActionType = "Update"; 

                dbc.Users.Update(model);
                dbc.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
