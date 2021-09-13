using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.EfStuff.Model.BikeModel;

namespace WebApplication_Artur.EfStuff.Model.UserModel
{
    public class User : BaseModel
    {

        public string Login { get; set; }

        public string Password { get; set; }

        public string Awatar { get; set; }

        public Role Role { get; set; }

        public Lang Lang { get; set; }

        public virtual UserInformation UserInformation { get; set; }

        public virtual List<Bike> MyBikes { get; set; }

        public virtual List<Bike> LikeBikes { get; set; }

        public virtual List<Comment> Comments { get; set; }

    }
}
