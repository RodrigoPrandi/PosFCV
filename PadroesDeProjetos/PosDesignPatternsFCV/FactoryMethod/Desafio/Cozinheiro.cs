using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.FactoryMethod.Desafio
{
    public abstract class Cozinheiro
    {
        public abstract Comida CriarComida();
    }
}
