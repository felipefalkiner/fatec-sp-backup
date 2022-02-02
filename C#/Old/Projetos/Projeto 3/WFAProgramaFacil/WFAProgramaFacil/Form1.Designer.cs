namespace WFAProgramaFacil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNumCliques = new System.Windows.Forms.Label();
            this.txtContaCliques = new System.Windows.Forms.TextBox();
            this.btnCliqueMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumCliques
            // 
            this.lblNumCliques.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCliques.Location = new System.Drawing.Point(0, 39);
            this.lblNumCliques.Name = "lblNumCliques";
            this.lblNumCliques.Size = new System.Drawing.Size(232, 23);
            this.lblNumCliques.TabIndex = 0;
            this.lblNumCliques.Text = "Número de Cliques";
            this.lblNumCliques.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumCliques.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtContaCliques
            // 
            this.txtContaCliques.Enabled = false;
            this.txtContaCliques.Location = new System.Drawing.Point(65, 72);
            this.txtContaCliques.Name = "txtContaCliques";
            this.txtContaCliques.Size = new System.Drawing.Size(100, 20);
            this.txtContaCliques.TabIndex = 1;
            this.txtContaCliques.TextChanged += new System.EventHandler(this.txtContaCliques_TextChanged);
            // 
            // btnCliqueMe
            // 
            this.btnCliqueMe.BackColor = System.Drawing.Color.Lime;
            this.btnCliqueMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliqueMe.ForeColor = System.Drawing.Color.Black;
            this.btnCliqueMe.Location = new System.Drawing.Point(12, 112);
            this.btnCliqueMe.Name = "btnCliqueMe";
            this.btnCliqueMe.Size = new System.Drawing.Size(208, 23);
            this.btnCliqueMe.TabIndex = 2;
            this.btnCliqueMe.Text = "Clique-me";
            this.btnCliqueMe.UseVisualStyleBackColor = false;
            this.btnCliqueMe.Click += new System.EventHandler(this.btnCliqueMe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 159);
            this.Controls.Add(this.btnCliqueMe);
            this.Controls.Add(this.txtContaCliques);
            this.Controls.Add(this.lblNumCliques);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Programa Fácil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumCliques;
        private System.Windows.Forms.TextBox txtContaCliques;
        private System.Windows.Forms.Button btnCliqueMe;
    }
}

