using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignPatternsFCV.FactoryMethod.Exemplo1
{
    public static class FabricaMotos
    {
        public static IMoto Fabricar(MotoEnum tipoMoto)
        {
            switch (tipoMoto)
            {
                case MotoEnum.CG150:
                    return new CgTitanHonda();
                case MotoEnum.YBR:
                    return new YbrYamaha();
                case MotoEnum.Ninja250:
                    return new NinjaKawasaki();
                case MotoEnum.F800:
                    return new F800Bmw();
                default:
                    throw new Exception("Moto Não encontrada");
            }
        }
    }
}
