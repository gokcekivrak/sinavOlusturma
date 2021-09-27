using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
	public interface IUnitOfWork : IAsyncDisposable
	{
		IQuestionRepository Questions { get; }
		ITestRepository Tests { get; }
		IUserRepository Users { get; }
		Task<int> SaveAsync();
	}
}
