using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTech.Business.Services
{
	public class AuthService : IAuthService
	{
		private readonly SolidTechContext _solidTechContext;
		
		public AuthService(SolidTechContext solidTechContext)
		{
			_solidTechContext = solidTechContext;
		}



		public User Login(LoginDto loginDto)
		{
			
			

			var result =  _solidTechContext.Users.
				FirstOrDefault(u => u.username == loginDto.username && u.password == loginDto.password);

			var role = _solidTechContext.Roles.FirstOrDefault(r => r.RoleID == result.RoleID);

            if (result != null)
			{
				result.Role = role;
                return result;
            }
            else
            {
				return null;
            }

        }
	}
}
