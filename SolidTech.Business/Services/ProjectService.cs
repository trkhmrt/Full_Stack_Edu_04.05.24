
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
            return _mapper.Map<List<ProjectDto>>(_context.Projects.ToList());
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
    }
}
