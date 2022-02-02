namespace wfaAreas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbParalelepipedo = new System.Windows.Forms.RadioButton();
            this.rdbRetangulo = new System.Windows.Forms.RadioButton();
            this.rdbQuadrado = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbParalelepipedo);
            this.groupBox1.Controls.Add(this.rdbRetangulo);
            this.groupBox1.Controls.Add(this.rdbQuadrado);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figura Geometrica";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbParalelepipedo
            // 
            this.rdbParalelepipedo.AutoSize = true;
            this.rdbParalelepipedo.Location = new System.Drawing.Point(6, 65);
            this.rdbParalelepipedo.Name = "rdbParalelepipedo";
            this.rdbParalelepipedo.Size = new System.Drawing.Size(97, 17);
            this.rdbParalelepipedo.TabIndex = 2;
            this.rdbParalelepipedo.Text = "Paralelepípedo";
            this.rdbParalelepipedo.UseVisualStyleBackColor = true;
            this.rdbParalelepipedo.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdbRetangulo
            // 
            this.rdbRetangulo.AutoSize = true;
            this.rdbRetangulo.Location = new System.Drawing.Point(6, 42);
            this.rdbRetangulo.Name = "rdbRetangulo";
            this.rdbRetangulo.Size = new System.Drawing.Size(74, 17);
            this.rdbRetangulo.TabIndex = 1;
            this.rdbRetangulo.Text = "Retângulo";
            this.rdbRetangulo.UseVisualStyleBackColor = true;
            this.rdbRetangulo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbQuadrado
            // 
            this.rdbQuadrado.AutoSize = true;
            this.rdbQuadrado.Checked = true;
            this.rdbQuadrado.Location = new System.Drawing.Point(6, 19);
            this.rdbQuadrado.Name = "rdbQuadrado";
            this.rdbQuadrado.Size = new System.Drawing.Size(72, 17);
            this.rdbQuadrado.TabIndex = 0;
            this.rdbQuadrado.TabStop = true;
            this.rdbQuadrado.Text = "Quadrado";
            this.rdbQuadrado.UseVisualStyleBackColor = true;
            this.rdbQuadrado.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(263, 29);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(65, 20);
            this.txtX.TabIndex = 2;
            this.txtX.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // txtY
            // 
            this.txtY.Enabled = false;
            this.txtY.Location = new System.Drawing.Point(334, 29);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(65, 20);
            this.txtY.TabIndex = 4;
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // txtZ
            // 
            this.txtZ.Enabled = false;
            this.txtZ.Location = new System.Drawing.Point(405, 29);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(65, 20);
            this.txtZ.TabIndex = 6;
            this.txtZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZ_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Área/Volume:";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(385, 76);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(110, 20);
            this.txtResultado.TabIndex = 8;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(218, 54);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Cálculo";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(218, 83);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 23);
            this.btnLimpa.TabIndex = 10;
            this.btnLimpa.Text = "Limpa";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 119);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculo de Areas de Figuras Geometricas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbParalelepipedo;
        private System.Windows.Forms.RadioButton rdbRetangulo;
        private System.Windows.Forms.RadioButton rdbQuadrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimpa;
    }
}

