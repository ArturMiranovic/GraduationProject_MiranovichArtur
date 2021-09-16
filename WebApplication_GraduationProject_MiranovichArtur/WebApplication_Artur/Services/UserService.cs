using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.EfStuff.Model.UserModel;
using WebApplication_Artur.EfStuff.Repositories;

namespace WebApplication_Artur.Services
{
    public class UserService
    {

        private UserRepository _userRepository;
        private BikeRepository _bikeRepository;
        private IHttpContextAccessor _httpContextAccessor;

        public UserService(UserRepository userRepository, IHttpContextAccessor httpContextAccessor, BikeRepository bikeRepository)
        {
            _userRepository = userRepository;
            _httpContextAccessor = httpContextAccessor;
            _bikeRepository = bikeRepository;
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

        public bool IsOvner(long id) => GetCurrent()?.Id == _bikeRepository.Get(id).Owner.Id;

    }
}
