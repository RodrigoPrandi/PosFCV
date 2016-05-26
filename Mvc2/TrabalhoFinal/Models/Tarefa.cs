using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

          
        public string Nome { get; set; }

        [Required]
        public string Descricao { get; set; }

        public bool Done { get; set; }

        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
