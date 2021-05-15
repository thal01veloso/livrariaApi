﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using livrariaApi.Context;

namespace livrariaApi.Migrations
{
    [DbContext(typeof(ProdutoContext))]
    partial class ProdutoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("livrariaApi.Entity.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnName("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnName("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("Preco")
                        .HasColumnName("Preco")
                        .HasColumnType("float");

                    b.Property<int>("quantidade")
                        .HasColumnName("Qtd")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
