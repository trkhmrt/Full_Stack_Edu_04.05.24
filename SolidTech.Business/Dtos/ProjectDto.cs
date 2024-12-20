using Microsoft.AspNetCore.Http;

namespace SolidTech.Business.Dtos
{
    public class ProjectDto
    {
        public int ProjectId { get; set; }
        public int ProjectCategoryId { get; set; }
        public required string Name { get; set; }

        public string? Image { get; set; }

        public IFormFile File { get; set; }

    }

}
