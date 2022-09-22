﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Task08_WebAPI.Data;

#nullable disable

namespace Task08WebAPI.Migrations
{
    [DbContext(typeof(ProductAPIDbContext))]
    partial class ProductAPIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0-rc.1.22426.7");

            modelBuilder.Entity("Task08_WebAPI.Model.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Availability")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
