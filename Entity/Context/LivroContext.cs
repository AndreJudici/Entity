using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Context
{
    class LivroContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>().HasKey(l => l.Id);
            base.OnModelCreating(modelBuilder);            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {  
            optionsBuilder.UseSqlite("Data Source=c:\\Banco\\Livros.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
