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
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace WebApplication_Artur.Controllers
{
    public class SharedBikeController : Controller
    {

        private IMapper _mapper;
        private BikeRepository _bikeRepository; 
        private UserService _userServices;
        private SharedRepository _sharedRepository;
        private IWebHostEnvironment _webHostEnvironment;

        public SharedBikeController(IMapper mapper, BikeRepository bikeRepository, UserService userServices, IWebHostEnvironment webHostEnvironment, SharedRepository sharedRepository)
        {
            _mapper = mapper;
            _bikeRepository = bikeRepository;
            _userServices = userServices;
            _webHostEnvironment = webHostEnvironment;
            _sharedRepository = sharedRepository;
        }

        public IActionResult All()
        {

            var allBike = _bikeRepository.GetAll();

            var viewModels = _mapper.Map<List<GalereyBikeViewModel>>(allBike);

            return View(viewModels);
        }

        public IActionResult Remove(long id)
        {

            _bikeRepository.Remove(id);

            return RedirectToActionPermanent("All");
        }


        [HttpGet]
        public IActionResult Add(long id)
        {
            var viewMmodel = new AddSharedBikeViewModel()
            {
                BikeId = id
            };

            return View(viewMmodel);
        }

        [HttpPost]
        public IActionResult Add(AddSharedBikeViewModel viewMmodel)
        {

            var shared = _mapper.Map<Shared>(viewMmodel);

            shared.Bike = _bikeRepository.Get(viewMmodel.BikeId);

            _sharedRepository.Save(shared);

            return RedirectToActionPermanent("PageBike", "Bike", new { idBike = viewMmodel.BikeId });
        }


    }
}
