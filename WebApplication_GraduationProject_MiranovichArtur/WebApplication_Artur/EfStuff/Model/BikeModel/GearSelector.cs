using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Artur.EfStuff.Model.BikeModel
{
    public class GearSelector : BaseModel
    {
        public int Chainrings { get; set; }

        public int Rearstars { get; set; }

        public virtual Bike Bike { get; set; }

    }
}
