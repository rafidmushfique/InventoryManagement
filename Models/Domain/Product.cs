using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public String ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string? Description { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Value can not be less than 0")]
        public int Price { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Value can not be less than 0")]
        public int Qty { get; set; }
        public int ProductCategoryId { get; set; }
        public int SupplierId { get; set; }
        public string ActionType { get; set; } 
        public DateTime ActionDate { get; set; } 




    }
}
