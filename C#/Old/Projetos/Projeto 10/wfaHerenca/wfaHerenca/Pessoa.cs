using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaHerenca
{
    class Pessoa   //classe Base
    {
        private string nome;

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return (nome);
        }
    }

    class PessoaJuridica : Pessoa
    {

        private string cnpj;

        public void setCNPJ(string cnpj)
        {
            this.cnpj = cnpj;
        }

        public string getCNPJ()
        {
            return (cnpj);
        }

    }

    class PessoaFisica : Pessoa
    {
        private string cpf;

        public void setCPF(string cpf)
        {
            this.cpf = cpf;
        }
        
        public string getCPF()
        {
            return (cpf);
   
        }

        public void validaCPF(string cpf)
        {
            double SA, SB, SC, SD, SE, SF, SG, SH, SI, SJ, SK, SL;

        }

    }



}
