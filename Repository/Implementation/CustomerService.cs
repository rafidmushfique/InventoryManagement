using InventoryManagement.Models;
using InventoryManagement.Models.Domain;
using InventoryManagement.Repository.Abstract;

namespace InventoryManagement.Repository.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly INVDbContext dbc;

        public CustomerService(INVDbContext dbc)
        {
            this.dbc = dbc;
        }
        public bool Add(Customer model)
        {
            try {
                model.ActionType = "Insert";
                model.ActionDate = DateTime.Now;
                dbc.Customers.Add(model);
             dbc.SaveChanges();
                return true;
            } 
            catch(Exception) {
                return false;
            }
        }

        public bool Delete(int id)
        {
            var data = this.FindById(id);
            if (data == null) return false;
            else
            {
                data.ActionType = "Delete";
                dbc.Customers.Update(data);
                dbc.SaveChanges();
                return true;
            }
        }

        public Customer FindById(int id) => dbc.Customers.Find(id);

        public IEnumerable<Customer> GetAll()
        {
           return dbc.Customers.ToList();
        }

        public bool Update(Customer model)
        {
            try
            {
               model.ActionType = "Update";

                dbc.Customers.Update(model);
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
