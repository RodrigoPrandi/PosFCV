using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resultado: " + Somar(1, 3));
            Console.WriteLine("Resultado: " + Subtrair(200, 52));
            Console.WriteLine("Resultado: " + Multiplicar(23, 13));
            Console.WriteLine("Resultado: " + Dividir(3455, 3));

            Console.WriteLine("Seu nome completo é: " + NomeCompleto("Rodrigo", "Prandi"));

            Console.ReadKey();
        }

        //public static void Imprimir(Action<int,int> operacao, int valor1, int valor2)
        //{
        //    Console.WriteLine("Resultado: " + operacao.Invoke(valor1, valor2));
        //}

        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public static string NomeCompleto(string a, string b)
        {
            return a + " " + b;
        }

        public static int Subtrair(int a, int b)
        {
            return a - b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public static int Dividir(int dividendo, int divisor)
        {
            return dividendo / divisor;
        }
    }
}
