using Microsoft.AspNetCore.Mvc;

namespace SolidTech.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {

        IAuthService _authService;

		public AuthController(IAuthService authService)
		{
			_authService = authService;
		}

		public IActionResult Index()
        {

            var error_message = TempData["Message"];

            if (error_message != null)
            {

                ViewBag.ErrorMessage = error_message;

             
            }



			return View();
        }


        [HttpPost]
        public IActionResult AuthLogin(LoginDto loginDto)
        {
            if (_authService.Login(loginDto))
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
                TempData["Message"] = "Kullanıcı adı veya şifre hatalıdır";
				return RedirectToAction("Index");
			}
        }


    }
}
