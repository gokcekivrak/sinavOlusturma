using Data.Abstract;
using Data.Concrete.EntityFramework.Context;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Concrete.EntityFramework.Repositories
{
	public class EfTestRepository :ITestRepository
	{
        public void AddTest(Test test)
        {
            using (SinavOlusturContext context = new SinavOlusturContext())
            {
                var addedEntity = context.Entry(test);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void DeleteTest(Test test)
        {
            using (SinavOlusturContext context = new SinavOlusturContext())
            {
                var deletedEntity = context.Entry(test);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Test> GetTestList()
        {
            using (SinavOlusturContext context = new SinavOlusturContext())
            {
                return context.Tests.ToList();
            }
        }

        public List<Test> GetTestListWithUser(int userId)
        {
            using (SinavOlusturContext context = new SinavOlusturContext())
            {
                return context.Tests.Where(t => t.userId == userId).ToList();
            }
        }

        public Test GetTestWithId(int id)
        {
            using (SinavOlusturContext context = new SinavOlusturContext())
            {
                return context.Tests.Where(t => t.testId == id).FirstOrDefault();
            }
        }

        public Test GetTestWithKey(string key)
        {
            using (SinavOlusturContext context = new SinavOlusturContext())
            {
                return context.Tests.Where(t => t.key == key).FirstOrDefault();
            }
        }
    }
}
