using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.FactoryMethod.Desafio
{
    public class Carne : Comida
    {
        public override string Sabor()
        {
            return "Sabor de carne assada";
        }
    }
}
