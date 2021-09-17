using Microsoft.AspNetCore.Http;
using System.Linq;
using WebApplication_Artur.EfStuff.Model.UserModel;
using WebApplication_Artur.EfStuff.Repositories;

namespace WebApplication_Artur.Services
{
    public class UserService
    {

        private UserRepository _userRepository;
        private IHttpContextAccessor _httpContextAccessor;

        public UserService(UserRepository userRepository, IHttpContextAccessor httpContextAccessor)
        {
            _userRepository = userRepository;
            _httpContextAccessor = httpContextAccessor;
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

        
        public bool IsAdmin() => GetCurrent()?.Role == Role.Admin;

        public bool IsAdmin(long id) => _userRepository.Get(id)?.Role == Role.Admin;

        public bool IsOwner(long id) => GetCurrent()?.MyBikes.Any(x => x.Id == id) != null;

        public bool IsMy(long id) => GetCurrent()?.Id == id;

        public bool IsDontAnminMyUser(long id) => !IsAdmin(id) && (IsAdmin() || IsMy(id));

        public bool IsAdminOrOwner(long id) => IsOwner(id) || IsAdmin();


    }
}
