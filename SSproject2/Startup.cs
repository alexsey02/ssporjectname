using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SSproject2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SSproject2.Domain.Repositories.Abstract;
using SSproject2.Domain.Repositories.EntityFramework;
using SSproject2.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SSproject2
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)//объявление сервисов конфигурации
        {
           
            Configuration.Bind("Project", new Config());
            services.AddTransient<ITextFieldsRepository, EFTextFieldsRepository>();
            services.AddTransient<IPostItemsRepository, EFPostItemsRepository>();
            services.AddTransient<IApplicationRepository, EFApplicationRepository>();
            services.AddTransient<DataManager>();
            services.AddTransient<MailClass>();
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "mySSAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });

            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
                x.AddPolicy("OtdelSMI", policy => { policy.RequireRole("otdelsmi"); });
                x.AddPolicy("Curator", policy => { policy.RequireRole("curator"); });
            });

            services.AddControllersWithViews(x =>
            {
                x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
                x.Conventions.Add(new AdminAreaAuthorization("OtdelSMI", "OtdelSMI"));
                x.Conventions.Add(new AdminAreaAuthorization("Curator", "Curator"));
            })

                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        

        }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)//объявление метода конфигурирования
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();


            app.UseRouting();
            app.UseStaticFiles();

            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("otdelsmi", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("curator", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
            
        }
    }
}
