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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCdCliente = new System.Windows.Forms.Label();
            this.txtCdCliente = new System.Windows.Forms.TextBox();
            this.lblDtVenda = new System.Windows.Forms.Label();
            this.lblVlVenda = new System.Windows.Forms.Label();
            this.lblNotaFiscal = new System.Windows.Forms.Label();
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnCdCliente = new System.Windows.Forms.Button();
            this.txtDataVenda = new System.Windows.Forms.MaskedTextBox();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnOP = new System.Windows.Forms.Button();
            this.btnAdicionaProdutos = new System.Windows.Forms.Button();
            this.txtValorVenda = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.gbBuscaItem = new System.Windows.Forms.GroupBox();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.hId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscaFiltro = new System.Windows.Forms.TextBox();
            this.lblQtdPeca = new System.Windows.Forms.Label();
            this.txtQtdProdutos = new System.Windows.Forms.TextBox();
            this.btnBuscarItemDtGrid = new System.Windows.Forms.Button();
            this.lblNmProduto = new System.Windows.Forms.Label();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.TxtNmProduto = new System.Windows.Forms.TextBox();
            this.lblTipoProduto = new System.Windows.Forms.Label();
            this.cboTipoProduto = new System.Windows.Forms.ComboBox();
            this.gbBuscaItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
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
            this.lblDtVenda.Location = new System.Drawing.Point(97, 63);
            this.lblDtVenda.Name = "lblDtVenda";
            this.lblDtVenda.Size = new System.Drawing.Size(79, 13);
            this.lblDtVenda.TabIndex = 2;
            this.lblDtVenda.Text = "Data de Venda";
            // 
            // lblVlVenda
            // 
            this.lblVlVenda.AutoSize = true;
            this.lblVlVenda.Location = new System.Drawing.Point(97, 109);
            this.lblVlVenda.Name = "lblVlVenda";
            this.lblVlVenda.Size = new System.Drawing.Size(107, 13);
            this.lblVlVenda.TabIndex = 0;
            this.lblVlVenda.Text = "Valor Total da Venda";
            // 
            // lblNotaFiscal
            // 
            this.lblNotaFiscal.AutoSize = true;
            this.lblNotaFiscal.Location = new System.Drawing.Point(323, 104);
            this.lblNotaFiscal.Name = "lblNotaFiscal";
            this.lblNotaFiscal.Size = new System.Drawing.Size(60, 13);
            this.lblNotaFiscal.TabIndex = 0;
            this.lblNotaFiscal.Text = "Nota Fiscal";
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotaFiscal.Location = new System.Drawing.Point(438, 102);
            this.txtNotaFiscal.MaxLength = 20;
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.Size = new System.Drawing.Size(133, 20);
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
            this.btnCdCliente.Location = new System.Drawing.Point(438, 7);
            this.btnCdCliente.Name = "btnCdCliente";
            this.btnCdCliente.Size = new System.Drawing.Size(40, 35);
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
            // btnOP
            // 
            this.btnOP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOP.BackgroundImage")));
            this.btnOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOP.Location = new System.Drawing.Point(531, 7);
            this.btnOP.Name = "btnOP";
            this.btnOP.Size = new System.Drawing.Size(40, 35);
            this.btnOP.TabIndex = 6;
            this.toolTipLegenda.SetToolTip(this.btnOP, "Gerar Ordem de Produção");
            this.btnOP.UseVisualStyleBackColor = true;
            // 
            // btnAdicionaProdutos
            // 
            this.btnAdicionaProdutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionaProdutos.BackgroundImage")));
            this.btnAdicionaProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionaProdutos.Location = new System.Drawing.Point(31, 183);
            this.btnAdicionaProdutos.Name = "btnAdicionaProdutos";
            this.btnAdicionaProdutos.Size = new System.Drawing.Size(40, 35);
            this.btnAdicionaProdutos.TabIndex = 22;
            this.toolTipLegenda.SetToolTip(this.btnAdicionaProdutos, "Adiciona ITem");
            this.btnAdicionaProdutos.UseVisualStyleBackColor = true;
            this.btnAdicionaProdutos.Click += new System.EventHandler(this.btnAdicionaProdutos_Click);
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorVenda.Location = new System.Drawing.Point(201, 102);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(100, 20);
            this.txtValorVenda.TabIndex = 7;
            this.txtValorVenda.TipoTexto = Controles.MegaTextBox.TipoTexto.Texto;
            // 
            // gbBuscaItem
            // 
            this.gbBuscaItem.Controls.Add(this.cboTipoProduto);
            this.gbBuscaItem.Controls.Add(this.lblTipoProduto);
            this.gbBuscaItem.Controls.Add(this.btnAdicionaProdutos);
            this.gbBuscaItem.Controls.Add(this.dgProdutos);
            this.gbBuscaItem.Controls.Add(this.txtBuscaFiltro);
            this.gbBuscaItem.Controls.Add(this.lblQtdPeca);
            this.gbBuscaItem.Controls.Add(this.txtQtdProdutos);
            this.gbBuscaItem.Controls.Add(this.btnBuscarItemDtGrid);
            this.gbBuscaItem.Controls.Add(this.lblNmProduto);
            this.gbBuscaItem.Controls.Add(this.rdbNome);
            this.gbBuscaItem.Controls.Add(this.rdbCodigo);
            this.gbBuscaItem.Controls.Add(this.TxtNmProduto);
            this.gbBuscaItem.Location = new System.Drawing.Point(82, 128);
            this.gbBuscaItem.Name = "gbBuscaItem";
            this.gbBuscaItem.Size = new System.Drawing.Size(498, 238);
            this.gbBuscaItem.TabIndex = 11;
            this.gbBuscaItem.TabStop = false;
            this.gbBuscaItem.Text = "Produtos da Venda";
            // 
            // dgProdutos
            // 
            this.dgProdutos.AllowUserToAddRows = false;
            this.dgProdutos.AllowUserToDeleteRows = false;
            this.dgProdutos.AllowUserToResizeColumns = false;
            this.dgProdutos.AllowUserToResizeRows = false;
            this.dgProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hId,
            this.hCodigo,
            this.hNome,
            this.hQtd});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProdutos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgProdutos.Location = new System.Drawing.Point(172, 55);
            this.dgProdutos.MultiSelect = false;
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdutos.ShowEditingIcon = false;
            this.dgProdutos.Size = new System.Drawing.Size(295, 177);
            this.dgProdutos.TabIndex = 21;
            // 
            // hId
            // 
            this.hId.DataPropertyName = "Id";
            this.hId.HeaderText = "Id";
            this.hId.Name = "hId";
            this.hId.ReadOnly = true;
            this.hId.Visible = false;
            this.hId.Width = 41;
            // 
            // hCodigo
            // 
            this.hCodigo.DataPropertyName = "Codigo";
            this.hCodigo.HeaderText = "Codigo";
            this.hCodigo.Name = "hCodigo";
            this.hCodigo.ReadOnly = true;
            this.hCodigo.Width = 65;
            // 
            // hNome
            // 
            this.hNome.DataPropertyName = "Nome";
            this.hNome.HeaderText = "Nome";
            this.hNome.Name = "hNome";
            this.hNome.ReadOnly = true;
            this.hNome.Width = 60;
            // 
            // hQtd
            // 
            this.hQtd.DataPropertyName = "Qtd";
            this.hQtd.HeaderText = "Quantidade";
            this.hQtd.Name = "hQtd";
            this.hQtd.ReadOnly = true;
            this.hQtd.Width = 87;
            // 
            // txtBuscaFiltro
            // 
            this.txtBuscaFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscaFiltro.Location = new System.Drawing.Point(216, 32);
            this.txtBuscaFiltro.MaxLength = 20;
            this.txtBuscaFiltro.Name = "txtBuscaFiltro";
            this.txtBuscaFiltro.Size = new System.Drawing.Size(179, 20);
            this.txtBuscaFiltro.TabIndex = 15;
            // 
            // lblQtdPeca
            // 
            this.lblQtdPeca.AutoSize = true;
            this.lblQtdPeca.Location = new System.Drawing.Point(28, 127);
            this.lblQtdPeca.Name = "lblQtdPeca";
            this.lblQtdPeca.Size = new System.Drawing.Size(62, 13);
            this.lblQtdPeca.TabIndex = 18;
            this.lblQtdPeca.Text = "Quantidade";
            // 
            // txtQtdProdutos
            // 
            this.txtQtdProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdProdutos.Location = new System.Drawing.Point(31, 143);
            this.txtQtdProdutos.MaxLength = 20;
            this.txtQtdProdutos.Name = "txtQtdProdutos";
            this.txtQtdProdutos.Size = new System.Drawing.Size(102, 20);
            this.txtQtdProdutos.TabIndex = 16;
            // 
            // btnBuscarItemDtGrid
            // 
            this.btnBuscarItemDtGrid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarItemDtGrid.BackgroundImage")));
            this.btnBuscarItemDtGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarItemDtGrid.Location = new System.Drawing.Point(394, 18);
            this.btnBuscarItemDtGrid.Name = "btnBuscarItemDtGrid";
            this.btnBuscarItemDtGrid.Size = new System.Drawing.Size(40, 35);
            this.btnBuscarItemDtGrid.TabIndex = 13;
            this.btnBuscarItemDtGrid.UseVisualStyleBackColor = true;
            this.btnBuscarItemDtGrid.Click += new System.EventHandler(this.btnBuscarItemDtGrid_Click);
            // 
            // lblNmProduto
            // 
            this.lblNmProduto.AutoSize = true;
            this.lblNmProduto.Location = new System.Drawing.Point(28, 78);
            this.lblNmProduto.Name = "lblNmProduto";
            this.lblNmProduto.Size = new System.Drawing.Size(35, 13);
            this.lblNmProduto.TabIndex = 17;
            this.lblNmProduto.Text = "Nome";
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(279, 15);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(53, 17);
            this.rdbNome.TabIndex = 20;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Checked = true;
            this.rdbCodigo.Location = new System.Drawing.Point(215, 15);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(58, 17);
            this.rdbCodigo.TabIndex = 19;
            this.rdbCodigo.TabStop = true;
            this.rdbCodigo.Text = "Codigo";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            // 
            // TxtNmProduto
            // 
            this.TxtNmProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNmProduto.Location = new System.Drawing.Point(31, 94);
            this.TxtNmProduto.MaxLength = 20;
            this.TxtNmProduto.Name = "TxtNmProduto";
            this.TxtNmProduto.Size = new System.Drawing.Size(102, 20);
            this.TxtNmProduto.TabIndex = 14;
            // 
            // lblTipoProduto
            // 
            this.lblTipoProduto.AutoSize = true;
            this.lblTipoProduto.Location = new System.Drawing.Point(28, 19);
            this.lblTipoProduto.Name = "lblTipoProduto";
            this.lblTipoProduto.Size = new System.Drawing.Size(68, 13);
            this.lblTipoProduto.TabIndex = 24;
            this.lblTipoProduto.Text = "Tipo Produto";
            // 
            // cboTipoProduto
            // 
            this.cboTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboTipoProduto.Location = new System.Drawing.Point(31, 35);
            this.cboTipoProduto.Name = "cboTipoProduto";
            this.cboTipoProduto.Size = new System.Drawing.Size(91, 21);
            this.cboTipoProduto.TabIndex = 15;
            // 
            // frmCadVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 368);
            this.ControlBox = false;
            this.Controls.Add(this.gbBuscaItem);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.btnOP);
            this.Controls.Add(this.txtDataVenda);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnCdCliente);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.lblDtVenda);
            this.Controls.Add(this.txtNotaFiscal);
            this.Controls.Add(this.txtCdCliente);
            this.Controls.Add(this.lblNotaFiscal);
            this.Controls.Add(this.lblVlVenda);
            this.Controls.Add(this.lblCdCliente);
            this.MaximizeBox = false;
            this.Name = "frmCadVenda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.frmCadVenda_Load);
            this.gbBuscaItem.ResumeLayout(false);
            this.gbBuscaItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCdCliente;
        private System.Windows.Forms.TextBox txtCdCliente;
        private System.Windows.Forms.Label lblDtVenda;
        private System.Windows.Forms.Label lblVlVenda;
        private System.Windows.Forms.Label lblNotaFiscal;
        private System.Windows.Forms.TextBox txtNotaFiscal;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnCdCliente;
        private System.Windows.Forms.MaskedTextBox txtDataVenda;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnOP;
        private Controles.MegaTextBox.MegaTextBox txtValorVenda;
        private System.Windows.Forms.GroupBox gbBuscaItem;
        private System.Windows.Forms.Button btnAdicionaProdutos;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.TextBox txtBuscaFiltro;
        private System.Windows.Forms.Label lblQtdPeca;
        private System.Windows.Forms.TextBox txtQtdProdutos;
        private System.Windows.Forms.Button btnBuscarItemDtGrid;
        private System.Windows.Forms.Label lblNmProduto;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.TextBox TxtNmProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn hId;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQtd;
        private System.Windows.Forms.ComboBox cboTipoProduto;
        private System.Windows.Forms.Label lblTipoProduto;
    }
}