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
    public class SharedController : Controller
    {

        private IMapper _mapper;

        public SharedController(ShopDbContext shopDbContext, IMapper mapper)
        {
            _mapper = mapper;

        }

        
    }
}
