using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.EfStuff;
using WebApplication_Artur.Models;

namespace WebApplication_Artur.Controllers
{
    public class HomeController : Controller
    {

        private ShopDbContext _shopDbContext;

        public HomeController(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }

        public IActionResult Index()
        {

            var allUsers = _shopDbContext.Bikes.ToList();

            return View(allUsers.Count);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
