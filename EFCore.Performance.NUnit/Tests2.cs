using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace EFCore.Performance.NUnit
{
	[Parallelizable]
	public sealed class Tests2
	{
		[SetUp]
		public void Setup() {}

		[Test]
		public Task Test1() => Execute();

		[Test]
		public Task Test2() => Execute();

		[Test]
		public Task Test3() => Execute();

		[Test]
		public Task Test4() => Execute();

		[Test]
		public Task Test5() => Execute();

		static Task Execute()
		{
			var builder = new DbContextOptionsBuilder<Storage>();
			builder.UseInMemoryDatabase(Guid
			                            .NewGuid()
			                            .ToString())
			       .EnableSensitiveDataLogging();
			return new Storage(builder.Options).Set<User>().ToArrayAsync();
		}
	}
}