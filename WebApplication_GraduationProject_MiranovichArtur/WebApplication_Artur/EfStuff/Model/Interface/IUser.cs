using System.Collections.Generic;
using WebApplication_Artur.EfStuff.Model.BikeModel;
using WebApplication_Artur.EfStuff.Model.UserModel;

namespace WebApplication_Artur.EfStuff.Model.Interface

{
    public interface IUser
    {
        public long Id { get; set; }
        public string Name { get; set; }
        string Awatar { get; set; }
        List<Comment> Comments { get; set; }
        Lang Lang { get; set; }
        List<Bike> LikeBikes { get; set; }
        string Login { get; set; }
        List<Bike> MyBikes { get; set; }
        string Password { get; set; }
        Role Role { get; set; }
        UserInformation UserInformation { get; set; }
        Сurrency Сurrency { get; set; }
    }
}