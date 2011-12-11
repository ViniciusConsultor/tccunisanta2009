namespace TCC.UI
{
    partial class frmCadKitGrupoPeca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadKitGrupoPeca));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNmKit = new System.Windows.Forms.TextBox();
            this.lblNmKit = new System.Windows.Forms.Label();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdicionaItem = new System.Windows.Forms.Button();
            this.btnBuscarItemDtGrid = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.gbBuscaItem = new System.Windows.Forms.GroupBox();
            this.txtQtdItem = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.hIdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscaFiltro = new System.Windows.Forms.TextBox();
            this.lblQtdPeca = new System.Windows.Forms.Label();
            this.lblNmItem = new System.Windows.Forms.Label();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.TxtNmItem = new System.Windows.Forms.TextBox();
            this.lblCdKitReal = new System.Windows.Forms.Label();
            this.txtCodigoKit = new System.Windows.Forms.TextBox();
            this.gbBuscaItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(8, 155);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(53, 43);
            this.btnVoltar.TabIndex = 13;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(8, 54);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(53, 43);
            this.btnLimpar.TabIndex = 11;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtNmKit
            // 
            this.txtNmKit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNmKit.Location = new System.Drawing.Point(391, 90);
            this.txtNmKit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNmKit.MaxLength = 50;
            this.txtNmKit.Name = "txtNmKit";
            this.txtNmKit.Size = new System.Drawing.Size(177, 22);
            this.txtNmKit.TabIndex = 2;
            // 
            // lblNmKit
            // 
            this.lblNmKit.AutoSize = true;
            this.lblNmKit.Location = new System.Drawing.Point(296, 92);
            this.lblNmKit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNmKit.Name = "lblNmKit";
            this.lblNmKit.Size = new System.Drawing.Size(85, 17);
            this.lblNmKit.TabIndex = 15;
            this.lblNmKit.Text = "Nome do Kit";
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // btnAdicionaItem
            // 
            this.btnAdicionaItem.BackgroundImage = global::TCC.resImg.btnAdd_;
            this.btnAdicionaItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionaItem.Location = new System.Drawing.Point(48, 209);
            this.btnAdicionaItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionaItem.Name = "btnAdicionaItem";
            this.btnAdicionaItem.Size = new System.Drawing.Size(53, 43);
            this.btnAdicionaItem.TabIndex = 8;
            this.toolTipLegenda.SetToolTip(this.btnAdicionaItem, "Adicionar Item");
            this.btnAdicionaItem.UseVisualStyleBackColor = true;
            this.btnAdicionaItem.Click += new System.EventHandler(this.btnAdicionaItem_Click);
            // 
            // btnBuscarItemDtGrid
            // 
            this.btnBuscarItemDtGrid.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscarItemDtGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarItemDtGrid.Location = new System.Drawing.Point(613, 43);
            this.btnBuscarItemDtGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarItemDtGrid.Name = "btnBuscarItemDtGrid";
            this.btnBuscarItemDtGrid.Size = new System.Drawing.Size(36, 28);
            this.btnBuscarItemDtGrid.TabIndex = 6;
            this.toolTipLegenda.SetToolTip(this.btnBuscarItemDtGrid, "Buscar Itens");
            this.btnBuscarItemDtGrid.UseVisualStyleBackColor = true;
            this.btnBuscarItemDtGrid.Click += new System.EventHandler(this.btnBuscarItemDtGrid_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackgroundImage = global::TCC.resImg.btnLess;
            this.btnRemoveItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveItem.Location = new System.Drawing.Point(131, 209);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(53, 43);
            this.btnRemoveItem.TabIndex = 9;
            this.toolTipLegenda.SetToolTip(this.btnRemoveItem, "Remover Item");
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(8, 5);
            this.btnAceitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(53, 43);
            this.btnAceitar.TabIndex = 10;
            this.toolTipLegenda.SetToolTip(this.btnAceitar, "Salvar");
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(8, 105);
            this.btnBuscaAlteracaoDelecao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(53, 43);
            this.btnBuscaAlteracaoDelecao.TabIndex = 12;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            // 
            // gbBuscaItem
            // 
            this.gbBuscaItem.Controls.Add(this.txtQtdItem);
            this.gbBuscaItem.Controls.Add(this.btnRemoveItem);
            this.gbBuscaItem.Controls.Add(this.btnAdicionaItem);
            this.gbBuscaItem.Controls.Add(this.dgItems);
            this.gbBuscaItem.Controls.Add(this.txtBuscaFiltro);
            this.gbBuscaItem.Controls.Add(this.lblQtdPeca);
            this.gbBuscaItem.Controls.Add(this.btnBuscarItemDtGrid);
            this.gbBuscaItem.Controls.Add(this.lblNmItem);
            this.gbBuscaItem.Controls.Add(this.rdbNome);
            this.gbBuscaItem.Controls.Add(this.rdbCodigo);
            this.gbBuscaItem.Controls.Add(this.TxtNmItem);
            this.gbBuscaItem.Location = new System.Drawing.Point(111, 133);
            this.gbBuscaItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBuscaItem.Name = "gbBuscaItem";
            this.gbBuscaItem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBuscaItem.Size = new System.Drawing.Size(664, 299);
            this.gbBuscaItem.TabIndex = 16;
            this.gbBuscaItem.TabStop = false;
            this.gbBuscaItem.Text = "Items do Kit";
            // 
            // txtQtdItem
            // 
            this.txtQtdItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdItem.Location = new System.Drawing.Point(48, 161);
            this.txtQtdItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQtdItem.MaxLength = 2;
            this.txtQtdItem.Name = "txtQtdItem";
            this.txtQtdItem.Size = new System.Drawing.Size(133, 22);
            this.txtQtdItem.TabIndex = 7;
            this.txtQtdItem.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
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
            this.hIdItem,
            this.hCodigo,
            this.hNome,
            this.hQtd});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgItems.Location = new System.Drawing.Point(256, 75);
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
            this.dgItems.Size = new System.Drawing.Size(393, 218);
            this.dgItems.TabIndex = 7;
            this.dgItems.Click += new System.EventHandler(this.dgItems_Click);
            // 
            // hIdItem
            // 
            this.hIdItem.DataPropertyName = "id_item";
            this.hIdItem.HeaderText = "IdItem";
            this.hIdItem.Name = "hIdItem";
            this.hIdItem.ReadOnly = true;
            this.hIdItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hIdItem.Visible = false;
            this.hIdItem.Width = 42;
            // 
            // hCodigo
            // 
            this.hCodigo.DataPropertyName = "Codigo";
            this.hCodigo.HeaderText = "Codigo";
            this.hCodigo.Name = "hCodigo";
            this.hCodigo.ReadOnly = true;
            this.hCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hCodigo.Width = 58;
            // 
            // hNome
            // 
            this.hNome.DataPropertyName = "Item";
            this.hNome.HeaderText = "Nome";
            this.hNome.Name = "hNome";
            this.hNome.ReadOnly = true;
            this.hNome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hNome.Width = 51;
            // 
            // hQtd
            // 
            this.hQtd.DataPropertyName = "qtd";
            this.hQtd.HeaderText = "Quantidade";
            this.hQtd.Name = "hQtd";
            this.hQtd.ReadOnly = true;
            this.hQtd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hQtd.Width = 88;
            // 
            // txtBuscaFiltro
            // 
            this.txtBuscaFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscaFiltro.Location = new System.Drawing.Point(256, 44);
            this.txtBuscaFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscaFiltro.MaxLength = 25;
            this.txtBuscaFiltro.Name = "txtBuscaFiltro";
            this.txtBuscaFiltro.Size = new System.Drawing.Size(349, 22);
            this.txtBuscaFiltro.TabIndex = 5;
            // 
            // lblQtdPeca
            // 
            this.lblQtdPeca.AutoSize = true;
            this.lblQtdPeca.Location = new System.Drawing.Point(44, 140);
            this.lblQtdPeca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdPeca.Name = "lblQtdPeca";
            this.lblQtdPeca.Size = new System.Drawing.Size(82, 17);
            this.lblQtdPeca.TabIndex = 18;
            this.lblQtdPeca.Text = "Quantidade";
            // 
            // lblNmItem
            // 
            this.lblNmItem.AutoSize = true;
            this.lblNmItem.Location = new System.Drawing.Point(44, 69);
            this.lblNmItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNmItem.Name = "lblNmItem";
            this.lblNmItem.Size = new System.Drawing.Size(75, 17);
            this.lblNmItem.TabIndex = 17;
            this.lblNmItem.Text = "Nome Item";
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(341, 16);
            this.rdbNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(66, 21);
            this.rdbNome.TabIndex = 4;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Checked = true;
            this.rdbCodigo.Location = new System.Drawing.Point(256, 16);
            this.rdbCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(73, 21);
            this.rdbCodigo.TabIndex = 3;
            this.rdbCodigo.TabStop = true;
            this.rdbCodigo.Text = "Codigo";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            // 
            // TxtNmItem
            // 
            this.TxtNmItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNmItem.Enabled = false;
            this.TxtNmItem.Location = new System.Drawing.Point(48, 89);
            this.TxtNmItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNmItem.MaxLength = 25;
            this.TxtNmItem.Name = "TxtNmItem";
            this.TxtNmItem.ReadOnly = true;
            this.TxtNmItem.Size = new System.Drawing.Size(135, 22);
            this.TxtNmItem.TabIndex = 5;
            // 
            // lblCdKitReal
            // 
            this.lblCdKitReal.AutoSize = true;
            this.lblCdKitReal.Location = new System.Drawing.Point(296, 54);
            this.lblCdKitReal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCdKitReal.Name = "lblCdKitReal";
            this.lblCdKitReal.Size = new System.Drawing.Size(92, 17);
            this.lblCdKitReal.TabIndex = 24;
            this.lblCdKitReal.Text = "Código do Kit";
            // 
            // txtCodigoKit
            // 
            this.txtCodigoKit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoKit.Location = new System.Drawing.Point(391, 50);
            this.txtCodigoKit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoKit.MaxLength = 20;
            this.txtCodigoKit.Name = "txtCodigoKit";
            this.txtCodigoKit.Size = new System.Drawing.Size(177, 22);
            this.txtCodigoKit.TabIndex = 1;
            this.txtCodigoKit.TextChanged += new System.EventHandler(this.txtCodigoKit_TextChanged);
            // 
            // frmCadKitGrupoPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 503);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.lblCdKitReal);
            this.Controls.Add(this.txtCodigoKit);
            this.Controls.Add(this.gbBuscaItem);
            this.Controls.Add(this.lblNmKit);
            this.Controls.Add(this.txtNmKit);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAceitar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmCadKitGrupoPeca";
            this.Text = "KitGrupoPeca";
            this.Load += new System.EventHandler(this.frmCadKitGrupoPeca_Load);
            this.gbBuscaItem.ResumeLayout(false);
            this.gbBuscaItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.TextBox txtNmKit;
        private System.Windows.Forms.Label lblNmKit;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.GroupBox gbBuscaItem;
        private System.Windows.Forms.Button btnAdicionaItem;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.TextBox txtBuscaFiltro;
        private System.Windows.Forms.Label lblQtdPeca;
        private System.Windows.Forms.Button btnBuscarItemDtGrid;
        private System.Windows.Forms.Label lblNmItem;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.TextBox TxtNmItem;
        private System.Windows.Forms.Label lblCdKitReal;
        private System.Windows.Forms.TextBox txtCodigoKit;
        private System.Windows.Forms.Button btnRemoveItem;
        private Controles.MegaTextBox.MegaTextBox txtQtdItem;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQtd;
    }
}