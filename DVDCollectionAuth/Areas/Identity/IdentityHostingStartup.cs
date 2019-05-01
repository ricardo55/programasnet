using System;
using DVDCollection.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DVDCollection.Areas.Identity.IdentityHostingStartup))]
namespace DVDCollection.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DVDContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("DVDContext")));

                services.AddDefaultIdentity<User>()
                    .AddEntityFrameworkStores<DVDContext>();
            });
        }
    }
}