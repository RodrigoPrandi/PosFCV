using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new Context())
            {
                foreach (var item in contexto.Departamentos)
                {

                }
            }
            Console.ReadKey();
        }
    }
}
