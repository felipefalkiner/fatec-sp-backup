using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WFCaraDePau
{
    class Cara
    {
        public Cara(String nome, double cash) {
            this.nome = nome;
            this.cash = cash;
        }

        private double cash;

        public double Cash
        {
            get { return cash; }
            set { cash = value; }
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public bool empresta(double cash)
        {
            if (Cash < cash)
                return false;
            Cash -= cash;
            return true;
        }

        public bool recebe(double cash)
        {
            if (cash < 0)
                return false;
            Cash += cash;
            return true;
        }
    }
}
