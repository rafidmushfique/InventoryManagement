using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models.Domain
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int OrderQty { get; set; }
        public int OrderStatus { get; set; }
        public string ActionType { get; set; } = string.Empty;
        public string ActionDate { get; set; } = DateTime.Now.ToString();
        [Required]
        public string OrderDate { get; set; }
        [Required]
        public string DeliveryDate { get; set; }

        [NotMapped]
        public List <SelectListItem>? ProductList { get; set; }
        [NotMapped]
        public List<SelectListItem>? CustomerList { get;set; }
        [NotMapped]
        public List<SelectListItem>? SupplierList { get; set; }



    }
}
