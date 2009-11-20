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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCdTipoPeca = new System.Windows.Forms.Button();
            this.txtCodigoReal = new System.Windows.Forms.TextBox();
            this.lblNomePecaReal = new System.Windows.Forms.Label();
            this.lblQtdPeca = new System.Windows.Forms.Label();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnRelacionarEstoque = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnRelacionarFornecedor = new System.Windows.Forms.Button();
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.txtQtdPeca = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.txtPesoPeca = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCdTipoPeca
            // 
            this.lblCdTipoPeca.AutoSize = true;
            this.lblCdTipoPeca.Location = new System.Drawing.Point(52, 14);
            this.lblCdTipoPeca.Name = "lblCdTipoPeca";
            this.lblCdTipoPeca.Size = new System.Drawing.Size(71, 13);
            this.lblCdTipoPeca.TabIndex = 0;
            this.lblCdTipoPeca.Text = "Tipo da Peça";
            // 
            // txtCdTipoPeca
            // 
            this.txtCdTipoPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdTipoPeca.Enabled = false;
            this.txtCdTipoPeca.Location = new System.Drawing.Point(137, 14);
            this.txtCdTipoPeca.MaxLength = 50;
            this.txtCdTipoPeca.Name = "txtCdTipoPeca";
            this.txtCdTipoPeca.ReadOnly = true;
            this.txtCdTipoPeca.Size = new System.Drawing.Size(118, 20);
            this.txtCdTipoPeca.TabIndex = 1;
            this.txtCdTipoPeca.TabStop = false;
            this.txtCdTipoPeca.TextChanged += new System.EventHandler(this.txtCdTipoPeca_TextChanged);
            // 
            // lblNmPeca
            // 
            this.lblNmPeca.AutoSize = true;
            this.lblNmPeca.Location = new System.Drawing.Point(53, 88);
            this.lblNmPeca.Name = "lblNmPeca";
            this.lblNmPeca.Size = new System.Drawing.Size(78, 13);
            this.lblNmPeca.TabIndex = 0;
            this.lblNmPeca.Text = "Nome da Peça";
            // 
            // txtNmPeca
            // 
            this.txtNmPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNmPeca.Location = new System.Drawing.Point(137, 86);
            this.txtNmPeca.MaxLength = 50;
            this.txtNmPeca.Name = "txtNmPeca";
            this.txtNmPeca.Size = new System.Drawing.Size(194, 20);
            this.txtNmPeca.TabIndex = 3;
            // 
            // lblDsPeca
            // 
            this.lblDsPeca.AutoSize = true;
            this.lblDsPeca.Location = new System.Drawing.Point(53, 111);
            this.lblDsPeca.Name = "lblDsPeca";
            this.lblDsPeca.Size = new System.Drawing.Size(83, 13);
            this.lblDsPeca.TabIndex = 0;
            this.lblDsPeca.Text = "Descrição Peça";
            // 
            // txtDsPeca
            // 
            this.txtDsPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDsPeca.Location = new System.Drawing.Point(56, 127);
            this.txtDsPeca.MaxLength = 100;
            this.txtDsPeca.Multiline = true;
            this.txtDsPeca.Name = "txtDsPeca";
            this.txtDsPeca.Size = new System.Drawing.Size(275, 42);
            this.txtDsPeca.TabIndex = 4;
            // 
            // lblPesoPeca
            // 
            this.lblPesoPeca.AutoSize = true;
            this.lblPesoPeca.Location = new System.Drawing.Point(194, 180);
            this.lblPesoPeca.Name = "lblPesoPeca";
            this.lblPesoPeca.Size = new System.Drawing.Size(74, 13);
            this.lblPesoPeca.TabIndex = 0;
            this.lblPesoPeca.Text = "Peso da Peça";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(2, 94);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 12;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(2, 34);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 10;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCdTipoPeca
            // 
            this.btnCdTipoPeca.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnCdTipoPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdTipoPeca.Location = new System.Drawing.Point(261, 14);
            this.btnCdTipoPeca.Name = "btnCdTipoPeca";
            this.btnCdTipoPeca.Size = new System.Drawing.Size(27, 23);
            this.btnCdTipoPeca.TabIndex = 1;
            this.toolTipLegenda.SetToolTip(this.btnCdTipoPeca, "Buscar Tipo da Peça");
            this.btnCdTipoPeca.UseVisualStyleBackColor = true;
            this.btnCdTipoPeca.Click += new System.EventHandler(this.btnCdTipoPeca_Click);
            // 
            // txtCodigoReal
            // 
            this.txtCodigoReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoReal.Location = new System.Drawing.Point(137, 38);
            this.txtCodigoReal.MaxLength = 50;
            this.txtCodigoReal.Name = "txtCodigoReal";
            this.txtCodigoReal.Size = new System.Drawing.Size(118, 20);
            this.txtCodigoReal.TabIndex = 2;
            // 
            // lblNomePecaReal
            // 
            this.lblNomePecaReal.AutoSize = true;
            this.lblNomePecaReal.Location = new System.Drawing.Point(52, 44);
            this.lblNomePecaReal.Name = "lblNomePecaReal";
            this.lblNomePecaReal.Size = new System.Drawing.Size(83, 13);
            this.lblNomePecaReal.TabIndex = 8;
            this.lblNomePecaReal.Text = "Código da Peça";
            // 
            // lblQtdPeca
            // 
            this.lblQtdPeca.AutoSize = true;
            this.lblQtdPeca.Location = new System.Drawing.Point(53, 180);
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
            // btnRelacionarEstoque
            // 
            this.btnRelacionarEstoque.BackgroundImage = global::TCC.resImg.btnRlacionaEstoque;
            this.btnRelacionarEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelacionarEstoque.Location = new System.Drawing.Point(291, 219);
            this.btnRelacionarEstoque.Name = "btnRelacionarEstoque";
            this.btnRelacionarEstoque.Size = new System.Drawing.Size(40, 35);
            this.btnRelacionarEstoque.TabIndex = 8;
            this.toolTipLegenda.SetToolTip(this.btnRelacionarEstoque, "Relacionar Estoque");
            this.btnRelacionarEstoque.UseVisualStyleBackColor = true;
            this.btnRelacionarEstoque.Click += new System.EventHandler(this.btnRelacionarEstoque_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(2, 4);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(27, 23);
            this.btnConfirma.TabIndex = 9;
            this.toolTipLegenda.SetToolTip(this.btnConfirma, "Salvar");
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnRelacionarFornecedor
            // 
            this.btnRelacionarFornecedor.BackgroundImage = global::TCC.resImg.btnFornecedorDepto;
            this.btnRelacionarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelacionarFornecedor.Location = new System.Drawing.Point(120, 219);
            this.btnRelacionarFornecedor.Name = "btnRelacionarFornecedor";
            this.btnRelacionarFornecedor.Size = new System.Drawing.Size(40, 35);
            this.btnRelacionarFornecedor.TabIndex = 7;
            this.toolTipLegenda.SetToolTip(this.btnRelacionarFornecedor, "Relacionar Departamento");
            this.btnRelacionarFornecedor.UseVisualStyleBackColor = true;
            this.btnRelacionarFornecedor.Click += new System.EventHandler(this.btnRelacionarFornecedor_Click);
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(2, 63);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaAlteracaoDelecao.TabIndex = 11;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            // 
            // txtQtdPeca
            // 
            this.txtQtdPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdPeca.Location = new System.Drawing.Point(151, 176);
            this.txtQtdPeca.MaxLength = 3;
            this.txtQtdPeca.Name = "txtQtdPeca";
            this.txtQtdPeca.Size = new System.Drawing.Size(37, 20);
            this.txtQtdPeca.TabIndex = 5;
            this.txtQtdPeca.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // txtPesoPeca
            // 
            this.txtPesoPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesoPeca.Location = new System.Drawing.Point(275, 176);
            this.txtPesoPeca.MaxLength = 10;
            this.txtPesoPeca.Name = "txtPesoPeca";
            this.txtPesoPeca.Size = new System.Drawing.Size(56, 20);
            this.txtPesoPeca.TabIndex = 6;
            this.txtPesoPeca.TipoTexto = Controles.MegaTextBox.TipoTexto.Decimal;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Relacionar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Fornecedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Estoque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Relacionar";
            // 
            // frmCadPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 268);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.btnRelacionarFornecedor);
            this.Controls.Add(this.txtPesoPeca);
            this.Controls.Add(this.txtQtdPeca);
            this.Controls.Add(this.btnRelacionarEstoque);
            this.Controls.Add(this.lblQtdPeca);
            this.Controls.Add(this.txtCodigoReal);
            this.Controls.Add(this.lblNomePecaReal);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCdTipoPeca);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtDsPeca);
            this.Controls.Add(this.txtNmPeca);
            this.Controls.Add(this.lblPesoPeca);
            this.Controls.Add(this.lblDsPeca);
            this.Controls.Add(this.lblNmPeca);
            this.Controls.Add(this.txtCdTipoPeca);
            this.Controls.Add(this.lblCdTipoPeca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadPeca";
            this.Text = "Cadastro de Pecas";
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
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnCdTipoPeca;
        private System.Windows.Forms.TextBox txtCodigoReal;
        private System.Windows.Forms.Label lblNomePecaReal;
        private System.Windows.Forms.Label lblQtdPeca;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnRelacionarEstoque;
        private Controles.MegaTextBox.MegaTextBox txtQtdPeca;
        private Controles.MegaTextBox.MegaTextBox txtPesoPeca;
        private System.Windows.Forms.Button btnRelacionarFornecedor;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}