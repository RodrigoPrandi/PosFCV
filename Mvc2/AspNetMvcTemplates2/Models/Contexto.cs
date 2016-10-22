using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcTemplates2.Models
{
    public class Contexto : DbContext
    {
        public Contexto()
            : base("MinhaString")
        { }

        public DbSet<Versao> Versoes { get; set; }
        public DbSet<Sistema> Sistemas { get; set; }
        public DbSet<Release> Release { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
