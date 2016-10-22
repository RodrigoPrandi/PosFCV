using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WS_Aluno
{
    /// <summary>
    /// Summary description for ServicoAluno
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicoAluno : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<Aluno> CarregaAluno()
        {
            var listaAlunos = new List<Aluno>()
            {
                new Aluno {
                    Id = 1,
                    Nome = "Teste",
                    Nota = 9
                },
                new Aluno {
                    Id = 1,
                    Nome = "Teste2",
                    Nota = 7
                },
                new Aluno {
                    Id = 1,
                    Nome = "Teste3",
                    Nota = 9
                },
                new Aluno {
                    Id = 1,
                    Nome = "Prandi",
                    Nota = 10
                }
            };
            return listaAlunos;
        }
    }
}
