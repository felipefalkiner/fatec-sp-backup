using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaMercadoria
{
    class Mercadoria
    {
        public string nome;
        public double preco;

        public void atualizaPreco(double percent)
        {
            preco = preco + (preco * percent / 100);
        }

    }
}
