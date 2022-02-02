using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            int dia, mes, ano, resultado;

            dia = int.Parse(txtDia.Text);
            mes = int.Parse(txtMes.Text);
            ano = int.Parse(txtAno.Text);


            resultado = DataClass.validaData(dia, mes, ano);

            if (resultado == 99)
                MessageBox.Show("A DATA NÃO É VALIDA");
            else MessageBox.Show("A DATA É VALIDA");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
