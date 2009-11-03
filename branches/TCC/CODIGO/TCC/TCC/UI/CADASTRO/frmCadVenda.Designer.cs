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
            this.lblCdCliente = new System.Windows.Forms.Label();
            this.txtCdCliente = new System.Windows.Forms.TextBox();
            this.lblDtVenda = new System.Windows.Forms.Label();
            this.lblQtdVenda = new System.Windows.Forms.Label();
            this.txtQtdVenda = new System.Windows.Forms.TextBox();
            this.lblVlVenda = new System.Windows.Forms.Label();
            this.lblNotaFiscal = new System.Windows.Forms.Label();
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnCdCliente = new System.Windows.Forms.Button();
            this.txtDataVenda = new System.Windows.Forms.MaskedTextBox();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnPedidoVenda = new System.Windows.Forms.Button();
            this.btnOP = new System.Windows.Forms.Button();
            this.txtValorVenda = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.SuspendLayout();
            // 
            // lblCdCliente
            // 
            this.lblCdCliente.AutoSize = true;
            this.lblCdCliente.Location = new System.Drawing.Point(97, 18);
            this.lblCdCliente.Name = "lblCdCliente";
            this.lblCdCliente.Size = new System.Drawing.Size(85, 13);
            this.lblCdCliente.TabIndex = 0;
            this.lblCdCliente.Text = "Nome do Cliente";
            // 
            // txtCdCliente
            // 
            this.txtCdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdCliente.Location = new System.Drawing.Point(193, 16);
            this.txtCdCliente.Name = "txtCdCliente";
            this.txtCdCliente.ReadOnly = true;
            this.txtCdCliente.Size = new System.Drawing.Size(208, 20);
            this.txtCdCliente.TabIndex = 1;
            // 
            // lblDtVenda
            // 
            this.lblDtVenda.AutoSize = true;
            this.lblDtVenda.Location = new System.Drawing.Point(106, 63);
            this.lblDtVenda.Name = "lblDtVenda";
            this.lblDtVenda.Size = new System.Drawing.Size(79, 13);
            this.lblDtVenda.TabIndex = 2;
            this.lblDtVenda.Text = "Data de Venda";
            // 
            // lblQtdVenda
            // 
            this.lblQtdVenda.AutoSize = true;
            this.lblQtdVenda.Location = new System.Drawing.Point(323, 63);
            this.lblQtdVenda.Name = "lblQtdVenda";
            this.lblQtdVenda.Size = new System.Drawing.Size(111, 13);
            this.lblQtdVenda.TabIndex = 0;
            this.lblQtdVenda.Text = "Quantidade de Venda";
            // 
            // txtQtdVenda
            // 
            this.txtQtdVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdVenda.Location = new System.Drawing.Point(450, 61);
            this.txtQtdVenda.MaxLength = 5;
            this.txtQtdVenda.Name = "txtQtdVenda";
            this.txtQtdVenda.Size = new System.Drawing.Size(73, 20);
            this.txtQtdVenda.TabIndex = 1;
            // 
            // lblVlVenda
            // 
            this.lblVlVenda.AutoSize = true;
            this.lblVlVenda.Location = new System.Drawing.Point(106, 104);
            this.lblVlVenda.Name = "lblVlVenda";
            this.lblVlVenda.Size = new System.Drawing.Size(80, 13);
            this.lblVlVenda.TabIndex = 0;
            this.lblVlVenda.Text = "Valor da Venda";
            // 
            // lblNotaFiscal
            // 
            this.lblNotaFiscal.AutoSize = true;
            this.lblNotaFiscal.Location = new System.Drawing.Point(307, 104);
            this.lblNotaFiscal.Name = "lblNotaFiscal";
            this.lblNotaFiscal.Size = new System.Drawing.Size(60, 13);
            this.lblNotaFiscal.TabIndex = 0;
            this.lblNotaFiscal.Text = "Nota Fiscal";
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotaFiscal.Location = new System.Drawing.Point(375, 102);
            this.txtNotaFiscal.MaxLength = 20;
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.Size = new System.Drawing.Size(148, 20);
            this.txtNotaFiscal.TabIndex = 1;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = global::TCC.Properties.Resources.btnSalvar;
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
            this.btnLimpa.BackgroundImage = global::TCC.Properties.Resources.eraser;
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
            this.btnCdCliente.Location = new System.Drawing.Point(407, 14);
            this.btnCdCliente.Name = "btnCdCliente";
            this.btnCdCliente.Size = new System.Drawing.Size(27, 22);
            this.btnCdCliente.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnCdCliente, "Buscar Cliente");
            this.btnCdCliente.UseVisualStyleBackColor = true;
            this.btnCdCliente.Click += new System.EventHandler(this.btnCdCliente_Click);
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Location = new System.Drawing.Point(191, 60);
            this.txtDataVenda.Mask = "00/00/0000";
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(66, 20);
            this.txtDataVenda.TabIndex = 4;
            this.txtDataVenda.ValidatingType = typeof(System.DateTime);
            // 
            // btnPedidoVenda
            // 
            this.btnPedidoVenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPedidoVenda.BackgroundImage")));
            this.btnPedidoVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedidoVenda.Location = new System.Drawing.Point(353, 193);
            this.btnPedidoVenda.Name = "btnPedidoVenda";
            this.btnPedidoVenda.Size = new System.Drawing.Size(40, 35);
            this.btnPedidoVenda.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnPedidoVenda, "Item de Venda");
            this.btnPedidoVenda.UseVisualStyleBackColor = true;
            // 
            // btnOP
            // 
            this.btnOP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOP.BackgroundImage")));
            this.btnOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOP.Location = new System.Drawing.Point(231, 193);
            this.btnOP.Name = "btnOP";
            this.btnOP.Size = new System.Drawing.Size(40, 35);
            this.btnOP.TabIndex = 6;
            this.btnOP.UseVisualStyleBackColor = true;
            this.btnOP.Click += new System.EventHandler(this.btnOP_Click);
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorVenda.Location = new System.Drawing.Point(193, 102);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(100, 20);
            this.txtValorVenda.TabIndex = 7;
            this.txtValorVenda.TipoTexto = Controles.MegaTextBox.TipoTexto.Decimal;
            // 
            // frmCadVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 368);
            this.ControlBox = false;
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.btnOP);
            this.Controls.Add(this.btnPedidoVenda);
            this.Controls.Add(this.txtDataVenda);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnCdCliente);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.lblDtVenda);
            this.Controls.Add(this.txtNotaFiscal);
            this.Controls.Add(this.txtQtdVenda);
            this.Controls.Add(this.txtCdCliente);
            this.Controls.Add(this.lblNotaFiscal);
            this.Controls.Add(this.lblVlVenda);
            this.Controls.Add(this.lblQtdVenda);
            this.Controls.Add(this.lblCdCliente);
            this.MaximizeBox = false;
            this.Name = "frmCadVenda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.frmCadVenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCdCliente;
        private System.Windows.Forms.TextBox txtCdCliente;
        private System.Windows.Forms.Label lblDtVenda;
        private System.Windows.Forms.Label lblQtdVenda;
        private System.Windows.Forms.TextBox txtQtdVenda;
        private System.Windows.Forms.Label lblVlVenda;
        private System.Windows.Forms.Label lblNotaFiscal;
        private System.Windows.Forms.TextBox txtNotaFiscal;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnCdCliente;
        private System.Windows.Forms.MaskedTextBox txtDataVenda;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnPedidoVenda;
        private System.Windows.Forms.Button btnOP;
        private Controles.MegaTextBox.MegaTextBox txtValorVenda;
    }
}