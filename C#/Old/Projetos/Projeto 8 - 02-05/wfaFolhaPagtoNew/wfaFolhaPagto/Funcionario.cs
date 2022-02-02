using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFolhaPagto
{
    class Funcionario
    {
        public string nome;
        public double horasTrabalhadas;
        public double valorHora;
        public int numDependetes;

        public double calculaINSS(double salBruto)
        {
            if (salBruto <= 965.67)
                return (salBruto * 0.08);
            else if (salBruto <= 1609.45)
                return (salBruto * 0.09);
            else if (salBruto <= 3218.90)
                return (salBruto * 0.11);
            else return (354.08);
        }

        public double calculaIR(double baseIR)
        {
            if (baseIR <= 1434.59) return (0);
            else if (baseIR <= 2150) return (baseIR * 0.07 - 107.59);
            else if (baseIR <= 2866.70) return (baseIR * 0.15 - 268.84);
            else if (baseIR <= 3582) return (baseIR * 0.225 - 483.84);
            else return (baseIR * 0.275 - 662.94);


        }

    }
}
