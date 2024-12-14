using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;

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


        [HttpGet] 
        public IActionResult AddNewSolutionPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewSolution(SolutionDto solutionDto)
        {

            if (!ModelState.IsValid)
            {
                return View("AddNewSolutionPage", solutionDto);
            }

            

            _solutionService.AddSolution(solutionDto);


            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult DeleteSolution(int id)
        {


            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult EditSolutionPage(int id)
        {
            var result = _solutionService.GetSolutionById(id);

            if (result != null)
            {
                return View(result);
            }

            ViewBag.ErrorMessage = "Nesne null";

            return RedirectToAction("Index");

        }




    }
}
