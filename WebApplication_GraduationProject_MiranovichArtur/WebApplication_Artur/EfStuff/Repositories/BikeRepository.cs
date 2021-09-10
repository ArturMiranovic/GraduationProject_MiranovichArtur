using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.EfStuff.Model.BikeModel;

namespace WebApplication_Artur.EfStuff.Repositories
{
    public class BikeRepository : BaseRepository<Bike>
    {

        public BikeRepository(ShopDbContext dbContext) : base(dbContext)
        {
        }

        public Bike Get(string name)
        {
            return _dbSet
                .SingleOrDefault(x => x.Name == name);
        }


    }
}
