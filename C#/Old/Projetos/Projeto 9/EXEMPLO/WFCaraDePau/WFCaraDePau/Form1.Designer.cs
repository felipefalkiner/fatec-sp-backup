namespace WFCaraDePau
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbJhoe1 = new System.Windows.Forms.RadioButton();
            this.rdbBob1 = new System.Windows.Forms.RadioButton();
            this.rdbPedir = new System.Windows.Forms.RadioButton();
            this.rdbEmprestar = new System.Windows.Forms.RadioButton();
            this.rdbBob2 = new System.Windows.Forms.RadioButton();
            this.rdbJhoe2 = new System.Windows.Forms.RadioButton();
            this.rdbBanco = new System.Windows.Forms.RadioButton();
            this.gbxCara = new System.Windows.Forms.GroupBox();
            this.gbxAcao = new System.Windows.Forms.GroupBox();
            this.gbxDeQuem = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.btnVai = new System.Windows.Forms.Button();
            this.gbxCara.SuspendLayout();
            this.gbxAcao.SuspendLayout();
            this.gbxDeQuem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbJhoe1
            // 
            this.rdbJhoe1.AutoSize = true;
            this.rdbJhoe1.Location = new System.Drawing.Point(24, 23);
            this.rdbJhoe1.Name = "rdbJhoe1";
            this.rdbJhoe1.Size = new System.Drawing.Size(48, 17);
            this.rdbJhoe1.TabIndex = 0;
            this.rdbJhoe1.TabStop = true;
            this.rdbJhoe1.Text = "Jhoe";
            this.rdbJhoe1.UseVisualStyleBackColor = true;
            this.rdbJhoe1.CheckedChanged += new System.EventHandler(this.rdbJhoe1_CheckedChanged);
            // 
            // rdbBob1
            // 
            this.rdbBob1.AutoSize = true;
            this.rdbBob1.Location = new System.Drawing.Point(24, 60);
            this.rdbBob1.Name = "rdbBob1";
            this.rdbBob1.Size = new System.Drawing.Size(44, 17);
            this.rdbBob1.TabIndex = 1;
            this.rdbBob1.TabStop = true;
            this.rdbBob1.Text = "Bob";
            this.rdbBob1.UseVisualStyleBackColor = true;
            this.rdbBob1.CheckedChanged += new System.EventHandler(this.rdbBob1_CheckedChanged);
            // 
            // rdbPedir
            // 
            this.rdbPedir.AutoSize = true;
            this.rdbPedir.Location = new System.Drawing.Point(36, 60);
            this.rdbPedir.Name = "rdbPedir";
            this.rdbPedir.Size = new System.Drawing.Size(106, 17);
            this.rdbPedir.TabIndex = 2;
            this.rdbPedir.TabStop = true;
            this.rdbPedir.Text = "pedir emprestado";
            this.rdbPedir.UseVisualStyleBackColor = true;
            // 
            // rdbEmprestar
            // 
            this.rdbEmprestar.AutoSize = true;
            this.rdbEmprestar.Location = new System.Drawing.Point(36, 30);
            this.rdbEmprestar.Name = "rdbEmprestar";
            this.rdbEmprestar.Size = new System.Drawing.Size(72, 17);
            this.rdbEmprestar.TabIndex = 3;
            this.rdbEmprestar.TabStop = true;
            this.rdbEmprestar.Text = "Emprestar";
            this.rdbEmprestar.UseVisualStyleBackColor = true;
            // 
            // rdbBob2
            // 
            this.rdbBob2.AutoSize = true;
            this.rdbBob2.Location = new System.Drawing.Point(38, 30);
            this.rdbBob2.Name = "rdbBob2";
            this.rdbBob2.Size = new System.Drawing.Size(44, 17);
            this.rdbBob2.TabIndex = 4;
            this.rdbBob2.TabStop = true;
            this.rdbBob2.Text = "Bob";
            this.rdbBob2.UseVisualStyleBackColor = true;
            // 
            // rdbJhoe2
            // 
            this.rdbJhoe2.AutoSize = true;
            this.rdbJhoe2.Enabled = false;
            this.rdbJhoe2.Location = new System.Drawing.Point(38, 76);
            this.rdbJhoe2.Name = "rdbJhoe2";
            this.rdbJhoe2.Size = new System.Drawing.Size(48, 17);
            this.rdbJhoe2.TabIndex = 5;
            this.rdbJhoe2.TabStop = true;
            this.rdbJhoe2.Text = "Jhoe";
            this.rdbJhoe2.UseVisualStyleBackColor = true;
            // 
            // rdbBanco
            // 
            this.rdbBanco.AutoSize = true;
            this.rdbBanco.Location = new System.Drawing.Point(38, 122);
            this.rdbBanco.Name = "rdbBanco";
            this.rdbBanco.Size = new System.Drawing.Size(56, 17);
            this.rdbBanco.TabIndex = 6;
            this.rdbBanco.TabStop = true;
            this.rdbBanco.Text = "Banco";
            this.rdbBanco.UseVisualStyleBackColor = true;
            // 
            // gbxCara
            // 
            this.gbxCara.Controls.Add(this.rdbBob1);
            this.gbxCara.Controls.Add(this.rdbJhoe1);
            this.gbxCara.Location = new System.Drawing.Point(30, 36);
            this.gbxCara.Name = "gbxCara";
            this.gbxCara.Size = new System.Drawing.Size(134, 100);
            this.gbxCara.TabIndex = 7;
            this.gbxCara.TabStop = false;
            this.gbxCara.Text = "Cara";
            // 
            // gbxAcao
            // 
            this.gbxAcao.Controls.Add(this.rdbEmprestar);
            this.gbxAcao.Controls.Add(this.rdbPedir);
            this.gbxAcao.Location = new System.Drawing.Point(209, 36);
            this.gbxAcao.Name = "gbxAcao";
            this.gbxAcao.Size = new System.Drawing.Size(200, 105);
            this.gbxAcao.TabIndex = 8;
            this.gbxAcao.TabStop = false;
            this.gbxAcao.Text = "Ação";
            // 
            // gbxDeQuem
            // 
            this.gbxDeQuem.Controls.Add(this.rdbBanco);
            this.gbxDeQuem.Controls.Add(this.rdbBob2);
            this.gbxDeQuem.Controls.Add(this.rdbJhoe2);
            this.gbxDeQuem.Location = new System.Drawing.Point(449, 36);
            this.gbxDeQuem.Name = "gbxDeQuem";
            this.gbxDeQuem.Size = new System.Drawing.Size(156, 165);
            this.gbxDeQuem.TabIndex = 9;
            this.gbxDeQuem.TabStop = false;
            this.gbxDeQuem.Text = "de quem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Valor R$:";
            // 
            // nudValor
            // 
            this.nudValor.Location = new System.Drawing.Point(279, 180);
            this.nudValor.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(120, 20);
            this.nudValor.TabIndex = 11;
            // 
            // btnVai
            // 
            this.btnVai.Location = new System.Drawing.Point(209, 238);
            this.btnVai.Name = "btnVai";
            this.btnVai.Size = new System.Drawing.Size(200, 76);
            this.btnVai.TabIndex = 12;
            this.btnVai.Text = "Vai";
            this.btnVai.UseVisualStyleBackColor = true;
            this.btnVai.Click += new System.EventHandler(this.btnVai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 347);
            this.Controls.Add(this.btnVai);
            this.Controls.Add(this.nudValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxDeQuem);
            this.Controls.Add(this.gbxAcao);
            this.Controls.Add(this.gbxCara);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxCara.ResumeLayout(false);
            this.gbxCara.PerformLayout();
            this.gbxAcao.ResumeLayout(false);
            this.gbxAcao.PerformLayout();
            this.gbxDeQuem.ResumeLayout(false);
            this.gbxDeQuem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbJhoe1;
        private System.Windows.Forms.RadioButton rdbBob1;
        private System.Windows.Forms.RadioButton rdbPedir;
        private System.Windows.Forms.RadioButton rdbEmprestar;
        private System.Windows.Forms.RadioButton rdbBob2;
        private System.Windows.Forms.RadioButton rdbJhoe2;
        private System.Windows.Forms.RadioButton rdbBanco;
        private System.Windows.Forms.GroupBox gbxCara;
        private System.Windows.Forms.GroupBox gbxAcao;
        private System.Windows.Forms.GroupBox gbxDeQuem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.Button btnVai;
    }
}

