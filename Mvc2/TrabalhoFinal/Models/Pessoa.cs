using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Cpf { get; set; }

        [JsonIgnore]
        public ICollection<Tarefa> Tarefas { get; set; }
    }
}
