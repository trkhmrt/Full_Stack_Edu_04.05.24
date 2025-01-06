using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTech.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {


            builder.HasOne(u => u.Role)
                .WithOne(u => u.User).
                HasForeignKey<User>(u => u.RoleID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
