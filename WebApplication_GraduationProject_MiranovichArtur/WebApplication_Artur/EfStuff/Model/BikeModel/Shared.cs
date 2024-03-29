﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Artur.EfStuff.Model.BikeModel
{
    public class Shared : BaseModel
    {

        public long BikeSize { get; set; }

        public long BrakeDiametr { get; set; }

        public long WheelDiametr { get; set; }

        public int FrontChainrings { get; set; }

        public int RearChainrings { get; set; }

        public virtual Bike Bike { get; set; }

    }
}
