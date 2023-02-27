using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models.Domain
{
    public class Supplier
    {
        public int Id { get; set; }
        
        public String SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set;}
        public string ContactInfo { get; set; }
        public string ActionType { get; set; }
        public DateTime ActionDate { get; set; }

        [NotMapped]
        public IEnumerable<Supplier>? SuppliersList { get; set;}
 
    }
    }

