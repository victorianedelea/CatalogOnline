using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CatalogOnline.Models;

namespace CatalogOnline.Data
{
    public class CatalogOnlineContext : DbContext
    {
        public CatalogOnlineContext (DbContextOptions<CatalogOnlineContext> options)
            : base(options)
        {
        }

        public DbSet<CatalogOnline.Models.ListaProfesoriMaterie> ListaProfesoriMaterie { get; set; } = default!;

        public DbSet<CatalogOnline.Models.Materie> Materie { get; set; }

        public DbSet<CatalogOnline.Models.Profesor> Profesor { get; set; }

        public DbSet<CatalogOnline.Models.Student> Student { get; set; }

        public DbSet<CatalogOnline.Models.Nota> Nota { get; set; }
    }
}
