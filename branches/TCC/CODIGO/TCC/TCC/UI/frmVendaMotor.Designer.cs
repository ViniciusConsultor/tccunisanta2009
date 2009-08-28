namespace TCC.UI
{
    partial class frmVendaMotor
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
            this.lblcdVendas = new System.Windows.Forms.Label();
            this.txtCodigoVenda = new System.Windows.Forms.TextBox();
            this.lblCdOrdemMotor = new System.Windows.Forms.Label();
            this.txtCdOrdemMotor = new System.Windows.Forms.TextBox();
            this.lblCdCliente = new System.Windows.Forms.Label();
            this.txtCdCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCdTipoProduto = new System.Windows.Forms.Label();
            this.txtCdTipoProduto = new System.Windows.Forms.TextBox();
            this.lblCdKit = new System.Windows.Forms.Label();
            this.txtCdKit = new System.Windows.Forms.TextBox();
            this.lblDtVenda = new System.Windows.Forms.Label();
            this.txtDataVenda = new System.Windows.Forms.TextBox();
            this.lblQtdVenda = new System.Windows.Forms.Label();
            this.txtQtdVenda = new System.Windows.Forms.TextBox();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.lblNotaFiscal = new System.Windows.Forms.Label();
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.lblDtSaida = new System.Windows.Forms.Label();
            this.txtDtSaida = new System.Windows.Forms.TextBox();
            this.btnInsere = new System.Windows.Forms.Button();
            this.btnDeleta = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcdVendas
            // 
            this.lblcdVendas.AutoSize = true;
            this.lblcdVendas.Location = new System.Drawing.Point(13, 13);
            this.lblcdVendas.Name = "lblcdVendas";
            this.lblcdVendas.Size = new System.Drawing.Size(89, 13);
            this.lblcdVendas.TabIndex = 0;
            this.lblcdVendas.Text = "Codigo de Venda";
            // 
            // txtCodigoVenda
            // 
            this.txtCodigoVenda.Location = new System.Drawing.Point(108, 10);
            this.txtCodigoVenda.Name = "txtCodigoVenda";
            this.txtCodigoVenda.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoVenda.TabIndex = 0;
            // 
            // lblCdOrdemMotor
            // 
            this.lblCdOrdemMotor.AutoSize = true;
            this.lblCdOrdemMotor.Location = new System.Drawing.Point(214, 13);
            this.lblCdOrdemMotor.Name = "lblCdOrdemMotor";
            this.lblCdOrdemMotor.Size = new System.Drawing.Size(119, 13);
            this.lblCdOrdemMotor.TabIndex = 0;
            this.lblCdOrdemMotor.Text = "Codigo da Ordem Motor";
            // 
            // txtCdOrdemMotor
            // 
            this.txtCdOrdemMotor.Location = new System.Drawing.Point(341, 6);
            this.txtCdOrdemMotor.Name = "txtCdOrdemMotor";
            this.txtCdOrdemMotor.Size = new System.Drawing.Size(100, 20);
            this.txtCdOrdemMotor.TabIndex = 2;
            // 
            // lblCdCliente
            // 
            this.lblCdCliente.AutoSize = true;
            this.lblCdCliente.Location = new System.Drawing.Point(12, 42);
            this.lblCdCliente.Name = "lblCdCliente";
            this.lblCdCliente.Size = new System.Drawing.Size(90, 13);
            this.lblCdCliente.TabIndex = 0;
            this.lblCdCliente.Text = "Codigo de Cliente";
            // 
            // txtCdCliente
            // 
            this.txtCdCliente.Location = new System.Drawing.Point(107, 39);
            this.txtCdCliente.Name = "txtCdCliente";
            this.txtCdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCdCliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo de Venda";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(341, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblCdTipoProduto
            // 
            this.lblCdTipoProduto.AutoSize = true;
            this.lblCdTipoProduto.Location = new System.Drawing.Point(13, 76);
            this.lblCdTipoProduto.Name = "lblCdTipoProduto";
            this.lblCdTipoProduto.Size = new System.Drawing.Size(136, 13);
            this.lblCdTipoProduto.TabIndex = 0;
            this.lblCdTipoProduto.Text = "Codigo do Tipo Do Produto";
            // 
            // txtCdTipoProduto
            // 
            this.txtCdTipoProduto.Location = new System.Drawing.Point(155, 73);
            this.txtCdTipoProduto.Name = "txtCdTipoProduto";
            this.txtCdTipoProduto.Size = new System.Drawing.Size(100, 20);
            this.txtCdTipoProduto.TabIndex = 5;
            // 
            // lblCdKit
            // 
            this.lblCdKit.AutoSize = true;
            this.lblCdKit.Location = new System.Drawing.Point(265, 76);
            this.lblCdKit.Name = "lblCdKit";
            this.lblCdKit.Size = new System.Drawing.Size(70, 13);
            this.lblCdKit.TabIndex = 0;
            this.lblCdKit.Text = "Codigo do Kit";
            // 
            // txtCdKit
            // 
            this.txtCdKit.Location = new System.Drawing.Point(341, 73);
            this.txtCdKit.Name = "txtCdKit";
            this.txtCdKit.Size = new System.Drawing.Size(100, 20);
            this.txtCdKit.TabIndex = 6;
            // 
            // lblDtVenda
            // 
            this.lblDtVenda.AutoSize = true;
            this.lblDtVenda.Location = new System.Drawing.Point(13, 106);
            this.lblDtVenda.Name = "lblDtVenda";
            this.lblDtVenda.Size = new System.Drawing.Size(81, 13);
            this.lblDtVenda.TabIndex = 0;
            this.lblDtVenda.Text = "Data De Venda";
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Location = new System.Drawing.Point(108, 103);
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(100, 20);
            this.txtDataVenda.TabIndex = 7;
            // 
            // lblQtdVenda
            // 
            this.lblQtdVenda.AutoSize = true;
            this.lblQtdVenda.Location = new System.Drawing.Point(222, 111);
            this.lblQtdVenda.Name = "lblQtdVenda";
            this.lblQtdVenda.Size = new System.Drawing.Size(111, 13);
            this.lblQtdVenda.TabIndex = 0;
            this.lblQtdVenda.Text = "Quantidade de Venda";
            // 
            // txtQtdVenda
            // 
            this.txtQtdVenda.Location = new System.Drawing.Point(341, 104);
            this.txtQtdVenda.Name = "txtQtdVenda";
            this.txtQtdVenda.Size = new System.Drawing.Size(100, 20);
            this.txtQtdVenda.TabIndex = 8;
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Location = new System.Drawing.Point(12, 141);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(64, 13);
            this.lblValorVenda.TabIndex = 0;
            this.lblValorVenda.Text = "valor Venda";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(107, 138);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(100, 20);
            this.txtValorVenda.TabIndex = 9;
            // 
            // lblNotaFiscal
            // 
            this.lblNotaFiscal.AutoSize = true;
            this.lblNotaFiscal.Location = new System.Drawing.Point(265, 144);
            this.lblNotaFiscal.Name = "lblNotaFiscal";
            this.lblNotaFiscal.Size = new System.Drawing.Size(60, 13);
            this.lblNotaFiscal.TabIndex = 0;
            this.lblNotaFiscal.Text = "Nota Fiscal";
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.Location = new System.Drawing.Point(341, 141);
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.Size = new System.Drawing.Size(100, 20);
            this.txtNotaFiscal.TabIndex = 10;
            // 
            // lblDtSaida
            // 
            this.lblDtSaida.AutoSize = true;
            this.lblDtSaida.Location = new System.Drawing.Point(13, 172);
            this.lblDtSaida.Name = "lblDtSaida";
            this.lblDtSaida.Size = new System.Drawing.Size(60, 13);
            this.lblDtSaida.TabIndex = 0;
            this.lblDtSaida.Text = "Data Saida";
            // 
            // txtDtSaida
            // 
            this.txtDtSaida.Location = new System.Drawing.Point(107, 169);
            this.txtDtSaida.Name = "txtDtSaida";
            this.txtDtSaida.Size = new System.Drawing.Size(101, 20);
            this.txtDtSaida.TabIndex = 11;
            // 
            // btnInsere
            // 
            this.btnInsere.Location = new System.Drawing.Point(107, 214);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(75, 23);
            this.btnInsere.TabIndex = 12;
            this.btnInsere.Text = "Insere";
            this.btnInsere.UseVisualStyleBackColor = true;
            // 
            // btnDeleta
            // 
            this.btnDeleta.Location = new System.Drawing.Point(225, 214);
            this.btnDeleta.Name = "btnDeleta";
            this.btnDeleta.Size = new System.Drawing.Size(75, 23);
            this.btnDeleta.TabIndex = 13;
            this.btnDeleta.Text = "Deleta";
            this.btnDeleta.UseVisualStyleBackColor = true;
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(341, 214);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 23);
            this.btnLimpa.TabIndex = 14;
            this.btnLimpa.Text = "Limpa";
            this.btnLimpa.UseVisualStyleBackColor = true;
            // 
            // frmVendaMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 252);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnDeleta);
            this.Controls.Add(this.btnInsere);
            this.Controls.Add(this.txtDtSaida);
            this.Controls.Add(this.txtNotaFiscal);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.txtQtdVenda);
            this.Controls.Add(this.txtDataVenda);
            this.Controls.Add(this.txtCdKit);
            this.Controls.Add(this.txtCdTipoProduto);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtCdCliente);
            this.Controls.Add(this.txtCdOrdemMotor);
            this.Controls.Add(this.lblDtSaida);
            this.Controls.Add(this.txtCodigoVenda);
            this.Controls.Add(this.lblNotaFiscal);
            this.Controls.Add(this.lblValorVenda);
            this.Controls.Add(this.lblQtdVenda);
            this.Controls.Add(this.lblDtVenda);
            this.Controls.Add(this.lblCdKit);
            this.Controls.Add(this.lblCdTipoProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCdCliente);
            this.Controls.Add(this.lblCdOrdemMotor);
            this.Controls.Add(this.lblcdVendas);
            this.Name = "frmVendaMotor";
            this.Text = "Venda Motor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcdVendas;
        private System.Windows.Forms.TextBox txtCodigoVenda;
        private System.Windows.Forms.Label lblCdOrdemMotor;
        private System.Windows.Forms.TextBox txtCdOrdemMotor;
        private System.Windows.Forms.Label lblCdCliente;
        private System.Windows.Forms.TextBox txtCdCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCdTipoProduto;
        private System.Windows.Forms.TextBox txtCdTipoProduto;
        private System.Windows.Forms.Label lblCdKit;
        private System.Windows.Forms.TextBox txtCdKit;
        private System.Windows.Forms.Label lblDtVenda;
        private System.Windows.Forms.TextBox txtDataVenda;
        private System.Windows.Forms.Label lblQtdVenda;
        private System.Windows.Forms.TextBox txtQtdVenda;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label lblNotaFiscal;
        private System.Windows.Forms.TextBox txtNotaFiscal;
        private System.Windows.Forms.Label lblDtSaida;
        private System.Windows.Forms.TextBox txtDtSaida;
        private System.Windows.Forms.Button btnInsere;
        private System.Windows.Forms.Button btnDeleta;
        private System.Windows.Forms.Button btnLimpa;
    }
}