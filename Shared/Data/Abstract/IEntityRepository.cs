using Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Data.Abstract
{
	public interface IEntityRepository<T> where T : class, IEntityBase, new()
	{
	}
}
