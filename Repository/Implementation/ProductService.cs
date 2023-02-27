using InventoryManagement.Models;
using InventoryManagement.Models.Domain;
using InventoryManagement.Repository.Abstract;

namespace InventoryManagement.Repository.Implementation
{
    public class Productservice : IProductService

    {
        private readonly INVDbContext dbc;

        public Productservice(INVDbContext dbc)
        {
            this.dbc = dbc;
        }
        public bool Add(Product model)
        {
            try
            {
                model.ActionType = "Insert";
                model.ActionDate = DateTime.Now;
                dbc.Products.Add(model);
                return true;
            }
            catch (Exception)
            {
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
                dbc.Products.Update(data);
                dbc.SaveChanges();
                return true;
            }
        }

        public Product FindById(int id) => dbc.Products.Find(id);

        public IEnumerable<Product> GetAll() => dbc.Products.ToList();

        public bool Update(Product model)
        {
            try
            {
                model.ActionType = "Update";
                dbc.Products.Update(model);
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
