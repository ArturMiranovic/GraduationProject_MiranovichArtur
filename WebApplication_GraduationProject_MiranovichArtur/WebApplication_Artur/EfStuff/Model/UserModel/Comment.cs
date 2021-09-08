using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.EfStuff.Model.BikeModel;

namespace WebApplication_Artur.EfStuff.Model.UserModel
{
    public class Comment : BaseModel
    {

        public string Text { get; set; }

        public DateTime DateTime { get; set; }

        public virtual User User { get; set; }

        public virtual Bike Bike { get; set; }

    }
}
