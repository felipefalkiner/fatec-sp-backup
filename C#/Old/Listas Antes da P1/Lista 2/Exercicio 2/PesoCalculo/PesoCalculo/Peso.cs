using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesoCalculo
{
    class Peso
    {
        public static double pesoMasculino(double altura){

            return 72.7 * altura - 58;
            
        }

        public static double pesoFeminino(double altura)
        {

            return 62.1 * altura - 44.7;

        }

    }
}
