using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new AulaEntityFrameworkEntities())
            {
                Console.WriteLine("Categorias Selecionadas: ");
                foreach(var item in contexto.Categoria)
                {
                    Console.WriteLine(item.Nome);
                }
            }
            Console.ReadKey();
        }
    }
}
