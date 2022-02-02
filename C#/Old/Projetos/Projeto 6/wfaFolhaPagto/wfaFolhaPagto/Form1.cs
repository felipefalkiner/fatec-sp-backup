using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaFolhaPagto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        void Principal()
        {
            int nDep;
            double vh, sb, inss, salIr, ir, sl, ht;
            try
            {
                ht = float.Parse(txtHT.Text);
                vh = float.Parse(txtVH.Text);
                nDep = int.Parse(txtDep.Text);

                sb = ht * vh;
                inss = Taxas.calculaINSS(sb);

                salIr = sb - inss - (nDep * 144.20);
                ir = Taxas.calculaIR(salIr);

                sl = sb - inss - ir;

                txtSB.Text = sb.ToString("###,###,##0.00");
                txtINSS.Text = inss.ToString("###,###,##0.00");
                txtIR.Text = ir.ToString("###,###,##0.00");
                txtSL.Text = sl.ToString("###,###,##0.00");
                }
            catch (Exception caught)
            {
                MessageBox.Show("Erro: " + caught.Message);
            }

        }
        void CamposNulos()
                {
                    if (txtNome.Text == "")
                    {
                        MessageBox.Show("Nome não pode ser nulo!");
                        txtNome.Focus();
                    }
                    else if (txtHT.Text == "")
                    {
                        MessageBox.Show("Horas Trabalhadas não pode ser nulo!");
                        txtHT.Focus();
                    }
                    else if (txtVH.Text == "")
                    {
                        MessageBox.Show("Valor da Hora não pode ser nulo!");
                        txtVH.Focus();
                    }
                    else if (txtDep.Text == "")
                    {
                        MessageBox.Show("Num. Dependentes não pode ser nulo!");
                        txtDep.Focus();
                    }
                    else
                        Principal();



                }
        public class testes
        {
            public static char consistNum(char c)
            {
                if ((c < '0' || c > '9') && c != ',' && c != (char)8 && c != (char)0 && c != (char)13)
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

            public static char nenhumaVirgula()
            {
                    MessageBox.Show("Não é possível adicionar virgula neste campo!");
                    return ((char)0);           
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void gbUm_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtHT.Text = "";
            txtVH.Text = "";
            txtDep.Text = "";

            txtSB.Text = "";
            txtINSS.Text = "";
            txtIR.Text = "";
            txtSL.Text = "";
            txtNome.Focus();

        }

        private void btnFim_Click(object sender, EventArgs e)
        {
            DialogResult btnFimResult = MessageBox.Show("Deseja encerrar?",
                "Atenção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            //
            // Test the results of the previous three dialogs. [6]
            //
            if (btnFimResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CamposNulos();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                txtHT.Focus();
            }

            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space) && !(e.KeyChar == (char)Keys.Enter))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

          

           

           
        }

        private void txtHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                txtVH.Focus();
            }

            if (e.KeyChar == ',')
                e.KeyChar = testes.soUmaVirgula(txtHT.Text);

            e.KeyChar = testes.consistNum(e.KeyChar);
        }

        private void txtDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                btnCalcular.Focus();
                CamposNulos();
            }

            if (e.KeyChar == ',')
                e.KeyChar = testes.nenhumaVirgula();

            e.KeyChar = testes.consistNum(e.KeyChar);
        }

        private void txtVH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                txtDep.Focus();
            }

            if (e.KeyChar == ',')
                e.KeyChar = testes.soUmaVirgula(txtVH.Text);

            e.KeyChar = testes.consistNum(e.KeyChar);

        }
    }
}
