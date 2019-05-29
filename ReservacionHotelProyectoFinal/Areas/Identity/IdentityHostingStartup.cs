using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReservacionHotelExamen2.Models;

[assembly: HostingStartup(typeof(ReservacionHotelExamen2.Areas.Identity.IdentityHostingStartup))]
namespace ReservacionHotelExamen2.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ReservacionHotelContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("HotelContext")));

                services.AddDefaultIdentity<User>()
                    .AddEntityFrameworkStores<ReservacionHotelContext>();
            });
        }
    }
}