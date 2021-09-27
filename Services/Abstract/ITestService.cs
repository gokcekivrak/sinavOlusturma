using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Abstract
{
	public interface ITestService
	{
        void AddTest(Test test);
        void DeleteTest(Test test);
        Test GetTestWithKey(string key);
        Test GetTestWithId(int id);
        List<Test> GetTestListWithUser(int userId);
        List<Test> GetTestList();
    }
}
