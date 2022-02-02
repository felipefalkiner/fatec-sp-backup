using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaCalculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        void valor2nulo()
        {
            string valorN1, valorN2;


            valorN1 = txtN1.Text;
            valorN2 = txtN2.Text;

            if (valorN1 == "")
                txtN1.Text = "0";

            if (valorN2 == "")
                txtN2.Text = "0";


        }

        void soma()
        {
            float valorN1, valorN2, resultado;

            valorN1 = 0;
            valorN2 = 0;

            try
            {
                valorN1 = float.Parse(txtN1.Text);
                valorN2 = float.Parse(txtN2.Text);
                resultado = valorN1 + valorN2;
                lblResult.Text = resultado.ToString();
            }
            catch (Exception caught)
            {
                lblResult.Text = "";
                lblResult.Text = caught.Message;
            }
            return;

        }

        void subtrai()
        {
            float valorN1, valorN2, resultado;

            valorN1 = 0;
            valorN2 = 0;

            try
            {
                valorN1 = float.Parse(txtN1.Text);
                valorN2 = float.Parse(txtN2.Text);
                resultado = valorN1 - valorN2;
                lblResult.Text = resultado.ToString();
            }
            catch (Exception caught)
            {
                lblResult.Text = "";
                lblResult.Text = caught.Message;
            }
            return;

        }

        void multiplica()
        {
            float valorN1, valorN2, resultado;

            valorN1 = 0;
            valorN2 = 0;

            try
            {
                valorN1 = float.Parse(txtN1.Text);
                valorN2 = float.Parse(txtN2.Text);
                resultado = valorN1 * valorN2;
                lblResult.Text = resultado.ToString();
            }
            catch (Exception caught)
            {
                lblResult.Text = "";
                lblResult.Text = caught.Message;
            }
            return;

        }

        void divide()
        {
            float valorN1, valorN2, resultado;

            valorN1 = 0;
            valorN2 = 0;

            valorN2 = float.Parse(txtN2.Text);

            if (valorN2 == 0)
            {
                MessageBox.Show("Divisão por Zero não é permitida");
                txtN2.Focus();
                txtN2.SelectAll();
            }
            else
            { 
                try
                {
                    valorN1 = float.Parse(txtN1.Text);
                    valorN2 = float.Parse(txtN2.Text);
                    resultado = valorN1 / valorN2;
                    lblResult.Text = resultado.ToString();
                }

                catch (Exception caught)
                    {
                       lblResult.Text = "";
                       lblResult.Text = caught.Message;
                    }
            }
            return;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor2nulo();
            soma();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtN1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                txtN2.Focus();
            }
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && e.KeyChar != (Char)13 && e.KeyChar != (Char)8 && e.KeyChar != (Char)42 && e.KeyChar != (Char)43 && e.KeyChar != (Char)45 && e.KeyChar != (Char)47 && e.KeyChar != (Char)0)
	        {MessageBox.Show("Tecla Inválida");
	        e.KeyChar = (Char)0;
	        }
          
          int i;
          if (e.KeyChar == ',') { 
            i = txtN1.Text.IndexOf(',');
            if (i >= 0)
                { 
                    MessageBox.Show("Vírgula já existe, não é possível adicionar outra!");
                    e.KeyChar = (Char)0;
                }
          }
        }

        private void txtN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            valor2nulo();
            multiplica();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            valor2nulo();
            subtrai();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            valor2nulo();
            divide();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            lblResult.Text = "";
            txtN1.Focus();
            lblResult.BackColor = Color.Yellow;
        }

        private void frmCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (Char)43:
                    valor2nulo();
                    soma();
                    e.KeyChar = (Char)0;
                    break;
                case (Char)42:
                    valor2nulo();
                    multiplica();
                    e.KeyChar = (Char)0;
                    break;
                case (Char)45:
                    valor2nulo();
                    subtrai();
                    e.KeyChar = (Char)0;
                    break;
                case (Char)47:
                    valor2nulo();
                    divide();
                    e.KeyChar = (Char)0;
                    break;
                default:
                    break;
            }
        }

        private void txtN2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                valor2nulo();
                soma();
            }
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && e.KeyChar != (Char)13 && e.KeyChar != (Char)8 && e.KeyChar != (Char)42 && e.KeyChar != (Char)43 && e.KeyChar != (Char)45 && e.KeyChar != (Char)47 && e.KeyChar != (Char)0)
            {
                MessageBox.Show("Tecla Inválida");
                e.KeyChar = (Char)0;
            }

            int i;
            if (e.KeyChar == ',')
            {
                i = txtN2.Text.IndexOf(',');
                if (i >= 0)
                {
                    MessageBox.Show("Vírgula já existe, não é possível adicionar outra!");
                    e.KeyChar = (Char)0;
                }
            }
        }

        private void lblResult_TextChanged(object sender, EventArgs e)
        {
            if (lblResult.Text == "")
                lblResult.BackColor = Color.Yellow;
            else
                if (float.Parse(lblResult.Text) < 0)
                    lblResult.BackColor = Color.Red;
            else
                    if (float.Parse(lblResult.Text) > 0)
                        lblResult.BackColor = Color.Yellow;
        }

   
        }
    }
