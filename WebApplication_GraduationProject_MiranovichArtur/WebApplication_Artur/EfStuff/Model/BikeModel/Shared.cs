using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Artur.EfStuff.Model.BikeModel
{
    public class Shared : BaseModel
    {

        public long BrakeDiametr { get; set; }

        public long WheelDiameter { get; set; }

        public long FrontChainrings { get; set; }

        public long RearChainrings { get; set; }

        public virtual Bike Bike { get; set; }

    }
}
