using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Aviao
    {
        public string Prefixo { get; set; }
        public string Fabricante { get; set; }
        public int QuantidadeAssntos { get; set; }
        public int QuantidadeAssentosOcupados { get; set; }

        public void ImprimirPrefixoAeronave()
        {
            Console.WriteLine(this.Prefixo);
        }
    }
}
