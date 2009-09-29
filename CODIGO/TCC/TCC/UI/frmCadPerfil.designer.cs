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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadPerfil));
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
            this.lblIdPerfil.Location = new System.Drawing.Point(76, 31);
            this.lblIdPerfil.Name = "lblIdPerfil";
            this.lblIdPerfil.Size = new System.Drawing.Size(66, 13);
            this.lblIdPerfil.TabIndex = 0;
            this.lblIdPerfil.Text = "Codigo Perfil";
            // 
            // lblDescPerfil
            // 
            this.lblDescPerfil.AutoSize = true;
            this.lblDescPerfil.Location = new System.Drawing.Point(61, 60);
            this.lblDescPerfil.Name = "lblDescPerfil";
            this.lblDescPerfil.Size = new System.Drawing.Size(81, 13);
            this.lblDescPerfil.TabIndex = 1;
            this.lblDescPerfil.Text = "Descricao Perfil";
            // 
            // txtIdPerfil
            // 
            this.txtIdPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdPerfil.Enabled = false;
            this.txtIdPerfil.Location = new System.Drawing.Point(148, 28);
            this.txtIdPerfil.Name = "txtIdPerfil";
            this.txtIdPerfil.Size = new System.Drawing.Size(100, 20);
            this.txtIdPerfil.TabIndex = 0;
            // 
            // txtDescPerfil
            // 
            this.txtDescPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescPerfil.Location = new System.Drawing.Point(148, 60);
            this.txtDescPerfil.MaxLength = 30;
            this.txtDescPerfil.Name = "txtDescPerfil";
            this.txtDescPerfil.Size = new System.Drawing.Size(100, 20);
            this.txtDescPerfil.TabIndex = 1;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(64, 180);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(75, 23);
            this.btnConfirma.TabIndex = 2;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(145, 180);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(226, 180);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // frmCadPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(327, 245);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtDescPerfil);
            this.Controls.Add(this.txtIdPerfil);
            this.Controls.Add(this.lblDescPerfil);
            this.Controls.Add(this.lblIdPerfil);
            this.Name = "frmCadPerfil";
            this.Text = "Cad Perfil";
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