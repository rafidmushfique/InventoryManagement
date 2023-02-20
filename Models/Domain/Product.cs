namespace InventoryManagement.Models.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public int ProductCategory { get; set; }
        public int SupplierId { get; set; }
        public string ActionType { get; set; } = string.Empty;
        public string ActionDate { get; set; } = DateTime.Now.ToString();




    }
}
