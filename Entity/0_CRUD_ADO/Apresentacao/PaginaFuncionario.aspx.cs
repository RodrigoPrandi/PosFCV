using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Apresentacao
{
    public partial class PaginaFuncionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
        public void CarregarGrid()
        {
            FuncionarioNegocio negocio = new FuncionarioNegocio();
            var retorno = negocio.ListarFuncionario();

            GrvFuncionario.DataSource = retorno;
            GrvFuncionario.DataBind();
        }

        protected void GrvFuncionario_RowCommand(object sender, GridViewCommandEventArgs e)
        {


            if (e.CommandName == "Excluir")
            {
                FuncionarioNegocio negocio = new FuncionarioNegocio();
                var id = int.Parse(e.CommandArgument.ToString());
                //negocio.ExcluirFuncionario(id);
                //LimparCampos();
                CarregarGrid();
            }

            if (e.CommandName == "Editar")
            {
                int idx = int.Parse(e.CommandArgument.ToString());
                GridViewRow row = GrvFuncionario.Rows[idx];
                txtId.Text = row.Cells[2].Text;
                txtNome.Text = row.Cells[3].Text;
                txtSalario.Text = row.Cells[4].Text;

            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}