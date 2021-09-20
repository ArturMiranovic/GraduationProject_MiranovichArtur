﻿using System;
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

        public void RemoveBike(long id)
        {
            var bike = Get(id);

            _shopDbContext.Entry(bike)
                .Collection(c => c.Comments)
                .Load();                            //Удаление всех связанных элементов с байком!!!

            _shopDbContext.Entry(bike)
                .Collection(l => l.PotentialBuyer)
                .Load();

            _dbSet.Remove(bike);
            _shopDbContext.SaveChanges();
        }

    }
}
