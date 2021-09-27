using Data.Concrete.EntityFramework.Context;
using Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete
{
	public class UnitOfWork
	{
        private readonly SinavOlusturContext _context;
        private EfTestRepository _testRepository;
        private EfQuestionsRepository _questionRepository;
        private EfUserRepository _userRepository;

        public UnitOfWork(SinavOlusturContext context)
        {
            _context = context;
        }


        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
