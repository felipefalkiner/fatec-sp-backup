using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista1_Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, resultado;

            n = int.Parse(txtN.Text);

            resultado = Numero.par(n);

            if (resultado == 100)
                MessageBox.Show("O NÚMERO É PAR!!!");
            else MessageBox.Show("O NÚMERO NÃO É PAR!!!");


        }

        private void button2_Click(object sender, EventArgs e)
        {

            int n, resultado;

            n = int.Parse(txtN.Text);

            resultado = Numero.primo(n);

            if (resultado == 100)
                MessageBox.Show("O NÚMERO É PRIMO !!! ");
            else MessageBox.Show("O NÚMERO NÃO É PRIMO !!! ");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n, resultado;

            n = int.Parse(txtN.Text);

            resultado = Numero.fatorial(n);

            MessageBox.Show("O FATORIAL DE " + n + " é : " + resultado);
        }
    }
}
