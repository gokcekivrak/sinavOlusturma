using Data.Abstract;
using Data.Concrete.EntityFramework.Context;
using Entities;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Concrete
{
	public class UserManager : IUserService
	{
		private IUserRepository _userRepository;

		public UserManager(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public User GetUser(string userName, string password)
		{
			return _userRepository.GetUser(userName, password);
		}

		public User GetUserById(int id)
		{
			using (SinavOlusturContext context = new SinavOlusturContext())
			{
				User user = context.Users.Where(user => user.userId == id).FirstOrDefault();
				return user;

			}
		}
	}
}
