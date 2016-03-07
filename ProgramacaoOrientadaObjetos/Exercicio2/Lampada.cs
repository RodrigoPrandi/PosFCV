using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Lampada
    {
        public StatusLampada Estado { get; private set; }

        public Lampada ()
        {
            Estado = StatusLampada.Apagada;
        }

        public void MudarEstado()
        {
            switch (Estado)
            {
                case StatusLampada.Apagada:
                    Estado = StatusLampada.MeiaLuz;
                    break;
                case StatusLampada.MeiaLuz:
                    Estado = StatusLampada.Acesa;
                    break;
                case StatusLampada.Acesa:
                    Estado = StatusLampada.Apagada;
                    break;
                default:
                    break;
            }
        }

    }
}
