using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimentos
{
    class Investimento
    {
        public static double rendimentoAnual(double capital, double jurosMensal){

            jurosMensal = jurosMensal / 100;
            
            for (int i = 1; i <= 12; i++)
            {
                capital = (capital * jurosMensal) + capital;
            }

            return capital;

        }

        public static double mesesInvestimento(double capital, double jurosMensal)
        {
            jurosMensal = jurosMensal / 100;

            int conta;

            double capitalDobro;

            capitalDobro = capital*2;

            conta = 0;

            for (double i = 0; i <= capitalDobro; )
            {
                capital = (capital * jurosMensal) + capital;
                i = capital;

                conta++;
            }

            return conta;


        }

    }
}
