﻿// <auto-generated />
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GeekShopping.ProductAPI.Migrations
{
    [DbContext(typeof(MySqlContext))]
    [Migration("20220307012523_SeedProductDataTable")]
    partial class SeedProductDataTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("GeekShopping.ProductAPI.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("product");

                    b.HasData(
                        new
                        {
                            Id = 3L,
                            CategoryName = "T-Shirt",
                            Description = "Camiseta casual",
                            ImageUrl = "C:\\Users\\Rodolfo\\Pictures\\MicrosserviceImg\\camiseta-personalizada.jpg",
                            Name = "Camiseta G",
                            Price = 58.88m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryName = "Eletroeletrônicos",
                            Description = "Ventilador de chão",
                            ImageUrl = "C:\\Users\\Rodolfo\\Pictures\\MicrosserviceImg\\ventilador.jpg",
                            Name = "Ventilador",
                            Price = 58.88m
                        },
                        new
                        {
                            Id = 5L,
                            CategoryName = "Shoew",
                            Description = "Tênis preto e amarelo",
                            ImageUrl = "C:\\Users\\Rodolfo\\Pictures\\MicrosserviceImg\\tenis.jpg",
                            Name = "Tênis",
                            Price = 58.88m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
