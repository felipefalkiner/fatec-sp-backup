namespace wfaFolhaPagto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.txtVH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFim = new System.Windows.Forms.Button();
            this.gbUm = new System.Windows.Forms.GroupBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.lblSL = new System.Windows.Forms.Label();
            this.txtIR = new System.Windows.Forms.TextBox();
            this.lblIR = new System.Windows.Forms.Label();
            this.txtINSS = new System.Windows.Forms.TextBox();
            this.lblINSS = new System.Windows.Forms.Label();
            this.txtSB = new System.Windows.Forms.TextBox();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.btnAtribuir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbUm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::wfaFolhaPagto.Properties.Resources.payment_clipart_k4449063;
            this.pictureBox1.Location = new System.Drawing.Point(467, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 179);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(11, 61);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(160, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do Funcionário";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(177, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(285, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(177, 86);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(110, 20);
            this.txtHT.TabIndex = 4;
            this.txtHT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHT_KeyPress);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(11, 87);
            this.lblHoras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(144, 20);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Horas Trabalhadas";
            // 
            // txtVH
            // 
            this.txtVH.Location = new System.Drawing.Point(177, 112);
            this.txtVH.Name = "txtVH";
            this.txtVH.Size = new System.Drawing.Size(110, 20);
            this.txtVH.TabIndex = 6;
            this.txtVH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVH_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor da Hora";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtDep
            // 
            this.txtDep.Location = new System.Drawing.Point(177, 138);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(110, 20);
            this.txtDep.TabIndex = 8;
            this.txtDep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDep_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Num. Dependentes";
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(56, 187);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(123, 53);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(185, 187);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(123, 53);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFim
            // 
            this.btnFim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFim.Location = new System.Drawing.Point(314, 187);
            this.btnFim.Name = "btnFim";
            this.btnFim.Size = new System.Drawing.Size(123, 53);
            this.btnFim.TabIndex = 11;
            this.btnFim.Text = "Fim";
            this.btnFim.UseVisualStyleBackColor = true;
            this.btnFim.Click += new System.EventHandler(this.btnFim_Click);
            // 
            // gbUm
            // 
            this.gbUm.Controls.Add(this.txtSL);
            this.gbUm.Controls.Add(this.lblSL);
            this.gbUm.Controls.Add(this.txtIR);
            this.gbUm.Controls.Add(this.lblIR);
            this.gbUm.Controls.Add(this.txtINSS);
            this.gbUm.Controls.Add(this.lblINSS);
            this.gbUm.Controls.Add(this.txtSB);
            this.gbUm.Controls.Add(this.lblSalarioBruto);
            this.gbUm.Location = new System.Drawing.Point(15, 262);
            this.gbUm.Name = "gbUm";
            this.gbUm.Size = new System.Drawing.Size(707, 174);
            this.gbUm.TabIndex = 12;
            this.gbUm.TabStop = false;
            this.gbUm.Enter += new System.EventHandler(this.gbUm_Enter);
            // 
            // txtSL
            // 
            this.txtSL.Enabled = false;
            this.txtSL.Location = new System.Drawing.Point(354, 114);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(148, 20);
            this.txtSL.TabIndex = 18;
            this.txtSL.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL.Location = new System.Drawing.Point(208, 114);
            this.lblSL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(113, 20);
            this.lblSL.TabIndex = 19;
            this.lblSL.Text = "Salário Líquido";
            // 
            // txtIR
            // 
            this.txtIR.Enabled = false;
            this.txtIR.Location = new System.Drawing.Point(354, 88);
            this.txtIR.Name = "txtIR";
            this.txtIR.Size = new System.Drawing.Size(148, 20);
            this.txtIR.TabIndex = 16;
            this.txtIR.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // lblIR
            // 
            this.lblIR.AutoSize = true;
            this.lblIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIR.Location = new System.Drawing.Point(208, 88);
            this.lblIR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIR.Name = "lblIR";
            this.lblIR.Size = new System.Drawing.Size(141, 20);
            this.lblIR.TabIndex = 17;
            this.lblIR.Text = "Impsoto de Renda";
            // 
            // txtINSS
            // 
            this.txtINSS.Enabled = false;
            this.txtINSS.Location = new System.Drawing.Point(354, 62);
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.Size = new System.Drawing.Size(148, 20);
            this.txtINSS.TabIndex = 14;
            this.txtINSS.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINSS.Location = new System.Drawing.Point(208, 62);
            this.lblINSS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(47, 20);
            this.lblINSS.TabIndex = 15;
            this.lblINSS.Text = "INSS";
            // 
            // txtSB
            // 
            this.txtSB.Enabled = false;
            this.txtSB.Location = new System.Drawing.Point(354, 36);
            this.txtSB.Name = "txtSB";
            this.txtSB.Size = new System.Drawing.Size(148, 20);
            this.txtSB.TabIndex = 13;
            this.txtSB.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.Location = new System.Drawing.Point(208, 36);
            this.lblSalarioBruto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(101, 20);
            this.lblSalarioBruto.TabIndex = 13;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // btnAtribuir
            // 
            this.btnAtribuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtribuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtribuir.Location = new System.Drawing.Point(314, 97);
            this.btnAtribuir.Name = "btnAtribuir";
            this.btnAtribuir.Size = new System.Drawing.Size(123, 53);
            this.btnAtribuir.TabIndex = 13;
            this.btnAtribuir.Text = "Atribuir";
            this.btnAtribuir.UseVisualStyleBackColor = true;
            this.btnAtribuir.Click += new System.EventHandler(this.btnAtribuir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.btnAtribuir);
            this.Controls.Add(this.gbUm);
            this.Controls.Add(this.btnFim);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHT);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbUm.ResumeLayout(false);
            this.gbUm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox txtVH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFim;
        private System.Windows.Forms.GroupBox gbUm;
        private System.Windows.Forms.TextBox txtSB;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.TextBox txtIR;
        private System.Windows.Forms.Label lblIR;
        private System.Windows.Forms.TextBox txtINSS;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Button btnAtribuir;
    }
}

