﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Artur.EfStuff.Model
{
    public class Bike : BaseModel
    {

        public virtual List<User> Users { get; set; }

        public long Price { get; set; }

        public int Size { get; set; }
        //public enum ViewBike {}
        


    }
}
