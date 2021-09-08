using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Artur.EfStuff.Model.BikeModel
{
    public class Switch : BaseModel
    {

        public double SwitchSize { get; set; }

        public virtual List<Bike> Bikes { get; set; }

    }
}
