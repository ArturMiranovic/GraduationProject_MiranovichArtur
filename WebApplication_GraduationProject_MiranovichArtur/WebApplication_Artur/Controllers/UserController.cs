using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication_Artur.EfStuff.Model.UserModel;
using WebApplication_Artur.EfStuff.Model.BikeModel;
using WebApplication_Artur.EfStuff.Repositories;
using WebApplication_Artur.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

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
        public IActionResult Login()
        {
            var returnUrl = Request.Query["ReturnUrl"].FirstOrDefault();
            var viewModel = new RegistrationViewModel()
            {
                ReturnUrl = returnUrl
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Login(RegistrationViewModel viewModel)
        {
            var user = _userRepository.Get(viewModel.Login, viewModel.Password);

            if (user == null)
            {
                ModelState.AddModelError(nameof(RegistrationViewModel.Login),
                    "Неверный логин или пароль");
                return View(viewModel);
            }

            var claims = new List<Claim>();
            claims.Add(new Claim("Id", user.Id.ToString()));  //заменить Id на ClaimTypes
            claims.Add(new Claim(ClaimTypes.Name, user.Login));
            claims.Add(new Claim(
                ClaimTypes.AuthenticationMethod,
                Startup.AuthName));

            var claimsIdentity = new ClaimsIdentity(claims, Startup.AuthName);

            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            await HttpContext.SignInAsync(claimsPrincipal);

            if (string.IsNullOrEmpty(viewModel.ReturnUrl))
            {
                return Redirect("/");
            }

            return Redirect(viewModel.ReturnUrl);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
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
