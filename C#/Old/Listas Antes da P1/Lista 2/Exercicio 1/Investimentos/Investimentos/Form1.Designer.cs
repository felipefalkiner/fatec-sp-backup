namespace Investimentos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.btnRA = new System.Windows.Forms.Button();
            this.btnMI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capital Investido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Juros Mensal:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCapital
            // 
            this.txtCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapital.Location = new System.Drawing.Point(183, 71);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(248, 27);
            this.txtCapital.TabIndex = 2;
            // 
            // txtJuros
            // 
            this.txtJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJuros.Location = new System.Drawing.Point(183, 104);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(248, 27);
            this.txtJuros.TabIndex = 3;
            // 
            // btnRA
            // 
            this.btnRA.Location = new System.Drawing.Point(148, 168);
            this.btnRA.Name = "btnRA";
            this.btnRA.Size = new System.Drawing.Size(164, 23);
            this.btnRA.TabIndex = 4;
            this.btnRA.Text = "Rendimento Anual";
            this.btnRA.UseVisualStyleBackColor = true;
            this.btnRA.Click += new System.EventHandler(this.btnRA_Click);
            // 
            // btnMI
            // 
            this.btnMI.Location = new System.Drawing.Point(148, 222);
            this.btnMI.Name = "btnMI";
            this.btnMI.Size = new System.Drawing.Size(164, 23);
            this.btnMI.TabIndex = 5;
            this.btnMI.Text = "Meses Investimento";
            this.btnMI.UseVisualStyleBackColor = true;
            this.btnMI.Click += new System.EventHandler(this.btnMI_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 286);
            this.Controls.Add(this.btnMI);
            this.Controls.Add(this.btnRA);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "INVESTIMENTOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Button btnRA;
        private System.Windows.Forms.Button btnMI;
    }
}

