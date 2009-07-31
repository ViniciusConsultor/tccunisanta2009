namespace TelasDesenvolvedor.UI
{
    partial class frmCadSubMenu
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.txtEnderecoSubMenu = new System.Windows.Forms.TextBox();
            this.lblEnderecoSubMenu = new System.Windows.Forms.Label();
            this.txtDescricaoSubMenu = new System.Windows.Forms.TextBox();
            this.lblDescricaoSubMenu = new System.Windows.Forms.Label();
            this.txtIdSubMenu = new System.Windows.Forms.TextBox();
            this.lblIdSubMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(182, 113);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(101, 113);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(20, 113);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(75, 23);
            this.btnConfirma.TabIndex = 15;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // txtEnderecoSubMenu
            // 
            this.txtEnderecoSubMenu.Location = new System.Drawing.Point(157, 73);
            this.txtEnderecoSubMenu.Name = "txtEnderecoSubMenu";
            this.txtEnderecoSubMenu.Size = new System.Drawing.Size(100, 20);
            this.txtEnderecoSubMenu.TabIndex = 14;
            // 
            // lblEnderecoSubMenu
            // 
            this.lblEnderecoSubMenu.AutoSize = true;
            this.lblEnderecoSubMenu.Location = new System.Drawing.Point(17, 76);
            this.lblEnderecoSubMenu.Name = "lblEnderecoSubMenu";
            this.lblEnderecoSubMenu.Size = new System.Drawing.Size(105, 13);
            this.lblEnderecoSubMenu.TabIndex = 13;
            this.lblEnderecoSubMenu.Text = "Endereço Sub Menu";
            // 
            // txtDescricaoSubMenu
            // 
            this.txtDescricaoSubMenu.Location = new System.Drawing.Point(157, 47);
            this.txtDescricaoSubMenu.Name = "txtDescricaoSubMenu";
            this.txtDescricaoSubMenu.Size = new System.Drawing.Size(100, 20);
            this.txtDescricaoSubMenu.TabIndex = 12;
            // 
            // lblDescricaoSubMenu
            // 
            this.lblDescricaoSubMenu.AutoSize = true;
            this.lblDescricaoSubMenu.Location = new System.Drawing.Point(17, 50);
            this.lblDescricaoSubMenu.Name = "lblDescricaoSubMenu";
            this.lblDescricaoSubMenu.Size = new System.Drawing.Size(107, 13);
            this.lblDescricaoSubMenu.TabIndex = 11;
            this.lblDescricaoSubMenu.Text = "Descrição Sub Menu";
            // 
            // txtIdSubMenu
            // 
            this.txtIdSubMenu.Location = new System.Drawing.Point(157, 21);
            this.txtIdSubMenu.Name = "txtIdSubMenu";
            this.txtIdSubMenu.Size = new System.Drawing.Size(100, 20);
            this.txtIdSubMenu.TabIndex = 10;
            // 
            // lblIdSubMenu
            // 
            this.lblIdSubMenu.AutoSize = true;
            this.lblIdSubMenu.Location = new System.Drawing.Point(17, 24);
            this.lblIdSubMenu.Name = "lblIdSubMenu";
            this.lblIdSubMenu.Size = new System.Drawing.Size(68, 13);
            this.lblIdSubMenu.TabIndex = 9;
            this.lblIdSubMenu.Text = "Id Sub Menu";
            // 
            // frmCadSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtEnderecoSubMenu);
            this.Controls.Add(this.lblEnderecoSubMenu);
            this.Controls.Add(this.txtDescricaoSubMenu);
            this.Controls.Add(this.lblDescricaoSubMenu);
            this.Controls.Add(this.txtIdSubMenu);
            this.Controls.Add(this.lblIdSubMenu);
            this.Name = "frmCadSubMenu";
            this.Text = "Endereço Sub Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.TextBox txtEnderecoSubMenu;
        private System.Windows.Forms.Label lblEnderecoSubMenu;
        private System.Windows.Forms.TextBox txtDescricaoSubMenu;
        private System.Windows.Forms.Label lblDescricaoSubMenu;
        private System.Windows.Forms.TextBox txtIdSubMenu;
        private System.Windows.Forms.Label lblIdSubMenu;
    }
}