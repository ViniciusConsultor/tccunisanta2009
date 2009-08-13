namespace TelasDesenvolvedor.UI
{
    partial class frmCadMenu
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
            this.lblIdMenu = new System.Windows.Forms.Label();
            this.txtIdMenu = new System.Windows.Forms.TextBox();
            this.txtDescricaoMenu = new System.Windows.Forms.TextBox();
            this.lblDescricaoMenu = new System.Windows.Forms.Label();
            this.txtEnderecoMenu = new System.Windows.Forms.TextBox();
            this.lblEnderecoMenu = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdMenu
            // 
            this.lblIdMenu.AutoSize = true;
            this.lblIdMenu.Location = new System.Drawing.Point(13, 13);
            this.lblIdMenu.Name = "lblIdMenu";
            this.lblIdMenu.Size = new System.Drawing.Size(46, 13);
            this.lblIdMenu.TabIndex = 0;
            this.lblIdMenu.Text = "Id Menu";
            // 
            // txtIdMenu
            // 
            this.txtIdMenu.Location = new System.Drawing.Point(104, 10);
            this.txtIdMenu.Name = "txtIdMenu";
            this.txtIdMenu.Size = new System.Drawing.Size(100, 20);
            this.txtIdMenu.TabIndex = 1;
            // 
            // txtDescricaoMenu
            // 
            this.txtDescricaoMenu.Location = new System.Drawing.Point(104, 36);
            this.txtDescricaoMenu.Name = "txtDescricaoMenu";
            this.txtDescricaoMenu.Size = new System.Drawing.Size(100, 20);
            this.txtDescricaoMenu.TabIndex = 3;
            // 
            // lblDescricaoMenu
            // 
            this.lblDescricaoMenu.AutoSize = true;
            this.lblDescricaoMenu.Location = new System.Drawing.Point(13, 39);
            this.lblDescricaoMenu.Name = "lblDescricaoMenu";
            this.lblDescricaoMenu.Size = new System.Drawing.Size(85, 13);
            this.lblDescricaoMenu.TabIndex = 2;
            this.lblDescricaoMenu.Text = "Descrição Menu";
            // 
            // txtEnderecoMenu
            // 
            this.txtEnderecoMenu.Location = new System.Drawing.Point(104, 62);
            this.txtEnderecoMenu.Name = "txtEnderecoMenu";
            this.txtEnderecoMenu.Size = new System.Drawing.Size(100, 20);
            this.txtEnderecoMenu.TabIndex = 5;
            // 
            // lblEnderecoMenu
            // 
            this.lblEnderecoMenu.AutoSize = true;
            this.lblEnderecoMenu.Location = new System.Drawing.Point(13, 65);
            this.lblEnderecoMenu.Name = "lblEnderecoMenu";
            this.lblEnderecoMenu.Size = new System.Drawing.Size(83, 13);
            this.lblEnderecoMenu.TabIndex = 4;
            this.lblEnderecoMenu.Text = "Endereço Menu";
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(16, 102);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(75, 23);
            this.btnConfirma.TabIndex = 6;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(97, 102);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(178, 102);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // frmCadMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtEnderecoMenu);
            this.Controls.Add(this.lblEnderecoMenu);
            this.Controls.Add(this.txtDescricaoMenu);
            this.Controls.Add(this.lblDescricaoMenu);
            this.Controls.Add(this.txtIdMenu);
            this.Controls.Add(this.lblIdMenu);
            this.Name = "frmCadMenu";
            this.Text = "frmCadMenu";
            this.Load += new System.EventHandler(this.frmCadMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdMenu;
        private System.Windows.Forms.TextBox txtIdMenu;
        private System.Windows.Forms.TextBox txtDescricaoMenu;
        private System.Windows.Forms.Label lblDescricaoMenu;
        private System.Windows.Forms.TextBox txtEnderecoMenu;
        private System.Windows.Forms.Label lblEnderecoMenu;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
    }
}