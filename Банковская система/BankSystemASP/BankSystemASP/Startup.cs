using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using BankSystemASP.DAL;
using BankSystemASP.DAL.Interfaces;
using BankSystemASP.DAL.Repositories;
using BankSystemASP.Service.Interfaces;
using Service.Implementations;
using BankSystemASP.Service.Implementations;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace BankSystemASP
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            string connection = Configuration.GetConnectionString("DefaultConnection");
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));
            services.AddDbContext<ApplicationDbContext>(options =>  options.UseMySql(connection, serverVersion));
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IBranchRepository, BranchRepository>();
            services.AddScoped<IBranchServise, BranchService>();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                options.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                        name: "HomeController",
                        pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
