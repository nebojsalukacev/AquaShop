using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AquaShop.Data.Interfaces;
using AquaShop.Data.Mocks;
using AquaShop.Data.Models;
using AquaShop.Data.Repositories;
using AquaShop.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AquaShop
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredUniqueChars = 3;
            }).AddEntityFrameworkStores<AppDbContext>();

            services.AddDbContextPool<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("AquaConn")));

            services.AddTransient<ICategoryRepository, SqlCategoryRepository>();
            services.AddTransient<IProductRepository, SqlProductRepository>();
            services.AddTransient<IOrderRepository, SqlOrderRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopingCart.GetCart(sp));

            services.AddControllersWithViews();
            // services.AddRazorPages();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();
            

            DbInitializer.Seed(serviceProvider);

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                    name: "categoryFilter",
                    pattern: "Product/List/{category?}",
                    defaults: new { controller = "Product", action = "List" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=home}/{action=index}/{id?}");

            });
        }
    }
}
