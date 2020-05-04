using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace EFCore.Performance
{
	public sealed class Run
	{
		public static Run Default { get; } = new Run();

		Run() : this(new DbContextOptionsBuilder<Storage>().UseInMemoryDatabase(Guid.NewGuid().ToString())
		                                                   .EnableSensitiveDataLogging().Options) {}

		readonly DbContextOptions<Storage> _options;

		public Run(DbContextOptions<Storage> options) => _options = options;

		public Task Execute()
		{
			using var storage = new Storage(_options);
			var result = storage.Set<User>().ToArrayAsync();
			return result;
		}
	}
}
