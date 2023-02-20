using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models.Account
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        public string UserEmail { get; set; }= string.Empty;
        [Required]
        public string Password { get; set; }
        public int AccessLevel { get; set; } = 0;

        public string ActionType { get; set; } = string.Empty;
        public string ActionDate { get; set; } = DateTime.Now.ToString();

    }
}
