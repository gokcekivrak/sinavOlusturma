using Data.Abstract;
using Entities;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Concrete
{
	public class TestManager : ITestService
	{
		private ITestRepository _testRepository;

		public TestManager(ITestRepository testRepository)
		{
			_testRepository = testRepository;
		}

		public void AddTest(Test test)
		{
			_testRepository.AddTest(test);
		}

		public void DeleteTest(Test test)
		{
			return _testRepository.DeleteTest(test);
		}

		public List<Test> GetTestList()
		{
			return _testRepository.GetTestList();
		}

		public List<Test> GetTestListWithUser(int userId)
		{
			return _testRepository.GetTestListWithUser(userId);
		}

		public Test GetTestWithId(int id)
		{
			return _testRepository.GetTestWithId(id);
		}

		public Test GetTestWithKey(string key)
		{
			return _testRepository.GetTestWithKey(key);
		}
	}
}
