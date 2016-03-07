using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.AbstractFactory
{
    class HondaBiz : IMotoPopular
    {
        public string ExibirInfoPopular()
        {
            return "Biz popular";
        }
    }
}
