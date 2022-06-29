using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.EfStuff.Model.BikeModel;
using WebApplication_Artur.EfStuff.Model.UserModel;

namespace WebApplication_Artur.Models
{
    public class SharedViewModel
    {

        public long Id { get; set; }

        public string Name { get; set; }

        public long Price { get; set; }

        public long BikeSize { get; set; }

        public string Page { get; set; }

        public long BrakeDiametr { get; set; }

        public long WheelDiametr { get; set; }

        public int FrontChainrings { get; set; }

        public int RearChainrings { get; set; }

        public BikeClass BikeClass { get; set; }

        public virtual Bike Bike { get; set; }

        public User Owner { get; set; }

        public List<User> PotentialBuyer { get; set; }

        public List<Comment> Comments { get; set; }



    }
}
