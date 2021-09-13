using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Artur.EfStuff.Model.BikeModel
{
    public class Brake : BaseModel
    {

        public long Diametr { get; set; }

        //public double BrakeSize { get; set; }

        public virtual List<Bike> Bikes { get; set; }

    }
}
