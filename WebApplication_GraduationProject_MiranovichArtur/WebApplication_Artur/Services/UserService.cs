using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Linq;
using WebApplication_Artur.EfStuff.Model.UserModel;
using WebApplication_Artur.EfStuff.Repositories;

namespace WebApplication_Artur.Services
{
    public class UserService
    {

        private UserRepository _userRepository;
        private IWebHostEnvironment _webHostEnvironment;
        private IHttpContextAccessor _httpContextAccessor;

        public UserService(UserRepository userRepository, IHttpContextAccessor httpContextAccessor, IWebHostEnvironment webHostEnvironment)
        {
            _userRepository = userRepository;
            _httpContextAccessor = httpContextAccessor;
            _webHostEnvironment = webHostEnvironment;
        }

        public User GetCurrent()
        {
            var idStr = _httpContextAccessor
                .HttpContext
                .User
                .Claims
                .SingleOrDefault(x => x.Type == "Id")
                ?.Value;

            if (string.IsNullOrEmpty(idStr))
            {
                return null;
            }

            var id = long.Parse(idStr);
            return _userRepository.Get(id);

        }

        public void AllBikeUser(long id)
        {
            var user = _userRepository.Get(id);

            var projectPath = _webHostEnvironment.WebRootPath;

            var path = Path.Combine(projectPath, "file\\", user.Name + ".txt");

            var sw = new StreamWriter("C:\\Test.txt");

            var nomer = 1;

            using (var filestream = new FileStream(path, FileMode.Create))
            {

                sw.WriteLine($"У пользователя {user.Name} [{user.Login}] { user.MyBikes.Count()} велосипедов:");
                sw.WriteLine();

                foreach (var bike in user.MyBikes)
                {
                    sw.WriteLine($"    {nomer++}. Модель велосипеда: {bike.Name} - является {bike.BikeClass} велосипедом.\n" +
                        $" \b что-то с б ");

                }
            }
        }

        public bool IsAdmin() => GetCurrent()?.Role == Role.Admin;

        public bool IsAdmin(long id) => _userRepository.Get(id)?.Role == Role.Admin;

        public bool IsOwner(long id) => GetCurrent()?.MyBikes.Any(x => x.Id == id) != null;

        public bool IsMy(long id) => GetCurrent()?.Id == id;

        public bool IsDontAnminMyUser(long id) => !IsAdmin(id) && (IsAdmin() || IsMy(id));

        public bool IsAdminOrOwner(long id) => IsOwner(id) || IsAdmin();
    }
}
