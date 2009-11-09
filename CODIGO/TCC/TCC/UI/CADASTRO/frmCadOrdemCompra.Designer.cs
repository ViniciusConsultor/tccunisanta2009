namespace TCC.UI.CADASTRO
{
    partial class frmCadOrdemCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.lblNotafiscal = new System.Windows.Forms.Label();
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.lblUltimoPreco = new System.Windows.Forms.Label();
            this.lblCdFornecedor = new System.Windows.Forms.Label();
            this.txtCdFornecedor = new System.Windows.Forms.TextBox();
            this.btnCdFornecedor = new System.Windows.Forms.Button();
            this.gbBuscaItem = new System.Windows.Forms.GroupBox();
            this.btnRemovePeca = new System.Windows.Forms.Button();
            this.gpTipoProduto = new System.Windows.Forms.GroupBox();
            this.rdbTipoProduto1 = new System.Windows.Forms.RadioButton();
            this.rdbTipoProduto0 = new System.Windows.Forms.RadioButton();
            this.btnAdicionaItem = new System.Windows.Forms.Button();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.CdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NmItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscaFiltro = new System.Windows.Forms.TextBox();
            this.lblQtdPeca = new System.Windows.Forms.Label();
            this.btnBuscarItemDtGrid = new System.Windows.Forms.Button();
            this.lblNmItem = new System.Windows.Forms.Label();
            this.rdbFiltro1 = new System.Windows.Forms.RadioButton();
            this.rdbfiltro0 = new System.Windows.Forms.RadioButton();
            this.TxtNmProduto = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.txtUIltimoPreco = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.txtQtdItem = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.gbBuscaItem.SuspendLayout();
            this.gpTipoProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(7, 96);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(40, 35);
            this.btnVolta.TabIndex = 12;
            this.btnVolta.UseVisualStyleBackColor = true;
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackgroundImage = global::TCC.resImg.btnLimpa;
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpa.Location = new System.Drawing.Point(7, 55);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(40, 35);
            this.btnLimpa.TabIndex = 11;
            this.btnLimpa.UseVisualStyleBackColor = true;
            // 
            // lblNotafiscal
            // 
            this.lblNotafiscal.AutoSize = true;
            this.lblNotafiscal.Location = new System.Drawing.Point(86, 81);
            this.lblNotafiscal.Name = "lblNotafiscal";
            this.lblNotafiscal.Size = new System.Drawing.Size(60, 13);
            this.lblNotafiscal.TabIndex = 13;
            this.lblNotafiscal.Text = "Nota Fiscal";
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotaFiscal.Location = new System.Drawing.Point(153, 73);
            this.txtNotaFiscal.MaxLength = 25;
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.Size = new System.Drawing.Size(100, 20);
            this.txtNotaFiscal.TabIndex = 14;
            // 
            // lblUltimoPreco
            // 
            this.lblUltimoPreco.AutoSize = true;
            this.lblUltimoPreco.Location = new System.Drawing.Point(276, 78);
            this.lblUltimoPreco.Name = "lblUltimoPreco";
            this.lblUltimoPreco.Size = new System.Drawing.Size(67, 13);
            this.lblUltimoPreco.TabIndex = 13;
            this.lblUltimoPreco.Text = "Ultimo Preço";
            // 
            // lblCdFornecedor
            // 
            this.lblCdFornecedor.AutoSize = true;
            this.lblCdFornecedor.Location = new System.Drawing.Point(73, 32);
            this.lblCdFornecedor.Name = "lblCdFornecedor";
            this.lblCdFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblCdFornecedor.TabIndex = 15;
            this.lblCdFornecedor.Text = "Fornecedor";
            // 
            // txtCdFornecedor
            // 
            this.txtCdFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdFornecedor.Location = new System.Drawing.Point(140, 27);
            this.txtCdFornecedor.MaxLength = 50;
            this.txtCdFornecedor.Name = "txtCdFornecedor";
            this.txtCdFornecedor.ReadOnly = true;
            this.txtCdFornecedor.Size = new System.Drawing.Size(52, 20);
            this.txtCdFornecedor.TabIndex = 17;
            this.txtCdFornecedor.TabStop = false;
            // 
            // btnCdFornecedor
            // 
            this.btnCdFornecedor.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnCdFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdFornecedor.Location = new System.Drawing.Point(198, 24);
            this.btnCdFornecedor.Name = "btnCdFornecedor";
            this.btnCdFornecedor.Size = new System.Drawing.Size(27, 23);
            this.btnCdFornecedor.TabIndex = 16;
            this.btnCdFornecedor.UseVisualStyleBackColor = true;
            // 
            // gbBuscaItem
            // 
            this.gbBuscaItem.Controls.Add(this.txtQtdItem);
            this.gbBuscaItem.Controls.Add(this.btnRemovePeca);
            this.gbBuscaItem.Controls.Add(this.gpTipoProduto);
            this.gbBuscaItem.Controls.Add(this.btnAdicionaItem);
            this.gbBuscaItem.Controls.Add(this.dgItems);
            this.gbBuscaItem.Controls.Add(this.txtBuscaFiltro);
            this.gbBuscaItem.Controls.Add(this.lblQtdPeca);
            this.gbBuscaItem.Controls.Add(this.btnBuscarItemDtGrid);
            this.gbBuscaItem.Controls.Add(this.lblNmItem);
            this.gbBuscaItem.Controls.Add(this.rdbFiltro1);
            this.gbBuscaItem.Controls.Add(this.rdbfiltro0);
            this.gbBuscaItem.Controls.Add(this.TxtNmProduto);
            this.gbBuscaItem.Location = new System.Drawing.Point(80, 114);
            this.gbBuscaItem.Name = "gbBuscaItem";
            this.gbBuscaItem.Size = new System.Drawing.Size(498, 243);
            this.gbBuscaItem.TabIndex = 18;
            this.gbBuscaItem.TabStop = false;
            this.gbBuscaItem.Text = "Items do Kit";
            // 
            // btnRemovePeca
            // 
            this.btnRemovePeca.BackgroundImage = global::TCC.resImg.btnLess;
            this.btnRemovePeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemovePeca.Location = new System.Drawing.Point(96, 198);
            this.btnRemovePeca.Name = "btnRemovePeca";
            this.btnRemovePeca.Size = new System.Drawing.Size(40, 35);
            this.btnRemovePeca.TabIndex = 19;
            this.btnRemovePeca.UseVisualStyleBackColor = true;
            // 
            // gpTipoProduto
            // 
            this.gpTipoProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gpTipoProduto.Controls.Add(this.rdbTipoProduto1);
            this.gpTipoProduto.Controls.Add(this.rdbTipoProduto0);
            this.gpTipoProduto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gpTipoProduto.Location = new System.Drawing.Point(73, 19);
            this.gpTipoProduto.Name = "gpTipoProduto";
            this.gpTipoProduto.Size = new System.Drawing.Size(67, 65);
            this.gpTipoProduto.TabIndex = 23;
            this.gpTipoProduto.TabStop = false;
            this.gpTipoProduto.Visible = false;
            // 
            // rdbTipoProduto1
            // 
            this.rdbTipoProduto1.AutoSize = true;
            this.rdbTipoProduto1.Location = new System.Drawing.Point(6, 42);
            this.rdbTipoProduto1.Name = "rdbTipoProduto1";
            this.rdbTipoProduto1.Size = new System.Drawing.Size(50, 17);
            this.rdbTipoProduto1.TabIndex = 23;
            this.rdbTipoProduto1.Text = "Peça";
            this.rdbTipoProduto1.UseVisualStyleBackColor = true;
            // 
            // rdbTipoProduto0
            // 
            this.rdbTipoProduto0.AutoSize = true;
            this.rdbTipoProduto0.Location = new System.Drawing.Point(6, 16);
            this.rdbTipoProduto0.Name = "rdbTipoProduto0";
            this.rdbTipoProduto0.Size = new System.Drawing.Size(52, 17);
            this.rdbTipoProduto0.TabIndex = 23;
            this.rdbTipoProduto0.Text = "Motor";
            this.rdbTipoProduto0.UseVisualStyleBackColor = true;
            // 
            // btnAdicionaItem
            // 
            this.btnAdicionaItem.BackgroundImage = global::TCC.resImg.btnAdd_;
            this.btnAdicionaItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionaItem.Location = new System.Drawing.Point(34, 198);
            this.btnAdicionaItem.Name = "btnAdicionaItem";
            this.btnAdicionaItem.Size = new System.Drawing.Size(40, 35);
            this.btnAdicionaItem.TabIndex = 22;
            this.btnAdicionaItem.UseVisualStyleBackColor = true;
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
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdItem,
            this.NmItem});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgItems.Location = new System.Drawing.Point(170, 56);
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
            this.dgItems.Size = new System.Drawing.Size(295, 177);
            this.dgItems.TabIndex = 21;
            // 
            // CdItem
            // 
            this.CdItem.HeaderText = "Codigo";
            this.CdItem.Name = "CdItem";
            this.CdItem.ReadOnly = true;
            this.CdItem.Width = 65;
            // 
            // NmItem
            // 
            this.NmItem.HeaderText = "Nome";
            this.NmItem.Name = "NmItem";
            this.NmItem.ReadOnly = true;
            this.NmItem.Width = 60;
            // 
            // txtBuscaFiltro
            // 
            this.txtBuscaFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscaFiltro.Location = new System.Drawing.Point(216, 36);
            this.txtBuscaFiltro.MaxLength = 20;
            this.txtBuscaFiltro.Name = "txtBuscaFiltro";
            this.txtBuscaFiltro.Size = new System.Drawing.Size(179, 20);
            this.txtBuscaFiltro.TabIndex = 15;
            // 
            // lblQtdPeca
            // 
            this.lblQtdPeca.AutoSize = true;
            this.lblQtdPeca.Location = new System.Drawing.Point(31, 139);
            this.lblQtdPeca.Name = "lblQtdPeca";
            this.lblQtdPeca.Size = new System.Drawing.Size(62, 13);
            this.lblQtdPeca.TabIndex = 18;
            this.lblQtdPeca.Text = "Quantidade";
            // 
            // btnBuscarItemDtGrid
            // 
            this.btnBuscarItemDtGrid.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscarItemDtGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarItemDtGrid.Location = new System.Drawing.Point(394, 22);
            this.btnBuscarItemDtGrid.Name = "btnBuscarItemDtGrid";
            this.btnBuscarItemDtGrid.Size = new System.Drawing.Size(40, 35);
            this.btnBuscarItemDtGrid.TabIndex = 13;
            this.btnBuscarItemDtGrid.UseVisualStyleBackColor = true;
            // 
            // lblNmItem
            // 
            this.lblNmItem.AutoSize = true;
            this.lblNmItem.Location = new System.Drawing.Point(31, 90);
            this.lblNmItem.Name = "lblNmItem";
            this.lblNmItem.Size = new System.Drawing.Size(75, 13);
            this.lblNmItem.TabIndex = 17;
            this.lblNmItem.Text = "Nome Produto";
            // 
            // rdbFiltro1
            // 
            this.rdbFiltro1.AutoSize = true;
            this.rdbFiltro1.Checked = true;
            this.rdbFiltro1.Location = new System.Drawing.Point(279, 19);
            this.rdbFiltro1.Name = "rdbFiltro1";
            this.rdbFiltro1.Size = new System.Drawing.Size(53, 17);
            this.rdbFiltro1.TabIndex = 20;
            this.rdbFiltro1.TabStop = true;
            this.rdbFiltro1.Text = "Nome";
            this.rdbFiltro1.UseVisualStyleBackColor = true;
            // 
            // rdbfiltro0
            // 
            this.rdbfiltro0.AutoSize = true;
            this.rdbfiltro0.Location = new System.Drawing.Point(215, 19);
            this.rdbfiltro0.Name = "rdbfiltro0";
            this.rdbfiltro0.Size = new System.Drawing.Size(58, 17);
            this.rdbfiltro0.TabIndex = 19;
            this.rdbfiltro0.Text = "Codigo";
            this.rdbfiltro0.UseVisualStyleBackColor = true;
            // 
            // TxtNmProduto
            // 
            this.TxtNmProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNmProduto.Location = new System.Drawing.Point(34, 106);
            this.TxtNmProduto.MaxLength = 25;
            this.TxtNmProduto.Name = "TxtNmProduto";
            this.TxtNmProduto.ReadOnly = true;
            this.TxtNmProduto.Size = new System.Drawing.Size(102, 20);
            this.TxtNmProduto.TabIndex = 14;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(7, 12);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(40, 35);
            this.btnConfirma.TabIndex = 10;
            this.btnConfirma.UseVisualStyleBackColor = true;
            // 
            // txtUIltimoPreco
            // 
            this.txtUIltimoPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUIltimoPreco.Location = new System.Drawing.Point(385, 72);
            this.txtUIltimoPreco.MaxLength = 15;
            this.txtUIltimoPreco.Name = "txtUIltimoPreco";
            this.txtUIltimoPreco.Size = new System.Drawing.Size(100, 20);
            this.txtUIltimoPreco.TabIndex = 19;
            this.txtUIltimoPreco.TipoTexto = Controles.MegaTextBox.TipoTexto.Decimal;
            // 
            // txtQtdItem
            // 
            this.txtQtdItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdItem.Location = new System.Drawing.Point(34, 156);
            this.txtQtdItem.MaxLength = 2;
            this.txtQtdItem.Name = "txtQtdItem";
            this.txtQtdItem.Size = new System.Drawing.Size(100, 20);
            this.txtQtdItem.TabIndex = 24;
            this.txtQtdItem.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // frmCadOrdemCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 364);
            this.Controls.Add(this.txtUIltimoPreco);
            this.Controls.Add(this.gbBuscaItem);
            this.Controls.Add(this.btnCdFornecedor);
            this.Controls.Add(this.txtCdFornecedor);
            this.Controls.Add(this.lblCdFornecedor);
            this.Controls.Add(this.lblUltimoPreco);
            this.Controls.Add(this.txtNotaFiscal);
            this.Controls.Add(this.lblNotafiscal);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnConfirma);
            this.Name = "frmCadOrdemCompra";
            this.Text = "frmCadOrdemCompra";
            this.gbBuscaItem.ResumeLayout(false);
            this.gbBuscaItem.PerformLayout();
            this.gpTipoProduto.ResumeLayout(false);
            this.gpTipoProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Label lblNotafiscal;
        private System.Windows.Forms.TextBox txtNotaFiscal;
        private System.Windows.Forms.Label lblUltimoPreco;
        private System.Windows.Forms.Label lblCdFornecedor;
        private System.Windows.Forms.TextBox txtCdFornecedor;
        private System.Windows.Forms.Button btnCdFornecedor;
        private System.Windows.Forms.GroupBox gbBuscaItem;
        private System.Windows.Forms.RadioButton rdbTipoProduto1;
        private System.Windows.Forms.RadioButton rdbTipoProduto0;
        private System.Windows.Forms.Button btnAdicionaItem;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NmItem;
        private System.Windows.Forms.TextBox txtBuscaFiltro;
        private System.Windows.Forms.Label lblQtdPeca;
        private System.Windows.Forms.Button btnBuscarItemDtGrid;
        private System.Windows.Forms.Label lblNmItem;
        private System.Windows.Forms.RadioButton rdbFiltro1;
        private System.Windows.Forms.RadioButton rdbfiltro0;
        private System.Windows.Forms.TextBox TxtNmProduto;
        private System.Windows.Forms.GroupBox gpTipoProduto;
        private System.Windows.Forms.Button btnRemovePeca;
        private Controles.MegaTextBox.MegaTextBox txtUIltimoPreco;
        private Controles.MegaTextBox.MegaTextBox txtQtdItem;
    }
}