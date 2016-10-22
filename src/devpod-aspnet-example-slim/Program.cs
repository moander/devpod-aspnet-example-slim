using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace devpod_aspnet_example_slim
{
    public class Program
    {
        public static int Main(string[] args)
        {
            try
            {
                Console.Title = typeof(Program).Namespace;

                var config = new ConfigurationBuilder()
                    .AddCommandLine(args)
                    .AddEnvironmentVariables(prefix: "ASPNETCORE_")
                    .Build();

                var host = new WebHostBuilder()
                         .UseConfiguration(config)
                         .UseKestrel()
                         .UseContentRoot(Directory.GetCurrentDirectory())
                         .UseStartup<Startup>()
                         .Build();


                host.Run();

                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return 1;
            }
        }
    }
}
