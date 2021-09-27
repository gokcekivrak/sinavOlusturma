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
	public class EfQuestionsRepository : IQuestionRepository
	{
        public void AddQuestion(Question question)
        {
            using (SinavOlusturContext context = new SinavOlusturContext())
            {
                var addedEntity = context.Entry(question);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public List<Question> GetQuestions(int testId, int userId)
        {
            using (SinavOlusturContext context = new SinavOlusturContext())
            {
                var result = from q in context.Questions
                             join t in context.Tests on q.testId equals t.testId
                             select new Question
                             {
                                 Test = t,
                                 questionId = q.questionId,
                                 selectedFirst = q.selectedFirst,
                                 selectedSecond = q.selectedSecond,
                                 selectedThird = q.selectedThird,
                                 selectedFourth = q.selectedFourth,
                                 Answer = q.Answer,
                                 testId = q.testId,
                                 question = q.question
                             };

                return result.Where(q => q.testId == testId && q.Test.userId == userId).ToList();

            }
        }

        public List<Question> GetTestQuestion(int testId)
        {
            using (SinavOlusturContext context = new SinavOlusturContext())
            {
                return context.Questions.Where(q => q.testId == testId).ToList();
            }
        }
    }
}
