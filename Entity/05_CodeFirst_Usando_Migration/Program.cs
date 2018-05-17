using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CodeFirst_Usando_Migration
{
    class Program
    {
        /// <summary>
        /// 1 - enable-migrations
        /// 2 - add-migration 'NOME'
        /// 3 - update-database                  *para atualizar até o último
        /// 4 - update-database -target 'NOME'   *para voltar a um ponto especifico
        /// </summary>
        /// <param name="args"></param>
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
