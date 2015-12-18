using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class Form1 : Form
    {
        private Restaurante _restaurante;
        public Form1()
        {
            InitializeComponent();
            _restaurante = new Restaurante(0);
            AtualizarValorTela();
        }

        private void btnAdicionarConsumacao_Click(object sender, EventArgs e)
        {
            double valor;
            if (double.TryParse(textBoxConsumacao.Text, out valor))
                _restaurante.AdicionarConsumacao(valor);
            else
                MessageBox.Show("Não foi possível acrescentar a consumação");

            AtualizarValorTela();
        }

        private void AtualizarValorTela()
        {
            lblValorTotal.Text = string.Format("R$ {0}", _restaurante.ValorConta);
            lblValorPorPessoa.Text = string.Format("R$ {0}", _restaurante.ValorPorPessoa);
        }

        private void buttonDividirConta_Click(object sender, EventArgs e)
        {
            int quantidadePessoas;

            if (int.TryParse(textBoxQuantidadePessoas.Text, out quantidadePessoas))
            {
                _restaurante.DividirContaPor(quantidadePessoas);
                AtualizarValorTela();
                lblValorPorPessoa.Visible = true;
            }
        }

        private void buttonPagarParte_Click(object sender, EventArgs e)
        {
            _restaurante.PagarParte();
            AtualizarValorTela();

        }
    }
}
