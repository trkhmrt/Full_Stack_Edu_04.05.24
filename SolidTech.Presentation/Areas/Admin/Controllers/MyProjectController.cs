using Microsoft.AspNetCore.Mvc;
using SolidTech.Data.Entities;
using SolidTech.Business.Services;

namespace SolidTech.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MyProjectController : Controller
    {

        private SolidTechContext _context;
        private IProjectService _projectService;

        public MyProjectController(SolidTechContext context,IProjectService projectService)
        {
            _context = context;
            _projectService = projectService;
        }

        [HttpGet]
        public IActionResult Index()
        {

            List<Project> my_projects = _context.Projects.ToList();


            return View(my_projects);

        }


        //Tek bir projeyi ekrana getirecek.
        [HttpGet]
        public IActionResult GetMyProjectToEdit(int project_id)
        {

            var result = _projectService.GetProjectById(project_id);

            if(result != null)
            {
                return View(result);
            }

            ViewBag.Message = "Proje bulunamadı!";


            return View();
        }

        [HttpGet]
        public IActionResult DeleteProjectByID(int project_id)
        {
            var result = _projectService.DeleteProjectByID(project_id);

            if (result)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Message = "Proje Silinemedi!";
            return View();
        }




    }
}
