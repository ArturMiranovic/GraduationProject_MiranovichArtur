﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.EfStuff.Model.UserModel;
using WebApplication_Artur.EfStuff.Model.BikeModel;

namespace WebApplication_Artur.EfStuff
{
    public class ShopDbContext : DbContext
    {

        public ShopDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UserInformation> UserInformation { get; set; }

        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Brake> Brakes { get; set; }
        public DbSet<GearSelector> Switches { get; set; }
        public DbSet<Wheel> Wheels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(x => x.MyBikes)
                .WithOne(x => x.Owner);

            modelBuilder.Entity<User>()
                .HasMany(x => x.LikeBikes)
                .WithMany(x => x.PotentialBuyer);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Comments)
                .WithOne(x => x.User);

            modelBuilder.Entity<User>()
                .HasOne(x => x.UserInformation)
                .WithOne(x => x.User)
                .HasForeignKey<UserInformation>(b => b.UserId);


            modelBuilder.Entity<Bike>()
                .HasMany(x => x.Brakes)
                .WithMany(x => x.Bikes);

            modelBuilder.Entity<Bike>()
                .HasMany(x => x.Switches)
                .WithMany(x => x.Bikes);

            modelBuilder.Entity<Bike>()
                .HasMany(x => x.Wheels)
                .WithMany(x => x.Bikes);

            modelBuilder.Entity<Bike>()
                .HasMany(x => x.Comments)
                .WithOne(x => x.Bike);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
