using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CodeFirst_Usando_Migration
{
    [Table("Funcionarios")]
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public Departamento Departamento { get; set; }
    }
}

//Enable-Migrations