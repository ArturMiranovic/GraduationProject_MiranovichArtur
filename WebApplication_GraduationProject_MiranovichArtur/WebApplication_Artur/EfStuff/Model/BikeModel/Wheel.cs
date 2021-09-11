﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Artur.EfStuff.Model.BikeModel
{
    public class Wheel : BaseModel
    {

        public int Diameter { get; set; }

        public double WhellSize { get; set; }

        public virtual List<Bike> Bikes { get; set; }

    }
}