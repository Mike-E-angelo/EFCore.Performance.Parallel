using System.Threading.Tasks;
using Xunit;

namespace EFCore.Performance.xUnit
{
	public sealed class UnitTest8
	{
		[Fact]
		public Task Test1() => Run.Default.Execute();

		[Fact]
		public Task Test2() => Run.Default.Execute();

		[Fact]
		public Task Test3() => Run.Default.Execute();

		[Fact]
		public Task Test4() => Run.Default.Execute();

		[Fact]
		public Task Test5() => Run.Default.Execute();
	}
}