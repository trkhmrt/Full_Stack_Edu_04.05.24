using System.ComponentModel.DataAnnotations;

namespace SolidTech.Business.Dtos
{
    public class SolutionDto
    {
        public int SolutionId { get; set; }
        [Required(ErrorMessage ="Header alanı boş geçilemez")]
        [StringLength(10,ErrorMessage ="10 Karakterden uzun olamaz")]
        public required string Header { get; set; }

        [Required(ErrorMessage = "Header alanı boş geçilemez")]
        [StringLength(10, ErrorMessage = "10 Karakterden uzun olamaz")]
        public required string Content { get; set; }

        [Required(ErrorMessage = "Header alanı boş geçilemez")]
        [StringLength(20, ErrorMessage = "20 Karakterden uzun olamaz")]
        [Url(ErrorMessage ="Geçerli Bir Url girin")]
        public required string ImageIcon { get; set; }
        public int Order { get; set; }
    }
}
