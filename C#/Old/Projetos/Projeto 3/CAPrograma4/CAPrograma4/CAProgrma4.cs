using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAPrograma4
{
    class CAProgrma4
    {
        static void Main(string[] args)
        {

            string s;
            float x, y;
            int viagens;

            Console.Write("Digite a Capacidade do Elevador em kg: ");
            s = Console.ReadLine();

            x = float.Parse(s);

            Console.WriteLine();

            Console.Write("Digite o peso da carga de Areia em kg: ");
            s = Console.ReadLine();

            y = float.Parse(s);

            x = y / x;

            
            viagens = (int)x;

            if (x != viagens)
            {
                viagens = viagens + 1;
            }

            

            if (viagens == 1 )
            {
                s = "viagem";
            } else
            {
                s = "viagens";
            }
            Console.WriteLine("\n\nSerão necessarias: " + viagens + " " + s + ".");


            Console.ReadKey();



        }
    }
}
