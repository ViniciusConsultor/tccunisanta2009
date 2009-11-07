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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnOP = new System.Windows.Forms.Button();
            this.btnAdicionaProdutos = new System.Windows.Forms.Button();
            this.txtValorVenda = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.gbBuscaItem = new System.Windows.Forms.GroupBox();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.CdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NmItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscaFiltro = new System.Windows.Forms.TextBox();
            this.lblQtdPeca = new System.Windows.Forms.Label();
            this.txtQtdProdutos = new System.Windows.Forms.TextBox();
            this.btnBuscarItemDtGrid = new System.Windows.Forms.Button();
            this.lblNmProduto = new System.Windows.Forms.Label();
            this.rdbFiltro1 = new System.Windows.Forms.RadioButton();
            this.rdbfiltro0 = new System.Windows.Forms.RadioButton();
            this.TxtNmProduto = new System.Windows.Forms.TextBox();
            this.gbEscolhaRdb = new System.Windows.Forms.GroupBox();
            this.rdbkit0 = new System.Windows.Forms.RadioButton();
            this.rdbmotor1 = new System.Windows.Forms.RadioButton();
            this.gbBuscaItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.gbEscolhaRdb.SuspendLayout();
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
            this.txtQtdVenda.Location = new System.Drawing.Point(438, 61);
            this.txtQtdVenda.MaxLength = 5;
            this.txtQtdVenda.Name = "txtQtdVenda";
            this.txtQtdVenda.Size = new System.Drawing.Size(133, 20);
            this.txtQtdVenda.TabIndex = 1;
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
            this.btnOP.Click += new System.EventHandler(this.btnOP_Click);
            // 
            // btnAdicionaProdutos
            // 
            this.btnAdicionaProdutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionaProdutos.BackgroundImage")));
            this.btnAdicionaProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionaProdutos.Location = new System.Drawing.Point(60, 180);
            this.btnAdicionaProdutos.Name = "btnAdicionaProdutos";
            this.btnAdicionaProdutos.Size = new System.Drawing.Size(40, 35);
            this.btnAdicionaProdutos.TabIndex = 22;
            this.toolTipLegenda.SetToolTip(this.btnAdicionaProdutos, "Adiciona ITem");
            this.btnAdicionaProdutos.UseVisualStyleBackColor = true;
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
            this.gbBuscaItem.Controls.Add(this.gbEscolhaRdb);
            this.gbBuscaItem.Controls.Add(this.btnAdicionaProdutos);
            this.gbBuscaItem.Controls.Add(this.dgProdutos);
            this.gbBuscaItem.Controls.Add(this.txtBuscaFiltro);
            this.gbBuscaItem.Controls.Add(this.lblQtdPeca);
            this.gbBuscaItem.Controls.Add(this.txtQtdProdutos);
            this.gbBuscaItem.Controls.Add(this.btnBuscarItemDtGrid);
            this.gbBuscaItem.Controls.Add(this.lblNmProduto);
            this.gbBuscaItem.Controls.Add(this.rdbFiltro1);
            this.gbBuscaItem.Controls.Add(this.rdbfiltro0);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdItem,
            this.NmItem});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgProdutos.Location = new System.Drawing.Point(170, 52);
            this.dgProdutos.MultiSelect = false;
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdutos.ShowEditingIcon = false;
            this.dgProdutos.Size = new System.Drawing.Size(295, 177);
            this.dgProdutos.TabIndex = 21;
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
            // rdbFiltro1
            // 
            this.rdbFiltro1.AutoSize = true;
            this.rdbFiltro1.Location = new System.Drawing.Point(279, 15);
            this.rdbFiltro1.Name = "rdbFiltro1";
            this.rdbFiltro1.Size = new System.Drawing.Size(53, 17);
            this.rdbFiltro1.TabIndex = 20;
            this.rdbFiltro1.Text = "Nome";
            this.rdbFiltro1.UseVisualStyleBackColor = true;
            // 
            // rdbfiltro0
            // 
            this.rdbfiltro0.AutoSize = true;
            this.rdbfiltro0.Checked = true;
            this.rdbfiltro0.Location = new System.Drawing.Point(215, 15);
            this.rdbfiltro0.Name = "rdbfiltro0";
            this.rdbfiltro0.Size = new System.Drawing.Size(58, 17);
            this.rdbfiltro0.TabIndex = 19;
            this.rdbfiltro0.TabStop = true;
            this.rdbfiltro0.Text = "Codigo";
            this.rdbfiltro0.UseVisualStyleBackColor = true;
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
            // gbEscolhaRdb
            // 
            this.gbEscolhaRdb.Controls.Add(this.rdbmotor1);
            this.gbEscolhaRdb.Controls.Add(this.rdbkit0);
            this.gbEscolhaRdb.Location = new System.Drawing.Point(31, 19);
            this.gbEscolhaRdb.Name = "gbEscolhaRdb";
            this.gbEscolhaRdb.Size = new System.Drawing.Size(72, 56);
            this.gbEscolhaRdb.TabIndex = 23;
            this.gbEscolhaRdb.TabStop = false;
            // 
            // rdbkit0
            // 
            this.rdbkit0.AutoSize = true;
            this.rdbkit0.Location = new System.Drawing.Point(6, 12);
            this.rdbkit0.Name = "rdbkit0";
            this.rdbkit0.Size = new System.Drawing.Size(37, 17);
            this.rdbkit0.TabIndex = 19;
            this.rdbkit0.Text = "Kit";
            this.rdbkit0.UseVisualStyleBackColor = true;
            // 
            // rdbmotor1
            // 
            this.rdbmotor1.AutoSize = true;
            this.rdbmotor1.Location = new System.Drawing.Point(6, 35);
            this.rdbmotor1.Name = "rdbmotor1";
            this.rdbmotor1.Size = new System.Drawing.Size(52, 17);
            this.rdbmotor1.TabIndex = 19;
            this.rdbmotor1.Text = "Motor";
            this.rdbmotor1.UseVisualStyleBackColor = true;
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
            this.gbBuscaItem.ResumeLayout(false);
            this.gbBuscaItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.gbEscolhaRdb.ResumeLayout(false);
            this.gbEscolhaRdb.PerformLayout();
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
        private System.Windows.Forms.Button btnOP;
        private Controles.MegaTextBox.MegaTextBox txtValorVenda;
        private System.Windows.Forms.GroupBox gbBuscaItem;
        private System.Windows.Forms.Button btnAdicionaProdutos;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NmItem;
        private System.Windows.Forms.TextBox txtBuscaFiltro;
        private System.Windows.Forms.Label lblQtdPeca;
        private System.Windows.Forms.TextBox txtQtdProdutos;
        private System.Windows.Forms.Button btnBuscarItemDtGrid;
        private System.Windows.Forms.Label lblNmProduto;
        private System.Windows.Forms.RadioButton rdbFiltro1;
        private System.Windows.Forms.RadioButton rdbfiltro0;
        private System.Windows.Forms.TextBox TxtNmProduto;
        private System.Windows.Forms.GroupBox gbEscolhaRdb;
        private System.Windows.Forms.RadioButton rdbmotor1;
        private System.Windows.Forms.RadioButton rdbkit0;
    }
}