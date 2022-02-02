using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCirculo
{
    class Circulo
    {
        public double raio;

        public double calculaDiametro (double raio)
        {
            return raio * 2;
        }

        public double calculaArea (double raio)
        {
            raio = raio * raio;

            return 3.14 * raio;
        }

        public double calculaCircuferencia (double raio)
        {
            return 2 * raio * 3.14;
        }
    }
}
