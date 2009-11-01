namespace TCC.UI
{
    partial class frmCadVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadVenda));
            this.lblCdOrdemMotor = new System.Windows.Forms.Label();
            this.txtCdOrdemMotor = new System.Windows.Forms.TextBox();
            this.lblCdCliente = new System.Windows.Forms.Label();
            this.txtCdCliente = new System.Windows.Forms.TextBox();
            this.lblCdTipoProduto = new System.Windows.Forms.Label();
            this.txtCdTipoProduto = new System.Windows.Forms.TextBox();
            this.lblDtVenda = new System.Windows.Forms.Label();
            this.lblQtdVenda = new System.Windows.Forms.Label();
            this.txtQtdVenda = new System.Windows.Forms.TextBox();
            this.lblVlVenda = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.lblNotaFiscal = new System.Windows.Forms.Label();
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnCdCliente = new System.Windows.Forms.Button();
            this.btnCdOrdemMotor = new System.Windows.Forms.Button();
            this.CdTipoProduto = new System.Windows.Forms.Button();
            this.txtDataVenda = new System.Windows.Forms.MaskedTextBox();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnPedidoVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCdOrdemMotor
            // 
            this.lblCdOrdemMotor.AutoSize = true;
            this.lblCdOrdemMotor.Location = new System.Drawing.Point(102, 93);
            this.lblCdOrdemMotor.Name = "lblCdOrdemMotor";
            this.lblCdOrdemMotor.Size = new System.Drawing.Size(136, 13);
            this.lblCdOrdemMotor.TabIndex = 0;
            this.lblCdOrdemMotor.Text = "Codigo da ordem Produção";
            // 
            // txtCdOrdemMotor
            // 
            this.txtCdOrdemMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdOrdemMotor.Location = new System.Drawing.Point(244, 91);
            this.txtCdOrdemMotor.Name = "txtCdOrdemMotor";
            this.txtCdOrdemMotor.ReadOnly = true;
            this.txtCdOrdemMotor.Size = new System.Drawing.Size(121, 20);
            this.txtCdOrdemMotor.TabIndex = 1;
            // 
            // lblCdCliente
            // 
            this.lblCdCliente.AutoSize = true;
            this.lblCdCliente.Location = new System.Drawing.Point(102, 131);
            this.lblCdCliente.Name = "lblCdCliente";
            this.lblCdCliente.Size = new System.Drawing.Size(85, 13);
            this.lblCdCliente.TabIndex = 0;
            this.lblCdCliente.Text = "Nome do Cliente";
            // 
            // txtCdCliente
            // 
            this.txtCdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdCliente.Location = new System.Drawing.Point(198, 129);
            this.txtCdCliente.Name = "txtCdCliente";
            this.txtCdCliente.ReadOnly = true;
            this.txtCdCliente.Size = new System.Drawing.Size(73, 20);
            this.txtCdCliente.TabIndex = 1;
            // 
            // lblCdTipoProduto
            // 
            this.lblCdTipoProduto.AutoSize = true;
            this.lblCdTipoProduto.Location = new System.Drawing.Point(319, 131);
            this.lblCdTipoProduto.Name = "lblCdTipoProduto";
            this.lblCdTipoProduto.Size = new System.Drawing.Size(125, 13);
            this.lblCdTipoProduto.TabIndex = 0;
            this.lblCdTipoProduto.Text = "Nome do tipo do Produto";
            // 
            // txtCdTipoProduto
            // 
            this.txtCdTipoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdTipoProduto.Location = new System.Drawing.Point(455, 131);
            this.txtCdTipoProduto.Name = "txtCdTipoProduto";
            this.txtCdTipoProduto.ReadOnly = true;
            this.txtCdTipoProduto.Size = new System.Drawing.Size(64, 20);
            this.txtCdTipoProduto.TabIndex = 1;
            // 
            // lblDtVenda
            // 
            this.lblDtVenda.AutoSize = true;
            this.lblDtVenda.Location = new System.Drawing.Point(111, 194);
            this.lblDtVenda.Name = "lblDtVenda";
            this.lblDtVenda.Size = new System.Drawing.Size(79, 13);
            this.lblDtVenda.TabIndex = 2;
            this.lblDtVenda.Text = "Data de Venda";
            // 
            // lblQtdVenda
            // 
            this.lblQtdVenda.AutoSize = true;
            this.lblQtdVenda.Location = new System.Drawing.Point(328, 194);
            this.lblQtdVenda.Name = "lblQtdVenda";
            this.lblQtdVenda.Size = new System.Drawing.Size(111, 13);
            this.lblQtdVenda.TabIndex = 0;
            this.lblQtdVenda.Text = "Quantidade de Venda";
            // 
            // txtQtdVenda
            // 
            this.txtQtdVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdVenda.Location = new System.Drawing.Point(455, 192);
            this.txtQtdVenda.MaxLength = 5;
            this.txtQtdVenda.Name = "txtQtdVenda";
            this.txtQtdVenda.Size = new System.Drawing.Size(73, 20);
            this.txtQtdVenda.TabIndex = 1;
            // 
            // lblVlVenda
            // 
            this.lblVlVenda.AutoSize = true;
            this.lblVlVenda.Location = new System.Drawing.Point(111, 235);
            this.lblVlVenda.Name = "lblVlVenda";
            this.lblVlVenda.Size = new System.Drawing.Size(80, 13);
            this.lblVlVenda.TabIndex = 0;
            this.lblVlVenda.Text = "Valor da Venda";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorVenda.Location = new System.Drawing.Point(200, 233);
            this.txtValorVenda.MaxLength = 17;
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(80, 20);
            this.txtValorVenda.TabIndex = 1;
            // 
            // lblNotaFiscal
            // 
            this.lblNotaFiscal.AutoSize = true;
            this.lblNotaFiscal.Location = new System.Drawing.Point(312, 235);
            this.lblNotaFiscal.Name = "lblNotaFiscal";
            this.lblNotaFiscal.Size = new System.Drawing.Size(62, 13);
            this.lblNotaFiscal.TabIndex = 0;
            this.lblNotaFiscal.Text = "Noita Fiscal";
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotaFiscal.Location = new System.Drawing.Point(380, 233);
            this.txtNotaFiscal.MaxLength = 20;
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.Size = new System.Drawing.Size(148, 20);
            this.txtNotaFiscal.TabIndex = 1;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirma.BackgroundImage")));
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(7, 7);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(40, 35);
            this.btnConfirma.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnConfirma, "OK");
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackgroundImage = global::TCC.Properties.Resources.trash_can;
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpa.Location = new System.Drawing.Point(7, 48);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(40, 35);
            this.btnLimpa.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnLimpa, "Limpar");
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolta.BackgroundImage")));
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(7, 89);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(40, 35);
            this.btnVolta.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnVolta, "Fechar / Voltar");
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // btnCdCliente
            // 
            this.btnCdCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCdCliente.BackgroundImage")));
            this.btnCdCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdCliente.Location = new System.Drawing.Point(277, 129);
            this.btnCdCliente.Name = "btnCdCliente";
            this.btnCdCliente.Size = new System.Drawing.Size(27, 22);
            this.btnCdCliente.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnCdCliente, "Buscar Cliente");
            this.btnCdCliente.UseVisualStyleBackColor = true;
            this.btnCdCliente.Click += new System.EventHandler(this.btnCdCliente_Click);
            // 
            // btnCdOrdemMotor
            // 
            this.btnCdOrdemMotor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCdOrdemMotor.BackgroundImage")));
            this.btnCdOrdemMotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdOrdemMotor.Location = new System.Drawing.Point(371, 91);
            this.btnCdOrdemMotor.Name = "btnCdOrdemMotor";
            this.btnCdOrdemMotor.Size = new System.Drawing.Size(27, 22);
            this.btnCdOrdemMotor.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnCdOrdemMotor, "Buscar Ordem Produção");
            this.btnCdOrdemMotor.UseVisualStyleBackColor = true;
            this.btnCdOrdemMotor.Click += new System.EventHandler(this.btnCdOrdemMotor_Click);
            // 
            // CdTipoProduto
            // 
            this.CdTipoProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CdTipoProduto.BackgroundImage")));
            this.CdTipoProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CdTipoProduto.Location = new System.Drawing.Point(525, 131);
            this.CdTipoProduto.Name = "CdTipoProduto";
            this.CdTipoProduto.Size = new System.Drawing.Size(27, 22);
            this.CdTipoProduto.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.CdTipoProduto, "Buscar Tipo Produto");
            this.CdTipoProduto.UseVisualStyleBackColor = true;
            this.CdTipoProduto.Click += new System.EventHandler(this.CdTipoProduto_Click);
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Location = new System.Drawing.Point(196, 191);
            this.txtDataVenda.Mask = "00/00/0000";
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(66, 20);
            this.txtDataVenda.TabIndex = 4;
            this.txtDataVenda.ValidatingType = typeof(System.DateTime);
            // 
            // btnPedidoVenda
            // 
            this.btnPedidoVenda.Location = new System.Drawing.Point(437, 88);
            this.btnPedidoVenda.Name = "btnPedidoVenda";
            this.btnPedidoVenda.Size = new System.Drawing.Size(115, 23);
            this.btnPedidoVenda.TabIndex = 5;
            this.btnPedidoVenda.Text = "Items de Venda";
            this.btnPedidoVenda.UseVisualStyleBackColor = true;
            // 
            // frmCadVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 368);
            this.ControlBox = false;
            this.Controls.Add(this.btnPedidoVenda);
            this.Controls.Add(this.txtDataVenda);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.CdTipoProduto);
            this.Controls.Add(this.btnCdOrdemMotor);
            this.Controls.Add(this.btnCdCliente);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.lblDtVenda);
            this.Controls.Add(this.txtNotaFiscal);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.txtQtdVenda);
            this.Controls.Add(this.txtCdTipoProduto);
            this.Controls.Add(this.txtCdCliente);
            this.Controls.Add(this.txtCdOrdemMotor);
            this.Controls.Add(this.lblNotaFiscal);
            this.Controls.Add(this.lblVlVenda);
            this.Controls.Add(this.lblQtdVenda);
            this.Controls.Add(this.lblCdTipoProduto);
            this.Controls.Add(this.lblCdCliente);
            this.Controls.Add(this.lblCdOrdemMotor);
            this.MaximizeBox = false;
            this.Name = "frmCadVenda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.frmCadVenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCdOrdemMotor;
        private System.Windows.Forms.TextBox txtCdOrdemMotor;
        private System.Windows.Forms.Label lblCdCliente;
        private System.Windows.Forms.TextBox txtCdCliente;
        private System.Windows.Forms.Label lblCdTipoProduto;
        private System.Windows.Forms.TextBox txtCdTipoProduto;
        private System.Windows.Forms.Label lblDtVenda;
        private System.Windows.Forms.Label lblQtdVenda;
        private System.Windows.Forms.TextBox txtQtdVenda;
        private System.Windows.Forms.Label lblVlVenda;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label lblNotaFiscal;
        private System.Windows.Forms.TextBox txtNotaFiscal;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnCdCliente;
        private System.Windows.Forms.Button btnCdOrdemMotor;
        private System.Windows.Forms.Button CdTipoProduto;
        private System.Windows.Forms.MaskedTextBox txtDataVenda;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnPedidoVenda;
    }
}