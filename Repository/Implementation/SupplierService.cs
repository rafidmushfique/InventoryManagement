﻿using InventoryManagement.Models;
using InventoryManagement.Models.Domain;
using InventoryManagement.Repository.Abstract;
using Microsoft.Data.SqlClient;

namespace InventoryManagement.Repository.Implementation
{
    public class SupplierService : ISupplierService
    {
        private readonly INVDbContext dbc;

        public SupplierService(INVDbContext dbc)
        {
            this.dbc = dbc;
        }
        public bool Add(Supplier model)
        {
            try
            {
                model.ActionType = "Insert";
                model.ActionDate = DateTime.Now;
                dbc.Suppliers.Add(model);
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
                dbc.Suppliers.Update(data);
                dbc.SaveChanges();
                return true;
            }
        }

        public Supplier FindById(int id) => dbc.Suppliers.Find(id);

        public IEnumerable<Supplier> GetAll()
        { 
        return dbc.Suppliers.Where(x=> x.ActionType !="Delete").ToList();
        }

        //public IEnumerable<JsonContent> GetAllData() {
        //    SqlCommand sqlcmd = new SqlCommand(""); 
        //}
        public bool Update(Supplier model)
        {
            try
            {
                model.ActionType = "Update";
                dbc.Suppliers.Update(model);
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
