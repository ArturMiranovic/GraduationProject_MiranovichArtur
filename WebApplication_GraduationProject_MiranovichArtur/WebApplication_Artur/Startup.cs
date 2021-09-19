using AutoMapper;
using AutoMapper.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.EfStuff;
using WebApplication_Artur.EfStuff.Model;
using WebApplication_Artur.EfStuff.Model.BikeModel;
using WebApplication_Artur.EfStuff.Model.UserModel;
using WebApplication_Artur.EfStuff.Repositories;
using WebApplication_Artur.Models;
using WebApplication_Artur.Services;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace WebApplication_Artur
{
    public class Startup
    {

        public const string AuthName = "CoockieUser";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Shop;Integrated Security=True;";

            services.AddAuthentication(AuthName)
                .AddCookie(AuthName, config =>
                {
                    config.LoginPath = "/User/Login";
                    config.AccessDeniedPath = "/User/Denied";
                    config.Cookie.Name = "ArturBikeUser";
                });


            services.RegisterAssistant<UserService>();

            services.RegisterAssistant<UserRepository>();

            services.RegisterAssistant<BikeService>();

            services.RegisterAssistant<BikeRepository>();

            //services.AddScoped<UserRepository>(container =>
            //new UserRepository(container.GetService<ShopDbContext>())
            //);

            //services.AddScoped<UserService>(container =>
            //new UserService(
            //    container.GetService<UserRepository>(),
            //    container.GetService<IHttpContextAccessor>()
            //    )
            //);

            //services.AddScoped<BikeRepository>(container =>
            //new BikeRepository(
            //    container.GetService<ShopDbContext>())
            //);

            services.AddDbContext<ShopDbContext>(x => x.UseSqlServer(connectString));

            services.AddControllersWithViews();

            services.AddHttpContextAccessor();

            regiaterMapper(services);
        }

        private void regiaterMapper(IServiceCollection services)
        {
            var provider = new MapperConfigurationExpression();

            provider.CreateMap<User, UserViewModel>();
            provider.CreateMap<UserViewModel, User>();

            provider.CreateMap<UserRegistrationViewModel, User>();
            provider.CreateMap<User, UserRegistrationViewModel>();

            provider.CreateMap<Bike, BikeViewModel>();
            provider.CreateMap<BikeViewModel, Bike>();

            provider.CreateMap<Bike, SharedViewModel>();
            provider.CreateMap<SharedViewModel, Bike>();

            provider.CreateMap<Bike, AddBikeViewModel>();
            provider.CreateMap<AddBikeViewModel, Bike>();

            provider.CreateMap<Bike, GalereyBikeViewModel>();
            provider.CreateMap<GalereyBikeViewModel, Bike>();

            provider.CreateMap<Shared, AddSharedBikeViewModel>();
            provider.CreateMap<AddSharedBikeViewModel, Shared>();


            var mapperConfiguration = new MapperConfiguration(provider);
            var mapper = new Mapper(mapperConfiguration);

            services.AddScoped<IMapper>(x => mapper);
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            //Who am I?
            app.UseAuthentication();

            //Waht can I see?
            app.UseAuthorization();

            app.UseMiddleware<LocalizeMidlleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
