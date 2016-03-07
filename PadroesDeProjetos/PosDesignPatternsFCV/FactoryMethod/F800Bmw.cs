using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.FactoryMethod
{
    public class F800Bmw : IMoto
    {
        public string ExibirModelo()
        {
            return "F800 - BMW";
        }
    }
}
