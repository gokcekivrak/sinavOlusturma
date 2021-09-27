using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Entities.Abstract
{
	public abstract class EntityBase
	{
		public bool IsDeleted { get; set; } = false;
	}
}
