using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Conversor
    {

        public static double milhasKm(double dist)
        {
            return dist / 0.62137;   
        }

        public static double kmMilhas(double dist)
        {
            return dist * 0.62137;
        }

    }
}
