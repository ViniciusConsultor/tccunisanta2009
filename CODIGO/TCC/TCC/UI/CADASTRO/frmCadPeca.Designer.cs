namespace TCC.UI
{
    partial class frmCadPeca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadPeca));
            this.lblCdTipoPeca = new System.Windows.Forms.Label();
            this.txtCdTipoPeca = new System.Windows.Forms.TextBox();
            this.lblNmPeca = new System.Windows.Forms.Label();
            this.txtNmPeca = new System.Windows.Forms.TextBox();
            this.lblDsPeca = new System.Windows.Forms.Label();
            this.txtDsPeca = new System.Windows.Forms.TextBox();
            this.lblPesoPeca = new System.Windows.Forms.Label();
            this.txtPesoPeca = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnCdTipoPeca = new System.Windows.Forms.Button();
            this.txtCodigoReal = new System.Windows.Forms.TextBox();
            this.lblNomePecaReal = new System.Windows.Forms.Label();
            this.txtQtdPeca = new System.Windows.Forms.TextBox();
            this.lblQtdPeca = new System.Windows.Forms.Label();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnRelacioranEstoque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCdTipoPeca
            // 
            this.lblCdTipoPeca.AutoSize = true;
            this.lblCdTipoPeca.Location = new System.Drawing.Point(93, 37);
            this.lblCdTipoPeca.Name = "lblCdTipoPeca";
            this.lblCdTipoPeca.Size = new System.Drawing.Size(107, 13);
            this.lblCdTipoPeca.TabIndex = 0;
            this.lblCdTipoPeca.Text = "Codigo do Tipo Peça";
            // 
            // txtCdTipoPeca
            // 
            this.txtCdTipoPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdTipoPeca.Location = new System.Drawing.Point(206, 34);
            this.txtCdTipoPeca.Name = "txtCdTipoPeca";
            this.txtCdTipoPeca.ReadOnly = true;
            this.txtCdTipoPeca.Size = new System.Drawing.Size(32, 20);
            this.txtCdTipoPeca.TabIndex = 1;
            this.txtCdTipoPeca.TabStop = false;
            // 
            // lblNmPeca
            // 
            this.lblNmPeca.AutoSize = true;
            this.lblNmPeca.Location = new System.Drawing.Point(52, 64);
            this.lblNmPeca.Name = "lblNmPeca";
            this.lblNmPeca.Size = new System.Drawing.Size(78, 13);
            this.lblNmPeca.TabIndex = 0;
            this.lblNmPeca.Text = "Nome da Peça";
            // 
            // txtNmPeca
            // 
            this.txtNmPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNmPeca.Location = new System.Drawing.Point(136, 62);
            this.txtNmPeca.MaxLength = 50;
            this.txtNmPeca.Name = "txtNmPeca";
            this.txtNmPeca.Size = new System.Drawing.Size(194, 20);
            this.txtNmPeca.TabIndex = 4;
            // 
            // lblDsPeca
            // 
            this.lblDsPeca.AutoSize = true;
            this.lblDsPeca.Location = new System.Drawing.Point(52, 85);
            this.lblDsPeca.Name = "lblDsPeca";
            this.lblDsPeca.Size = new System.Drawing.Size(83, 13);
            this.lblDsPeca.TabIndex = 0;
            this.lblDsPeca.Text = "Descrição Peça";
            // 
            // txtDsPeca
            // 
            this.txtDsPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDsPeca.Location = new System.Drawing.Point(55, 101);
            this.txtDsPeca.MaxLength = 100;
            this.txtDsPeca.Multiline = true;
            this.txtDsPeca.Name = "txtDsPeca";
            this.txtDsPeca.Size = new System.Drawing.Size(275, 42);
            this.txtDsPeca.TabIndex = 5;
            // 
            // lblPesoPeca
            // 
            this.lblPesoPeca.AutoSize = true;
            this.lblPesoPeca.Location = new System.Drawing.Point(193, 154);
            this.lblPesoPeca.Name = "lblPesoPeca";
            this.lblPesoPeca.Size = new System.Drawing.Size(74, 13);
            this.lblPesoPeca.TabIndex = 0;
            this.lblPesoPeca.Text = "Peso da Peça";
            // 
            // txtPesoPeca
            // 
            this.txtPesoPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesoPeca.Location = new System.Drawing.Point(273, 152);
            this.txtPesoPeca.MaxLength = 12;
            this.txtPesoPeca.Name = "txtPesoPeca";
            this.txtPesoPeca.Size = new System.Drawing.Size(57, 20);
            this.txtPesoPeca.TabIndex = 7;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(2, 63);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 10;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::TCC.Properties.Resources.eraser;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(2, 34);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 9;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = global::TCC.Properties.Resources.btnSalvar;
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(2, 4);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(27, 23);
            this.btnConfirma.TabIndex = 8;
            this.toolTipLegenda.SetToolTip(this.btnConfirma, "Cadastrar");
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnCdTipoPeca
            // 
            this.btnCdTipoPeca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCdTipoPeca.BackgroundImage")));
            this.btnCdTipoPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdTipoPeca.Location = new System.Drawing.Point(243, 32);
            this.btnCdTipoPeca.Name = "btnCdTipoPeca";
            this.btnCdTipoPeca.Size = new System.Drawing.Size(27, 23);
            this.btnCdTipoPeca.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnCdTipoPeca, "Buscar Tipo da Peça");
            this.btnCdTipoPeca.UseVisualStyleBackColor = true;
            this.btnCdTipoPeca.Click += new System.EventHandler(this.btnCdTipoPeca_Click);
            // 
            // txtCodigoReal
            // 
            this.txtCodigoReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoReal.Location = new System.Drawing.Point(164, 7);
            this.txtCodigoReal.MaxLength = 50;
            this.txtCodigoReal.Name = "txtCodigoReal";
            this.txtCodigoReal.Size = new System.Drawing.Size(106, 20);
            this.txtCodigoReal.TabIndex = 1;
            // 
            // lblNomePecaReal
            // 
            this.lblNomePecaReal.AutoSize = true;
            this.lblNomePecaReal.Location = new System.Drawing.Point(93, 9);
            this.lblNomePecaReal.Name = "lblNomePecaReal";
            this.lblNomePecaReal.Size = new System.Drawing.Size(65, 13);
            this.lblNomePecaReal.TabIndex = 8;
            this.lblNomePecaReal.Text = "Codigo Real";
            // 
            // txtQtdPeca
            // 
            this.txtQtdPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdPeca.Location = new System.Drawing.Point(144, 152);
            this.txtQtdPeca.MaxLength = 9;
            this.txtQtdPeca.Name = "txtQtdPeca";
            this.txtQtdPeca.Size = new System.Drawing.Size(43, 20);
            this.txtQtdPeca.TabIndex = 6;
            // 
            // lblQtdPeca
            // 
            this.lblQtdPeca.AutoSize = true;
            this.lblQtdPeca.Location = new System.Drawing.Point(52, 154);
            this.lblQtdPeca.Name = "lblQtdPeca";
            this.lblQtdPeca.Size = new System.Drawing.Size(91, 13);
            this.lblQtdPeca.TabIndex = 10;
            this.lblQtdPeca.Text = "Qtd. Minima Peça";
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // btnRelacioranEstoque
            // 
            this.btnRelacioranEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelacioranEstoque.Location = new System.Drawing.Point(206, 183);
            this.btnRelacioranEstoque.Name = "btnRelacioranEstoque";
            this.btnRelacioranEstoque.Size = new System.Drawing.Size(124, 23);
            this.btnRelacioranEstoque.TabIndex = 11;
            this.btnRelacioranEstoque.Text = "Relacionar Estoque";
            this.btnRelacioranEstoque.UseVisualStyleBackColor = true;
            // 
            // frmCadPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 218);
            this.ControlBox = false;
            this.Controls.Add(this.btnRelacioranEstoque);
            this.Controls.Add(this.txtQtdPeca);
            this.Controls.Add(this.lblQtdPeca);
            this.Controls.Add(this.txtCodigoReal);
            this.Controls.Add(this.lblNomePecaReal);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCdTipoPeca);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtPesoPeca);
            this.Controls.Add(this.txtDsPeca);
            this.Controls.Add(this.txtNmPeca);
            this.Controls.Add(this.lblPesoPeca);
            this.Controls.Add(this.lblDsPeca);
            this.Controls.Add(this.lblNmPeca);
            this.Controls.Add(this.txtCdTipoPeca);
            this.Controls.Add(this.lblCdTipoPeca);
            this.MaximizeBox = false;
            this.Name = "frmCadPeca";
            this.Text = "Cadastro de Peca";
            this.Load += new System.EventHandler(this.frmCadPeca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCdTipoPeca;
        private System.Windows.Forms.TextBox txtCdTipoPeca;
        private System.Windows.Forms.Label lblNmPeca;
        private System.Windows.Forms.TextBox txtNmPeca;
        private System.Windows.Forms.Label lblDsPeca;
        private System.Windows.Forms.TextBox txtDsPeca;
        private System.Windows.Forms.Label lblPesoPeca;
        private System.Windows.Forms.TextBox txtPesoPeca;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnCdTipoPeca;
        private System.Windows.Forms.TextBox txtCodigoReal;
        private System.Windows.Forms.Label lblNomePecaReal;
        private System.Windows.Forms.TextBox txtQtdPeca;
        private System.Windows.Forms.Label lblQtdPeca;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnRelacioranEstoque;
    }
}