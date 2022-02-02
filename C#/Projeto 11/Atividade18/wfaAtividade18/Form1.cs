using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaAtividade18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BindingManagerBase bmbAcervo;

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                this.bmbAcervo = this.BindingContext[dtsAcervo, "AcervoLivros"];
                this.txtCod.DataBindings.Add("Text", this.dtsAcervo, "AcervoLivros.Código");
                this.txtTitulo.DataBindings.Add("Text", this.dtsAcervo, "AcervoLivros.Titulo");
                this.txtAutor.DataBindings.Add("Text", this.dtsAcervo, "AcervoLivros.Autor");
                this.txtISBN.DataBindings.Add("Text", this.dtsAcervo, "AcervoLivros.ISBN");
                this.txtQuantidade.DataBindings.Add("Text", this.dtsAcervo, "AcervoLivros.Quantidade");
                this.dtaAcervo.Fill(dtsAcervo, "AcervoLivros");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            finally
            {
                if (cnnAcervo.State == ConnectionState.Open)
                    this.cnnAcervo.Close();
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            bmbAcervo.Position--;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            bmbAcervo.Position++;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bmbAcervo.AddNew();
            txtQuantidade.Value = 0;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            bmbAcervo.RemoveAt(bmbAcervo.Position);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bmbAcervo.EndCurrentEdit();
            dtaAcervo.Update(dtsAcervo);
            dtsAcervo.AcceptChanges();
        }
    }
}
