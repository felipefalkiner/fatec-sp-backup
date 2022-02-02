using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
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
        private void button1_Click(object sender, EventArgs e)
        {
            double dist, resultado;
            

            if (rbMilhas.Checked)
            {
                
                if (txtDist.Text == "")
                    txtDist.Text = "0";

                dist = float.Parse(txtDist.Text);

                

                resultado = Conversor.milhasKm(dist);

                lblFinal.ForeColor = Color.Red;
                lblFinal.Text = resultado + " Quilômetros";
            } else
            {
                dist = float.Parse(txtDist.Text);

                resultado = Conversor.kmMilhas(dist);

                lblFinal.ForeColor = Color.Blue;
                lblFinal.Text = resultado + " Milhas";

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.KeyChar = testes.soUmaVirgula(txtDist.Text);

            e.KeyChar = testes.consistNum(e.KeyChar);
        }
    }
}
