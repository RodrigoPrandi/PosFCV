using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2
{
    public partial class Form1 : Form
    {
        private Lampada _lampada;
        public Form1()
        {
            InitializeComponent();
            _lampada = new Lampada();
            AtualizarTela();
        }

        private void AtualizarTela()
        {
            switch (_lampada.Estado)
            {
                case StatusLampada.Apagada:
                    lblValorTotal.Text = "APAGADA";
                    break;
                case StatusLampada.MeiaLuz:
                    lblValorTotal.Text = "MEIA LUZ";
                    break;
                case StatusLampada.Acesa:
                    lblValorTotal.Text = "ACESA";
                    break;
            }
        }

        private void btnInterruptor_Click(object sender, EventArgs e)
        {
            _lampada.MudarEstado();
            AtualizarTela();
        }
    }
}
