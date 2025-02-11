﻿// <auto-generated />
using Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api.Migrations.CarrinhoDeCompras
{
    [DbContext(typeof(ShoppingCartContext))]
    [Migration("20221010031649_CriandoTabelaDeCarrinhoDeCompras")]
    partial class CriandoTabelaDeCarrinhoDeCompras
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Api.Models.CarrinhoDeCompras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdDoItem")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CarrinhoDeCompras");
                });
#pragma warning restore 612, 618
        }
    }
}
