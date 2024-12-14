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



		public bool Login(LoginDto loginDto)
		{
			
			SolidTechContext solidTechContext = new SolidTechContext();

			var result =  solidTechContext.Users.
				FirstOrDefault(u => u.username == loginDto.username && u.password == loginDto.password);

			if (result != null)
			{
				
				return true;
			}

			return false;

		}
	}
}
