using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models.Account
{
    public class User
    {
        public int Id { get; set; }
        public String UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public string ActionType { get; set; } /*= "Insert";*/
        public DateTime ActionDate { get; set; } /*= DateTime.Now.ToString();*/

    }
}
