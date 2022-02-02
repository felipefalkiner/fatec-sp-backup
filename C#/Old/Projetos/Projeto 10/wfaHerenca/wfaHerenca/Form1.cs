using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaHerenca
{
    public partial class Form1 : Form
    {
        PessoaFisica clientepf = new PessoaFisica();
        PessoaJuridica clientepj = new PessoaJuridica();


        public Form1()
        {
            InitializeComponent();
            lblNome.Text = "";
            lblCPF.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            lblCpfForm.Text = "CNPJ";
            mskcpf.Mask = "99,999,999/9999-99";
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            lblCpfForm.Text = "CPF";
            mskcpf.Mask = "999,999,999-99";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome deve ser preenchido!!!");
            }
            else if (rbPF.Checked)
            {
                clientepf.setNome(txtNome.Text);
                clientepf.setCPF(mskcpf.Text);
                btnExibir.Enabled = true;

            }
            else
            {
                clientepj.setNome(txtNome.Text);
                clientepj.setCNPJ(mskcpf.Text);
                btnExibir.Enabled = true;
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (rbPF.Checked)
            {
                lblNome.Text = clientepf.getNome();
                lblCPF.Text = clientepf.getCPF();

            }
            else
            {
                lblNome.Text = clientepj.getNome();
                lblCPF.Text = clientepj.getCNPJ();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            clientepf.setNome("");
            clientepf.setCPF("");
            clientepj.setNome("");
            clientepj.setCNPJ("");
            btnExibir.Enabled = false;
            txtNome.Text = "";
            mskcpf.Text = "";
            txtNome.Focus();
            lblCPF.Text = "";
            lblNome.Text = "";
        }
    }
}