using InventoryManagement.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService service;

        public CategoryController(ICategoryService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
