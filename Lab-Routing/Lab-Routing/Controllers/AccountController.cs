using Lab_Routing.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_Routing.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginviewmodel)
        {
            if(loginviewmodel.Username =="user@gmail.com" && loginviewmodel.Password == "12345678")
            {
                return RedirectToAction("Index", "Home", new { area = "Users" });
            }
            else if (loginviewmodel.Username == "admin@gmail.com" && loginviewmodel.Password == "12345678")
            {
                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }
            return View();
        }
    }
}
