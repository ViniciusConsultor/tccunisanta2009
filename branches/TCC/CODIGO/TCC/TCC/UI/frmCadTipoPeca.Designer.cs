namespace TCC.UI
{
    partial class frmCadTipoPeca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadTipoPeca));
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnInsere = new System.Windows.Forms.Button();
            this.txtDescricaoTipoPeca = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtCdPeca = new System.Windows.Forms.TextBox();
            this.lblCodigoPeca = new System.Windows.Forms.Label();
            this.txtCdTipoPeca = new System.Windows.Forms.TextBox();
            this.lblcodigoTipoPeca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolta
            // 
            this.btnVolta.Location = new System.Drawing.Point(414, 111);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(75, 23);
            this.btnVolta.TabIndex = 5;
            this.btnVolta.Text = "Voltar";
            this.btnVolta.UseVisualStyleBackColor = true;
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(333, 111);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 23);
            this.btnLimpa.TabIndex = 4;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            // 
            // btnInsere
            // 
            this.btnInsere.Location = new System.Drawing.Point(252, 111);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(75, 23);
            this.btnInsere.TabIndex = 3;
            this.btnInsere.Text = "Confirmar";
            this.btnInsere.UseVisualStyleBackColor = true;
            // 
            // txtDescricaoTipoPeca
            // 
            this.txtDescricaoTipoPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoTipoPeca.Location = new System.Drawing.Point(194, 50);
            this.txtDescricaoTipoPeca.Name = "txtDescricaoTipoPeca";
            this.txtDescricaoTipoPeca.Size = new System.Drawing.Size(100, 20);
            this.txtDescricaoTipoPeca.TabIndex = 2;
            this.txtDescricaoTipoPeca.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(121, 53);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 13;
            this.lblDescricao.Text = "Descrição ";
            // 
            // txtCdPeca
            // 
            this.txtCdPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdPeca.Location = new System.Drawing.Point(389, 24);
            this.txtCdPeca.Name = "txtCdPeca";
            this.txtCdPeca.Size = new System.Drawing.Size(100, 20);
            this.txtCdPeca.TabIndex = 1;
            // 
            // lblCodigoPeca
            // 
            this.lblCodigoPeca.AutoSize = true;
            this.lblCodigoPeca.Location = new System.Drawing.Point(300, 24);
            this.lblCodigoPeca.Name = "lblCodigoPeca";
            this.lblCodigoPeca.Size = new System.Drawing.Size(83, 13);
            this.lblCodigoPeca.TabIndex = 9;
            this.lblCodigoPeca.Text = "Codigo da Peça";
            // 
            // txtCdTipoPeca
            // 
            this.txtCdTipoPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdTipoPeca.Location = new System.Drawing.Point(194, 24);
            this.txtCdTipoPeca.Name = "txtCdTipoPeca";
            this.txtCdTipoPeca.Size = new System.Drawing.Size(100, 20);
            this.txtCdTipoPeca.TabIndex = 0;
            // 
            // lblcodigoTipoPeca
            // 
            this.lblcodigoTipoPeca.AutoSize = true;
            this.lblcodigoTipoPeca.Location = new System.Drawing.Point(67, 27);
            this.lblcodigoTipoPeca.Name = "lblcodigoTipoPeca";
            this.lblcodigoTipoPeca.Size = new System.Drawing.Size(106, 13);
            this.lblcodigoTipoPeca.TabIndex = 7;
            this.lblcodigoTipoPeca.Text = "Codigo Tipo da peça";
            // 
            // frmCadTipoPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 158);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnInsere);
            this.Controls.Add(this.txtDescricaoTipoPeca);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtCdPeca);
            this.Controls.Add(this.lblCodigoPeca);
            this.Controls.Add(this.txtCdTipoPeca);
            this.Controls.Add(this.lblcodigoTipoPeca);
            this.Name = "frmCadTipoPeca";
            this.Text = "Cadastro Tipo da Peça";
            this.Load += new System.EventHandler(this.frmCadTipoPeca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnInsere;
        private System.Windows.Forms.TextBox txtDescricaoTipoPeca;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtCdPeca;
        private System.Windows.Forms.Label lblCodigoPeca;
        private System.Windows.Forms.TextBox txtCdTipoPeca;
        private System.Windows.Forms.Label lblcodigoTipoPeca;
    }
}