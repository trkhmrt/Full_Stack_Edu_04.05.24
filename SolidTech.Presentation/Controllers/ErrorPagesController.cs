using Microsoft.AspNetCore.Mvc;

namespace SolidTech.Presentation.Controllers
{
    public class ErrorPagesController : Controller
    {

        [Route("ErrorPages/{statusCode}")]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 404)
            {
                var code = statusCode;
                return View();
            }
            else if (statusCode == 500)
            {
                var code = statusCode;
                return View();
            }

            return RedirectToAction();
           
        }
    }
}
