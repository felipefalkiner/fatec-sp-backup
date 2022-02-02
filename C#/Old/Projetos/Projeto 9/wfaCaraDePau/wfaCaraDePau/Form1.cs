using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaCaraDePau
{
    public partial class Form1 : Form
    {

        Cara diou, bob, banco;

        public Form1()
        {
            InitializeComponent();
            diou = new Cara("Dioutro Mundo", 100);
            bob = new Cara("Bob Esponja", 100);
            banco = new Cara("The Bank", 10000);

        }

        private void rbDiouCara_Click(object sender, EventArgs e)
        {
            rbDiouQuem.Enabled = false;
            rbBobQuem.Enabled = true;
            if (rbDiouQuem.Checked)
                rbBobQuem.Checked = true;
        }

        private void rbBobCara_Click(object sender, EventArgs e)
        {
            rbDiouQuem.Enabled = true;
            rbBobQuem.Enabled = false;
            if (rbBobQuem.Checked)
                rbDiouQuem.Checked = true;
        }

        private void btnVai_Click(object sender, EventArgs e)
        {
            if (rbEmpresta.Checked)
            {
                if (rbDiouQuem.Checked)
                {
                    if (diou.pagar((double)nQuantia.Value) > 0)
                        bob.receber((double)nQuantia.Value);

                }
                if (rbBobQuem.Checked)
                {
                    if (bob.pagar((double)nQuantia.Value) > 0)
                        diou.receber((double)nQuantia.Value);

                }
                if (rbBancoQuem.Checked)
                {
                    if (rbDiouCara.Checked)
                        if (banco.pagar((double)nQuantia.Value) > 0)
                            diou.receber((double)nQuantia.Value);

                    if (rbBobCara.Checked)
                        if (banco.pagar((double)nQuantia.Value) > 0)
                            bob.receber((double)nQuantia.Value);

                }
            }

            double bobv, diouv, bancov;

            bobv = bob.Cash;
            diouv = diou.Cash;
            bancov = banco.Cash;

            if (rbPaga.Checked)
            {
                if (rbDiouQuem.Checked)
                {
                    if ((double)nQuantia.Value > bob.Cash)
                        MessageBox.Show("Não tenho essa grana para pagar. - Disse Bob");
                    else
                    {
                        diou.receber((double)nQuantia.Value);
                        bob.pagar((double)nQuantia.Value);
                    }


                }
                if (rbBobQuem.Checked)
                {
                    if ((double)nQuantia.Value > diou.Cash)
                        MessageBox.Show("Não tenho essa grana para pagar. - Disse Diou");
                    else
                    {
                        bob.receber((double)nQuantia.Value);
                        diou.pagar((double)nQuantia.Value);
                    }

                }
                if (rbBancoQuem.Checked)
                {
                    if (rbDiouCara.Checked)
                    {
                        if ((double)nQuantia.Value > diou.Cash)
                            MessageBox.Show("Não tenho essa grana para pagar. - Disse Diou");
                        else
                        {
                            banco.receber((double)nQuantia.Value);
                            diou.pagar((double)nQuantia.Value);
                        }

                    }

                    if (rbBobCara.Checked)
                        if ((double)nQuantia.Value > bob.Cash)
                            MessageBox.Show("Não tenho essa grana para pagar. - Disse Bob");
                        else
                        {
                            banco.receber((double)nQuantia.Value);
                            bob.pagar((double)nQuantia.Value);
                        }

                }

            }

        }

    }
}
