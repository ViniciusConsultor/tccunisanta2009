namespace TCC.UI
{
    partial class frmCadPerfilMenu
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblCodigoPerfil = new System.Windows.Forms.Label();
            this.lblCodigoMenu = new System.Windows.Forms.Label();
            this.txtCodigoPerfil = new System.Windows.Forms.TextBox();
            this.txtCodigoMenu = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnBuscaPerfil = new System.Windows.Forms.Button();
            this.btnBuscaMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 229);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCodigoPerfil
            // 
            this.lblCodigoPerfil.AutoSize = true;
            this.lblCodigoPerfil.Location = new System.Drawing.Point(12, 21);
            this.lblCodigoPerfil.Name = "lblCodigoPerfil";
            this.lblCodigoPerfil.Size = new System.Drawing.Size(30, 13);
            this.lblCodigoPerfil.TabIndex = 1;
            this.lblCodigoPerfil.Text = "Perfil";
            // 
            // lblCodigoMenu
            // 
            this.lblCodigoMenu.AutoSize = true;
            this.lblCodigoMenu.Location = new System.Drawing.Point(12, 58);
            this.lblCodigoMenu.Name = "lblCodigoMenu";
            this.lblCodigoMenu.Size = new System.Drawing.Size(34, 13);
            this.lblCodigoMenu.TabIndex = 2;
            this.lblCodigoMenu.Text = "Menu";
            // 
            // txtCodigoPerfil
            // 
            this.txtCodigoPerfil.Enabled = false;
            this.txtCodigoPerfil.Location = new System.Drawing.Point(53, 18);
            this.txtCodigoPerfil.Name = "txtCodigoPerfil";
            this.txtCodigoPerfil.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPerfil.TabIndex = 3;
            // 
            // txtCodigoMenu
            // 
            this.txtCodigoMenu.Enabled = false;
            this.txtCodigoMenu.Location = new System.Drawing.Point(53, 55);
            this.txtCodigoMenu.Name = "txtCodigoMenu";
            this.txtCodigoMenu.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoMenu.TabIndex = 4;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(93, 229);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(174, 229);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnBuscaPerfil
            // 
            this.btnBuscaPerfil.Location = new System.Drawing.Point(159, 16);
            this.btnBuscaPerfil.Name = "btnBuscaPerfil";
            this.btnBuscaPerfil.Size = new System.Drawing.Size(24, 23);
            this.btnBuscaPerfil.TabIndex = 7;
            this.btnBuscaPerfil.Text = "...";
            this.btnBuscaPerfil.UseVisualStyleBackColor = true;
            this.btnBuscaPerfil.Click += new System.EventHandler(this.btnBuscaPerfil_Click);
            // 
            // btnBuscaMenu
            // 
            this.btnBuscaMenu.Location = new System.Drawing.Point(159, 53);
            this.btnBuscaMenu.Name = "btnBuscaMenu";
            this.btnBuscaMenu.Size = new System.Drawing.Size(24, 23);
            this.btnBuscaMenu.TabIndex = 8;
            this.btnBuscaMenu.Text = "...";
            this.btnBuscaMenu.UseVisualStyleBackColor = true;
            this.btnBuscaMenu.Click += new System.EventHandler(this.btnBuscaMenu_Click);
            // 
            // frmCadPerfilMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.btnBuscaMenu);
            this.Controls.Add(this.btnBuscaPerfil);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtCodigoMenu);
            this.Controls.Add(this.txtCodigoPerfil);
            this.Controls.Add(this.lblCodigoMenu);
            this.Controls.Add(this.lblCodigoPerfil);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "frmCadPerfilMenu";
            this.Text = "frmCadPerfilMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblCodigoPerfil;
        private System.Windows.Forms.Label lblCodigoMenu;
        private System.Windows.Forms.TextBox txtCodigoPerfil;
        private System.Windows.Forms.TextBox txtCodigoMenu;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnBuscaPerfil;
        private System.Windows.Forms.Button btnBuscaMenu;
    }
}