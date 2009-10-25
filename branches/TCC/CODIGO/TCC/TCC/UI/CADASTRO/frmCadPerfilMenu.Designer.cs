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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadPerfilMenu));
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
            this.btnCadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.BackgroundImage")));
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrar.Location = new System.Drawing.Point(3, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(27, 23);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCodigoPerfil
            // 
            this.lblCodigoPerfil.AutoSize = true;
            this.lblCodigoPerfil.Location = new System.Drawing.Point(95, 67);
            this.lblCodigoPerfil.Name = "lblCodigoPerfil";
            this.lblCodigoPerfil.Size = new System.Drawing.Size(30, 13);
            this.lblCodigoPerfil.TabIndex = 1;
            this.lblCodigoPerfil.Text = "Perfil";
            // 
            // lblCodigoMenu
            // 
            this.lblCodigoMenu.AutoSize = true;
            this.lblCodigoMenu.Location = new System.Drawing.Point(95, 103);
            this.lblCodigoMenu.Name = "lblCodigoMenu";
            this.lblCodigoMenu.Size = new System.Drawing.Size(34, 13);
            this.lblCodigoMenu.TabIndex = 2;
            this.lblCodigoMenu.Text = "Menu";
            // 
            // txtCodigoPerfil
            // 
            this.txtCodigoPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoPerfil.Enabled = false;
            this.txtCodigoPerfil.Location = new System.Drawing.Point(135, 65);
            this.txtCodigoPerfil.Name = "txtCodigoPerfil";
            this.txtCodigoPerfil.ReadOnly = true;
            this.txtCodigoPerfil.Size = new System.Drawing.Size(114, 20);
            this.txtCodigoPerfil.TabIndex = 0;
            // 
            // txtCodigoMenu
            // 
            this.txtCodigoMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoMenu.Enabled = false;
            this.txtCodigoMenu.Location = new System.Drawing.Point(135, 101);
            this.txtCodigoMenu.Name = "txtCodigoMenu";
            this.txtCodigoMenu.ReadOnly = true;
            this.txtCodigoMenu.Size = new System.Drawing.Size(114, 20);
            this.txtCodigoMenu.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::TCC.Properties.Resources.trash_can;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(3, 30);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(3, 58);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnBuscaPerfil
            // 
            this.btnBuscaPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaPerfil.BackgroundImage")));
            this.btnBuscaPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaPerfil.Location = new System.Drawing.Point(255, 62);
            this.btnBuscaPerfil.Name = "btnBuscaPerfil";
            this.btnBuscaPerfil.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaPerfil.TabIndex = 1;
            this.btnBuscaPerfil.UseVisualStyleBackColor = true;
            this.btnBuscaPerfil.Click += new System.EventHandler(this.btnBuscaPerfil_Click);
            // 
            // btnBuscaMenu
            // 
            this.btnBuscaMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaMenu.BackgroundImage")));
            this.btnBuscaMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaMenu.Location = new System.Drawing.Point(255, 101);
            this.btnBuscaMenu.Name = "btnBuscaMenu";
            this.btnBuscaMenu.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaMenu.TabIndex = 2;
            this.btnBuscaMenu.UseVisualStyleBackColor = true;
            this.btnBuscaMenu.Click += new System.EventHandler(this.btnBuscaMenu_Click);
            // 
            // frmCadPerfilMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(349, 210);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscaMenu);
            this.Controls.Add(this.btnBuscaPerfil);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtCodigoMenu);
            this.Controls.Add(this.txtCodigoPerfil);
            this.Controls.Add(this.lblCodigoMenu);
            this.Controls.Add(this.lblCodigoPerfil);
            this.Controls.Add(this.btnCadastrar);
            this.MaximizeBox = false;
            this.Name = "frmCadPerfilMenu";
            this.Text = "Cadastro PerfilMenu";
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