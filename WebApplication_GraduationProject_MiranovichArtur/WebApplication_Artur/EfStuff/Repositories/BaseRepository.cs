using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.EfStuff.Model;
using WebApplication_Artur.EfStuff.Model.BikeModel;

namespace WebApplication_Artur.EfStuff.Repositories
{
    public abstract class BaseRepository<Model>
    where Model : BaseModel
    {
        protected ShopDbContext _shopDbContext;
        protected DbSet<Model> _dbSet;

        public BaseRepository(ShopDbContext dbContext)
        {
            _shopDbContext = dbContext;
            _dbSet = _shopDbContext.Set<Model>();
        }

        public Model Get(long id)
        {
            return _dbSet.SingleOrDefault(x => x.Id == id);
        }

        public List<Model> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Save(Model model)
        {
            if (model.Id > 0)
            {
                _shopDbContext.Update(model);
            }
            else
            {
                _dbSet.Add(model);
            }

            _shopDbContext.SaveChanges();
        }

        public void Remove(Model model)
        {
            _dbSet.Remove(model);
            _shopDbContext.SaveChanges();
        }

        public void Remove(long id)
        {
            _dbSet.Remove(Get(id));
            _shopDbContext.SaveChanges();
        }

        public bool Exist(long id)
        {
            return _dbSet.Any(x => x.Id == id);
        }

        public bool ExistName(string name)
        {
            return _dbSet.Any(x => (x.Name == name));
        }
    }
}
