using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.Controllers;
using WebApplication_Artur.EfStuff.Model.UserModel;

namespace WebApplication_Artur.EfStuff.Repositories
{
    public class UserRepository : BaseRepository<User>
    {

        protected BikeRepository _bikeRepository;

        public UserRepository(ShopDbContext dbContext, BikeRepository bikeRepository) : base(dbContext)
        {
            _bikeRepository = bikeRepository;
        }

        public User Get(string login, string password)
        {
            return _dbSet
                .SingleOrDefault(x => x.Login == login && x.Password == password);
        }

        public User Get(string login)
        {
            return _dbSet
                .SingleOrDefault(x => x.Login == login);
        }

        public User GetUser(long id)
        {
            return _dbSet
                .SingleOrDefault(x => x.Id == id);
        }

        public void RemoveUser(long id)
        {
            var user = Get(id);

            var userBikes = _bikeRepository.GetAll()
                .Select(x => x.Owner = user);

            foreach (var bike in userBikes)
            {
                _bikeRepository.RemoveBike(bike.Id);
            }

            _shopDbContext.Entry(user)
                .Collection(m => m.MyBikes)
                .Load();


            _shopDbContext.Entry(user)
                .Collection(l => l.LikeBikes)
                .Load();

            _dbSet.Remove(user);

            _shopDbContext.SaveChanges();
        }


        public bool ExistLogin(string login)
        {
            return _dbSet.Any(x => (x.Login == login));
        }
    }
}
