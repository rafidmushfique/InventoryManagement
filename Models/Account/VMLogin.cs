using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models.Account
{
    [NotMapped]
    public class VMLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool KeepLoggedIn { get; set; }

    }
}
