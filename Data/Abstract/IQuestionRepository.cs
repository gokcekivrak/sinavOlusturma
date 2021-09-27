using Entities;
using Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Abstract
{
	public interface IQuestionRepository : IEntityRepository<Question>
	{
		void AddQuestion(Question question);
		List<Question> GetQuestions(int testId, int userId);
		List<Question> GetTestQuestion(int testId);
	}
}
