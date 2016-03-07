using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.AbstractFactory
{
    class Yamaha1000cc : IMotoLuxo
    {
        public string ExibirInfoLuxo()
        {
            return "Yamaha 100 luxo";
        }
    }
}
