using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_4_5
{
    class Program
    {
        static void Main(string[] args)
        {

            LivroBiblioteca livroBiblioteca = new LivroBiblioteca();
            livroBiblioteca.Nome = "Livro 1";
            livroBiblioteca.Autor = "Autor 1";
            livroBiblioteca.Editora = "Editora1";
            livroBiblioteca.Identificador = 1233;
            livroBiblioteca.Instituicao = "FCV";

            Console.WriteLine(livroBiblioteca.ToString());

            LivroLivraria livroLivraria = new LivroLivraria();
            livroLivraria.Nome = "Livro 2";
            livroLivraria.Autor = "Autor 2";
            livroLivraria.Editora = "Editora2";
            livroLivraria.CodigoBarra = 79822323;
            livroLivraria.Valor = 50.32;

            Console.WriteLine(livroLivraria.ToString());

            Console.ReadKey();
        }
    }
}
