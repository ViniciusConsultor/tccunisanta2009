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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadPerfil));
            this.lblDescPerfil = new System.Windows.Forms.Label();
            this.txtDescPerfil = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblDescPerfil
            // 
            this.lblDescPerfil.AutoSize = true;
            this.lblDescPerfil.Location = new System.Drawing.Point(82, 57);
            this.lblDescPerfil.Name = "lblDescPerfil";
            this.lblDescPerfil.Size = new System.Drawing.Size(81, 13);
            this.lblDescPerfil.TabIndex = 1;
            this.lblDescPerfil.Text = "Descricao Perfil";
            // 
            // txtDescPerfil
            // 
            this.txtDescPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescPerfil.Location = new System.Drawing.Point(85, 74);
            this.txtDescPerfil.MaxLength = 50;
            this.txtDescPerfil.Multiline = true;
            this.txtDescPerfil.Name = "txtDescPerfil";
            this.txtDescPerfil.Size = new System.Drawing.Size(217, 80);
            this.txtDescPerfil.TabIndex = 1;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirma.BackgroundImage")));
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(2, 4);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(27, 23);
            this.btnConfirma.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnConfirma, "Cadastrar");
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::TCC.Properties.Resources.trash_can;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(2, 30);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Novo");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(2, 57);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // frmCadPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 218);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtDescPerfil);
            this.Controls.Add(this.lblDescPerfil);
            this.MaximizeBox = false;
            this.Name = "frmCadPerfil";
            this.Text = "Cadastro de Perfil";
            this.Load += new System.EventHandler(this.frmCadPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescPerfil;
        private System.Windows.Forms.TextBox txtDescPerfil;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ToolTip toolTipLegenda;
    }
}