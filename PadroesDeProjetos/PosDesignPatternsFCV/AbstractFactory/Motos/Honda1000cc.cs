using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.AbstractFactory
{
    class Honda1000cc : IMotoLuxo
    {
        public string ExibirInfoLuxo()
        {
            return "Honda 1000 Luxo";
        }
    }
}
