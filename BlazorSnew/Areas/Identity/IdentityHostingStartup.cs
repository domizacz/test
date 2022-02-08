using System;
using BlazorSnew.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BlazorSnew.Areas.Identity.IdentityHostingStartup))]
namespace BlazorSnew.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<testbaseforlogin>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("testbaseforloginConnection")));

                services.AddDefaultIdentity<BlazorSnewUsertest>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<testbaseforlogin>();
            });
        }
    }
}