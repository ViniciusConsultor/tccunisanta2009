namespace TCC.UI
{
    partial class frmCadUsinagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadUsinagem));
            this.lblCdUsinagem = new System.Windows.Forms.Label();
            this.txtCdUsinagem = new System.Windows.Forms.TextBox();
            this.lblCdPeca = new System.Windows.Forms.Label();
            this.txtCdPeca = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCdUsinagem
            // 
            this.lblCdUsinagem.AutoSize = true;
            this.lblCdUsinagem.Location = new System.Drawing.Point(59, 22);
            this.lblCdUsinagem.Name = "lblCdUsinagem";
            this.lblCdUsinagem.Size = new System.Drawing.Size(105, 13);
            this.lblCdUsinagem.TabIndex = 0;
            this.lblCdUsinagem.Text = "Codigo da Usinagem";
            // 
            // txtCdUsinagem
            // 
            this.txtCdUsinagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdUsinagem.Location = new System.Drawing.Point(170, 19);
            this.txtCdUsinagem.Name = "txtCdUsinagem";
            this.txtCdUsinagem.Size = new System.Drawing.Size(100, 20);
            this.txtCdUsinagem.TabIndex = 1;
            // 
            // lblCdPeca
            // 
            this.lblCdPeca.AutoSize = true;
            this.lblCdPeca.Location = new System.Drawing.Point(59, 58);
            this.lblCdPeca.Name = "lblCdPeca";
            this.lblCdPeca.Size = new System.Drawing.Size(83, 13);
            this.lblCdPeca.TabIndex = 0;
            this.lblCdPeca.Text = "Codigo da Peça";
            // 
            // txtCdPeca
            // 
            this.txtCdPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdPeca.Location = new System.Drawing.Point(170, 55);
            this.txtCdPeca.Name = "txtCdPeca";
            this.txtCdPeca.Size = new System.Drawing.Size(100, 20);
            this.txtCdPeca.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(213, 108);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(132, 108);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnAceitar
            // 
            this.btnAceitar.Location = new System.Drawing.Point(51, 108);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(75, 23);
            this.btnAceitar.TabIndex = 8;
            this.btnAceitar.Text = "Confirmar";
            this.btnAceitar.UseVisualStyleBackColor = true;
            // 
            // frmCadUsinagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(308, 169);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.txtCdPeca);
            this.Controls.Add(this.lblCdPeca);
            this.Controls.Add(this.txtCdUsinagem);
            this.Controls.Add(this.lblCdUsinagem);
            this.Name = "frmCadUsinagem";
            this.Text = "Usinagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCdUsinagem;
        private System.Windows.Forms.TextBox txtCdUsinagem;
        private System.Windows.Forms.Label lblCdPeca;
        private System.Windows.Forms.TextBox txtCdPeca;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAceitar;
    }
}