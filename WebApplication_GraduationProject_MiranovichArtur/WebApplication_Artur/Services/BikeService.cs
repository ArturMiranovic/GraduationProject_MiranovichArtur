using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.EfStuff.Repositories;

namespace WebApplication_Artur.Services
{
    public class BikeService
    {
        private BikeRepository _bikeRepository;
        private UserRepository _userRepository;
        private UserService _userService;
        private IWebHostEnvironment _webHostEnvironment;
        private IHttpContextAccessor _httpContextAccessor;

        public BikeService(BikeRepository bikeRepository, UserRepository userRepository, IHttpContextAccessor httpContextAccessor, UserService userService, IWebHostEnvironment webHostEnvironment)
        {
            _bikeRepository = bikeRepository;
            _userRepository = userRepository;
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
            _webHostEnvironment = webHostEnvironment;
        }


    }
}
