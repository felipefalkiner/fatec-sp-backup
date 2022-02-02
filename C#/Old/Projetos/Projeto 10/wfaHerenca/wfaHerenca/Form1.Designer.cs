namespace wfaHerenca
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
            this.rbPF = new System.Windows.Forms.RadioButton();
            this.rbPJ = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCpfForm = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mskcpf = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPJ);
            this.groupBox1.Controls.Add(this.rbPF);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbPF
            // 
            this.rbPF.AutoSize = true;
            this.rbPF.Checked = true;
            this.rbPF.Location = new System.Drawing.Point(7, 29);
            this.rbPF.Name = "rbPF";
            this.rbPF.Size = new System.Drawing.Size(90, 17);
            this.rbPF.TabIndex = 0;
            this.rbPF.TabStop = true;
            this.rbPF.Text = "Pessoa Fisica";
            this.rbPF.UseVisualStyleBackColor = true;
            this.rbPF.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // rbPJ
            // 
            this.rbPJ.AutoSize = true;
            this.rbPJ.Location = new System.Drawing.Point(7, 52);
            this.rbPJ.Name = "rbPJ";
            this.rbPJ.Size = new System.Drawing.Size(99, 17);
            this.rbPJ.TabIndex = 1;
            this.rbPJ.Text = "Pessoa Juridica";
            this.rbPJ.UseVisualStyleBackColor = true;
            this.rbPJ.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(184, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // lblCpfForm
            // 
            this.lblCpfForm.AutoSize = true;
            this.lblCpfForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCpfForm.Location = new System.Drawing.Point(184, 67);
            this.lblCpfForm.Name = "lblCpfForm";
            this.lblCpfForm.Size = new System.Drawing.Size(38, 18);
            this.lblCpfForm.TabIndex = 2;
            this.lblCpfForm.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNome.Location = new System.Drawing.Point(239, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(206, 24);
            this.txtNome.TabIndex = 1;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCadastro.Location = new System.Drawing.Point(39, 119);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(90, 36);
            this.btnCadastro.TabIndex = 3;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Enabled = false;
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnExibir.Location = new System.Drawing.Point(135, 119);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(90, 36);
            this.btnExibir.TabIndex = 4;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLimpa.Location = new System.Drawing.Point(231, 119);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(90, 36);
            this.btnLimpa.TabIndex = 5;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSair.Location = new System.Drawing.Point(327, 119);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 36);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(107, 181);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(263, 26);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "CLIENTE CADASTRADO";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(152, 216);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(175, 26);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome do Cliente";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(158, 253);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(163, 26);
            this.lblCPF.TabIndex = 11;
            this.lblCPF.Text = "111.111.111-11";
            // 
            // mskcpf
            // 
            this.mskcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskcpf.Location = new System.Drawing.Point(239, 64);
            this.mskcpf.Mask = "999,999,999-99";
            this.mskcpf.Name = "mskcpf";
            this.mskcpf.Size = new System.Drawing.Size(206, 24);
            this.mskcpf.TabIndex = 2;
            this.mskcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 326);
            this.Controls.Add(this.mskcpf);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCpfForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPJ;
        private System.Windows.Forms.RadioButton rbPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCpfForm;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mskcpf;
    }
}

