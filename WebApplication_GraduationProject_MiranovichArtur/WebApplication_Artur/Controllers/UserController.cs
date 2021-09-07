using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.EfStuff;
using WebApplication_Artur.EfStuff.Model;
using WebApplication_Artur.Models;

namespace WebApplication_Artur.Controllers
{
    public class UserController : Controller
    {

        private ShopDbContext _shopDbContext;

        public UserController(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }

        [HttpGet]
        public IActionResult Registration()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Registration(RegistrationViewModel viewmodel)
        {

            var user = new User()
            {
                Login = viewmodel.Login,
                Password = viewmodel.Password
            };

            _shopDbContext.Users.Add(user);

            _shopDbContext.SaveChanges();

            return RedirectToActionPermanent("Index", "Home");
        }

        public IActionResult All()
        {

            var allUser = _shopDbContext.Users.ToList();

            var viewModels = allUser
                .Select(x => new UaerForRemoveVieqModel()
                {
                    Id = x.Id,
                    Login = x.Login
                }).ToList();

            return View(viewModels);
        }

        public IActionResult Remove(long id)
        {

            var user = _shopDbContext.Users.Single(x => x.Id == id);
            _shopDbContext.Users.Remove(user);
            _shopDbContext.SaveChanges();

            return RedirectToActionPermanent("All");
        }
    }
}
