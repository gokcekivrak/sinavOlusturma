using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Abstract
{
	public interface IQuestionService
	{
		void AddQuestion(Question question);
		List<Question> GetQuestions(int testId, int userId);
		List<Question> GetTestQuestion(int testId);
		void SaveQuestions(Question[] questions, Test test);
	}
}
