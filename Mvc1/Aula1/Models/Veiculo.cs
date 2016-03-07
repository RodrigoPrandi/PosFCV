using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Models
{
    public class Veiculo
    {
        public int id { get; set; }

        [Required]
        public int Ano { get; set; }
        public string Modelo { get; set; }
        public decimal Preco { get; set; }

        [Required]
        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; }
    }
}
