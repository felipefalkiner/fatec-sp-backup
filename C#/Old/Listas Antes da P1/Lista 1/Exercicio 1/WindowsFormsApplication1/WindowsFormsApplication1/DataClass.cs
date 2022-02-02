using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class DataClass
    {
        public static int bissexto(int ano)
        {
            int resto, resto2, resto3;

            resto = ano % 400;

            if (resto == 0)
            {
                return 100;
            }

            else
            {

                resto2 = ano % 4;
                resto3 = ano % 100;

                if (resto2 == 0 && resto3 != 0)
                    return 100;
                else return 99;
            }
        }


        public static int validaData(int dia, int mes, int ano)
        {
            switch (mes)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    if (dia > 30)
                        return 99;
                    else return 100;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (dia > 31)
                        return 99;
                    else return 100;
                case 2:
                    int vb;
                    vb = bissexto(ano);

                    if (dia > 29)
                        return 99;
                    else if (dia == 29)
                    {
                        if (vb == 99)
                            return 99;
                        else return 100;
                    }
                    else
                        return 100;
                default:
                    return 99;
            }
        }

    }
}
