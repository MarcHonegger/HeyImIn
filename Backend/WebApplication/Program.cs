﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace HeyImIn.WebApplication
{
	public class Program
	{
		public static void Main(string[] args)
		{
			BuildWebHost(args).Run();
		}

		private static IWebHost BuildWebHost(string[] args)
		{
			return WebHost.CreateDefaultBuilder(args)
				.UseKestrel()
				.UseIISIntegration()
				.UseAzureAppServices()
				.UseStartup<Startup>()
				.Build();
		}
	}
}