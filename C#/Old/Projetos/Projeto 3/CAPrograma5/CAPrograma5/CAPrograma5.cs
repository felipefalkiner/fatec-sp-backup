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
            int viagens, pessoas;

            Console.Write("Digite a Capacidade do Elevador em kg: ");
            s = Console.ReadLine();

            x = float.Parse(s);

            Console.WriteLine();

            Console.Write("Digite quantas pessoas vão precisam subir: ");
            s = Console.ReadLine();

            pessoas = int.Parse(s);

            Console.Write("Digite o peso dessas pessoas: ");
            s = Console.ReadLine();

            y = float.Parse(s);

            y = y * (float)pessoas;

            x = y / x;


            viagens = (int)x;

            if (x != viagens)
            {
                viagens = viagens + 1;
            }

            Console.WriteLine("\n\nSão necessarias: " + viagens + " viagens.");


            Console.ReadKey();



        }
    }
}
