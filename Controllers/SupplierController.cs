using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    public class SupplierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
