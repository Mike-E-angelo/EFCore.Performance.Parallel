using NUnit.Framework;
using System.Threading.Tasks;

namespace EFCore.Performance.NUnit
{
	[Parallelizable]
	public sealed class Tests1
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public Task Test1() => Run.Default.Execute();

		[Test]
		public Task Test2() => Run.Default.Execute();

		[Test]
		public Task Test3() => Run.Default.Execute();

		[Test]
		public Task Test4() => Run.Default.Execute();

		[Test]
		public Task Test5() => Run.Default.Execute();

	}
}