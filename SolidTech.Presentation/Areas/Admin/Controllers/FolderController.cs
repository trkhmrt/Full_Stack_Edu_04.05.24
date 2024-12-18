using Microsoft.AspNetCore.Mvc;

namespace SolidTech.Presentation.Areas.Admin.Controllers
{
    [RequestSizeLimit(80 * 1024 * 1024)]
    [Area("Admin")]
    public class FolderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetFile(IFormFile file)
        {

            return RedirectToAction();
        }
    }
}
