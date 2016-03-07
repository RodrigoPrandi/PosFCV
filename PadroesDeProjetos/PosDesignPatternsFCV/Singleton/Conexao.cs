using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.Singleton
{
    // Singleton
    // Garantir que apenas uma única instancia será instanciada

    //Problema:
    //Inicialização é lenta e o acesso global é necessário.
    //Concorrencia em sistemas com muitas threads
    
    public class Conexao
    {
        private static Conexao _instance;
        public string Usuario { get; set; }
        public string Senha { get; set; }

        protected Conexao()
        {
        }

        public bool IniciarConexao()
        {
            return true;
        }

        public string Salvar()
        {
            return "Salvo";
        }

        public static Conexao GetInstance()
        {
            if (_instance == null)
                _instance = new Conexao();

            return _instance;
        }
    }
}
