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
            //Caminho do banco de dados sqlite.
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\andre\\Documents\\Projetos\\C#\\Entity\\Entity\\Banco\\Livros.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
