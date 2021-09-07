using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Artur.EfStuff.Model
{
    public class User : BaseModel
    {

        public string Login { get; set; }

        public string Password { get; set; }

        public string Awatar { get; set; }

        public virtual List<Bike> Bike { get; set; }

    }
}
