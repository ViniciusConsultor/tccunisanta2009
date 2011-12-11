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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.btnBuscaFornecedor = new System.Windows.Forms.Button();
            this.btnBuscarItemDtGrid = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAdicionaItem = new System.Windows.Forms.Button();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtValor = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.lblValor = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbOrdemCompra = new System.Windows.Forms.GroupBox();
            this.txtBuscaFiltro = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtQtdItem = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.hId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNomeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hFlg_motor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQtdPeca = new System.Windows.Forms.Label();
            this.rdbMotor = new System.Windows.Forms.RadioButton();
            this.rdbPeca = new System.Windows.Forms.RadioButton();
            this.txtDataCompra = new System.Windows.Forms.MaskedTextBox();
            this.gpbOrdemCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(8, 57);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(53, 43);
            this.btnLimpar.TabIndex = 14;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(8, 158);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(53, 43);
            this.btnVoltar.TabIndex = 16;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(8, 107);
            this.btnBuscaAlteracaoDelecao.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(53, 43);
            this.btnBuscaAlteracaoDelecao.TabIndex = 15;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(8, 6);
            this.btnAceitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(53, 43);
            this.btnAceitar.TabIndex = 13;
            this.toolTipLegenda.SetToolTip(this.btnAceitar, "Cadastrar");
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // btnBuscaFornecedor
            // 
            this.btnBuscaFornecedor.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscaFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaFornecedor.Location = new System.Drawing.Point(303, 98);
            this.btnBuscaFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscaFornecedor.Name = "btnBuscaFornecedor";
            this.btnBuscaFornecedor.Size = new System.Drawing.Size(36, 28);
            this.btnBuscaFornecedor.TabIndex = 9;
            this.toolTipLegenda.SetToolTip(this.btnBuscaFornecedor, "Buscar Fornecedor");
            this.btnBuscaFornecedor.UseVisualStyleBackColor = true;
            this.btnBuscaFornecedor.Click += new System.EventHandler(this.btnBuscaFornecedor_Click);
            // 
            // btnBuscarItemDtGrid
            // 
            this.btnBuscarItemDtGrid.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscarItemDtGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarItemDtGrid.Location = new System.Drawing.Point(303, 47);
            this.btnBuscarItemDtGrid.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarItemDtGrid.Name = "btnBuscarItemDtGrid";
            this.btnBuscarItemDtGrid.Size = new System.Drawing.Size(36, 28);
            this.btnBuscarItemDtGrid.TabIndex = 7;
            this.toolTipLegenda.SetToolTip(this.btnBuscarItemDtGrid, "Buscar Itens");
            this.btnBuscarItemDtGrid.UseVisualStyleBackColor = true;
            this.btnBuscarItemDtGrid.Click += new System.EventHandler(this.btnBuscarItemDtGrid_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackgroundImage = global::TCC.resImg.btnLess;
            this.btnRemoveItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveItem.Location = new System.Drawing.Point(587, 100);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(36, 28);
            this.btnRemoveItem.TabIndex = 12;
            this.toolTipLegenda.SetToolTip(this.btnRemoveItem, "Remover Item");
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAdicionaItem
            // 
            this.btnAdicionaItem.BackgroundImage = global::TCC.resImg.btnAdd_;
            this.btnAdicionaItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionaItem.Location = new System.Drawing.Point(543, 100);
            this.btnAdicionaItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionaItem.Name = "btnAdicionaItem";
            this.btnAdicionaItem.Size = new System.Drawing.Size(36, 28);
            this.btnAdicionaItem.TabIndex = 11;
            this.toolTipLegenda.SetToolTip(this.btnAdicionaItem, "Adicionar Item");
            this.btnAdicionaItem.UseVisualStyleBackColor = true;
            this.btnAdicionaItem.Click += new System.EventHandler(this.btnAdicionaItem_Click);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(115, 22);
            this.lblObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(85, 17);
            this.lblObs.TabIndex = 20;
            this.lblObs.Text = "Observação";
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Location = new System.Drawing.Point(492, 57);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.MaxLength = 14;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(113, 22);
            this.txtValor.TabIndex = 2;
            this.txtValor.TipoTexto = Controles.MegaTextBox.TipoTexto.Decimal;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(488, 36);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(45, 17);
            this.lblValor.TabIndex = 22;
            this.lblValor.Text = "Preço";
            // 
            // txtObs
            // 
            this.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObs.Location = new System.Drawing.Point(117, 42);
            this.txtObs.Margin = new System.Windows.Forms.Padding(4);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(355, 41);
            this.txtObs.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Data da Compra";
            // 
            // gpbOrdemCompra
            // 
            this.gpbOrdemCompra.Controls.Add(this.btnBuscaFornecedor);
            this.gpbOrdemCompra.Controls.Add(this.txtBuscaFiltro);
            this.gpbOrdemCompra.Controls.Add(this.btnBuscarItemDtGrid);
            this.gpbOrdemCompra.Controls.Add(this.txtFornecedor);
            this.gpbOrdemCompra.Controls.Add(this.lblFornecedor);
            this.gpbOrdemCompra.Controls.Add(this.txtQtdItem);
            this.gpbOrdemCompra.Controls.Add(this.btnRemoveItem);
            this.gpbOrdemCompra.Controls.Add(this.btnAdicionaItem);
            this.gpbOrdemCompra.Controls.Add(this.dgItems);
            this.gpbOrdemCompra.Controls.Add(this.lblQtdPeca);
            this.gpbOrdemCompra.Controls.Add(this.rdbMotor);
            this.gpbOrdemCompra.Controls.Add(this.rdbPeca);
            this.gpbOrdemCompra.Location = new System.Drawing.Point(117, 107);
            this.gpbOrdemCompra.Margin = new System.Windows.Forms.Padding(4);
            this.gpbOrdemCompra.Name = "gpbOrdemCompra";
            this.gpbOrdemCompra.Padding = new System.Windows.Forms.Padding(4);
            this.gpbOrdemCompra.Size = new System.Drawing.Size(656, 331);
            this.gpbOrdemCompra.TabIndex = 4;
            this.gpbOrdemCompra.TabStop = false;
            this.gpbOrdemCompra.Text = "Ordem de Compra";
            // 
            // txtBuscaFiltro
            // 
            this.txtBuscaFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscaFiltro.Enabled = false;
            this.txtBuscaFiltro.Location = new System.Drawing.Point(40, 50);
            this.txtBuscaFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscaFiltro.MaxLength = 25;
            this.txtBuscaFiltro.Name = "txtBuscaFiltro";
            this.txtBuscaFiltro.ReadOnly = true;
            this.txtBuscaFiltro.Size = new System.Drawing.Size(253, 22);
            this.txtBuscaFiltro.TabIndex = 6;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(40, 100);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtFornecedor.Multiline = true;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.ReadOnly = true;
            this.txtFornecedor.Size = new System.Drawing.Size(253, 25);
            this.txtFornecedor.TabIndex = 8;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(36, 79);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(81, 17);
            this.lblFornecedor.TabIndex = 35;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // txtQtdItem
            // 
            this.txtQtdItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdItem.Location = new System.Drawing.Point(347, 102);
            this.txtQtdItem.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdItem.MaxLength = 4;
            this.txtQtdItem.Name = "txtQtdItem";
            this.txtQtdItem.Size = new System.Drawing.Size(187, 22);
            this.txtQtdItem.TabIndex = 10;
            this.txtQtdItem.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.AllowUserToResizeColumns = false;
            this.dgItems.AllowUserToResizeRows = false;
            this.dgItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hId,
            this.hNomeItem,
            this.hFornecedor,
            this.hQuantidade,
            this.hFlg_motor});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgItems.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgItems.Location = new System.Drawing.Point(40, 135);
            this.dgItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgItems.MultiSelect = false;
            this.dgItems.Name = "dgItems";
            this.dgItems.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItems.ShowEditingIcon = false;
            this.dgItems.Size = new System.Drawing.Size(583, 188);
            this.dgItems.TabIndex = 45;
            // 
            // hId
            // 
            this.hId.DataPropertyName = "id_item";
            this.hId.HeaderText = "ID";
            this.hId.Name = "hId";
            this.hId.ReadOnly = true;
            this.hId.Visible = false;
            this.hId.Width = 43;
            // 
            // hNomeItem
            // 
            this.hNomeItem.DataPropertyName = "item";
            this.hNomeItem.HeaderText = "Item";
            this.hNomeItem.Name = "hNomeItem";
            this.hNomeItem.ReadOnly = true;
            this.hNomeItem.Width = 59;
            // 
            // hFornecedor
            // 
            this.hFornecedor.DataPropertyName = "fornecedor";
            this.hFornecedor.HeaderText = "Fornecedor";
            this.hFornecedor.Name = "hFornecedor";
            this.hFornecedor.ReadOnly = true;
            this.hFornecedor.Width = 106;
            // 
            // hQuantidade
            // 
            this.hQuantidade.DataPropertyName = "quantidade";
            this.hQuantidade.HeaderText = "Quantidade";
            this.hQuantidade.Name = "hQuantidade";
            this.hQuantidade.ReadOnly = true;
            this.hQuantidade.Width = 107;
            // 
            // hFlg_motor
            // 
            this.hFlg_motor.DataPropertyName = "flg_motor";
            this.hFlg_motor.HeaderText = "flg_motor";
            this.hFlg_motor.Name = "hFlg_motor";
            this.hFlg_motor.ReadOnly = true;
            this.hFlg_motor.Visible = false;
            this.hFlg_motor.Width = 75;
            // 
            // lblQtdPeca
            // 
            this.lblQtdPeca.AutoSize = true;
            this.lblQtdPeca.Location = new System.Drawing.Point(343, 82);
            this.lblQtdPeca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdPeca.Name = "lblQtdPeca";
            this.lblQtdPeca.Size = new System.Drawing.Size(82, 17);
            this.lblQtdPeca.TabIndex = 46;
            this.lblQtdPeca.Text = "Quantidade";
            // 
            // rdbMotor
            // 
            this.rdbMotor.AutoSize = true;
            this.rdbMotor.Location = new System.Drawing.Point(107, 27);
            this.rdbMotor.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMotor.Name = "rdbMotor";
            this.rdbMotor.Size = new System.Drawing.Size(65, 21);
            this.rdbMotor.TabIndex = 5;
            this.rdbMotor.Text = "Motor";
            this.rdbMotor.UseVisualStyleBackColor = true;
            // 
            // rdbPeca
            // 
            this.rdbPeca.AutoSize = true;
            this.rdbPeca.Checked = true;
            this.rdbPeca.Location = new System.Drawing.Point(40, 27);
            this.rdbPeca.Margin = new System.Windows.Forms.Padding(4);
            this.rdbPeca.Name = "rdbPeca";
            this.rdbPeca.Size = new System.Drawing.Size(61, 21);
            this.rdbPeca.TabIndex = 4;
            this.rdbPeca.TabStop = true;
            this.rdbPeca.Text = "Peça";
            this.rdbPeca.UseVisualStyleBackColor = true;
            // 
            // txtDataCompra
            // 
            this.txtDataCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataCompra.Location = new System.Drawing.Point(632, 55);
            this.txtDataCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataCompra.Mask = "00/00/0000";
            this.txtDataCompra.Name = "txtDataCompra";
            this.txtDataCompra.Size = new System.Drawing.Size(94, 22);
            this.txtDataCompra.TabIndex = 3;
            this.txtDataCompra.ValidatingType = typeof(System.DateTime);
            // 
            // frmCadCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 463);
            this.ControlBox = false;
            this.Controls.Add(this.txtDataCompra);
            this.Controls.Add(this.gpbOrdemCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAceitar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCadCompra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.frmCadCompra_Load);
            this.gpbOrdemCompra.ResumeLayout(false);
            this.gpbOrdemCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private System.Windows.Forms.Label lblObs;
        private Controles.MegaTextBox.MegaTextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbOrdemCompra;
        private System.Windows.Forms.Button btnBuscaFornecedor;
        private System.Windows.Forms.TextBox txtBuscaFiltro;
        private System.Windows.Forms.Button btnBuscarItemDtGrid;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private Controles.MegaTextBox.MegaTextBox txtQtdItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAdicionaItem;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.Label lblQtdPeca;
        private System.Windows.Forms.RadioButton rdbMotor;
        private System.Windows.Forms.RadioButton rdbPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn hId;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNomeItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn hFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn hFlg_motor;
        private System.Windows.Forms.MaskedTextBox txtDataCompra;
    }
}