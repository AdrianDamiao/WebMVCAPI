﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Models;

namespace WebAPI.Migrations
{
    [DbContext(typeof(WebAPIContext))]
    partial class WebAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebAPI.Models.Department", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("WebAPI.Models.SalesRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<long?>("SellerId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("WebAPI.Models.Seller", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("BirthName");

                    b.Property<long?>("DepartmentId");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("WebAPI.Models.SalesRecord", b =>
                {
                    b.HasOne("WebAPI.Models.Seller", "Seller")
                        .WithMany("Sales")
                        .HasForeignKey("SellerId");
                });

            modelBuilder.Entity("WebAPI.Models.Seller", b =>
                {
                    b.HasOne("WebAPI.Models.Department", "Department")
                        .WithMany("Sellers")
                        .HasForeignKey("DepartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
