using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class FuncionarioRepositorio
    {
        private string ConnectionString { get; set; }
        public FuncionarioRepositorio()
        {
            ConnectionString = "Data Source=.\\SQLExpress;Initial Catalog=BancoADO;Integrated Security=SSPI;";
        }

        public List<Funcionario> ListaFuncionario()
        {
            var listaFuncionario = new List<Funcionario>();
            SqlConnection conexao;
            SqlDataAdapter da;
            try
            {
                conexao = new SqlConnection(ConnectionString);
                da = new SqlDataAdapter("SELECIONAR_FUNCIONARIO", conexao);

                DataSet ds = new DataSet();
                DataTable dt = new DataTable();

                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                conexao.Open();
                da.Fill(dt);
                da.Fill(ds);

                listaFuncionario = dt.AsEnumerable().Select(f => new Funcionario()
                {
                    Id = f.Field<int>("Id"),
                    Nome = f.Field<string>("Nome"),
                    Salario = f.Field<decimal>("Salario")
                }).ToList();

                return listaFuncionario;

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {

            }
        }
    }
}
