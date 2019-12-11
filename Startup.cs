using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using web_project.Models;
using web_project.Services;



namespace web_project
{
    public class Startup
    {

        private IConfigurationRoot configString;

        public Startup(IConfiguration configuration, IHostingEnvironment hostingEnvironment)
        {
            configString = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath).AddJsonFile("dbsettings.json").Build();
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddLocalization(options => options.ResourcesPath = "Resources");

            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[]
                {
                    new CultureInfo("en"),
                    new CultureInfo("de"),
                    new CultureInfo("ru")
                };

                options.DefaultRequestCulture = new RequestCulture("ru");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });


            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configString.GetConnectionString("DefaultConnection")));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

            services.AddSignalR();
            services.AddRouting();

            services.Configure<SecurityStampValidatorOptions>(options => { options.ValidationInterval = TimeSpan.Zero; });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddDataAnnotationsLocalization().AddViewLocalization();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            var locOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(locOptions.Value);


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Places}/{action=Index}");
                routes.MapRoute(
                    name: "list",
                    template: "{controller}/{action}/{id?}",
                    constraints: new {id = new IntRouteConstraint()},
                    defaults: new {controller = "Places", action = "Index"}
                    );
                routes.MapRoute(
                    name: "create_item",
                    template: "{controller=Places}/{action=Create}");
                routes.MapRoute(
                    name: "search",
                    template: "{controller=Places}/{action=Search}");
                routes.MapRoute(
                    name: "categories",
                    template: "{controller=Places}/{action=Categories}");
                routes.MapRoute(
                    name: "places_create",
                    template: "{controller=Places}/{action=Create}");
                routes.MapRoute(
                    name: "roles_index",
                    template: "{controller=Roles}/{action=Index}");
                routes.MapRoute(
                    name: "roles_create",
                    template: "{controller=Roles}/{action=Create}");
                routes.MapRoute(
                    name: "roles_edit",
                    template: "{controller=Roles}/{action=Edit}");
                routes.MapRoute(
                    name: "create_user",
                    template: "{controller=User}/{action=Create}");
                routes.MapRoute(
                    name: "user_index",
                    template: "{controller=User}/{action=Index}");

            });

            app.UseSignalR(routes =>
            {
                routes.MapHub<ChatHub>("/Chat");
            });
        }
    }
}
