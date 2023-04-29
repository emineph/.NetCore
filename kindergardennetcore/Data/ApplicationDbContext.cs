using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using kindergardennetcore.Models;

namespace kindergardennetcore.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }

        public virtual DbSet<Ders> Derses { get; set; }

        public virtual DbSet<Ogrenci> Ogrencis { get; set; }

        public virtual DbSet<Ogretmen>Ogretmens { get; set; }

        public virtual DbSet<Okul> Okuls { get; set; }

        public virtual DbSet<Admin> Admins { get; set; }
    }
}
