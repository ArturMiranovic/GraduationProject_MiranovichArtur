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
    public class BikeController : Controller
    {

        private IMapper _mapper;
        private BikeRepository _bikeRepository;
        private UserService _userServices;
        private IWebHostEnvironment _webHostEnvironment;

        public BikeController(IMapper mapper, BikeRepository bikeRepository,
            UserService userServices, IWebHostEnvironment webHostEnvironment)
        {
            _mapper = mapper;
            _bikeRepository = bikeRepository;
            _userServices = userServices;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult All()
        {

            var allBike = _bikeRepository.GetAll();

            var viewModels = _mapper.Map<List<GalereyBikeViewModel>>(allBike);

            return View(viewModels);
        }

        public IActionResult Remove(long id)
        {

            _bikeRepository.RemoveBike(id);
            //_bikeRepository.Remove(id);

            return RedirectToActionPermanent("All");
        }


        [HttpGet]
        [Authorize]
        public IActionResult AddBike()
        {


            return View();
        }

        [HttpPost]
        public IActionResult AddBike(AddBikeViewModel viewmodel)
        {
            var user = _userServices.GetCurrent().Name;

            var projectPath = _webHostEnvironment.WebRootPath;

            var guidRandom = Guid.NewGuid();

            if (viewmodel.BikePage != null)
            {
                var path = Path.Combine(projectPath, "image\\bike\\", user + "_" + viewmodel.BikePage.Name +
                   "_" + guidRandom + ".png");

                using (var filestream = new FileStream(path, FileMode.Create))
                {
                    viewmodel.BikePage.CopyTo(filestream);
                }
            }

            var bike = _mapper.Map<Bike>(viewmodel);

            if (viewmodel.BikePage != null)
            {
                bike.Page = $"/image/bike/{user}_{viewmodel.BikePage.Name}_{guidRandom}.png";
            }

            bike.Owner = _userServices.GetCurrent();

            _bikeRepository.Save(bike);

            return RedirectToActionPermanent("PageBike", "Bike", new { idBike = bike.Id });
        }

        public IActionResult PageBike(long idBike)
        {

            var bike = _bikeRepository.Get(idBike);

            var viewmodel = _mapper.Map<SharedViewModel>(bike);

            return View(viewmodel);
        }
    }
}
