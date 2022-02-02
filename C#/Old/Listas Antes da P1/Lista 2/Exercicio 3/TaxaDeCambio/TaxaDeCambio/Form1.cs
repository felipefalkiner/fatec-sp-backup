using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxaDeCambio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class testes
        {
            public static char consistNum(char c)
            {
                if ((c < '0' || c > '9') && c != ',' && c != (char)8 && c != (char)0)
                {
                    c = (char)0;
                }
                return (c);
            }

            public static char soUmaVirgula(string texto)
            {
                int i;
                i = texto.IndexOf(',');
                if (i >= 0)
                {
                    MessageBox.Show("Vírgula já existe, não é possível adicionar outra!");
                    return ((char)0);
                }
                else
                    return (',');
            }
        }


        private void btnCalc_Click(object sender, EventArgs e)
        {
            double vlr, taxa, resultado;

            vlr = double.Parse(txtValor.Text);
            taxa = double.Parse(txtTaxa.Text);

            if (rbReal.Checked)
            {
                resultado = Conversor.realDolar(vlr, taxa);
                resultado = Math.Round(resultado, 2);
                lblFinal.Text = "$ " + resultado;
                lblFinal.ForeColor = Color.Blue;

            } else
            {
                resultado = Conversor.dolarReal(vlr, taxa);
                resultado = Math.Round(resultado, 2);
                lblFinal.Text = "R$ " + resultado;
                lblFinal.ForeColor = Color.Red;

            }

        }

        private void txtTaxa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.KeyChar = testes.soUmaVirgula(txtTaxa.Text);

            e.KeyChar = testes.consistNum(e.KeyChar);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.KeyChar = testes.soUmaVirgula(txtValor.Text);

            e.KeyChar = testes.consistNum(e.KeyChar);
        }
    }
}
