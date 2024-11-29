using Microsoft.AspNetCore.Mvc;

namespace SolidTech.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {

            return View();
        }
    }
}
