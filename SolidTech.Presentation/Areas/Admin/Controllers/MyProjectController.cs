using Microsoft.AspNetCore.Mvc;
using SolidTech.Data.Entities;
using SolidTech.Business.Services;
using Microsoft.AspNetCore.Authorization;

namespace SolidTech.Presentation.Areas.Admin.Controllers
{
    [Authorize]
    [RequestSizeLimit(80 * 1024 * 1024)]
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
        public IActionResult AddNewProject()
        {
            ViewBag.SelectedCategory = _projectCategoryService.ProjectCategories();
            return View();
        }


        [HttpPost]
        public IActionResult AddNewProjectToDB(ProjectDto projectDto)
        {


            if (_projectService.CheckProjectCount())
            {
                _projectService.AddProject(projectDto);
                TempData["Message"] = "Basarili  bir sekilde eklendi";
                TempData["MessageType"] = "success";
            }
            else
            {
                TempData["Message"] = "proje sayisi 6 dan fazla olamaz.";
                TempData["MessageType"] = "fail";
            }

            return RedirectToAction("AddNewProject");




            }

    }
}
