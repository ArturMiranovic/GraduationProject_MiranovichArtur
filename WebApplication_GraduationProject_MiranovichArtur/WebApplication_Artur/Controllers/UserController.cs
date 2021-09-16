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
using System.Threading;

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
        public IActionResult Login(RegistrationViewModel viewModel)
        {
            var user = _userRepository.Get(viewModel.Login, viewModel.Password);

            if (user == null)
            {
                ModelState.AddModelError(nameof(RegistrationViewModel.Login),
                    "Неверный логин или пароль");
                return View();
            }

            Voidentrance(user);

            if (string.IsNullOrEmpty(viewModel.ReturnUrl))
            {
                return Redirect("/");
            }
            return Redirect(viewModel.ReturnUrl);
        }

        private async void Voidentrance(User user)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim("Id", user.Id.ToString()));
            claims.Add(new Claim(ClaimTypes.Name, user.Login));
            claims.Add(new Claim("Lang", user.Lang.ToString()));
            claims.Add(new Claim(
                ClaimTypes.AuthenticationMethod,
                Startup.AuthName));

            var claimsIdentity = new ClaimsIdentity(claims, Startup.AuthName);

            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            await HttpContext.SignInAsync(claimsPrincipal);

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

            _userRepository.Save(user);

            Voidentrance(user);

            return RedirectToActionPermanent("Index", "Home");
        }

        public IActionResult All()
        {

            var allUser = _userRepository.GetAll();

            var viewModels = _mapper.Map<List<UserForRemoveVieqModel>>(allUser);

            return View(viewModels);
        }

        public IActionResult Remove(long id)
        {

            _userRepository.RemoveUser(id);

            return RedirectToActionPermanent("All");
        }

        public IActionResult IsUniq(string login) => Json(!_userRepository.Exist(login));

        public IActionResult IsUniqPassword(string password) => Json(password?.LongCount() > 3);

        public IActionResult IsUniqName(string name) => Json(name?.LongCount() > 1);
    }
}
