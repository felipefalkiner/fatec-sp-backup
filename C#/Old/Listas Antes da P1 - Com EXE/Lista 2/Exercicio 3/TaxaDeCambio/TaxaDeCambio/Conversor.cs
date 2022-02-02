using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxaDeCambio
{
    class Conversor
    {
        public static double dolarReal(double vlr, double taxa){
            return vlr * taxa;
        }

        public static double realDolar(double vlr, double taxa)
        {
            return vlr / taxa;
        }

    }
}
