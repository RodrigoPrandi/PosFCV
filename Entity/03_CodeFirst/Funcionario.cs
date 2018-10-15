using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CodeFirst
{
    [Table("Funcionario")]
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public Departamento Departamento { get; set; }
    }
}
