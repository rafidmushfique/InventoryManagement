namespace InventoryManagement.Models.Domain
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set;}
        public string ContactInfo { get; set; }
        public string ActionType { get; set; }= string.Empty;
        public string ActionDate { get; set; } = DateTime.Now.ToString();

    }
    }

