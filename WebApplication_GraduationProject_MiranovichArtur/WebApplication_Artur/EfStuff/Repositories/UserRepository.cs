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

        public UserRepository(ShopDbContext dbContext) : base(dbContext)
        {

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

        public bool Exist(string login)
        {
            return _dbSet.Any(x => x.Login == login);
        }

        public void RemoveUser(long id)
        {
            var user = Get(id);

            _shopDbContext.Entry(user)
                .Collection(m => m.MyBikes)
                .Load();

            _shopDbContext.Entry(user)
                .Collection(l => l.LikeBikes)
                .Load();

            _dbSet.Remove(user);
            _shopDbContext.SaveChanges();
        }
    }
}
