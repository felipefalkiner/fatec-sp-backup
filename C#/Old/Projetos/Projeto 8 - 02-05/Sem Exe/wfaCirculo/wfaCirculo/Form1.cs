using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaCirculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Circulo circulo1 = new Circulo();

        private void btnAtribuir_Click(object sender, EventArgs e)
        {
            double raio;
            try { 
            raio = double.Parse(txtRaio.Text);

            circulo1.raio = raio;
            }
            catch (Exception)
            {
                MessageBox.Show("Valor de Raio não pode ser Nulo!");
            }
        }


        private void btnDiametro_Click(object sender, EventArgs e)
        {
            lblSaida.Text = circulo1.calculaDiametro(circulo1.raio).ToString();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            lblSaida.Text = circulo1.calculaArea(circulo1.raio).ToString();
        }

        private void btnCircuferencia_Click(object sender, EventArgs e)
        {
            lblSaida.Text = circulo1.calculaCircuferencia(circulo1.raio).ToString();
        }
    }
}
