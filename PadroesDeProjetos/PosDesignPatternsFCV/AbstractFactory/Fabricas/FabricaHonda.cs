using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.AbstractFactory
{
    class FabricaHonda : IFabricaDeMoto
    {
        public IMotoLuxo CriarMotoLuxo()
        {
            return new Honda1000cc();
        }

        public IMotoPopular CriarMotoPopular()
        {
            return new HondaBiz();
        }
    }
}
