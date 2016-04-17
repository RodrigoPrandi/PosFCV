using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaLocadora.Models
{
    public class Contexto: DbContext
    {
        public Contexto()
            : base("MinhaString")
        {}

        public DbSet<PessoaModels> Pessoas { get; set; }
        public DbSet<CarrosModels> Carros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
