using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaProva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota: ");
            int nota1;
            if (!int.TryParse(Console.ReadLine(), out nota1))
                nota1 = 0;
            Console.Write("Digite a segunda nota: ");
            int nota2;
            if (!int.TryParse(Console.ReadLine(), out nota2))
                nota2 = 0;
            Console.Write("Digite a terceira nota: ");
            int nota3;
            if (!int.TryParse(Console.ReadLine(), out nota3))
                nota3 = 0;

            float media = CalcularMedia(nota1, nota2, nota3);
            if (media > 7)
                Console.WriteLine("O Aluno foi APROVADO com a média " + media);
            else
                Console.WriteLine("O Aluno foi REPROVADO com a média " + media);

            Console.ReadKey();
        }

        private static float CalcularMedia(int nota1, int nota2, int nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }
    }
}
