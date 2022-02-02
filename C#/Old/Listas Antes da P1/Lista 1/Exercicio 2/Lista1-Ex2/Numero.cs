using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_Ex2
{
    class Numero
    {
        public static int par(int n)
        {
            int resultado;

            resultado = n % 2;

            if (resultado == 0)
                return 100;
            else return 99;
        }

        public static int primo(int n)
        {
            int resultado;
            int index;

            index = 0;

            for (int i = 1; i <= n; i++)
            {
                resultado = n % i;

                if (resultado == 0)
                    index = index + 1;

            }

            if (index == 2)
                return 100;
            else return 99;

        }

        public static int fatorial(int n)
        {
            if (n <= 1)
                return 1;
            else return n * fatorial(n - 1);
        }
    
    
    
    
    }
}
