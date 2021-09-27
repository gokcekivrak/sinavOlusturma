using Entities;
using Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Abstract
{
	public interface ITestRepository: IEntityRepository<Test>
    {
        void AddTest(Test test);
        void DeleteTest(Test test);
        Test GetTestWithKey(string key);
        Test GetTestWithId(int id);
        List<Test> GetTestListWithUser(int userId);
        List<Test> GetTestList();
    }
}
