﻿using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
