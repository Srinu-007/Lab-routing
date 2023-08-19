using Microsoft.AspNetCore.Mvc;

namespace Lab_Routing.Areas.Users.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
