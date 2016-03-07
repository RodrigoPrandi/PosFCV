using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.FactoryMethod
{
    public class CgTitanHonda : IMoto
    {
        public string ExibirModelo()
        {
            return "CG - Honda";
        }
    }
}
