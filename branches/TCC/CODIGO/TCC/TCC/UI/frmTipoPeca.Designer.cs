namespace TCC.UI
{
    partial class frmTipoPeca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoPeca));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.txtCdTipoPeca = new System.Windows.Forms.TextBox();
            this.lblCdTipoPeca = new System.Windows.Forms.Label();
            this.lblDsTipoPeca = new System.Windows.Forms.Label();
            this.txtDsTipoPeca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(205, 118);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(124, 118);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnAceitar
            // 
            this.btnAceitar.Location = new System.Drawing.Point(43, 118);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(75, 23);
            this.btnAceitar.TabIndex = 14;
            this.btnAceitar.Text = "Confirmar";
            this.btnAceitar.UseVisualStyleBackColor = true;
            // 
            // txtCdTipoPeca
            // 
            this.txtCdTipoPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdTipoPeca.Location = new System.Drawing.Point(186, 37);
            this.txtCdTipoPeca.Name = "txtCdTipoPeca";
            this.txtCdTipoPeca.Size = new System.Drawing.Size(100, 20);
            this.txtCdTipoPeca.TabIndex = 17;
            // 
            // lblCdTipoPeca
            // 
            this.lblCdTipoPeca.AutoSize = true;
            this.lblCdTipoPeca.Location = new System.Drawing.Point(43, 40);
            this.lblCdTipoPeca.Name = "lblCdTipoPeca";
            this.lblCdTipoPeca.Size = new System.Drawing.Size(122, 13);
            this.lblCdTipoPeca.TabIndex = 18;
            this.lblCdTipoPeca.Text = "Codigo do Tipo de Peça";
            // 
            // lblDsTipoPeca
            // 
            this.lblDsTipoPeca.AutoSize = true;
            this.lblDsTipoPeca.Location = new System.Drawing.Point(43, 78);
            this.lblDsTipoPeca.Name = "lblDsTipoPeca";
            this.lblDsTipoPeca.Size = new System.Drawing.Size(137, 13);
            this.lblDsTipoPeca.TabIndex = 20;
            this.lblDsTipoPeca.Text = "Descrição do Tipo de Peça";
            // 
            // txtDsTipoPeca
            // 
            this.txtDsTipoPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDsTipoPeca.Location = new System.Drawing.Point(186, 75);
            this.txtDsTipoPeca.Name = "txtDsTipoPeca";
            this.txtDsTipoPeca.Size = new System.Drawing.Size(100, 20);
            this.txtDsTipoPeca.TabIndex = 19;
            // 
            // frmTipoPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(292, 176);
            this.Controls.Add(this.lblDsTipoPeca);
            this.Controls.Add(this.txtDsTipoPeca);
            this.Controls.Add(this.lblCdTipoPeca);
            this.Controls.Add(this.txtCdTipoPeca);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAceitar);
            this.Name = "frmTipoPeca";
            this.Text = "frmTipoPeca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.TextBox txtCdTipoPeca;
        private System.Windows.Forms.Label lblCdTipoPeca;
        private System.Windows.Forms.Label lblDsTipoPeca;
        private System.Windows.Forms.TextBox txtDsTipoPeca;
    }
}