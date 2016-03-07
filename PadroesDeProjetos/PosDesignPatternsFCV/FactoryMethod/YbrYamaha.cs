using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.FactoryMethod
{
    public class YbrYamaha : IMoto
    {
        public string ExibirModelo()
        {
            return "Y BR - Yamaha";
        }
    }
}
