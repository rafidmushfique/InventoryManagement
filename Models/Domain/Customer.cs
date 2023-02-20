namespace InventoryManagement.Models.Domain
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerContactInfo { get; set; }

        public string ActionType { get; set; } = string.Empty;
        public string ActionDate { get; set; } = DateTime.Now.ToString();
    }
}
