using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.EfStuff.Model.BikeModel;

namespace WebApplication_Artur.Models
{
    public class GalereyBikeViewModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public long Price { get; set; }

        public long BikeSize { get; set; }

        public BikeClass BikeClass { get; set; }

        public string Page { get; set; }
    }
}
