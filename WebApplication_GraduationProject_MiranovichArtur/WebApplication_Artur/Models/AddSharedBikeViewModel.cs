using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Artur.Models
{
    public class AddSharedBikeViewModel
    {
        public long Id { get; set; }

        public long BikeId { get; set; }

        public string Size { get; set; }

        public string BrakeDiametr { get; set; }

        public string FrontChainrings { get; set; }

        public string RearChainrings { get; set; }

        public string WheelDiametr { get; set; }

    }
}
