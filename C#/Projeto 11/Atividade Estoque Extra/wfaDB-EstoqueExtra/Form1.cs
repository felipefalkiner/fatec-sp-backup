using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaDB_EstoqueExtra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void estoqueBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estoqueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.estoqueDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueDataSet1.Estoque' table. You can move, or remove it, as needed.
            this.estoqueTableAdapter.Fill(this.estoqueDataSet1.Estoque);

        }
    }
}
