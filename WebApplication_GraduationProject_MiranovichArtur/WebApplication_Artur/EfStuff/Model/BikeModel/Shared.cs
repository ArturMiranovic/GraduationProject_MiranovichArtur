using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Artur.EfStuff.Model.BikeModel
{
    public class Shared : BaseModel
    {

        public long BrakeDiametr { get; set; }

        public int WheelDiameter { get; set; }

        public int Chainrings { get; set; }

        public int Rearstars { get; set; }

        public virtual Bike Bike { get; set; }

    }
}
