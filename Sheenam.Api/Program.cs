using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Sheenam.API;

namespace Sheenam.Api
{
    public class Program
    {
        public static void Main(string[] args) =>    
            CreateHostBuilder(args).Build().Run();
        
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuelder =>
                          webBuelder.UseStartup<Startup>());
            
        }
    }

}