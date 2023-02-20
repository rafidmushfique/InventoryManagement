using InventoryManagement.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using InventoryManagement.Models.Account;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace InventoryManagement.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService service;

        public UserController(IUserService service)
        {
            this.service = service;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(VMLogin modelLogin)
        {
            if (modelLogin.UserName == "admin@admin.com" && modelLogin.Password == "admin")
            {
                List<Claim> claims = new List<Claim>() { new Claim(ClaimTypes.NameIdentifier,modelLogin.UserName),
                new Claim("OtherProperties","Example")
                };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = modelLogin.KeepLoggedIn,

                };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), properties);
                return RedirectToAction("Index", "Home");
            }
            ViewData["vmsg"] = "User Not Foudn";
            return View();
        }
        public IActionResult Register()
        {
           return View();      
        }
        [HttpPost]
        public IActionResult Add(User model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = service.Add(model);
            if (result)
            {
                
                return RedirectToAction(nameof(Login));
            }
            TempData["msg"] = "Error Occured!!";

            return View(model);
        }
            //public IActionResult Index()
            //{
            //    return View();
            //}
        }
}
