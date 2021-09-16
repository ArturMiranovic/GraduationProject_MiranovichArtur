using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.EfStuff.Model.BikeModel;

namespace WebApplication_Artur.Models
{
    public class AddBikeViewModel
    {
        public string Name { get; set; }

        public long Price { get; set; }

        public BikeClass BikeClass { get; set; }

    }
}
