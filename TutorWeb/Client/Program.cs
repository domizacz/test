using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TutorWeb.Client.Shared;

namespace TutorWeb.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            ServicesConfig(builder.Services);
            await builder.Build().RunAsync();
        }
        private static void  ServicesConfig(IServiceCollection services)
        {
            services.AddOptions();
            services.AddSingleton<SingletorService>();
            services.AddTransient<TransitionService>();
            
        }
    }
}
