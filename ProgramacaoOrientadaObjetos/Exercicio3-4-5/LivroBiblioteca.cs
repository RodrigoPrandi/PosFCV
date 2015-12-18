using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_4_5
{
    class LivroBiblioteca: Livro
    {
        public string Instituicao { get; set; }
        public int Identificador { get; set; }

        public override string ToString()
        {
            return base.ToString() + " - " + this.Instituicao;
        }
    }
}
