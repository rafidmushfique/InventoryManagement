namespace InventoryManagement.Models.Domain
{
    public class Category
    {
        public int Id { get; set; } 
        public String CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public string ActionType { get; set; } 
        public DateTime ActionDate { get; set; }
    }
}
