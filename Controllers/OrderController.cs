using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
