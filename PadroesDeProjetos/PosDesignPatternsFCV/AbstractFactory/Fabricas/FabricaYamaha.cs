using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.AbstractFactory
{
    public class FabricaYamaha : IFabricaDeMoto
    {
        public IMotoLuxo CriarMotoLuxo()
        {
            return new Yamaha1000cc();
        }

        public IMotoPopular CriarMotoPopular()
        {
            return new YamahaBR();
        }
    }
}
