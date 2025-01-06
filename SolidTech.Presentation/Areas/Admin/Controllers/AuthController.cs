using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
        public async Task<IActionResult> AuthLogin(LoginDto loginDto)
        {

            if (_authService.Login(loginDto)!=null)
            {
                
                var user = _authService.Login(loginDto);


                var claims = new List<Claim>
                {
                  new Claim(ClaimTypes.Name,loginDto.username),
                  new Claim(ClaimTypes.Role,user.Role.RoleName)
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProp = new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(30)

                };


                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProp);


                return RedirectToAction("Index","Home");
            }
            else
            {
                TempData["Message"] = "Kullanıcı adı veya şifre hatalıdır";
				return RedirectToAction("Index");
			}
        }

        [HttpGet]
        public async Task<IActionResult> AuthLogOut()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);


            return RedirectToAction("Index");
        }


        public IActionResult AccessDenied()
        {


            return View();
        }

    }
}
