using ManagementStudent.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStudent.Services.Users
{
	public interface IUserService
	{
		Task<string> Authencatetion(LoginRequest request);
	}
}
