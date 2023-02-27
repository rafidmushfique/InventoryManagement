using InventoryManagement.Models.Domain;
using InventoryManagement.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ISupplierService service;

        public SupplierController(ISupplierService Service)
        {
            service = Service;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddSupplier() {
            
                return View();
            
        }

        [HttpPost]
        public IActionResult AddSupplier(Supplier model) {
            model.ActionDate= DateTime.Now;
            model.ActionType = "INSERT";
            model.SupplierId = Guid.NewGuid().ToString();
            var result = service.Add(model);
            if (result) {
                TempData["msg"] = "Data Save Success!";
                return View();
            }

            else
            {
                TempData["msg"] = "Error Occured!!";

                return RedirectToAction("AddSupplier");
            }
           
            
        
        }
        public IActionResult Delete (int id)
        {
            return RedirectToAction(nameof(AddSupplier));
        }
    }
}
