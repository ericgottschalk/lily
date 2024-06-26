﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ENG.Lily.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseWebRoot("wwwroot")
                .UseStartup<Startup>()
                .Build();
    }
}
