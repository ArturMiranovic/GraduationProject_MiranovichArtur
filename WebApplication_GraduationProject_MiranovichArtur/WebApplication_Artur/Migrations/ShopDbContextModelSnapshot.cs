﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication_Artur.EfStuff;

namespace WebApplication_Artur.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    partial class ShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BikeUser", b =>
                {
                    b.Property<long>("LikeBikesId")
                        .HasColumnType("bigint");

                    b.Property<long>("PotentialBuyerId")
                        .HasColumnType("bigint");

                    b.HasKey("LikeBikesId", "PotentialBuyerId");

                    b.HasIndex("PotentialBuyerId");

                    b.ToTable("BikeUser");
                });

            modelBuilder.Entity("WebApplication_Artur.EfStuff.Model.BikeModel.Bike", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BikeClass")
                        .HasColumnType("int");

                    b.Property<long>("BikeSize")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OwnerId")
                        .HasColumnType("bigint");

                    b.Property<string>("Page")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("/image/defolt/defaultBike1.png");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Bikes");
                });

            modelBuilder.Entity("WebApplication_Artur.EfStuff.Model.BikeModel.Shared", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<long>("BrakeDiametr")
                        .HasColumnType("bigint");

                    b.Property<long>("FrontChainrings")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RearChainrings")
                        .HasColumnType("bigint");

                    b.Property<long>("WheelDiameter")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Shareds");
                });

            modelBuilder.Entity("WebApplication_Artur.EfStuff.Model.UserModel.Comment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("BikeId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BikeId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("WebApplication_Artur.EfStuff.Model.UserModel.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Awatar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("/image/defolt/DefaultAvatar_V2.png");

                    b.Property<int>("Lang")
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Сurrency")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApplication_Artur.EfStuff.Model.UserModel.UserInformation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserInformation");
                });

            modelBuilder.Entity("BikeUser", b =>
                {
                    b.HasOne("WebApplication_Artur.EfStuff.Model.BikeModel.Bike", null)
                        .WithMany()
                        .HasForeignKey("LikeBikesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication_Artur.EfStuff.Model.UserModel.User", null)
                        .WithMany()
                        .HasForeignKey("PotentialBuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication_Artur.EfStuff.Model.BikeModel.Bike", b =>
                {
                    b.HasOne("WebApplication_Artur.EfStuff.Model.UserModel.User", "Owner")
                        .WithMany("MyBikes")
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("WebApplication_Artur.EfStuff.Model.BikeModel.Shared", b =>
                {
                    b.HasOne("WebApplication_Artur.EfStuff.Model.BikeModel.Bike", "Bike")
                        .WithOne("Shared")
                        .HasForeignKey("WebApplication_Artur.EfStuff.Model.BikeModel.Shared", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bike");
                });

            modelBuilder.Entity("WebApplication_Artur.EfStuff.Model.UserModel.Comment", b =>
                {
                    b.HasOne("WebApplication_Artur.EfStuff.Model.BikeModel.Bike", "Bike")
                        .WithMany("Comments")
                        .HasForeignKey("BikeId");

                    b.HasOne("WebApplication_Artur.EfStuff.Model.UserModel.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId");

                    b.Navigation("Bike");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication_Artur.EfStuff.Model.UserModel.UserInformation", b =>
                {
                    b.HasOne("WebApplication_Artur.EfStuff.Model.UserModel.User", "User")
                        .WithOne("UserInformation")
                        .HasForeignKey("WebApplication_Artur.EfStuff.Model.UserModel.UserInformation", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication_Artur.EfStuff.Model.BikeModel.Bike", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Shared");
                });

            modelBuilder.Entity("WebApplication_Artur.EfStuff.Model.UserModel.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("MyBikes");

                    b.Navigation("UserInformation");
                });
#pragma warning restore 612, 618
        }
    }
}
