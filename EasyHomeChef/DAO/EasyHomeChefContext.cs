using EasyHomeChef.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace EasyHomeChef.DAO
{
    public class EasyHomeChefContext : DbContext
    {

        public DbSet<Geladeira> Geladeira { get; set; }

        public DbSet<GeladeiraIngrediente> GeladeiraIngrediente { get; set; }

        public DbSet<GeladeiraTempero> GeladeiraTempero { get; set; }

        public DbSet<Ingrediente> Ingrediente { get; set; }

        public DbSet<Receita> Receita { get; set; }

        public DbSet<ReceitaIngrediente> ReceitaIngrediente { get; set; }

        public DbSet<ReceitaTempero> ReceitaTempero { get; set; }

        public DbSet<Tempero> Tempero { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["EasyHomeChef"].ConnectionString;
            optionsBuilder.UseSqlServer(stringConexao);
            base.OnConfiguring(optionsBuilder);
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GeladeiraIngrediente>()
                .HasKey(gi => new { gi.GeladeiraID, gi.IngredienteID });

            modelBuilder.Entity<GeladeiraTempero>()
                .HasKey(gt => new { gt.GeladeiraID, gt.TemperoID });

            modelBuilder.Entity<ReceitaIngrediente>()
                .HasKey(ri => new { ri.ReceitaID, ri.IngredienteID });

            modelBuilder.Entity<ReceitaTempero>()
                .HasKey(rt => new { rt.ReceitaID, rt.TemperoID });
            base.OnModelCreating(modelBuilder);
        }
        
    }
}
