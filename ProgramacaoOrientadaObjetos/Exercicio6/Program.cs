using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Aviao aviao = new Aviao();
            aviao.Prefixo = "PT-123";
            aviao.Fabricante = "Embraer";
            aviao.QuantidadeAssntos = 134;
            aviao.QuantidadeAssentosOcupados = 12;

            aviao.ImprimirPrefixoAeronave();

            Console.ReadKey();
        }
    }
}
