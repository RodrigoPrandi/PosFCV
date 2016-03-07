using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.FactoryMethod.Desafio
{
    class Pizzaiolo : Cozinheiro
    {
        public override Comida CriarComida()
        {
            return new Pizza();
        }
    }
}
