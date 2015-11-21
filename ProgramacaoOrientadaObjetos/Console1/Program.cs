using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////IF
            //int idade = Convert.ToInt32(Console.ReadLine());
            //if (idade >= 18)
            //{
            //    Console.WriteLine("Pode solicitar habilitação para digigir.");
            //    Console.WriteLine("Voto é obrigatorio");

            //}
            //else if (idade >= 16)
            //{
            //    Console.WriteLine("Não pode dirigir");
            //    Console.WriteLine("Voto é opcional");
            //}
            //else
            //{
            //    Console.WriteLine("Não pode dirigir");
            //    Console.WriteLine("Não pode votar");
            //}

            ////SWITCH 1
            //string statusPagamento = Console.ReadLine();
            //switch (statusPagamento)
            //{
            //    case "a":
            //        Console.WriteLine("pagamento em aberto");
            //        break;
            //    case "p":
            //        Console.WriteLine("pagamento realizado");
            //        break;
            //    default:
            //        Console.WriteLine("pagamento desconhecido");
            //        break;
            //}

            //FOR
            //Console.Write("Digite um número para a tabuada: ");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //for (int variavel = 0; variavel <= 10; variavel++)
            //{
            //    Console.WriteLine(string.Format("{0} X {1} = {2}", numero, variavel, numero * variavel));
            //}

            //WHILE
            //Console.Write("Digite um número para a tabuada: ");
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //int variavel2 = 0;
            //while (variavel2 < 10)
            //{
            //    Console.WriteLine(string.Format("{0} X {1} = {2}", numero2, variavel2, numero2 * variavel2));
            //    variavel2++;
            //}

            //DO WHILE
            char opcao;
            do
            {
                Console.Write("Escolha a opção [s] Sair - [c] Cadastrar - [p] Pesquisar: ");
                opcao = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch(opcao)
                {
                    case 'c':
                        Console.WriteLine("Cadastro");
                        break;
                    case 'p':
                        Console.WriteLine("Pesquisa");
                        break;
                    case 's':
                        break;
                    default:
                        Console.WriteLine("Opção inexistente!");
                        break;
                }

            } while (opcao != 's');

            //Console.WriteLine("Começou o programa");
            Console.ReadKey();
        }
    }
}
