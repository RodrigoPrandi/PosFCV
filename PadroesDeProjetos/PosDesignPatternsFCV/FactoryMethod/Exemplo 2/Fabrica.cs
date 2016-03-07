using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.FactoryMethod.Exemplo_2
{
    public abstract class Fabrica
    {
        public abstract IMoto FabricarMoto();
    }
}
