using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.EfStuff.Model.BikeModel;

namespace WebApplication_Artur.Models
{
    public class AddSharedBikeViewModel
    {
        public long Id { get; set; }

        public long BikeId { get; set; }

        public long BikeSize { get; set; }

        public long BrakeDiametr { get; set; }

        public long FrontChainrings { get; set; }

        public long RearChainrings { get; set; }

        public long WheelDiametr { get; set; }

        public BikeClass BikeClass { get; set; }


    }
}
