namespace TCC.UI
{
    partial class frmChegadaInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChegadaInsumos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.btnBuscarOrdemServDtGrid = new System.Windows.Forms.Button();
            this.btnBuscaEstoque = new System.Windows.Forms.Button();
            this.btnRemovePeca = new System.Windows.Forms.Button();
            this.btnAdicionaPeca = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbBuscarCompra = new System.Windows.Forms.RadioButton();
            this.txtBuscaFiltro = new System.Windows.Forms.TextBox();
            this.rdbBuscaOrdemServ = new System.Windows.Forms.RadioButton();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.hIdInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPecaMotor = new System.Windows.Forms.Label();
            this.txtInsumoRecebido = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.megaTextBox2 = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.lblUltimoPreco = new System.Windows.Forms.Label();
            this.txtQtdRecebida = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.lblQtdChegada = new System.Windows.Forms.Label();
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.lblNotaFiscal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
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
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(7, 108);
            this.btnBuscaAlteracaoDelecao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(53, 43);
            this.btnBuscaAlteracaoDelecao.TabIndex = 14;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            this.btnBuscaAlteracaoDelecao.Click += new System.EventHandler(this.btnBuscaAlteracaoDelecao_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(7, 159);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(53, 43);
            this.btnVoltar.TabIndex = 15;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(7, 58);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(53, 43);
            this.btnLimpar.TabIndex = 13;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(7, 7);
            this.btnAceitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(53, 43);
            this.btnAceitar.TabIndex = 12;
            this.toolTipLegenda.SetToolTip(this.btnAceitar, "Cadastrar");
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // btnBuscarOrdemServDtGrid
            // 
            this.btnBuscarOrdemServDtGrid.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscarOrdemServDtGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarOrdemServDtGrid.Location = new System.Drawing.Point(385, 66);
            this.btnBuscarOrdemServDtGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarOrdemServDtGrid.Name = "btnBuscarOrdemServDtGrid";
            this.btnBuscarOrdemServDtGrid.Size = new System.Drawing.Size(36, 28);
            this.btnBuscarOrdemServDtGrid.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnBuscarOrdemServDtGrid, "Buscar Ordem de Serviço");
            this.btnBuscarOrdemServDtGrid.UseVisualStyleBackColor = true;
            this.btnBuscarOrdemServDtGrid.Click += new System.EventHandler(this.btnBuscarOrdemServDtGrid_Click);
            // 
            // btnBuscaEstoque
            // 
            this.btnBuscaEstoque.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscaEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaEstoque.Location = new System.Drawing.Point(747, 364);
            this.btnBuscaEstoque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscaEstoque.Name = "btnBuscaEstoque";
            this.btnBuscaEstoque.Size = new System.Drawing.Size(36, 28);
            this.btnBuscaEstoque.TabIndex = 9;
            this.toolTipLegenda.SetToolTip(this.btnBuscaEstoque, "Buscar Itens");
            this.btnBuscaEstoque.UseVisualStyleBackColor = true;
            this.btnBuscaEstoque.Click += new System.EventHandler(this.btnBuscaEstoque_Click);
            // 
            // btnRemovePeca
            // 
            this.btnRemovePeca.BackgroundImage = global::TCC.resImg.btnLess;
            this.btnRemovePeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemovePeca.Location = new System.Drawing.Point(692, 400);
            this.btnRemovePeca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemovePeca.Name = "btnRemovePeca";
            this.btnRemovePeca.Size = new System.Drawing.Size(53, 43);
            this.btnRemovePeca.TabIndex = 11;
            this.toolTipLegenda.SetToolTip(this.btnRemovePeca, "Remover Peça");
            this.btnRemovePeca.UseVisualStyleBackColor = true;
            this.btnRemovePeca.Click += new System.EventHandler(this.btnRemovePeca_Click);
            // 
            // btnAdicionaPeca
            // 
            this.btnAdicionaPeca.BackgroundImage = global::TCC.resImg.btnAdd_;
            this.btnAdicionaPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionaPeca.Location = new System.Drawing.Point(612, 400);
            this.btnAdicionaPeca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionaPeca.Name = "btnAdicionaPeca";
            this.btnAdicionaPeca.Size = new System.Drawing.Size(53, 43);
            this.btnAdicionaPeca.TabIndex = 10;
            this.toolTipLegenda.SetToolTip(this.btnAdicionaPeca, "Adicionar Peça");
            this.btnAdicionaPeca.UseVisualStyleBackColor = true;
            this.btnAdicionaPeca.Click += new System.EventHandler(this.btnAdicionaPeca_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbBuscarCompra);
            this.groupBox1.Controls.Add(this.txtBuscaFiltro);
            this.groupBox1.Controls.Add(this.btnBuscarOrdemServDtGrid);
            this.groupBox1.Controls.Add(this.rdbBuscaOrdemServ);
            this.groupBox1.Location = new System.Drawing.Point(111, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(673, 107);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Código da Ordem de Serviço:";
            // 
            // rdbBuscarCompra
            // 
            this.rdbBuscarCompra.AutoSize = true;
            this.rdbBuscarCompra.Location = new System.Drawing.Point(245, 41);
            this.rdbBuscarCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbBuscarCompra.Name = "rdbBuscarCompra";
            this.rdbBuscarCompra.Size = new System.Drawing.Size(151, 21);
            this.rdbBuscarCompra.TabIndex = 2;
            this.rdbBuscarCompra.Text = "Buscar por Compra";
            this.rdbBuscarCompra.UseVisualStyleBackColor = true;
            // 
            // txtBuscaFiltro
            // 
            this.txtBuscaFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscaFiltro.Location = new System.Drawing.Point(19, 69);
            this.txtBuscaFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscaFiltro.MaxLength = 25;
            this.txtBuscaFiltro.Name = "txtBuscaFiltro";
            this.txtBuscaFiltro.Size = new System.Drawing.Size(358, 22);
            this.txtBuscaFiltro.TabIndex = 3;
            // 
            // rdbBuscaOrdemServ
            // 
            this.rdbBuscaOrdemServ.AutoSize = true;
            this.rdbBuscaOrdemServ.Checked = true;
            this.rdbBuscaOrdemServ.Location = new System.Drawing.Point(19, 41);
            this.rdbBuscaOrdemServ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbBuscaOrdemServ.Name = "rdbBuscaOrdemServ";
            this.rdbBuscaOrdemServ.Size = new System.Drawing.Size(216, 21);
            this.rdbBuscaOrdemServ.TabIndex = 1;
            this.rdbBuscaOrdemServ.TabStop = true;
            this.rdbBuscaOrdemServ.Text = "Buscar por Ordem de Serviço";
            this.rdbBuscaOrdemServ.UseVisualStyleBackColor = true;
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
            this.hIdInsumo,
            this.hCodigo,
            this.hNome,
            this.hEstoque,
            this.hQtd,
            this.hFornecedor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgItems.Location = new System.Drawing.Point(111, 130);
            this.dgItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dgItems.Size = new System.Drawing.Size(463, 305);
            this.dgItems.TabIndex = 0;
            // 
            // hIdInsumo
            // 
            this.hIdInsumo.DataPropertyName = "id_insumo";
            this.hIdInsumo.HeaderText = "IdInsumo";
            this.hIdInsumo.Name = "hIdInsumo";
            this.hIdInsumo.ReadOnly = true;
            this.hIdInsumo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hIdInsumo.Visible = false;
            this.hIdInsumo.Width = 54;
            // 
            // hCodigo
            // 
            this.hCodigo.DataPropertyName = "id_insumo_real";
            this.hCodigo.HeaderText = "Código";
            this.hCodigo.Name = "hCodigo";
            this.hCodigo.ReadOnly = true;
            this.hCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hCodigo.Width = 58;
            // 
            // hNome
            // 
            this.hNome.DataPropertyName = "nom";
            this.hNome.HeaderText = "Nome";
            this.hNome.Name = "hNome";
            this.hNome.ReadOnly = true;
            this.hNome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hNome.Width = 51;
            // 
            // hEstoque
            // 
            this.hEstoque.HeaderText = "Estoque";
            this.hEstoque.Name = "hEstoque";
            this.hEstoque.ReadOnly = true;
            this.hEstoque.Width = 85;
            // 
            // hQtd
            // 
            this.hQtd.DataPropertyName = "qtd";
            this.hQtd.HeaderText = "Qtd.";
            this.hQtd.Name = "hQtd";
            this.hQtd.ReadOnly = true;
            this.hQtd.Width = 60;
            // 
            // hFornecedor
            // 
            this.hFornecedor.DataPropertyName = "fornecedor";
            this.hFornecedor.HeaderText = "Fornecedor";
            this.hFornecedor.Name = "hFornecedor";
            this.hFornecedor.ReadOnly = true;
            this.hFornecedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hFornecedor.Width = 87;
            // 
            // lblPecaMotor
            // 
            this.lblPecaMotor.AutoSize = true;
            this.lblPecaMotor.Location = new System.Drawing.Point(581, 186);
            this.lblPecaMotor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPecaMotor.Name = "lblPecaMotor";
            this.lblPecaMotor.Size = new System.Drawing.Size(144, 17);
            this.lblPecaMotor.TabIndex = 16;
            this.lblPecaMotor.Text = "Peca/Motor Recebido";
            // 
            // txtInsumoRecebido
            // 
            this.txtInsumoRecebido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInsumoRecebido.Enabled = false;
            this.txtInsumoRecebido.Location = new System.Drawing.Point(585, 206);
            this.txtInsumoRecebido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInsumoRecebido.Name = "txtInsumoRecebido";
            this.txtInsumoRecebido.ReadOnly = true;
            this.txtInsumoRecebido.Size = new System.Drawing.Size(198, 22);
            this.txtInsumoRecebido.TabIndex = 6;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(581, 347);
            this.lblEstoque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(114, 17);
            this.lblEstoque.TabIndex = 20;
            this.lblEstoque.Text = "Estoque enviado";
            // 
            // txtEstoque
            // 
            this.txtEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstoque.Enabled = false;
            this.txtEstoque.Location = new System.Drawing.Point(584, 367);
            this.txtEstoque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(161, 22);
            this.txtEstoque.TabIndex = 8;
            this.txtEstoque.TabStop = false;
            // 
            // megaTextBox2
            // 
            this.megaTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.megaTextBox2.Location = new System.Drawing.Point(584, 256);
            this.megaTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.megaTextBox2.Name = "megaTextBox2";
            this.megaTextBox2.Size = new System.Drawing.Size(198, 22);
            this.megaTextBox2.TabIndex = 6;
            this.megaTextBox2.TipoTexto = Controles.MegaTextBox.TipoTexto.Decimal;
            // 
            // lblUltimoPreco
            // 
            this.lblUltimoPreco.AutoSize = true;
            this.lblUltimoPreco.Location = new System.Drawing.Point(580, 236);
            this.lblUltimoPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUltimoPreco.Name = "lblUltimoPreco";
            this.lblUltimoPreco.Size = new System.Drawing.Size(141, 17);
            this.lblUltimoPreco.TabIndex = 48;
            this.lblUltimoPreco.Text = "Último Preço Unitário";
            // 
            // txtQtdRecebida
            // 
            this.txtQtdRecebida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdRecebida.Location = new System.Drawing.Point(585, 313);
            this.txtQtdRecebida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQtdRecebida.Name = "txtQtdRecebida";
            this.txtQtdRecebida.Size = new System.Drawing.Size(198, 22);
            this.txtQtdRecebida.TabIndex = 7;
            this.txtQtdRecebida.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // lblQtdChegada
            // 
            this.lblQtdChegada.AutoSize = true;
            this.lblQtdChegada.Location = new System.Drawing.Point(581, 293);
            this.lblQtdChegada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdChegada.Name = "lblQtdChegada";
            this.lblQtdChegada.Size = new System.Drawing.Size(146, 17);
            this.lblQtdChegada.TabIndex = 52;
            this.lblQtdChegada.Text = "Quantidade Recebida";
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotaFiscal.Location = new System.Drawing.Point(585, 153);
            this.txtNotaFiscal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.Size = new System.Drawing.Size(198, 22);
            this.txtNotaFiscal.TabIndex = 5;
            // 
            // lblNotaFiscal
            // 
            this.lblNotaFiscal.AutoSize = true;
            this.lblNotaFiscal.Location = new System.Drawing.Point(581, 132);
            this.lblNotaFiscal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotaFiscal.Name = "lblNotaFiscal";
            this.lblNotaFiscal.Size = new System.Drawing.Size(78, 17);
            this.lblNotaFiscal.TabIndex = 54;
            this.lblNotaFiscal.Text = "Nota Fiscal";
            // 
            // frmChegadaInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 523);
            this.ControlBox = false;
            this.Controls.Add(this.btnRemovePeca);
            this.Controls.Add(this.btnAdicionaPeca);
            this.Controls.Add(this.txtNotaFiscal);
            this.Controls.Add(this.lblNotaFiscal);
            this.Controls.Add(this.txtQtdRecebida);
            this.Controls.Add(this.lblQtdChegada);
            this.Controls.Add(this.megaTextBox2);
            this.Controls.Add(this.lblUltimoPreco);
            this.Controls.Add(this.btnBuscaEstoque);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.txtInsumoRecebido);
            this.Controls.Add(this.lblPecaMotor);
            this.Controls.Add(this.dgItems);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAceitar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmChegadaInsumos";
            this.Text = "Chegada de Insumos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbBuscaOrdemServ;
        private System.Windows.Forms.TextBox txtBuscaFiltro;
        private System.Windows.Forms.Button btnBuscarOrdemServDtGrid;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.Label lblPecaMotor;
        private System.Windows.Forms.TextBox txtInsumoRecebido;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Button btnBuscaEstoque;
        private System.Windows.Forms.RadioButton rdbBuscarCompra;
        private Controles.MegaTextBox.MegaTextBox megaTextBox2;
        private System.Windows.Forms.Label lblUltimoPreco;
        private Controles.MegaTextBox.MegaTextBox txtQtdRecebida;
        private System.Windows.Forms.Label lblQtdChegada;
        private System.Windows.Forms.TextBox txtNotaFiscal;
        private System.Windows.Forms.Label lblNotaFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIdInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn hFornecedor;
        private System.Windows.Forms.Button btnRemovePeca;
        private System.Windows.Forms.Button btnAdicionaPeca;
    }
}