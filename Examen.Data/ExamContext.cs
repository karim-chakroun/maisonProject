using Examen.Data.Configurations;
using Examen.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen.Data
{
    public class ExamContext:DbContext
    {
        public ExamContext()
        {
            //Database.EnsureCreated();// création de la BDD pour la 1 fois
        }
        //la liste des DbSet
        //public DbSet<Exemple> Exemples { get; set; }
        public DbSet<Maison> Maisons { get; set; }
        public DbSet<TypeMaison> Types { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
            Initial Catalog=ProjetMeriem;
            Integrated Security=true;
            MultipleActiveResultSets=true");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.ApplyConfiguration(new ExempleConfiguration());
            modelBuilder.ApplyConfiguration(new MaisonConfiguration());
        }
    }
}
