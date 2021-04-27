using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sarpinos.Repositories;

[assembly: HostingStartup(typeof(Sarpinos.Areas.Identity.IdentityHostingStartup))]
namespace Sarpinos.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SarpinosDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SarpinosDbContextConnection")));

            });
        }
    }
}