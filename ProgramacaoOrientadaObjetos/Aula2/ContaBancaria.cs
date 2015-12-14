using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    class ContaBancaria
    {
        private decimal saldo;

        public void Deposito(decimal valor)
        {
            this.saldo += valor;
        }

        public bool Saque(decimal valor)
        {
            bool sucesso =  saldo >= valor;

            if (sucesso)
                this.saldo -= valor;

            return sucesso;
        }

        public decimal SaldoConta()
        {
            return saldo;
        }
    }
}
