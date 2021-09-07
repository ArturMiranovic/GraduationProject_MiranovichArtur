﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication_Artur.EfStuff;

namespace WebApplication_Artur.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20210907105644_BikeCost")]
    partial class BikeCost
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BikeUser", b =>
                {
                    b.Property<long>("BikeId")
                        .HasColumnType("bigint");

                    b.Property<long>("UsersId")
                        .HasColumnType("bigint");

                    b.HasKey("BikeId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("BikeUser");
                });

            modelBuilder.Entity("WebApplication_Artur.EfStuff.Model.Bike", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bike");
                });

            modelBuilder.Entity("WebApplication_Artur.EfStuff.Model.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Awatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BikeUser", b =>
                {
                    b.HasOne("WebApplication_Artur.EfStuff.Model.Bike", null)
                        .WithMany()
                        .HasForeignKey("BikeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication_Artur.EfStuff.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
