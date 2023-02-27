using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public String OrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int OrderQty { get; set; }
        public int OrderStatus { get; set; }
        public string ActionType { get; set; } 
        public DateTime ActionDate { get; set; }
  
        public DateTime OrderDate { get; set; }
   
        public DateTime DeliveryDate { get; set; }

        [NotMapped]
        public List <SelectListItem>? ProductList { get; set; }
        [NotMapped]
        public List<SelectListItem>? CustomerList { get;set; }
        [NotMapped]
        public List<SelectListItem>? SupplierList { get; set; }



    }
}
