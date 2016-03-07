using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_4_5
{
    class Livro
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public int QuantidadeDePagina { get; set; }
        public string Editora { get; set; }
        public string Idioma { get; set; }
        public string Resumo { get; set; }
        public DateTime Ano { get; set; }
        public int Edicao { get; set; }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", this.Nome, this.Autor, this.Editora);
        }
    }
}
