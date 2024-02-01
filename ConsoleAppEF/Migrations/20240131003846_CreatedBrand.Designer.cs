﻿// <auto-generated />
using System;
using ConsoleAppEF.DatabaseAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleAppEF.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240131003846_CreatedBrand")]
    partial class CreatedBrand
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConsoleAppEF.Core.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("ConsoleAppEF.Core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ConsoleAppEF.Core.Entities.ProductDetail", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("ConsoleAppEF.Core.Entities.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("ConsoleAppEF.Core.Entities.Product", b =>
                {
                    b.HasOne("ConsoleAppEF.Core.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId");

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("ConsoleAppEF.Core.Entities.ProductDetail", b =>
                {
                    b.HasOne("ConsoleAppEF.Core.Entities.Product", "Product")
                        .WithOne("ProductDetail")
                        .HasForeignKey("ConsoleAppEF.Core.Entities.ProductDetail", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ConsoleAppEF.Core.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ConsoleAppEF.Core.Entities.Product", b =>
                {
                    b.Navigation("ProductDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
