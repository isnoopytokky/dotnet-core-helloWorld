using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace HelloWeb
{
    
    abstract class Base
{
    public Base() // Noncompliant, should be private or protected
    {
      string a = "";
    }
}
    
    
    public class Program
    {
        public static void Main(string[] args)
        {
            
            ///xxxxxxxxx
            ///xxxxxxxxx
            ///xxxxxxxxx
            ///xxxxxxxxx
            
            ///xxxxxxxxx
            ///xxxxxxxxx
            ///xxxxxxxxx
            ///xxxxxxxxx
            
            ///xxxxxxxxx
            ///xxxxxxxxx
            ///xxxxxxxxx
            ///xxxxxxxxx
            
            ///xxxxxxxxx
            ///xxxxxxxxx
            ///xxxxxxxxx
            ///xxxxxxxxx
            
            //var config = new ConfigurationBuilder()
//                          .AddCommandLine(args)
//                          .Build();
//            var host = new WebHostBuilder()
//                        .UseKestrel()
//                        .UseConfiguration(config)
//                        .UseContentRoot(Directory.GetCurrentDirectory())
//                        .UseIISIntegration()
//                        .UseStartup<Startup>()
//                        .Build();

//            host.Run();
            //var config = new ConfigurationBuilder()
//                          .AddCommandLine(args)
//                          .Build();
//            var host = new WebHostBuilder()
//                        .UseKestrel()
//                        .UseConfiguration(config)
//                        .UseContentRoot(Directory.GetCurrentDirectory())
//                        .UseIISIntegration()
//                        .UseStartup<Startup>()
//                        .Build();

//            host.Run();
            var config = new ConfigurationBuilder()
                          .AddCommandLine(args)
                          .Build();
            var host = new WebHostBuilder()
                        .UseKestrel()
                        .UseConfiguration(config)
                        .UseContentRoot(Directory.GetCurrentDirectory())
                        .UseIISIntegration()
                        .UseStartup<Startup>()
                        .Build();

            host.Run();
        }
    }
}
