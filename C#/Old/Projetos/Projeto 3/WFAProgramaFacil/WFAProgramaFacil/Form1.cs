using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFAProgramaFacil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int contador = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCliqueMe_Click(object sender, EventArgs e)
        {
            contador++;
            txtContaCliques.Text = contador.ToString();
        }

        private void txtContaCliques_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
