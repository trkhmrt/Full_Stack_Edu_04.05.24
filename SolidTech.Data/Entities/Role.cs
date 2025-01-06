using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTech.Data.Entities
{
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public User User { get; set; }


    }
}
