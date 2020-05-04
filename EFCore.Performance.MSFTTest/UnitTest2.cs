using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace EFCore.Performance.MSFTTest
{
	[TestClass]
	public sealed class UnitTest2
	{
		[TestMethod]
		public Task TestMethod1() => Run.Default.Execute();

		[TestMethod]
		public Task TestMethod2() => Run.Default.Execute();

		[TestMethod]
		public Task TestMethod3() => Run.Default.Execute();

		[TestMethod]
		public Task TestMethod4() => Run.Default.Execute();

		[TestMethod]
		public Task TestMethod5() => Run.Default.Execute();
	}
}
