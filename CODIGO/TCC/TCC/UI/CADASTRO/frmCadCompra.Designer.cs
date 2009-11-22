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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.btnAdicionaItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnBuscarItemDtGrid = new System.Windows.Forms.Button();
            this.btnBuscaFornecedor = new System.Windows.Forms.Button();
            this.rdbMotor = new System.Windows.Forms.RadioButton();
            this.rdbPeca = new System.Windows.Forms.RadioButton();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtValor = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.lblValor = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.txtUltimoPreco = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.lblValorAntigo = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblQtdPeca = new System.Windows.Forms.Label();
            this.txtQtdItem = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.txtDataCompra = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscaFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(6, 46);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(40, 35);
            this.btnLimpar.TabIndex = 14;
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
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(6, 87);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(40, 35);
            this.btnBuscaAlteracaoDelecao.TabIndex = 15;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(6, 5);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(40, 35);
            this.btnAceitar.TabIndex = 13;
            this.toolTipLegenda.SetToolTip(this.btnAceitar, "Cadastrar");
            this.btnAceitar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionaItem
            // 
            this.btnAdicionaItem.BackgroundImage = global::TCC.resImg.btnAdd_;
            this.btnAdicionaItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionaItem.Location = new System.Drawing.Point(474, 158);
            this.btnAdicionaItem.Name = "btnAdicionaItem";
            this.btnAdicionaItem.Size = new System.Drawing.Size(27, 23);
            this.btnAdicionaItem.TabIndex = 11;
            this.toolTipLegenda.SetToolTip(this.btnAdicionaItem, "Adicionar Item");
            this.btnAdicionaItem.UseVisualStyleBackColor = true;
            this.btnAdicionaItem.Click += new System.EventHandler(this.btnAdicionaItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackgroundImage = global::TCC.resImg.btnLess;
            this.btnRemoveItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveItem.Location = new System.Drawing.Point(507, 157);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(27, 23);
            this.btnRemoveItem.TabIndex = 12;
            this.toolTipLegenda.SetToolTip(this.btnRemoveItem, "Remover Item");
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // btnBuscarItemDtGrid
            // 
            this.btnBuscarItemDtGrid.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscarItemDtGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarItemDtGrid.Location = new System.Drawing.Point(507, 76);
            this.btnBuscarItemDtGrid.Name = "btnBuscarItemDtGrid";
            this.btnBuscarItemDtGrid.Size = new System.Drawing.Size(27, 23);
            this.btnBuscarItemDtGrid.TabIndex = 8;
            this.toolTipLegenda.SetToolTip(this.btnBuscarItemDtGrid, "Buscar Itens");
            this.btnBuscarItemDtGrid.UseVisualStyleBackColor = true;
            this.btnBuscarItemDtGrid.Click += new System.EventHandler(this.btnBuscarItemDtGrid_Click);
            // 
            // btnBuscaFornecedor
            // 
            this.btnBuscaFornecedor.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscaFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaFornecedor.Location = new System.Drawing.Point(507, 114);
            this.btnBuscaFornecedor.Name = "btnBuscaFornecedor";
            this.btnBuscaFornecedor.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaFornecedor.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnBuscaFornecedor, "Buscar Fornecedor");
            this.btnBuscaFornecedor.UseVisualStyleBackColor = true;
            this.btnBuscaFornecedor.Click += new System.EventHandler(this.btnBuscaFornecedor_Click);
            // 
            // rdbMotor
            // 
            this.rdbMotor.AutoSize = true;
            this.rdbMotor.Location = new System.Drawing.Point(367, 57);
            this.rdbMotor.Name = "rdbMotor";
            this.rdbMotor.Size = new System.Drawing.Size(52, 17);
            this.rdbMotor.TabIndex = 6;
            this.rdbMotor.Text = "Motor";
            this.rdbMotor.UseVisualStyleBackColor = true;
            // 
            // rdbPeca
            // 
            this.rdbPeca.AutoSize = true;
            this.rdbPeca.Checked = true;
            this.rdbPeca.Location = new System.Drawing.Point(311, 57);
            this.rdbPeca.Name = "rdbPeca";
            this.rdbPeca.Size = new System.Drawing.Size(50, 17);
            this.rdbPeca.TabIndex = 6;
            this.rdbPeca.TabStop = true;
            this.rdbPeca.Text = "Peça";
            this.rdbPeca.UseVisualStyleBackColor = true;
            this.rdbPeca.CheckedChanged += new System.EventHandler(this.rdbPeca_CheckedChanged);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(116, 4);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(65, 13);
            this.lblObs.TabIndex = 20;
            this.lblObs.Text = "Observação";
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Location = new System.Drawing.Point(119, 76);
            this.txtValor.MaxLength = 2;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(85, 20);
            this.txtValor.TabIndex = 2;
            this.txtValor.TipoTexto = Controles.MegaTextBox.TipoTexto.Decimal;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(116, 59);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(35, 13);
            this.lblValor.TabIndex = 22;
            this.lblValor.Text = "Preço";
            // 
            // txtObs
            // 
            this.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObs.Location = new System.Drawing.Point(118, 20);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(417, 34);
            this.txtObs.TabIndex = 1;
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.AllowUserToResizeColumns = false;
            this.dgItems.AllowUserToResizeRows = false;
            this.dgItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgItems.Location = new System.Drawing.Point(118, 186);
            this.dgItems.MultiSelect = false;
            this.dgItems.Name = "dgItems";
            this.dgItems.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItems.ShowEditingIcon = false;
            this.dgItems.Size = new System.Drawing.Size(416, 177);
            this.dgItems.TabIndex = 27;
            // 
            // txtUltimoPreco
            // 
            this.txtUltimoPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUltimoPreco.Location = new System.Drawing.Point(119, 157);
            this.txtUltimoPreco.MaxLength = 2;
            this.txtUltimoPreco.Name = "txtUltimoPreco";
            this.txtUltimoPreco.Size = new System.Drawing.Size(107, 20);
            this.txtUltimoPreco.TabIndex = 9;
            this.txtUltimoPreco.TipoTexto = Controles.MegaTextBox.TipoTexto.Decimal;
            // 
            // lblValorAntigo
            // 
            this.lblValorAntigo.AutoSize = true;
            this.lblValorAntigo.Location = new System.Drawing.Point(116, 141);
            this.lblValorAntigo.Name = "lblValorAntigo";
            this.lblValorAntigo.Size = new System.Drawing.Size(67, 13);
            this.lblValorAntigo.TabIndex = 34;
            this.lblValorAntigo.Text = "Ultimo Preço";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(333, 75);
            this.txtFornecedor.Multiline = true;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.ReadOnly = true;
            this.txtFornecedor.Size = new System.Drawing.Size(190, 21);
            this.txtFornecedor.TabIndex = 4;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(308, 101);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 35;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // lblQtdPeca
            // 
            this.lblQtdPeca.AutoSize = true;
            this.lblQtdPeca.Location = new System.Drawing.Point(289, 141);
            this.lblQtdPeca.Name = "lblQtdPeca";
            this.lblQtdPeca.Size = new System.Drawing.Size(62, 13);
            this.lblQtdPeca.TabIndex = 32;
            this.lblQtdPeca.Text = "Quantidade";
            // 
            // txtQtdItem
            // 
            this.txtQtdItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdItem.Location = new System.Drawing.Point(292, 157);
            this.txtQtdItem.MaxLength = 2;
            this.txtQtdItem.Name = "txtQtdItem";
            this.txtQtdItem.Size = new System.Drawing.Size(120, 20);
            this.txtQtdItem.TabIndex = 10;
            this.txtQtdItem.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // txtDataCompra
            // 
            this.txtDataCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataCompra.Location = new System.Drawing.Point(224, 76);
            this.txtDataCompra.Mask = "__/__/____   ";
            this.txtDataCompra.Name = "txtDataCompra";
            this.txtDataCompra.Size = new System.Drawing.Size(81, 20);
            this.txtDataCompra.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Data da Compra";
            // 
            // txtBuscaFiltro
            // 
            this.txtBuscaFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscaFiltro.Enabled = false;
            this.txtBuscaFiltro.Location = new System.Drawing.Point(232, 111);
            this.txtBuscaFiltro.MaxLength = 25;
            this.txtBuscaFiltro.Name = "txtBuscaFiltro";
            this.txtBuscaFiltro.ReadOnly = true;
            this.txtBuscaFiltro.Size = new System.Drawing.Size(190, 20);
            this.txtBuscaFiltro.TabIndex = 7;
            // 
            // frmCadCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 368);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscaFornecedor);
            this.Controls.Add(this.txtBuscaFiltro);
            this.Controls.Add(this.btnBuscarItemDtGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataCompra);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txtUltimoPreco);
            this.Controls.Add(this.lblValorAntigo);
            this.Controls.Add(this.txtQtdItem);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAdicionaItem);
            this.Controls.Add(this.dgItems);
            this.Controls.Add(this.lblQtdPeca);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.rdbMotor);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.rdbPeca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadCompra";
            this.Text = "Compra";
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
        private System.Windows.Forms.RadioButton rdbMotor;
        private System.Windows.Forms.RadioButton rdbPeca;
        private System.Windows.Forms.Label lblObs;
        private Controles.MegaTextBox.MegaTextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.DataGridView dgItems;
        private Controles.MegaTextBox.MegaTextBox txtUltimoPreco;
        private System.Windows.Forms.Label lblValorAntigo;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblQtdPeca;
        private System.Windows.Forms.Button btnAdicionaItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private Controles.MegaTextBox.MegaTextBox txtQtdItem;
        private System.Windows.Forms.MaskedTextBox txtDataCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscaFiltro;
        private System.Windows.Forms.Button btnBuscarItemDtGrid;
        private System.Windows.Forms.Button btnBuscaFornecedor;
    }
}