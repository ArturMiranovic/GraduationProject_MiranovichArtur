using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.EfStuff;
using WebApplication_Artur.EfStuff.Model;
using WebApplication_Artur.Models;
using WebApplication_Artur.EfStuff.Model.BikeModel;
using AutoMapper;
using WebApplication_Artur.EfStuff.Repositories;
using WebApplication_Artur.Services;
using Microsoft.AspNetCore.Http;

namespace WebApplication_Artur.Controllers
{
    public class BikeController : Controller
    {

        private IMapper _mapper;
        private BikeRepository _bikeRepository; 
        private UserServices _userServices;
        //private IHttpContextAccessor _httpContextAccessor;

        public BikeController(ShopDbContext shopDbContext, IMapper mapper, BikeRepository bikeRepository, UserServices userServices)
        {
            _mapper = mapper;
            _bikeRepository = bikeRepository;
            _userServices = userServices;
        }

        [HttpPost]
        public IActionResult All()
        {

            var allUser = _bikeRepository.GetAll();

            var viewModels = _mapper.Map<BikeViewModel>(allUser);

            return View(viewModels);
        }

        public IActionResult Remove(long id)
        {

            _bikeRepository.Remove(id);

            return RedirectToActionPermanent("All");
        }

        [HttpGet]
        public IActionResult AddBike()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddBike(AddBikeViewModel viewmodel)
        {

            var bike = _mapper.Map<Bike>(viewmodel);        //на каком моменте появляется id?

            bike.Owner = _userServices.GetCurrent();

            _bikeRepository.Save(bike);

            //var idBike = _mapper.Map<BikeViewModel>(_bikeRepository.Get(bike.Name)).Id; //поиск по имени?

            //return RedirectToActionPermanent("PageBike", "Bike", idBike);  // передать полностью модель или только id?

            return RedirectToActionPermanent("PageBike", "Bike", bike.Id);
        }

        [HttpPost]
        public IActionResult PageBike(long idBike)
        {

            var bike = _bikeRepository.Get(idBike);

            var viewmodel = _mapper.Map<BikeViewModel>(bike);

            return View(viewmodel);
        }

        [HttpGet]
        public IActionResult PageBike()
        {



            return View();
        }
    }
}
