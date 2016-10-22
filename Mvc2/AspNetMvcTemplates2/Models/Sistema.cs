using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcTemplates2.Models
{
    public class Sistema
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Responsavel { get; set; }
        public SituacaoEnum Situacao { get; set; }
    }

    public enum SituacaoEnum
    {
        Poc = 1,
        EmDesenvolvimento = 2,
        Finalizado = 3
    }
}
