using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Models
{
    public class Marca
    {
        public int id { get; set; }

        public string Pais { get; set; }
        [Required]
        public string Nome { get; set; }
    }
}
