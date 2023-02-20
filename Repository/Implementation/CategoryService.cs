using InventoryManagement.Models;
using InventoryManagement.Models.Domain;
using InventoryManagement.Repository.Abstract;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace InventoryManagement.Repository.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly INVDbContext dbc;

        public CategoryService(INVDbContext dbc)
        {
            this.dbc = dbc;
        }
        public bool Add(Category model)
        {
            try {
                dbc.Categories.Add(model);
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
                dbc.Categories.Update(data);
                dbc.SaveChanges();
                return true;
            }
            //else {
            //    dbc.Categories.Remove(data);
            //    dbc.SaveChanges();
            //    return true;
            //}

        }

        public Category FindById(int id) => dbc.Categories.Find(id);

        public IEnumerable<Category> GetAll()
        {
           return dbc.Categories.ToList();
        }
        
        public bool Update(Category model)
        {
            try
            {
                model.ActionType = "Update"; 

                dbc.Categories.Update(model);
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
