using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EfCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using ShopApp.WebUI.Identity;
using System;
using Microsoft.AspNetCore.Http;
using WebUI.Identity;

namespace WebUI
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<ApplicationIdentityDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationIdentityDbContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
                {
                    //Passwd
                    options.Password.RequireDigit = true;  //kullanýcý parola sayýsal deðer
                    options.Password.RequireLowercase = true; //küçük harf
                    options.Password.RequiredLength = 10;
                    options.Password.RequireNonAlphanumeric = false; //Alphanumeric olmayabilir
                    options.Password.RequireUppercase = false; //büyük harf zorunlu

                    options.Lockout.MaxFailedAccessAttempts = 3; //3 giriþ hakký
                    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3); //3 dk giriþ yapamaz
                    options.Lockout.AllowedForNewUsers = true; //yeni kullanýcý içinde geçerli

                    options.User.RequireUniqueEmail = true; //var olan maille yeni kullanýcý oluþturmaz

                    options.SignIn.RequireConfirmedEmail = false; //mail adres onay

                });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.SlidingExpiration = true;
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".ShopProject.Security.Cookie"
                };
            });


            services.AddScoped<IProductDal, EfCoreProductDal>();
            services.AddScoped<ICategoryDal, EfCoreCategoryDal>();
            services.AddScoped<ICartDal, EfCoreCartDal>();
            //services.AddScoped<IOrderDal, EfCoreOrderDal>();


            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICartService, CartManager>();
            //services.AddScoped<IOrderService, OrderManager>();


            //services.AddControllersWithViews();
            //services.AddRazorPages();
            services.AddMvc(options => options.EnableEndpointRouting = false);  //3.1 için 
            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
            {
                if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                TestDatabase.Test();
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "adminProducts",
                    template: "admin/products",
                    defaults: new { controller = "Admin", action = "ProductLists" }
                );

                routes.MapRoute(
                   name: "editProducts",
                   template: "admin/products/{id?}",
                   defaults: new { controller = "Admin", action = "EditProduct" }
               );

                routes.MapRoute(
                   name: "cart",
                   template: "cart",
                   defaults: new { controller = "Cart", action = "Index" }
               );

                routes.MapRoute(
                  name: "checkout",
                  template: "checkout",
                  defaults: new {controller="Cart",action="Checkout"}
              );

                routes.MapRoute(
                    name: "products",
                    template: "products/{category?}",
                    defaults: new { controller = "Shop", action = "List" }
                );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                );

            });


            SeedIdentity.Seed(userManager, roleManager, Configuration).Wait();
        }
    }
}
