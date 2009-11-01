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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCompra));
            this.lblCdDepartamento = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.lblCdFornecedor = new System.Windows.Forms.Label();
            this.txtCdFornecedor = new System.Windows.Forms.TextBox();
            this.lblCdTipoProduto = new System.Windows.Forms.Label();
            this.txtCdTipoProduto = new System.Windows.Forms.TextBox();
            this.lblCdPeca = new System.Windows.Forms.Label();
            this.txtCdPeca = new System.Windows.Forms.TextBox();
            this.lblCdMotor = new System.Windows.Forms.Label();
            this.txtCdMotorCompra = new System.Windows.Forms.TextBox();
            this.lblDtCompra = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblQtdCompra = new System.Windows.Forms.Label();
            this.lblVlCompra = new System.Windows.Forms.Label();
            this.txtQtdCompra = new System.Windows.Forms.TextBox();
            this.lblNtFiscal = new System.Windows.Forms.Label();
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnBuscaFornecedor = new System.Windows.Forms.Button();
            this.btnBuscaPeca = new System.Windows.Forms.Button();
            this.btnBuscaDepartamento = new System.Windows.Forms.Button();
            this.btnBuscaTipoProduto = new System.Windows.Forms.Button();
            this.btnBuscaMotorCompra = new System.Windows.Forms.Button();
            this.txtDataCompra = new System.Windows.Forms.MaskedTextBox();
            this.txtVlCompra = new System.Windows.Forms.TextBox();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCdDepartamento
            // 
            this.lblCdDepartamento.AutoSize = true;
            this.lblCdDepartamento.Location = new System.Drawing.Point(337, 49);
            this.lblCdDepartamento.Name = "lblCdDepartamento";
            this.lblCdDepartamento.Size = new System.Drawing.Size(125, 13);
            this.lblCdDepartamento.TabIndex = 11;
            this.lblCdDepartamento.Text = "Codigo do Departamento";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartamento.Location = new System.Drawing.Point(468, 44);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.ReadOnly = true;
            this.txtDepartamento.Size = new System.Drawing.Size(49, 20);
            this.txtDepartamento.TabIndex = 3;
            this.txtDepartamento.TabStop = false;
            // 
            // lblCdFornecedor
            // 
            this.lblCdFornecedor.AutoSize = true;
            this.lblCdFornecedor.Location = new System.Drawing.Point(96, 46);
            this.lblCdFornecedor.Name = "lblCdFornecedor";
            this.lblCdFornecedor.Size = new System.Drawing.Size(112, 13);
            this.lblCdFornecedor.TabIndex = 11;
            this.lblCdFornecedor.Text = "Codigo do Fornecedor";
            // 
            // txtCdFornecedor
            // 
            this.txtCdFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdFornecedor.Location = new System.Drawing.Point(214, 44);
            this.txtCdFornecedor.Name = "txtCdFornecedor";
            this.txtCdFornecedor.ReadOnly = true;
            this.txtCdFornecedor.Size = new System.Drawing.Size(38, 20);
            this.txtCdFornecedor.TabIndex = 1;
            this.txtCdFornecedor.TabStop = false;
            // 
            // lblCdTipoProduto
            // 
            this.lblCdTipoProduto.AutoSize = true;
            this.lblCdTipoProduto.Location = new System.Drawing.Point(328, 78);
            this.lblCdTipoProduto.Name = "lblCdTipoProduto";
            this.lblCdTipoProduto.Size = new System.Drawing.Size(134, 13);
            this.lblCdTipoProduto.TabIndex = 11;
            this.lblCdTipoProduto.Text = "Codigo do Tipo do Produto";
            // 
            // txtCdTipoProduto
            // 
            this.txtCdTipoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdTipoProduto.Location = new System.Drawing.Point(468, 76);
            this.txtCdTipoProduto.Name = "txtCdTipoProduto";
            this.txtCdTipoProduto.ReadOnly = true;
            this.txtCdTipoProduto.Size = new System.Drawing.Size(49, 20);
            this.txtCdTipoProduto.TabIndex = 7;
            this.txtCdTipoProduto.TabStop = false;
            // 
            // lblCdPeca
            // 
            this.lblCdPeca.AutoSize = true;
            this.lblCdPeca.Location = new System.Drawing.Point(96, 76);
            this.lblCdPeca.Name = "lblCdPeca";
            this.lblCdPeca.Size = new System.Drawing.Size(83, 13);
            this.lblCdPeca.TabIndex = 11;
            this.lblCdPeca.Text = "Codigo da Peça";
            // 
            // txtCdPeca
            // 
            this.txtCdPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdPeca.Location = new System.Drawing.Point(185, 74);
            this.txtCdPeca.Name = "txtCdPeca";
            this.txtCdPeca.ReadOnly = true;
            this.txtCdPeca.Size = new System.Drawing.Size(38, 20);
            this.txtCdPeca.TabIndex = 5;
            this.txtCdPeca.TabStop = false;
            // 
            // lblCdMotor
            // 
            this.lblCdMotor.AutoSize = true;
            this.lblCdMotor.Location = new System.Drawing.Point(377, 112);
            this.lblCdMotor.Name = "lblCdMotor";
            this.lblCdMotor.Size = new System.Drawing.Size(85, 13);
            this.lblCdMotor.TabIndex = 11;
            this.lblCdMotor.Text = "Codigo do Motor";
            // 
            // txtCdMotorCompra
            // 
            this.txtCdMotorCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdMotorCompra.Location = new System.Drawing.Point(468, 110);
            this.txtCdMotorCompra.Name = "txtCdMotorCompra";
            this.txtCdMotorCompra.ReadOnly = true;
            this.txtCdMotorCompra.Size = new System.Drawing.Size(49, 20);
            this.txtCdMotorCompra.TabIndex = 9;
            this.txtCdMotorCompra.TabStop = false;
            // 
            // lblDtCompra
            // 
            this.lblDtCompra.AutoSize = true;
            this.lblDtCompra.Location = new System.Drawing.Point(96, 164);
            this.lblDtCompra.Name = "lblDtCompra";
            this.lblDtCompra.Size = new System.Drawing.Size(86, 13);
            this.lblDtCompra.TabIndex = 11;
            this.lblDtCompra.Text = "Data Da Compra";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(96, 243);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 11;
            this.lblObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.Location = new System.Drawing.Point(166, 241);
            this.txtObservacao.MaxLength = 20;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(391, 20);
            this.txtObservacao.TabIndex = 10;
            // 
            // lblQtdCompra
            // 
            this.lblQtdCompra.AutoSize = true;
            this.lblQtdCompra.Location = new System.Drawing.Point(96, 201);
            this.lblQtdCompra.Name = "lblQtdCompra";
            this.lblQtdCompra.Size = new System.Drawing.Size(116, 13);
            this.lblQtdCompra.TabIndex = 11;
            this.lblQtdCompra.Text = "Quantidade de Compra";
            // 
            // lblVlCompra
            // 
            this.lblVlCompra.AutoSize = true;
            this.lblVlCompra.Location = new System.Drawing.Point(337, 201);
            this.lblVlCompra.Name = "lblVlCompra";
            this.lblVlCompra.Size = new System.Drawing.Size(70, 13);
            this.lblVlCompra.TabIndex = 11;
            this.lblVlCompra.Text = "Valor Compra";
            // 
            // txtQtdCompra
            // 
            this.txtQtdCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdCompra.Location = new System.Drawing.Point(218, 199);
            this.txtQtdCompra.MaxLength = 5;
            this.txtQtdCompra.Name = "txtQtdCompra";
            this.txtQtdCompra.Size = new System.Drawing.Size(78, 20);
            this.txtQtdCompra.TabIndex = 8;
            // 
            // lblNtFiscal
            // 
            this.lblNtFiscal.AutoSize = true;
            this.lblNtFiscal.Location = new System.Drawing.Point(299, 164);
            this.lblNtFiscal.Name = "lblNtFiscal";
            this.lblNtFiscal.Size = new System.Drawing.Size(60, 13);
            this.lblNtFiscal.TabIndex = 11;
            this.lblNtFiscal.Text = "Nota Fiscal";
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotaFiscal.Location = new System.Drawing.Point(365, 161);
            this.txtNotaFiscal.MaxLength = 20;
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.Size = new System.Drawing.Size(192, 20);
            this.txtNotaFiscal.TabIndex = 7;
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceitar.BackgroundImage")));
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(6, 5);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(40, 35);
            this.btnAceitar.TabIndex = 11;
            this.toolTipLegenda.SetToolTip(this.btnAceitar, "Cadastrar");
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::TCC.Properties.Resources.trash_can;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(6, 46);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(40, 35);
            this.btnLimpar.TabIndex = 12;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Novo");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(6, 87);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(40, 35);
            this.btnVoltar.TabIndex = 13;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnBuscaFornecedor
            // 
            this.btnBuscaFornecedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaFornecedor.BackgroundImage")));
            this.btnBuscaFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaFornecedor.Location = new System.Drawing.Point(258, 44);
            this.btnBuscaFornecedor.Name = "btnBuscaFornecedor";
            this.btnBuscaFornecedor.Size = new System.Drawing.Size(34, 23);
            this.btnBuscaFornecedor.TabIndex = 1;
            this.toolTipLegenda.SetToolTip(this.btnBuscaFornecedor, "Buscar Fornecedor");
            this.btnBuscaFornecedor.UseVisualStyleBackColor = true;
            this.btnBuscaFornecedor.Click += new System.EventHandler(this.btnBuscaFornecedor_Click);
            // 
            // btnBuscaPeca
            // 
            this.btnBuscaPeca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaPeca.BackgroundImage")));
            this.btnBuscaPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaPeca.Location = new System.Drawing.Point(229, 73);
            this.btnBuscaPeca.Name = "btnBuscaPeca";
            this.btnBuscaPeca.Size = new System.Drawing.Size(34, 23);
            this.btnBuscaPeca.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnBuscaPeca, "Buscar Peça");
            this.btnBuscaPeca.UseVisualStyleBackColor = true;
            this.btnBuscaPeca.Click += new System.EventHandler(this.btnBuscaPeca_Click);
            // 
            // btnBuscaDepartamento
            // 
            this.btnBuscaDepartamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaDepartamento.BackgroundImage")));
            this.btnBuscaDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaDepartamento.Location = new System.Drawing.Point(523, 42);
            this.btnBuscaDepartamento.Name = "btnBuscaDepartamento";
            this.btnBuscaDepartamento.Size = new System.Drawing.Size(34, 23);
            this.btnBuscaDepartamento.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnBuscaDepartamento, "Buscar Departamento");
            this.btnBuscaDepartamento.UseVisualStyleBackColor = true;
            this.btnBuscaDepartamento.Click += new System.EventHandler(this.btnBuscaDepartamento_Click);
            // 
            // btnBuscaTipoProduto
            // 
            this.btnBuscaTipoProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaTipoProduto.BackgroundImage")));
            this.btnBuscaTipoProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaTipoProduto.Location = new System.Drawing.Point(523, 76);
            this.btnBuscaTipoProduto.Name = "btnBuscaTipoProduto";
            this.btnBuscaTipoProduto.Size = new System.Drawing.Size(34, 23);
            this.btnBuscaTipoProduto.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnBuscaTipoProduto, "Buscar Tipo do Produto");
            this.btnBuscaTipoProduto.UseVisualStyleBackColor = true;
            this.btnBuscaTipoProduto.Click += new System.EventHandler(this.btnBuscaTipoProduto_Click);
            // 
            // btnBuscaMotorCompra
            // 
            this.btnBuscaMotorCompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaMotorCompra.BackgroundImage")));
            this.btnBuscaMotorCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaMotorCompra.Location = new System.Drawing.Point(523, 107);
            this.btnBuscaMotorCompra.Name = "btnBuscaMotorCompra";
            this.btnBuscaMotorCompra.Size = new System.Drawing.Size(34, 23);
            this.btnBuscaMotorCompra.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnBuscaMotorCompra, "Buscar Motor");
            this.btnBuscaMotorCompra.UseVisualStyleBackColor = true;
            this.btnBuscaMotorCompra.Click += new System.EventHandler(this.btnBuscaMotorCompra_Click);
            // 
            // txtDataCompra
            // 
            this.txtDataCompra.Location = new System.Drawing.Point(188, 161);
            this.txtDataCompra.Mask = "00/00/0000";
            this.txtDataCompra.Name = "txtDataCompra";
            this.txtDataCompra.Size = new System.Drawing.Size(66, 20);
            this.txtDataCompra.TabIndex = 6;
            this.txtDataCompra.ValidatingType = typeof(System.DateTime);
            // 
            // txtVlCompra
            // 
            this.txtVlCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlCompra.Location = new System.Drawing.Point(413, 199);
            this.txtVlCompra.MaxLength = 17;
            this.txtVlCompra.Name = "txtVlCompra";
            this.txtVlCompra.Size = new System.Drawing.Size(144, 20);
            this.txtVlCompra.TabIndex = 9;
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.Properties.Resources.corel_draw;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(517, 282);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(40, 35);
            this.btnBuscaAlteracaoDelecao.TabIndex = 18;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar Registro");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            this.btnBuscaAlteracaoDelecao.Click += new System.EventHandler(this.btnBuscaAlteracaoDelecao_Click);
            // 
            // frmCadCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 368);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.txtVlCompra);
            this.Controls.Add(this.txtDataCompra);
            this.Controls.Add(this.btnBuscaMotorCompra);
            this.Controls.Add(this.btnBuscaTipoProduto);
            this.Controls.Add(this.btnBuscaDepartamento);
            this.Controls.Add(this.btnBuscaPeca);
            this.Controls.Add(this.btnBuscaFornecedor);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtNotaFiscal);
            this.Controls.Add(this.txtCdMotorCompra);
            this.Controls.Add(this.txtQtdCompra);
            this.Controls.Add(this.txtCdPeca);
            this.Controls.Add(this.txtCdTipoProduto);
            this.Controls.Add(this.txtCdFornecedor);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.lblDtCompra);
            this.Controls.Add(this.lblNtFiscal);
            this.Controls.Add(this.lblVlCompra);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.lblQtdCompra);
            this.Controls.Add(this.lblCdMotor);
            this.Controls.Add(this.lblCdPeca);
            this.Controls.Add(this.lblCdTipoProduto);
            this.Controls.Add(this.lblCdFornecedor);
            this.Controls.Add(this.lblCdDepartamento);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAceitar);
            this.MaximizeBox = false;
            this.Name = "frmCadCompra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.frmCadCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCdDepartamento;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label lblCdFornecedor;
        private System.Windows.Forms.TextBox txtCdFornecedor;
        private System.Windows.Forms.Label lblCdTipoProduto;
        private System.Windows.Forms.TextBox txtCdTipoProduto;
        private System.Windows.Forms.Label lblCdPeca;
        private System.Windows.Forms.TextBox txtCdPeca;
        private System.Windows.Forms.Label lblCdMotor;
        private System.Windows.Forms.TextBox txtCdMotorCompra;
        private System.Windows.Forms.Label lblDtCompra;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblQtdCompra;
        private System.Windows.Forms.Label lblVlCompra;
        private System.Windows.Forms.TextBox txtQtdCompra;
        private System.Windows.Forms.Label lblNtFiscal;
        private System.Windows.Forms.TextBox txtNotaFiscal;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnBuscaFornecedor;
        private System.Windows.Forms.Button btnBuscaPeca;
        private System.Windows.Forms.Button btnBuscaDepartamento;
        private System.Windows.Forms.Button btnBuscaTipoProduto;
        private System.Windows.Forms.Button btnBuscaMotorCompra;
        private System.Windows.Forms.MaskedTextBox txtDataCompra;
        private System.Windows.Forms.TextBox txtVlCompra;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
    }
}