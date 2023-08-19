using Microsoft.AspNetCore.Mvc;

namespace Lab_Routing.Areas.Users.Controllers
{
    public class AccountController : BaseController
    {
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }
    }
}
