using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaMercadoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Mercadoria produto1 = new Mercadoria();
        Mercadoria produto2 = new Mercadoria();
        Mercadoria produto3 = new Mercadoria();

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


        private void btnAtribuir_Click(object sender, EventArgs e)
        {

            lblSaida.Text = "";

            try
            { 
            lblSaida.Text = ("Nome Inicial do Produto 1: " + produto1.nome + "\n" + "Preço Inicial do Produto 1: " + produto1.preco.ToString("R$ #,##0.00") + "\n\n");

            produto1.nome = txtN1.Text;
            produto1.preco = double.Parse(txtV1.Text);

            lblSaida.Text += ("Nome do Produto 1: " + produto1.nome + "\n" + "Preço do Produto 1: " + produto1.preco.ToString("R$ #,##0.00") + "\n\n");

            produto2.nome = txtN2.Text;
            produto2.preco = double.Parse(txtV2.Text);

            lblSaida.Text += ("Nome do Produto 2: " + produto2.nome + "\n" + "Preço do Produto 2: " + produto2.preco.ToString("R$ #,##0.00") + "\n\n");

            produto3.nome = txtN3.Text;
            produto3.preco = double.Parse(txtV3.Text);

            lblSaida.Text += ("Nome do Produto 3: " + produto3.nome + "\n" + "Preço do Produto 3: " + produto3.preco.ToString("R$ #,##0.00") + "\n\n");
            }
            catch (Exception caught)
            {
                MessageBox.Show("Nenhum campo pode estar em branco, favor confira se todos os produtos possuem Nome e Valor!", "A T E N Ç Ã O");
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnReajuste_Click(object sender, EventArgs e)
        {
            double reajuste;

            if (String.IsNullOrEmpty(txtReajuste.Text))
            {
                MessageBox.Show("Valor de Reajuste não pode ser nulo!");
            }
            else { 

            reajuste = double.Parse(txtReajuste.Text);

            produto1.atualizaPreco(reajuste);

            txtV1.Text = produto1.preco.ToString("#,##0.00") + "\n";

            produto2.atualizaPreco(reajuste);

            txtV2.Text = produto2.preco.ToString("#,##0.00") + "\n";

            produto3.atualizaPreco(reajuste);

            txtV3.Text = produto3.preco.ToString("#,##0.00") + "\n";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void txtV1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.KeyChar = testes.soUmaVirgula(txtV1.Text);

            e.KeyChar = testes.consistNum(e.KeyChar);
        }

        private void txtV2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.KeyChar = testes.soUmaVirgula(txtV2.Text);

            e.KeyChar = testes.consistNum(e.KeyChar);
        }

        private void txtV3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.KeyChar = testes.soUmaVirgula(txtV3.Text);

            e.KeyChar = testes.consistNum(e.KeyChar);
        }

        private void txtReajuste_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.KeyChar = testes.soUmaVirgula(txtReajuste.Text);

            e.KeyChar = testes.consistNum(e.KeyChar);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";

            txtV1.Text = "";
            txtV2.Text = "";
            txtV3.Text = "";

            lblSaida.Text = "";

            produto1.nome = "";
            produto2.nome = "";
            produto3.nome = "";

            produto1.preco = 0;
            produto2.preco = 0;
            produto3.preco = 0;



        }
    }
}
