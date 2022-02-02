using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFCaraDePau
{
    public partial class Form1 : Form
    {
        private Cara bob;
        private Cara jhoe;
        private Cara banco;
        List<Cara> caras = new List<Cara>();

        public Form1()
        {
            InitializeComponent();
            bob = new Cara("Bob", 100);
            jhoe = new Cara("Jhoe", 100);
            banco = new Cara("Banco", 10000);
            caras.Add(bob);
            caras.Add(jhoe);
            caras.Add(banco);

            rdbJhoe1.Checked = true;
            rdbBob2.Checked = true;
            rdbEmprestar.Checked = true;
        }

        private void rdbJhoe1_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                rdbJhoe2.Enabled = false;
                rdbBob2.Enabled = true;
                rdbBob2.Checked = true;
            }
        }

        private void rdbBob1_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                rdbJhoe2.Enabled = true;
                rdbBob2.Enabled = false;
                rdbJhoe2.Checked = true;
            }
        }

        private void btnVai_Click(object sender, EventArgs e)
        {
            if(nudValor.Value <= 0)
            {
                MessageBox.Show("valor invalido!");
                nudValor.Value = 0;
                return;
            }

            Cara remente = caras.First(n => n.Nome == (gbxCara.Controls.OfType<RadioButton>().First(m => m.Checked).Text));
            Cara destinatario = caras.First(n => n.Nome == (gbxDeQuem.Controls.OfType<RadioButton>().First(m => m.Checked).Text));

            if (rdbEmprestar.Checked)
            {
                if (remente.empresta((double)nudValor.Value))
                {
                    destinatario.recebe((double)nudValor.Value);
                    MessageBox.Show(destinatario.Nome  + " recebeu: " + nudValor.Value.ToString("##,##0.00") + " e tem saldo de: " + destinatario.Cash.ToString("##,##0.00"));
                }
                else
                    MessageBox.Show(remente.Nome + " não possui fundos o suficiente");
                return;
            }
            else
            {
                if (destinatario.empresta((double)nudValor.Value))
                {
                    remente.recebe((double)nudValor.Value);
                    MessageBox.Show(remente.Nome + " recebeu: " + nudValor.Value.ToString("##,##0.00") + " e tem saldo de: " + remente.Cash.ToString("##,##0.00"));
                }
                else
                    MessageBox.Show(destinatario.Nome + " não possui fundos o suficiente");
                return;
            }
        }        
    }
}
