using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Artur.EfStuff.Model.UserModel
{
    public class UserInformation :  BaseModel
    {
        public long UserId { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public virtual User User { get; set; }

    }
}
