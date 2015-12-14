using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    class Calculadora
    {

        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Somar(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int dividendo, int divisor)
        {
            return dividendo / divisor;
        }
    }
}
