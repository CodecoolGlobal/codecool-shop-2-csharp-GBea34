using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Codecool.CodecoolShop.Daos;
using Codecool.CodecoolShop.Daos.Implementations;
using Codecool.CodecoolShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Codecool.CodecoolShop
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Product/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Product}/{action=Index}/{id?}");
                
                
            });

            SetupInMemoryDatabases();
        }

        private void SetupInMemoryDatabases()
        {
            IProductDao productDataStore = ProductDaoMemory.GetInstance();
            IProductCategoryDao productCategoryDataStore = ProductCategoryDaoMemory.GetInstance();
            ISupplierDao supplierDataStore = SupplierDaoMemory.GetInstance();

            Supplier Chio = new Supplier{Name = "Chio", Description = "Taste is Quality" };
            supplierDataStore.Add(Chio);
            Supplier CrikCrok = new Supplier { Name = "CrikCrok", Description = "New brand" };
            supplierDataStore.Add(CrikCrok);
            Supplier EatReal = new Supplier { Name = "Eat Real", Description = "You do what you eat. Take in the power of real food for all the goodness you do and are." };
            supplierDataStore.Add(EatReal);
            Supplier Lays = new Supplier { Name = "Lays", Description = "Lay's. Get your smile on." };
            supplierDataStore.Add(Lays);
            Supplier fini = new Supplier { Name = "fini", Description = "Its fun, its fini." };
            supplierDataStore.Add(fini);
            Supplier Manner = new Supplier { Name = "Manner", Description = "Csokoládét mindenkinek" };
            supplierDataStore.Add(Manner);
            Supplier Milka = new Supplier { Name = "Milka", Description = "Dare to be tender." };
            supplierDataStore.Add(Milka);
            Supplier Mizo = new Supplier { Name = "Mizo", Description = "Mizo" };
            supplierDataStore.Add(Mizo);
            Supplier Pocky = new Supplier { Name = "Pocky", Description = "Share happiness!" };
            supplierDataStore.Add(Pocky);
            Supplier Snickers = new Supplier { Name = "Snickers", Description = "You're not you when you're hungry." };
            supplierDataStore.Add(Snickers);
            Supplier SourPatch = new Supplier { Name = "Sour Patch", Description = "Sour Then Sweet" };
            supplierDataStore.Add(SourPatch);
            Supplier Toffifee = new Supplier { Name = "Toffifee", Description = "There's so much fun in Toffifee!" };
            supplierDataStore.Add(Toffifee);
            ProductCategory Sweet = new ProductCategory { Name = "Sweet"};
            productCategoryDataStore.Add(Sweet);
            ProductCategory Sour = new ProductCategory { Name = "Sour"};
            productCategoryDataStore.Add(Sour);
            ProductCategory Salty = new ProductCategory { Name = "Salty"};
            productCategoryDataStore.Add(Salty);
            ProductCategory Spicy = new ProductCategory { Name = "Spicy"};
            productCategoryDataStore.Add(Spicy);
            productDataStore.Add(new Product { Name = "Chio Chees", DefaultPrice = 2.0m, Currency = "USD", ProductCategories = {Salty}, Supplier = Chio });
            productDataStore.Add(new Product { Name = "CrikCrok jalapeno", DefaultPrice = 1.5m, Currency = "USD", ProductCategories = { Spicy, Salty}, Supplier = CrikCrok });
            productDataStore.Add(new Product { Name = "Eat Real chilli&lemon", DefaultPrice = 5.0m, Currency = "USD", ProductCategories = { Spicy, Sour }, Supplier = EatReal });
            productDataStore.Add(new Product { Name = "fini Roller", DefaultPrice = 1.8m, Currency = "USD", ProductCategories = { Sweet, Sour }, Supplier = fini });
            productDataStore.Add(new Product { Name = "Lays Classic", DefaultPrice = 2.1m, Currency = "USD", ProductCategories = { Salty }, Supplier = Lays });
            productDataStore.Add(new Product { Name = "Manner WIEN", DefaultPrice = 0.9m, Currency = "USD", ProductCategories = { Sweet }, Supplier = Manner });
            productDataStore.Add(new Product { Name = "Milka Choc and Choc", DefaultPrice = 4.0m, Currency = "USD", ProductCategories = { Sweet }, Supplier = Milka });
            productDataStore.Add(new Product { Name = "Mizo rudi", DefaultPrice = 0.8m, Currency = "USD", ProductCategories = { Sweet }, Supplier = Mizo });
            productDataStore.Add(new Product { Name = "Pocky COOKIES and CREAM", DefaultPrice = 1.5m, Currency = "USD", ProductCategories = { Sweet }, Supplier = Pocky });
            productDataStore.Add(new Product { Name = "Pocky STRAWBERRY", DefaultPrice = 1.7m, Currency = "USD", ProductCategories = { Sweet }, Supplier = Pocky });
            productDataStore.Add(new Product { Name = "snickers", DefaultPrice = 2.1m, Currency = "USD", ProductCategories = { Sweet }, Supplier = Snickers });
            productDataStore.Add(new Product { Name = "sour patch kids", DefaultPrice = 3.0m, Currency = "USD", ProductCategories = { Sour }, Supplier = SourPatch });
            productDataStore.Add(new Product { Name = "Toffifee", DefaultPrice = 8.0m, Currency = "USD", ProductCategories = { Sweet }, Supplier = Toffifee });
        }
    }
}
