using IsaacGonzález._2024.EN;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaacGonzález._2024.DAL
{
    public class ComunDB : DbContext
    {
        public DbSet<Produc> Productos { get; set; }
        public DbSet<Catego> Categorias { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Gabriel-7w7\\SQLEXPRESS;Initial Catalog=PruebaTecina;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
