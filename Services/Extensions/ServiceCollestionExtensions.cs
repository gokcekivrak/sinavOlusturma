using Data.Concrete.EntityFramework.Context;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Extensions
{
	public static class ServiceCollestionExtensions
	{
		public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
		{
			serviceCollection.AddDbContext<SinavOlusturContext>();
			return serviceCollection;
		}
	}
}
