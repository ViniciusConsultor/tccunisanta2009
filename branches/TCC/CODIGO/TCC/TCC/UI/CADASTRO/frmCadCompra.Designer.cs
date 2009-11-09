namespace TCC.UI
{
    partial class frmCadCompra
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
            this.lblCdFornecedor = new System.Windows.Forms.Label();
            this.txtCdFornecedor = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblVlCompra = new System.Windows.Forms.Label();
            this.lblNtFiscal = new System.Windows.Forms.Label();
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnBuscaFornecedor = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.dgPeca = new System.Windows.Forms.DataGridView();
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.pnlOrdemCompra = new System.Windows.Forms.Panel();
            this.txtVlCompra = new Controles.MegaTextBox.MegaTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgPeca)).BeginInit();
            this.pnlOrdemCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCdFornecedor
            // 
            this.lblCdFornecedor.AutoSize = true;
            this.lblCdFornecedor.Location = new System.Drawing.Point(90, 149);
            this.lblCdFornecedor.Name = "lblCdFornecedor";
            this.lblCdFornecedor.Size = new System.Drawing.Size(112, 13);
            this.lblCdFornecedor.TabIndex = 11;
            this.lblCdFornecedor.Text = "Codigo do Fornecedor";
            // 
            // txtCdFornecedor
            // 
            this.txtCdFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdFornecedor.Location = new System.Drawing.Point(208, 147);
            this.txtCdFornecedor.MaxLength = 25;
            this.txtCdFornecedor.Name = "txtCdFornecedor";
            this.txtCdFornecedor.ReadOnly = true;
            this.txtCdFornecedor.Size = new System.Drawing.Size(192, 20);
            this.txtCdFornecedor.TabIndex = 1;
            this.txtCdFornecedor.TabStop = false;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(137, 71);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 11;
            this.lblObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.Location = new System.Drawing.Point(208, 69);
            this.txtObservacao.MaxLength = 25;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(192, 72);
            this.txtObservacao.TabIndex = 10;
            // 
            // lblVlCompra
            // 
            this.lblVlCompra.AutoSize = true;
            this.lblVlCompra.Location = new System.Drawing.Point(132, 45);
            this.lblVlCompra.Name = "lblVlCompra";
            this.lblVlCompra.Size = new System.Drawing.Size(70, 13);
            this.lblVlCompra.TabIndex = 11;
            this.lblVlCompra.Text = "Valor Compra";
            // 
            // lblNtFiscal
            // 
            this.lblNtFiscal.AutoSize = true;
            this.lblNtFiscal.Location = new System.Drawing.Point(142, 19);
            this.lblNtFiscal.Name = "lblNtFiscal";
            this.lblNtFiscal.Size = new System.Drawing.Size(60, 13);
            this.lblNtFiscal.TabIndex = 11;
            this.lblNtFiscal.Text = "Nota Fiscal";
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotaFiscal.Location = new System.Drawing.Point(208, 17);
            this.txtNotaFiscal.MaxLength = 20;
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.Size = new System.Drawing.Size(192, 20);
            this.txtNotaFiscal.TabIndex = 7;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::TCC.resImg.btnLimpa;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(6, 46);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(40, 35);
            this.btnLimpar.TabIndex = 12;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(6, 128);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(40, 35);
            this.btnVoltar.TabIndex = 13;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnBuscaFornecedor
            // 
            this.btnBuscaFornecedor.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscaFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaFornecedor.Location = new System.Drawing.Point(406, 144);
            this.btnBuscaFornecedor.Name = "btnBuscaFornecedor";
            this.btnBuscaFornecedor.Size = new System.Drawing.Size(34, 23);
            this.btnBuscaFornecedor.TabIndex = 1;
            this.toolTipLegenda.SetToolTip(this.btnBuscaFornecedor, "Buscar Fornecedor");
            this.btnBuscaFornecedor.UseVisualStyleBackColor = true;
            this.btnBuscaFornecedor.Click += new System.EventHandler(this.btnBuscaFornecedor_Click);
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // dgPeca
            // 
            this.dgPeca.AllowUserToAddRows = false;
            this.dgPeca.AllowUserToDeleteRows = false;
            this.dgPeca.AllowUserToResizeColumns = false;
            this.dgPeca.AllowUserToResizeRows = false;
            this.dgPeca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeca.Location = new System.Drawing.Point(14, 40);
            this.dgPeca.MultiSelect = false;
            this.dgPeca.Name = "dgPeca";
            this.dgPeca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPeca.ShowEditingIcon = false;
            this.dgPeca.Size = new System.Drawing.Size(366, 125);
            this.dgPeca.TabIndex = 1;
            this.toolTipLegenda.SetToolTip(this.dgPeca, "Apertar Ctrl para Selecionar mais de um item");
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(6, 87);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(40, 35);
            this.btnBuscaAlteracaoDelecao.TabIndex = 18;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar Registro");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            this.btnBuscaAlteracaoDelecao.Click += new System.EventHandler(this.btnBuscaAlteracaoDelecao_Click);
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(6, 5);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(40, 35);
            this.btnAceitar.TabIndex = 11;
            this.toolTipLegenda.SetToolTip(this.btnAceitar, "Cadastrar");
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // pnlOrdemCompra
            // 
            this.pnlOrdemCompra.Controls.Add(this.dgPeca);
            this.pnlOrdemCompra.Location = new System.Drawing.Point(79, 173);
            this.pnlOrdemCompra.Name = "pnlOrdemCompra";
            this.pnlOrdemCompra.Size = new System.Drawing.Size(501, 185);
            this.pnlOrdemCompra.TabIndex = 19;
            // 
            // txtVlCompra
            // 
            this.txtVlCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlCompra.Location = new System.Drawing.Point(208, 43);
            this.txtVlCompra.MaxLength = 20;
            this.txtVlCompra.Name = "txtVlCompra";
            this.txtVlCompra.Size = new System.Drawing.Size(192, 20);
            this.txtVlCompra.TabIndex = 20;
            this.txtVlCompra.TipoTexto = Controles.MegaTextBox.TipoTexto.Decimal;
            // 
            // frmCadCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 368);
            this.ControlBox = false;
            this.Controls.Add(this.txtVlCompra);
            this.Controls.Add(this.pnlOrdemCompra);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.btnBuscaFornecedor);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtNotaFiscal);
            this.Controls.Add(this.txtCdFornecedor);
            this.Controls.Add(this.lblNtFiscal);
            this.Controls.Add(this.lblVlCompra);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.lblCdFornecedor);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAceitar);
            this.MaximizeBox = false;
            this.Name = "frmCadCompra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.frmCadCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPeca)).EndInit();
            this.pnlOrdemCompra.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCdFornecedor;
        private System.Windows.Forms.TextBox txtCdFornecedor;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblVlCompra;
        private System.Windows.Forms.Label lblNtFiscal;
        private System.Windows.Forms.TextBox txtNotaFiscal;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnBuscaFornecedor;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Panel pnlOrdemCompra;
        private System.Windows.Forms.DataGridView dgPeca;
        private Controles.MegaTextBox.MegaTextBox txtVlCompra;
    }
}