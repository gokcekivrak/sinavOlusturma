using Entities;
using Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Abstract
{
	public interface IUserRepository : IEntityRepository<User>
	{
		User GetUserById(int id);

		User GetUser(string userName, string password);
	}
}
