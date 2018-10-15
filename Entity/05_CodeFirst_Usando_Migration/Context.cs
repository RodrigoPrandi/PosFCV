using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CodeFirst_Usando_Migration
{
    public class Context : DbContext
    {
        public Context():base("name=ConectionString123")
        {

        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
    }
}
