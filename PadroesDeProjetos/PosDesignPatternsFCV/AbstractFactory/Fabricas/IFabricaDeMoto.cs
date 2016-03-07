using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.AbstractFactory
{
    public interface IFabricaDeMoto
    {
        IMotoLuxo CriarMotoLuxo();

        IMotoPopular CriarMotoPopular();
    }
}
