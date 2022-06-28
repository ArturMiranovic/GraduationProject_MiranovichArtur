using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Linq;
using System.Text;
using WebApplication_Artur.EfStuff.Model.UserModel;
using WebApplication_Artur.EfStuff.Repositories;

namespace WebApplication_Artur.Services
{
    public class UserService : IUserService
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

            var path = Path.Combine(projectPath, "file\\", user.Login + ".txt");

            var nomer = 1;

            var dataTime = DateTime.Now;

            var appendText = $"          У пользователя {user.Name} [{user.Login}] на текущую дату ({dataTime}) { user.MyBikes.Count()} велосипедов:\n\n\n";

            foreach (var bike in user.MyBikes)
            {

                appendText += $"    {nomer++}. Модель велосипеда: {bike.Name} - является {bike.BikeClass} велосипедом.\n" +
                    $"                         Цена данной модели составляет - {bike.Price} BYN.\n" +
                    $" =========================================================================================\n\n\n";
            };


            File.AppendAllText(path, appendText, Encoding.UTF8);

        }

        public bool IsAdmin() => GetCurrent()?.Role == Role.Admin;

        public bool IsAdmin(long id) => _userRepository.Get(id)?.Role == Role.Admin;

        public bool IsOwner(long id) => (GetCurrent()?.MyBikes.Any(x => x.Id == id)) == true;    

        public bool IsMy(long id) => GetCurrent()?.Id == id;

        public bool IsDontAnminMyUser(long id) => !IsAdmin(id) && (IsAdmin() || IsMy(id));

        public bool IsAdminOrOwner(long id) => IsOwner(id) || IsAdmin();
    }
}
