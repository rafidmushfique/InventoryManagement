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
            @ViewData["vmsg"] = "";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(VMLogin modelLogin)
        {
            var usertext= System.Text.Encoding.UTF8.GetBytes(modelLogin.Password);
            var userinputpass= System.Convert.ToBase64String(usertext);

            var admintxt= System.Text.Encoding.UTF8.GetBytes("admin");
            var adminpass=System.Convert.ToBase64String(admintxt);
            if (modelLogin.UserId == "01" && userinputpass == adminpass)
            {
                List<Claim> claims = new List<Claim>() { new Claim(ClaimTypes.NameIdentifier,modelLogin.UserId),
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
