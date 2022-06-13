using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.EfStuff.Model.BikeModel;

namespace WebApplication_Artur.EfStuff.Repositories
{
    public class SharedBikeRepository : BaseRepository<Shared>
    {

        public SharedBikeRepository(ShopDbContext dbContext) : base(dbContext)
        {




        }
    }
}
