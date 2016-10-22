using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AplicacaoWebService
{
    /// <summary>
    /// Summary description for Servico1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Servico1 : System.Web.Services.WebService
    {
        private List<String> listaAlunos = new List<String>();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public void CadastraAluno(string aluno)
        {
            listaAlunos.Add(aluno);
        }

        [WebMethod]
        public List<String> ListarAlunos()
        {
            return listaAlunos;
        }
    }
}
