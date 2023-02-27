namespace InventoryManagement.Models.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public String CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerContactInfo { get; set; }

        public string ActionType { get; set; } 
        public DateTime ActionDate { get; set; } 
    }
}
