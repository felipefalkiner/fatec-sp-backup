namespace wfaCirculo
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
            this.lblRaio = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.btnAtribuir = new System.Windows.Forms.Button();
            this.btnDiametro = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnCircuferencia = new System.Windows.Forms.Button();
            this.lblSaida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaio.Location = new System.Drawing.Point(44, 25);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(57, 25);
            this.lblRaio.TabIndex = 0;
            this.lblRaio.Text = "Raio:";
            // 
            // txtRaio
            // 
            this.txtRaio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaio.Location = new System.Drawing.Point(107, 22);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(100, 30);
            this.txtRaio.TabIndex = 1;
            // 
            // btnAtribuir
            // 
            this.btnAtribuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtribuir.Location = new System.Drawing.Point(226, 22);
            this.btnAtribuir.Name = "btnAtribuir";
            this.btnAtribuir.Size = new System.Drawing.Size(114, 30);
            this.btnAtribuir.TabIndex = 2;
            this.btnAtribuir.Text = "Atribuir";
            this.btnAtribuir.UseVisualStyleBackColor = true;
            this.btnAtribuir.Click += new System.EventHandler(this.btnAtribuir_Click);
            // 
            // btnDiametro
            // 
            this.btnDiametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiametro.Location = new System.Drawing.Point(12, 79);
            this.btnDiametro.Name = "btnDiametro";
            this.btnDiametro.Size = new System.Drawing.Size(114, 30);
            this.btnDiametro.TabIndex = 3;
            this.btnDiametro.Text = "Diâmetro";
            this.btnDiametro.UseVisualStyleBackColor = true;
            this.btnDiametro.Click += new System.EventHandler(this.btnDiametro_Click);
            // 
            // btnArea
            // 
            this.btnArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.Location = new System.Drawing.Point(132, 79);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(114, 30);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Área";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnCircuferencia
            // 
            this.btnCircuferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCircuferencia.Location = new System.Drawing.Point(252, 79);
            this.btnCircuferencia.Name = "btnCircuferencia";
            this.btnCircuferencia.Size = new System.Drawing.Size(114, 30);
            this.btnCircuferencia.TabIndex = 5;
            this.btnCircuferencia.Text = "Circunferência";
            this.btnCircuferencia.UseVisualStyleBackColor = true;
            this.btnCircuferencia.Click += new System.EventHandler(this.btnCircuferencia_Click);
            // 
            // lblSaida
            // 
            this.lblSaida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaida.Location = new System.Drawing.Point(12, 140);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(354, 38);
            this.lblSaida.TabIndex = 6;
            this.lblSaida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 203);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.btnCircuferencia);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnDiametro);
            this.Controls.Add(this.btnAtribuir);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.lblRaio);
            this.Name = "Form1";
            this.Text = "Circulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.Button btnAtribuir;
        private System.Windows.Forms.Button btnDiametro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnCircuferencia;
        private System.Windows.Forms.Label lblSaida;
    }
}

