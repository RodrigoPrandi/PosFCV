using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7_8_9
{
    class Professor
    {
        public string Nome { get; set; }
        public string Departamento { get; set; }
        public DateTime DataAdmissao { get; set; }
        public int NumeroRegistro { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine("Dados do Professor: ");
            Console.WriteLine(string.Format("Nome: {0}", Nome));
            Console.WriteLine(string.Format("Departamento: {0}", Departamento));
            Console.WriteLine(string.Format("Data Admissao: {0}", DataAdmissao));
            Console.WriteLine(string.Format("Numero Registro: {0}", NumeroRegistro));
        }
    }
}
