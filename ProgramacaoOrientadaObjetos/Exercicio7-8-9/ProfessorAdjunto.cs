using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7_8_9
{
    class ProfessorAdjunto : Professor
    {
        public void ImprimirAnosTrabalhados()
        {
            ImprimirDados();
            Console.WriteLine("Trabalhou: " + (DateTime.Now.Year - DataAdmissao.Year) + " anos.");
        }
    }
}
