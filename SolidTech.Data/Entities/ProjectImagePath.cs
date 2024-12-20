using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTech.Data.Entities
{
    public class ProjectImagePath 
    {
        [Key]
        public int Id { get; set; }
        public string ProjectImagePathExist { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }

    }

}
