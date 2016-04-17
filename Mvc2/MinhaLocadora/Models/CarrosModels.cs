using System;

namespace MinhaLocadora.Models
{
    public class CarrosModels
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public int PessoaModelsId { get; set; }
        public virtual PessoaModels Pessoa { get; set; }
    }
}