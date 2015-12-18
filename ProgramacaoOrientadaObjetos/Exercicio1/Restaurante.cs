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
        public double ValorPorPessoa
        {
            get
            {
                if (ValorConta > 0)
                    return ValorConta / _quantidadePessoas;
                else
                    return ValorConta;
            }
        }
        private int _quantidadePessoas = 0;

        public Restaurante (double valorInicial)
        {
            ValorConta = valorInicial;
        }

        public void AdicionarConsumacao(double valor)
        {
            ValorConta += valor;
        }

        public void DividirContaPor(int quantidadePessoas)
        {
            _quantidadePessoas = quantidadePessoas;
        }

        public void PagarParte()
        {
            if (ValorConta > 0 && _quantidadePessoas > 0)
            {
                ValorConta -= ValorConta / _quantidadePessoas;
                _quantidadePessoas--;
            }
        }
    }
}
