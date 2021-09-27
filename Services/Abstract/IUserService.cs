using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Abstract
{
	 public interface IUserService
	{
		User GetUserById(int id);

		User GetUser(string userName, string password);
	}
}
