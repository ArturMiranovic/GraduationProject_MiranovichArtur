using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication_Artur.EfStuff.Model.UserModel;
using WebApplication_Artur.EfStuff.Model.BikeModel;
using WebApplication_Artur.EfStuff.Repositories;
using WebApplication_Artur.Models;

namespace WebApplication_Artur.Controllers
{
    public class UserController : Controller
    {

        private IMapper _mapper;
        private UserRepository _userRepository;

        public UserController(IMapper mapper, UserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Registration()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Registration(RegistrationViewModel viewmodel)
        {
            
            var user = _mapper.Map<User>(viewmodel);

            //var user = new User()
            //{
            //    Login = viewmodel.Login,
            //    Password = viewmodel.Password
            //};

            _userRepository.Save(user);

            //_shopDbContext.Users.Add(user);
            //_shopDbContext.SaveChanges();

            return RedirectToActionPermanent("Index", "Home");
        }

        public IActionResult All()
        {

            var allUser = _userRepository.GetAll();

            var viewModels = _mapper.Map<List<UaerForRemoveVieqModel>>(allUser);

            //var viewModels = allUser
            //    .Select(x => new UaerForRemoveVieqModel()
            //    {
            //        Id = x.Id,
            //        Login = x.Login
            //    }).ToList();

            return View(viewModels);
        }

        public IActionResult Remove(long id)
        {

            _userRepository.Remove(id);

            //var user = _shopDbContext.Users.Single(x => x.Id == id);
            //_shopDbContext.Users.Remove(user);
            //_shopDbContext.SaveChanges();

            return RedirectToActionPermanent("All");
        }
    }
}
