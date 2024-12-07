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
        private IProjectCategoryService _projectCategoryService;
        public MyProjectController(SolidTechContext context,IProjectService projectService,IProjectCategoryService projectCategoryService)
        {
            _context = context;
            _projectService = projectService;
            _projectCategoryService = projectCategoryService;
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
                return RedirectToAction("Index","MyProject",new {area="Admin"});
            }

            ViewBag.Message = "Proje Silinemedi!";
            return View();
        }


        [HttpGet]
        public IActionResult AddNewProject(string message)
        {


            ViewBag.SelectedCategory = _projectCategoryService.ProjectCategories();

            var error_message = TempData["Message"];

            if (error_message != null) {

                ViewBag.Error = error_message;

                return View();
            }
            else
            {
                return View();
            }


           
        }


        [HttpPost]
        public IActionResult AddNewProjectToDB(ProjectDto projectDto)
        {

            

            if(_projectService.CheckProjectCount())
            {
                _projectService.AddProject(projectDto);
            }
            else{
                TempData["Message"] = "proje sayısı 6 dan fazla olamaz.";
            }

       

            return RedirectToAction("AddNewProject");




            }

    }
}
