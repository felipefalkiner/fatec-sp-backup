using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Investimentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRA_Click(object sender, EventArgs e)
        {
            double resultado, capital, jurosMensal;

            capital = double.Parse(txtCapital.Text);
            jurosMensal = double.Parse(txtJuros.Text);

            resultado = Investimento.rendimentoAnual(capital, jurosMensal);

            resultado = Math.Round(resultado, 2);

            MessageBox.Show("Valor ao final de 12 meses: " + resultado);


        }

        private void btnMI_Click(object sender, EventArgs e)
        {
            double resultado, capital, jurosMensal;

            capital = double.Parse(txtCapital.Text);
            jurosMensal = double.Parse(txtJuros.Text);

            resultado = Investimento.mesesInvestimento(capital, jurosMensal);

            resultado = Math.Round(resultado, 2);

            MessageBox.Show("Vão ser necessarios " + resultado + " meses");
        }
    }
}
