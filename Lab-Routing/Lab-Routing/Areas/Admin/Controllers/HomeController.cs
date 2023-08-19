using Microsoft.AspNetCore.Mvc;

namespace Lab_Routing.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
