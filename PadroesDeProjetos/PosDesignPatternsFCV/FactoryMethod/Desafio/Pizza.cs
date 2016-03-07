using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.FactoryMethod.Desafio
{
    public class Pizza : Comida
    {
        public override string Sabor()
        {
            return "Sabor de Pizza nova";
        }
    }
}
