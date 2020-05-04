using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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

		static async Task Execute()
		{
			using var host = new HostBuilder()
			                 .ConfigureServices(x =>
			                                    {
				                                    x.AddSingleton<IServer, TestServer>()
				                                     .AddDbContext<Storage>(builder => builder
				                                                                       .UseInMemoryDatabase(Guid
				                                                                                            .NewGuid()
				                                                                                            .ToString())
				                                                                       .EnableSensitiveDataLogging())
				                                     .AddIdentityCore<User>()
				                                     .AddEntityFrameworkStores<Storage>();
			                                    })
			                 .Build();
			await host.StartAsync();

			await host.Services.GetRequiredService<UserManager<User>>()
			          .CreateAsync(new User {UserName = "SomeUser"}, "*Password10*");
		}
	}
}