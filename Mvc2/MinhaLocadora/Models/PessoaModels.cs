using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaLocadora.Models
{
    public class PessoaModels
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        [JsonIgnore]
        public ICollection<CarrosModels> Carros { get; set; }
    }       
}
