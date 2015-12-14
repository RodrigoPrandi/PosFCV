using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Restaurante
    {
        public double ValorConta { get; private set; }
        public Restaurante (double valorInicial)
        {
            ValorConta = valorInicial;
        }

        public void AdicionarConsumacao(double valor)
        {
            ValorConta += valor;
        }

        public double DividirConta(int quantidadePessoas)
        {
            return ValorConta / quantidadePessoas;
        }

        public double PagarConta(double valorPago)
        {
            if (valorPago <= -ValorConta)
            {
                ValorConta -= valorPago;
                return 0;
            }
            else
            {
                var troco = valorPago - ValorConta;
                ValorConta = 0;
                return troco;
            }
        }
    }
}
