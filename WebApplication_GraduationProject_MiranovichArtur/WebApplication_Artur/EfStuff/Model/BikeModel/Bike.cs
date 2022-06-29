using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.EfStuff.Model.UserModel;

namespace WebApplication_Artur.EfStuff.Model.BikeModel
{
    public class Bike : BaseModel
    {

        public long Price { get; set; }

        public BikeClass BikeClass { get;set; }

        public string Page { get; set; }

        public virtual User Owner { get; set; }

        public virtual Shared Shared { get; set; }

        public virtual List<User> PotentialBuyer { get; set; }
        
        public virtual List<Comment> Comments { get; set; }
    }
}
