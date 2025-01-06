
namespace SolidTech.Business.Services
{
    public class ProjectService : IProjectService
    {
        private readonly SolidTechContext _context;
        private readonly IMapper _mapper;

        public ProjectService(SolidTechContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<ProjectDto> Projects()
        {
            List<ProjectDto> projectDtos = new List<ProjectDto>();

            var our_project = _context.Projects.ToList();

            foreach (var project in our_project) {

                var filepath = _context.ProjectImagePaths.FirstOrDefault(ip=>ip.ProjectId == project.ProjectId);

                if (filepath != null) {
                    ProjectDto projectDto = new ProjectDto
                    {
                        ProjectId = project.ProjectId,
                        ProjectCategoryId = project.ProjectCategoryId,
                        Name = project.Name,
                       


                    };
                    projectDtos.Add(projectDto);
                }
                else
                {
                    ProjectDto projectDto = new ProjectDto
                    {
                        ProjectId = project.ProjectId,
                        ProjectCategoryId = project.ProjectCategoryId,
                        Name = project.Name,
                        


                    };
                    projectDtos.Add(projectDto);
                }
              
            
            }




            return projectDtos;
        }

        public List<ProjectDto> GetLastProjects()
        {
            return _mapper.Map<List<ProjectDto>>(_context.Projects.OrderByDescending(x => x.CreaDate).Take(6));
        }

        public Project GetProjectById(int project_id)
        {

            var founded_project = _context.Projects.FirstOrDefault(p => p.ProjectId == project_id);

            if (founded_project != null)
            {
                return founded_project;
            }
            else
            {
                return null;
            }
        }

        public bool DeleteProjectByID(int project_id)
        {

            var result = GetProjectById(project_id);

            if (result != null)
            {
                var deleted_user = _context.Projects.Remove(result);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public void AddProject(ProjectDto projectDto)
        {

            Project project = new Project
            {
                Name = projectDto.Name,
                ProjectCategoryId = projectDto.ProjectCategoryId,
                CreaDate = DateTime.UtcNow,

            };

            _context.Projects.Add(project);
            _context.SaveChanges();


            ProjectImagePath projectImagePath = new ProjectImagePath()
            {
                ProjectId = project.ProjectId,
                ProjectImagePathExist = projectDto.File.FileName
            };


            _context.ProjectImagePaths.Add(projectImagePath);

            _context.SaveChanges();

        }

        public bool CheckProjectCount()
        {
            var result = _context.Projects.Count();

            if (result >= 6)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
