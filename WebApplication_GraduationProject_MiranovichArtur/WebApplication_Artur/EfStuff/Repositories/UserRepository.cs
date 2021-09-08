using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}
