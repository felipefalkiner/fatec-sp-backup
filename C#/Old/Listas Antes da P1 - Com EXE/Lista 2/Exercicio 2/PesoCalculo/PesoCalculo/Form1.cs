using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoCalculo
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCalc_Click(object sender, EventArgs e)
        {
            double altura;
            double PesoIdeal;

            altura = double.Parse(txtPeso.Text);

            if (rbFem.Checked)
            {
                PesoIdeal = Peso.pesoFeminino(altura);
                lblPeso.Text = Convert.ToString(PesoIdeal);
                lblPeso.ForeColor = Color.Red;
            }
            else
            {
                PesoIdeal = Peso.pesoMasculino(altura);
                lblPeso.Text = Convert.ToString(PesoIdeal);
                lblPeso.ForeColor = Color.Blue;

            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.KeyChar = testes.soUmaVirgula(txtPeso.Text);

            e.KeyChar = testes.consistNum(e.KeyChar);
        }
    }
}
