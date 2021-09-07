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
    public class BikeController : Controller
    {

        private ShopDbContext _shopDbContext;

        public BikeController(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }

        [HttpGet]
        public IActionResult AddBike()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddBike(BikeAddViewModel viewmodel)
        {

            var bike = new Bike()
            {
                Price = viewmodel.Price,

            };
            //добавить!!!!!!!!!!!!!!!!!!!!!!

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
