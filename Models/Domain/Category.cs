namespace InventoryManagement.Models.Domain
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public string ActionType { get; set; }
        
        public string ActionDate { get; set; } = DateTime.Now.ToString();

    }
}
