namespace TCC.UI
{
    partial class frmCadPerfil
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
            this.lblIdPerfil = new System.Windows.Forms.Label();
            this.lblDescPerfil = new System.Windows.Forms.Label();
            this.txtIdPerfil = new System.Windows.Forms.TextBox();
            this.txtDescPerfil = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdPerfil
            // 
            this.lblIdPerfil.AutoSize = true;
            this.lblIdPerfil.Location = new System.Drawing.Point(13, 13);
            this.lblIdPerfil.Name = "lblIdPerfil";
            this.lblIdPerfil.Size = new System.Drawing.Size(66, 13);
            this.lblIdPerfil.TabIndex = 0;
            this.lblIdPerfil.Text = "Codigo Perfil";
            // 
            // lblDescPerfil
            // 
            this.lblDescPerfil.AutoSize = true;
            this.lblDescPerfil.Location = new System.Drawing.Point(12, 42);
            this.lblDescPerfil.Name = "lblDescPerfil";
            this.lblDescPerfil.Size = new System.Drawing.Size(81, 13);
            this.lblDescPerfil.TabIndex = 1;
            this.lblDescPerfil.Text = "Descricao Perfil";
            // 
            // txtIdPerfil
            // 
            this.txtIdPerfil.Enabled = false;
            this.txtIdPerfil.Location = new System.Drawing.Point(129, 13);
            this.txtIdPerfil.Name = "txtIdPerfil";
            this.txtIdPerfil.Size = new System.Drawing.Size(68, 20);
            this.txtIdPerfil.TabIndex = 2;
            // 
            // txtDescPerfil
            // 
            this.txtDescPerfil.Location = new System.Drawing.Point(129, 42);
            this.txtDescPerfil.Name = "txtDescPerfil";
            this.txtDescPerfil.Size = new System.Drawing.Size(143, 20);
            this.txtDescPerfil.TabIndex = 3;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(12, 137);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(75, 23);
            this.btnConfirma.TabIndex = 4;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(103, 137);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Apagar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(193, 137);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // frmCadPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtDescPerfil);
            this.Controls.Add(this.txtIdPerfil);
            this.Controls.Add(this.lblDescPerfil);
            this.Controls.Add(this.lblIdPerfil);
            this.Name = "frmCadPerfil";
            this.Text = "frmCadPerfil";
            this.Load += new System.EventHandler(this.frmCadPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdPerfil;
        private System.Windows.Forms.Label lblDescPerfil;
        private System.Windows.Forms.TextBox txtIdPerfil;
        private System.Windows.Forms.TextBox txtDescPerfil;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
    }
}