namespace wfaCaraDePau
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
            this.gbCara = new System.Windows.Forms.GroupBox();
            this.rbDiouCara = new System.Windows.Forms.RadioButton();
            this.rbBobCara = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPaga = new System.Windows.Forms.RadioButton();
            this.rbEmpresta = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBobQuem = new System.Windows.Forms.RadioButton();
            this.rbDiouQuem = new System.Windows.Forms.RadioButton();
            this.rbBancoQuem = new System.Windows.Forms.RadioButton();
            this.nQuantia = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVai = new System.Windows.Forms.Button();
            this.gbCara.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nQuantia)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCara
            // 
            this.gbCara.Controls.Add(this.rbBobCara);
            this.gbCara.Controls.Add(this.rbDiouCara);
            this.gbCara.Location = new System.Drawing.Point(12, 12);
            this.gbCara.Name = "gbCara";
            this.gbCara.Size = new System.Drawing.Size(126, 100);
            this.gbCara.TabIndex = 0;
            this.gbCara.TabStop = false;
            this.gbCara.Text = "Cara";
            // 
            // rbDiouCara
            // 
            this.rbDiouCara.AutoSize = true;
            this.rbDiouCara.Checked = true;
            this.rbDiouCara.Location = new System.Drawing.Point(6, 30);
            this.rbDiouCara.Name = "rbDiouCara";
            this.rbDiouCara.Size = new System.Drawing.Size(47, 17);
            this.rbDiouCara.TabIndex = 0;
            this.rbDiouCara.TabStop = true;
            this.rbDiouCara.Text = "Diou";
            this.rbDiouCara.UseVisualStyleBackColor = true;
            this.rbDiouCara.Click += new System.EventHandler(this.rbDiouCara_Click);
            // 
            // rbBobCara
            // 
            this.rbBobCara.AutoSize = true;
            this.rbBobCara.Location = new System.Drawing.Point(6, 53);
            this.rbBobCara.Name = "rbBobCara";
            this.rbBobCara.Size = new System.Drawing.Size(44, 17);
            this.rbBobCara.TabIndex = 1;
            this.rbBobCara.Text = "Bob";
            this.rbBobCara.UseVisualStyleBackColor = true;
            this.rbBobCara.Click += new System.EventHandler(this.rbBobCara_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPaga);
            this.groupBox1.Controls.Add(this.rbEmpresta);
            this.groupBox1.Location = new System.Drawing.Point(167, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ação";
            // 
            // rbPaga
            // 
            this.rbPaga.AutoSize = true;
            this.rbPaga.Location = new System.Drawing.Point(6, 53);
            this.rbPaga.Name = "rbPaga";
            this.rbPaga.Size = new System.Drawing.Size(50, 17);
            this.rbPaga.TabIndex = 1;
            this.rbPaga.Text = "Paga";
            this.rbPaga.UseVisualStyleBackColor = true;
            // 
            // rbEmpresta
            // 
            this.rbEmpresta.AutoSize = true;
            this.rbEmpresta.Checked = true;
            this.rbEmpresta.Location = new System.Drawing.Point(6, 30);
            this.rbEmpresta.Name = "rbEmpresta";
            this.rbEmpresta.Size = new System.Drawing.Size(109, 17);
            this.rbEmpresta.TabIndex = 0;
            this.rbEmpresta.TabStop = true;
            this.rbEmpresta.Text = "Pega Emprestado";
            this.rbEmpresta.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBancoQuem);
            this.groupBox2.Controls.Add(this.rbBobQuem);
            this.groupBox2.Controls.Add(this.rbDiouQuem);
            this.groupBox2.Location = new System.Drawing.Point(321, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "A quem?";
            // 
            // rbBobQuem
            // 
            this.rbBobQuem.AutoSize = true;
            this.rbBobQuem.Checked = true;
            this.rbBobQuem.Location = new System.Drawing.Point(6, 44);
            this.rbBobQuem.Name = "rbBobQuem";
            this.rbBobQuem.Size = new System.Drawing.Size(44, 17);
            this.rbBobQuem.TabIndex = 1;
            this.rbBobQuem.TabStop = true;
            this.rbBobQuem.Text = "Bob";
            this.rbBobQuem.UseVisualStyleBackColor = true;
            // 
            // rbDiouQuem
            // 
            this.rbDiouQuem.AutoSize = true;
            this.rbDiouQuem.Enabled = false;
            this.rbDiouQuem.Location = new System.Drawing.Point(6, 21);
            this.rbDiouQuem.Name = "rbDiouQuem";
            this.rbDiouQuem.Size = new System.Drawing.Size(47, 17);
            this.rbDiouQuem.TabIndex = 0;
            this.rbDiouQuem.Text = "Diou";
            this.rbDiouQuem.UseVisualStyleBackColor = true;
            // 
            // rbBancoQuem
            // 
            this.rbBancoQuem.AutoSize = true;
            this.rbBancoQuem.Location = new System.Drawing.Point(6, 67);
            this.rbBancoQuem.Name = "rbBancoQuem";
            this.rbBancoQuem.Size = new System.Drawing.Size(56, 17);
            this.rbBancoQuem.TabIndex = 2;
            this.rbBancoQuem.Text = "Banco";
            this.rbBancoQuem.UseVisualStyleBackColor = true;
            // 
            // nQuantia
            // 
            this.nQuantia.Location = new System.Drawing.Point(173, 137);
            this.nQuantia.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nQuantia.Name = "nQuantia";
            this.nQuantia.Size = new System.Drawing.Size(156, 20);
            this.nQuantia.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quantia (R$)";
            // 
            // btnVai
            // 
            this.btnVai.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVai.Location = new System.Drawing.Point(158, 170);
            this.btnVai.Name = "btnVai";
            this.btnVai.Size = new System.Drawing.Size(149, 57);
            this.btnVai.TabIndex = 6;
            this.btnVai.Text = "VAI";
            this.btnVai.UseVisualStyleBackColor = true;
            this.btnVai.Click += new System.EventHandler(this.btnVai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 235);
            this.Controls.Add(this.btnVai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nQuantia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCara);
            this.Name = "Form1";
            this.Text = "Caras de Pau";
            this.gbCara.ResumeLayout(false);
            this.gbCara.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nQuantia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCara;
        private System.Windows.Forms.RadioButton rbBobCara;
        private System.Windows.Forms.RadioButton rbDiouCara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPaga;
        private System.Windows.Forms.RadioButton rbEmpresta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbBancoQuem;
        private System.Windows.Forms.RadioButton rbBobQuem;
        private System.Windows.Forms.RadioButton rbDiouQuem;
        private System.Windows.Forms.NumericUpDown nQuantia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVai;
    }
}

