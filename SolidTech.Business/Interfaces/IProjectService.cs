namespace SolidTech.Business.Interfaces
{
    public interface IProjectService
    {
        List<ProjectDto> Projects();
        public List<ProjectDto> GetLastProjects();
        public Project GetProjectById(int project_id);
        public bool DeleteProjectByID(int project_id);

        //public void AddProject(ProjectDto projectDto);
        public bool CheckProjectCount();
    }
}