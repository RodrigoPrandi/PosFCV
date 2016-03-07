using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_4_5
{
    class LivroLivraria:Livro
    {
        public int CodigoBarra { get; set; }
        public double Valor { get; set; }
        public override string ToString()
        {
            return base.ToString() + " - R$ " + Valor.ToString();
        }
    }
}
