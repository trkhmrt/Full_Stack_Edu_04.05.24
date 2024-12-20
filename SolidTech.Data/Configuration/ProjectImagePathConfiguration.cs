using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTech.Data.Configuration
{
    internal class ProjectImagePathConfiguration : IEntityTypeConfiguration<ProjectImagePath>

    {
        public void Configure(EntityTypeBuilder<ProjectImagePath> builder)
        {
            builder.HasKey(ip => ip.Id);


        }
    }
}
