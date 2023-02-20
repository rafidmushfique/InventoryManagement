using InventoryManagement.Models;
using InventoryManagement.Models.Domain;
using InventoryManagement.Repository.Abstract;

namespace InventoryManagement.Repository.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly INVDbContext dbc;

        public OrderService(INVDbContext dbc)
        {
            this.dbc = dbc;
        }
        public bool Add(Order model)
        {
            try {
             dbc.Orders.Add(model);
                return true;
            } 
            catch(Exception) {
              return false;
            }
        }

        public bool Delete(int id)
        {
            var data= this.FindById(id);
            if (data == null) return false;
            else {
                data.ActionType = "Delete";
                dbc.Orders.Update(data);
                dbc.SaveChanges();
                return true;
            }
        }

        public Order FindById(int id) => dbc.Orders.Find(id);

        public IEnumerable<Order> GetAll() => dbc.Orders.ToList();

        public bool Update(Order model)
        {
            try { 
            model.ActionType = "Update";
            dbc.Orders.Update(model);
                dbc.SaveChanges();
            return true;
            }
            catch(Exception){
                return false;
            }
        }
    }
}
