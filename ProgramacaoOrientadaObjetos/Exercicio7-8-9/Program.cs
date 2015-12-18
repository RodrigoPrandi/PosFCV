using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7_8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor();
            professor.DataAdmissao = new DateTime(2012, 12, 04);
            professor.Nome = "Rodrigo Prandi";
            professor.NumeroRegistro = 1234;
            professor.Departamento = "Informatica";
            professor.ImprimirDados();

            Console.WriteLine();


            ProfessorAdjunto professorAdjunto = new ProfessorAdjunto();
            professorAdjunto.DataAdmissao = new DateTime(2013, 05, 04);
            professorAdjunto.Nome = "Mario Anao";
            professorAdjunto.NumeroRegistro = 12333;
            professorAdjunto.Departamento = "Informatica";
            professorAdjunto.ImprimirAnosTrabalhados();

            Console.ReadKey();

        }
    }
}
