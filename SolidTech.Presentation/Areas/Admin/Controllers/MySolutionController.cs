using Microsoft.AspNetCore.Mvc;

namespace SolidTech.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MySolutionController : Controller
    {

        ISolutionService _solutionService;

        public MySolutionController(ISolutionService solutionService)
        {
           _solutionService = solutionService;           
        }


        public IActionResult Index()
        {

            var solutions = _solutionService.GetServices();


            return View(solutions);

        }

       

       
    }
}
