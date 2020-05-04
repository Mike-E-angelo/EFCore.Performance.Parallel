using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace EFCore.Performance
{
	public sealed class Run
	{
		public static Run Default { get; } = new Run();

		Run() {}

		public Task Execute()
		{
			var builder = new DbContextOptionsBuilder<Storage>().UseInMemoryDatabase(Guid.NewGuid().ToString())
			                                                    .EnableSensitiveDataLogging();
			return new Storage(builder.Options).Set<User>().ToArrayAsync();
		}
	}
}
