using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CodeFirst_Usando_Migration
{
    public class Departamento
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        //Propriedade de navegação
        public List<Funcionario> Funcionarios { get; set; }

    }
}
