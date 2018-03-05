﻿// <auto-generated />
using EasyHomeChef.DAO;
using EasyHomeChef.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EasyHomeChef.Migrations
{
    [DbContext(typeof(EasyHomeChefContext))]
    partial class EasyHomeChefContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EasyHomeChef.Models.Geladeira", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("ID");

                    b.ToTable("Geladeira");
                });

            modelBuilder.Entity("EasyHomeChef.Models.GeladeiraIngrediente", b =>
                {
                    b.Property<int>("GeladeiraID");

                    b.Property<int>("IngredienteID");

                    b.Property<int>("Quantidade");

                    b.HasKey("GeladeiraID", "IngredienteID");

                    b.HasIndex("IngredienteID");

                    b.ToTable("GeladeiraIngrediente");
                });

            modelBuilder.Entity("EasyHomeChef.Models.GeladeiraTempero", b =>
                {
                    b.Property<int>("GeladeiraID");

                    b.Property<int>("TemperoID");

                    b.HasKey("GeladeiraID", "TemperoID");

                    b.HasIndex("TemperoID");

                    b.ToTable("GeladeiraTempero");
                });

            modelBuilder.Entity("EasyHomeChef.Models.Ingrediente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Categoria");

                    b.Property<int?>("GeladeiraID");

                    b.Property<double>("MediaPreco");

                    b.Property<string>("Nome");

                    b.Property<int?>("ReceitaID");

                    b.Property<int>("UN");

                    b.HasKey("ID");

                    b.HasIndex("GeladeiraID");

                    b.HasIndex("ReceitaID");

                    b.ToTable("Ingrediente");
                });

            modelBuilder.Entity("EasyHomeChef.Models.Receita", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Dificuldade");

                    b.Property<string>("ModoPreparo");

                    b.Property<string>("Nome");

                    b.Property<int>("TempoPreparo");

                    b.HasKey("ID");

                    b.ToTable("Receita");
                });

            modelBuilder.Entity("EasyHomeChef.Models.ReceitaIngrediente", b =>
                {
                    b.Property<int>("ReceitaID");

                    b.Property<int>("IngredienteID");

                    b.Property<string>("UnidadeMedida");

                    b.HasKey("ReceitaID", "IngredienteID");

                    b.HasIndex("IngredienteID");

                    b.ToTable("ReceitaIngrediente");
                });

            modelBuilder.Entity("EasyHomeChef.Models.ReceitaTempero", b =>
                {
                    b.Property<int>("ReceitaID");

                    b.Property<int>("TemperoID");

                    b.HasKey("ReceitaID", "TemperoID");

                    b.HasIndex("TemperoID");

                    b.ToTable("ReceitaTempero");
                });

            modelBuilder.Entity("EasyHomeChef.Models.Tempero", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("GeladeiraID");

                    b.Property<string>("Nome");

                    b.HasKey("ID");

                    b.HasIndex("GeladeiraID");

                    b.ToTable("Tempero");
                });

            modelBuilder.Entity("EasyHomeChef.Models.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Biografia");

                    b.Property<string>("Email");

                    b.Property<int>("GeladeiraID");

                    b.Property<string>("Nome");

                    b.HasKey("ID");

                    b.HasIndex("GeladeiraID");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("EasyHomeChef.Models.GeladeiraIngrediente", b =>
                {
                    b.HasOne("EasyHomeChef.Models.Geladeira", "Geladeira")
                        .WithMany()
                        .HasForeignKey("GeladeiraID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EasyHomeChef.Models.Ingrediente", "Ingrediente")
                        .WithMany()
                        .HasForeignKey("IngredienteID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EasyHomeChef.Models.GeladeiraTempero", b =>
                {
                    b.HasOne("EasyHomeChef.Models.Geladeira", "Geladeira")
                        .WithMany()
                        .HasForeignKey("GeladeiraID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EasyHomeChef.Models.Tempero", "Tempero")
                        .WithMany()
                        .HasForeignKey("TemperoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EasyHomeChef.Models.Ingrediente", b =>
                {
                    b.HasOne("EasyHomeChef.Models.Geladeira")
                        .WithMany("Ingrediente")
                        .HasForeignKey("GeladeiraID");

                    b.HasOne("EasyHomeChef.Models.Receita")
                        .WithMany("Ingredientes")
                        .HasForeignKey("ReceitaID");
                });

            modelBuilder.Entity("EasyHomeChef.Models.ReceitaIngrediente", b =>
                {
                    b.HasOne("EasyHomeChef.Models.Ingrediente", "Ingrediente")
                        .WithMany()
                        .HasForeignKey("IngredienteID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EasyHomeChef.Models.Receita", "Receita")
                        .WithMany()
                        .HasForeignKey("ReceitaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EasyHomeChef.Models.ReceitaTempero", b =>
                {
                    b.HasOne("EasyHomeChef.Models.Receita", "Receita")
                        .WithMany()
                        .HasForeignKey("ReceitaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EasyHomeChef.Models.Tempero", "Tempero")
                        .WithMany()
                        .HasForeignKey("TemperoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EasyHomeChef.Models.Tempero", b =>
                {
                    b.HasOne("EasyHomeChef.Models.Geladeira")
                        .WithMany("Tempero")
                        .HasForeignKey("GeladeiraID");
                });

            modelBuilder.Entity("EasyHomeChef.Models.Usuario", b =>
                {
                    b.HasOne("EasyHomeChef.Models.Geladeira", "Geladeira")
                        .WithMany()
                        .HasForeignKey("GeladeiraID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
