using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.EfStuff.Model.BikeModel;
using WebApplication_Artur.EfStuff.Model.UserModel;
using WebApplication_Artur.EfStuff.Repositories;

namespace WebApplication_Artur.EfStuff
{
    public static class SeedExtantion
    {
        public const string ArturLogin = "artur@gmail.com";

        public static IHost Seed(this IHost host)
        {
            using (var service = host.Services.CreateScope())
            {
                InitUsers(service.ServiceProvider);

                InitBikes(service.ServiceProvider);
            }

            return host;
        }

        private static void InitBikes(IServiceProvider service)
        {
            var bikeRepository = service.GetService<BikeRepository>();

            var userRepository = service.GetService<UserRepository>();

            var artur = userRepository.Get(ArturLogin);

            var bikeDefolts = new List<Bike>() {
                new Bike()
                {

                    Name= "Haibike Big Curve 9.10 (2016)",
                    BikeClass = BikeClass.Mountain,
                    Price = 850,
                    Page = "/image/bike/Haibike Big Curve 9.10 (2016).png",
                },
                new Bike()
                {

                    Name= "Haibike Edition 7.40 (2016)",
                    BikeClass = BikeClass.Mountain,
                    Price = 2500,
                    Page = "/image/bike/Haibike Edition 7.40 (2016).png",
                },
                new Bike()
                {

                    Name= "Corratec CCT Team Race",
                    BikeClass = BikeClass.Road,
                    Price = 5130,
                    Page = "/image/bike/Corratec CCT Team Race.png",
                },
                new Bike()
                {

                    Name= "Aist 28-130",
                    BikeClass = BikeClass.Touring,
                    Price = 299,
                    Page = "/image/bike/Aist 28-130.png",
                },
            };

            foreach (var bike in bikeDefolts)
            {
                if (!bikeRepository.Exist(bike.Name))
                {
                    bike.Owner = artur;

                    bikeRepository.Save(bike);
                }
            }
        }

        private static void InitUsers(IServiceProvider service)
        {
            var userRepository = service.GetService<UserRepository>();

            var userDefolts = new List<User>() {
                new User()
                {
                    Name = "Admin",
                    Login = "Admin",
                    Password = "1111",
                    Role = Role.Admin,
                },
                new User()
                {
                    Name = "Artur",
                    Login = ArturLogin,
                    Password = "4444",
                    Role = Role.User,
                },
                new User()
                {
                    Name = "Mischa",
                    Login = "mischa@mail.ru",
                    Password = "2222",
                    Role = Role.User,
                },
            };

            foreach (var user in userDefolts)
            {

                if (!userRepository.Exist(user.Login))
                {
                    userRepository.Save(user);
                }
            }
        }
    }
}

