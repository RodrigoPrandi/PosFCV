using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.FactoryMethod.Exemplo_2
{
    public class FabricaF800 : Fabrica
    {
        public override IMoto FabricarMoto()
        {
            return new F800Bmw();
        }
    }
}
