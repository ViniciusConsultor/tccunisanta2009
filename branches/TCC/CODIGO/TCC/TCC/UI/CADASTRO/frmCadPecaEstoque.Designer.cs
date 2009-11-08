namespace TCC.UI.CADASTRO
{
    partial class frmCadPecaEstoque
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
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtQtdestoque = new System.Windows.Forms.TextBox();
            this.txtIdEstoque = new System.Windows.Forms.TextBox();
            this.lblCdEstoque = new System.Windows.Forms.Label();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnInsere = new System.Windows.Forms.Button();
            this.btnCdEstoque = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(62, 96);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(62, 13);
            this.lblQtd.TabIndex = 0;
            this.lblQtd.Text = "Quantidade";
            // 
            // txtQtdestoque
            // 
            this.txtQtdestoque.Location = new System.Drawing.Point(165, 93);
            this.txtQtdestoque.Name = "txtQtdestoque";
            this.txtQtdestoque.Size = new System.Drawing.Size(135, 20);
            this.txtQtdestoque.TabIndex = 1;
            // 
            // txtIdEstoque
            // 
            this.txtIdEstoque.Location = new System.Drawing.Point(165, 50);
            this.txtIdEstoque.Name = "txtIdEstoque";
            this.txtIdEstoque.ReadOnly = true;
            this.txtIdEstoque.Size = new System.Drawing.Size(100, 20);
            this.txtIdEstoque.TabIndex = 2;
            // 
            // lblCdEstoque
            // 
            this.lblCdEstoque.AutoSize = true;
            this.lblCdEstoque.Location = new System.Drawing.Point(62, 56);
            this.lblCdEstoque.Name = "lblCdEstoque";
            this.lblCdEstoque.Size = new System.Drawing.Size(46, 13);
            this.lblCdEstoque.TabIndex = 3;
            this.lblCdEstoque.Text = "Estoque";
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(2, 56);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(30, 26);
            this.btnVolta.TabIndex = 19;
            this.toolTipLegenda.SetToolTip(this.btnVolta, "Voltar / Fechar");
            this.btnVolta.UseVisualStyleBackColor = true;
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackgroundImage = global::TCC.resImg.btnLimpa;
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpa.Location = new System.Drawing.Point(2, 29);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(30, 25);
            this.btnLimpa.TabIndex = 18;
            this.toolTipLegenda.SetToolTip(this.btnLimpa, "Limpar");
            this.btnLimpa.UseVisualStyleBackColor = true;
            // 
            // btnInsere
            // 
            this.btnInsere.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnInsere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsere.Location = new System.Drawing.Point(2, 3);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(30, 25);
            this.btnInsere.TabIndex = 17;
            this.toolTipLegenda.SetToolTip(this.btnInsere, "OK");
            this.btnInsere.UseVisualStyleBackColor = true;
            // 
            // btnCdEstoque
            // 
            this.btnCdEstoque.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnCdEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdEstoque.Location = new System.Drawing.Point(271, 47);
            this.btnCdEstoque.Name = "btnCdEstoque";
            this.btnCdEstoque.Size = new System.Drawing.Size(29, 25);
            this.btnCdEstoque.TabIndex = 21;
            this.toolTipLegenda.SetToolTip(this.btnCdEstoque, "Buscar");
            this.btnCdEstoque.UseVisualStyleBackColor = true;
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(271, 119);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(29, 26);
            this.btnBuscaAlteracaoDelecao.TabIndex = 20;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar / Deletar");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            // 
            // frmCadPecaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(357, 180);
            this.ControlBox = false;
            this.Controls.Add(this.btnCdEstoque);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnInsere);
            this.Controls.Add(this.lblCdEstoque);
            this.Controls.Add(this.txtIdEstoque);
            this.Controls.Add(this.txtQtdestoque);
            this.Controls.Add(this.lblQtd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadPecaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Peças em Estoque ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtQtdestoque;
        private System.Windows.Forms.TextBox txtIdEstoque;
        private System.Windows.Forms.Label lblCdEstoque;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnInsere;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private System.Windows.Forms.Button btnCdEstoque;
        private System.Windows.Forms.ToolTip toolTipLegenda;
    }
}