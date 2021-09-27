using Data.Abstract;
using Data.Concrete.EntityFramework.Context;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Concrete.EntityFramework.Repositories
{
	class EfUserRepository : IUserRepository
	{
        public User GetUser(string userName, string password)
        {
            using (SinavOlusturContext context = new SinavOlusturContext())
            {
                User user = context.Users.Where(user => user.userName == userName && user.userPassword == password).FirstOrDefault();
                return user;

            }
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
