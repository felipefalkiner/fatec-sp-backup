using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaAreas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float area(float x)
        {
            return (x * x);
        }

        float area(float x, float y)
        {
            return (x * y);
        }

        float area(float x, float y, float z)
        {
            return (x * y * z);
        }

        public class testes
        {
            public static char consistNum(char c)
            {
                if ((c < '0' || c > '9') && c != ',' && c != (char)8 && c != (char)0)
                {
                    MessageBox.Show("Tecla Inválida");
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtX.Enabled = true;
            txtY.Enabled = false;
            txtZ.Enabled = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtX.Enabled = true;
            txtY.Enabled = true;
            txtZ.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtX.Enabled = true;
            txtY.Enabled = true;
            txtZ.Enabled = true;
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtX.Text = "";
            txtY.Text = "";
            txtZ.Text = "";

        }

        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.KeyChar = testes.soUmaVirgula(txtX.Text);

            e.KeyChar = testes.consistNum(e.KeyChar);
        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.KeyChar = testes.soUmaVirgula(txtY.Text);

            e.KeyChar = testes.consistNum(e.KeyChar);
        }

        private void txtZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.KeyChar = testes.soUmaVirgula(txtZ.Text);

            e.KeyChar = testes.consistNum(e.KeyChar);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            float x;
            float y;
            float z;

            if (rdbQuadrado.Checked)
            {
                x = float.Parse(txtX.Text);
                txtResultado.Text = area(x).ToString();
            }

            if (rdbRetangulo.Checked)
            {
                x = float.Parse(txtX.Text);
                y = float.Parse(txtY.Text);
                txtResultado.Text = area(x, y).ToString();
            }

            if (rdbParalelepipedo.Checked)
            {
                x = float.Parse(txtX.Text);
                y = float.Parse(txtY.Text);
                z = float.Parse(txtZ.Text);
                txtResultado.Text = area(x, y, z).ToString();
            }
        
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {

        }

    }
}