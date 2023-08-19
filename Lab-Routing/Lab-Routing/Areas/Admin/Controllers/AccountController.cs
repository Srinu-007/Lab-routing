using Microsoft.AspNetCore.Mvc;

namespace Lab_Routing.Areas.Admin.Controllers
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
