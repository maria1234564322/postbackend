﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241028142036_ImdexFunctional2")]
    partial class ImdexFunctional2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.18");

            modelBuilder.Entity("DataAccess.Entities.DbAnimal", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnimalTyp")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Feed")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("OrderId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("DataAccess.Entities.DbClient", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsRegistered")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("DataAccess.Entities.DbDocument", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<long>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Packaging")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ReturnShipping")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("DataAccess.Entities.DbIndex", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Districtus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Index")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumberStreet")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DbIndex");
                });

            modelBuilder.Entity("DataAccess.Entities.DbLocation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apartment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberApartment")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberStreet")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TypeOfLocations")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("DataAccess.Entities.DbOrder", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<long>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateArrival")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("TEXT");

                    b.Property<long>("DeliveryPointId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("DeliveryPrice")
                        .HasColumnType("TEXT");

                    b.Property<long>("DeparturePointId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Height")
                        .HasColumnType("REAL");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Length")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderPayer")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PromoCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("SenderId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Weight")
                        .HasColumnType("REAL");

                    b.Property<double>("Width")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DeliveryPointId");

                    b.HasIndex("DeparturePointId");

                    b.HasIndex("SenderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DataAccess.Entities.DbParcel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("EstimatedValue")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<long>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Remittancel")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Parcels");
                });

            modelBuilder.Entity("DataAccess.Entities.DbUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("UserLocationId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserLocationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataAccess.Entities.DbAnimal", b =>
                {
                    b.HasOne("DataAccess.Entities.DbOrder", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("DataAccess.Entities.DbDocument", b =>
                {
                    b.HasOne("DataAccess.Entities.DbOrder", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("DataAccess.Entities.DbOrder", b =>
                {
                    b.HasOne("DataAccess.Entities.DbClient", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.DbLocation", "DeliveryPoint")
                        .WithMany()
                        .HasForeignKey("DeliveryPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.DbLocation", "DeparturePoint")
                        .WithMany()
                        .HasForeignKey("DeparturePointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.DbClient", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("DeliveryPoint");

                    b.Navigation("DeparturePoint");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("DataAccess.Entities.DbParcel", b =>
                {
                    b.HasOne("DataAccess.Entities.DbOrder", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("DataAccess.Entities.DbUser", b =>
                {
                    b.HasOne("DataAccess.Entities.DbLocation", "UserLocation")
                        .WithMany()
                        .HasForeignKey("UserLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserLocation");
                });
#pragma warning restore 612, 618
        }
    }
}
