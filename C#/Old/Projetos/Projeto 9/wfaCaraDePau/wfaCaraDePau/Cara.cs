using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaCaraDePau
{
    class Cara
    {

        private String nome;
        private double cash;
        public Cara(String nome, double cash)
        {
            Nome = nome;
            Cash = cash;
        }
             
        public String Nome
        {
            get { return nome; }
            set
            {
                if (value == null)
                    nome = "Sem nome";
                else nome = value;
            }
        }

       
        public double Cash
        {
            get { return cash; }
            set
            {
                if (value < 0)
                    cash = 0;
                else cash = value;
            }
        }

        public double pagar(double vlr)
        {
            if (vlr > 0 && vlr <= cash)
            {
                cash = cash - vlr;
                MessageBox.Show("Paguei R$ "+vlr+". - " + nome + " disse...");
                return vlr;
            }
            else
            {
                MessageBox.Show("Não tenho grana suficiente. - " + nome + " disse...");
                return 0;
            }


        }

        public double receber(double vlr)
        {
                cash = cash + vlr;
                MessageBox.Show("Recebi R$ " + vlr + ". - " + nome + " disse...");
                return vlr;

        }


    }
}
