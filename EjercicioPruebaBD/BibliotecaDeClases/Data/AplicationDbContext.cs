using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaDeClases.Data
{
    public class AplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=JUANI\\SQLEXPRESS04;Database=EjemploEF;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }


    }
}
