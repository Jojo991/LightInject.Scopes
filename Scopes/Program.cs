using LightInject;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Unity.Microsoft.DependencyInjection;

namespace Scopes
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				//.UseLightInject(services =>
				//{
				//	var container = (ServiceContainer)services;
				//	var optionsField = container.GetType().GetField("options", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
				//	ContainerOptions options = (ContainerOptions)optionsField.GetValue(container);
				//	options.EnableCurrentScope = false;
				//})
				.UseUnityServiceProvider()

				.ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
	}
}