using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Models
{
    public class Contexto: DbContext
    {
        public Contexto()
        {
            Database.SetInitializer<Contexto>(new DropCreateDatabaseIfModelChanges<Contexto>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //remove plural das tabelas
            base.OnModelCreating(modelBuilder);modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Marca> Marcas { get; set; }

        public System.Data.Entity.DbSet<Aula1.Models.Usuario> Usuarios { get; set; }
    }
}
