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
            this.btnAceitar = new System.Windows.Forms.Button();
            this.txtCdItemPeca = new System.Windows.Forms.TextBox();
            this.lblCdItemPeca = new System.Windows.Forms.Label();
            this.txtNmKit = new System.Windows.Forms.TextBox();
            this.lblNmKit = new System.Windows.Forms.Label();
            this.btnBuscaItemPeca = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.gbBuscaItem = new System.Windows.Forms.GroupBox();
            this.btnAdicionaItem = new System.Windows.Forms.Button();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.CdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NmItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscaFiltro = new System.Windows.Forms.TextBox();
            this.lblQtdPeca = new System.Windows.Forms.Label();
            this.txtQtdItem = new System.Windows.Forms.TextBox();
            this.btnBuscarItemDtGrid = new System.Windows.Forms.Button();
            this.lblNmItem = new System.Windows.Forms.Label();
            this.rdbFiltro1 = new System.Windows.Forms.RadioButton();
            this.rdbfiltro0 = new System.Windows.Forms.RadioButton();
            this.TxtNmItem = new System.Windows.Forms.TextBox();
            this.gbBuscaItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(6, 85);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(40, 35);
            this.btnVoltar.TabIndex = 6;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::TCC.Properties.Resources.eraser;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(6, 44);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(40, 35);
            this.btnLimpar.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = global::TCC.Properties.Resources.btnSalvar;
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(6, 4);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(40, 35);
            this.btnAceitar.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnAceitar, "Cadastrar");
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // txtCdItemPeca
            // 
            this.txtCdItemPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdItemPeca.Location = new System.Drawing.Point(209, 15);
            this.txtCdItemPeca.Name = "txtCdItemPeca";
            this.txtCdItemPeca.ReadOnly = true;
            this.txtCdItemPeca.Size = new System.Drawing.Size(32, 20);
            this.txtCdItemPeca.TabIndex = 14;
            this.txtCdItemPeca.TabStop = false;
            // 
            // lblCdItemPeca
            // 
            this.lblCdItemPeca.AutoSize = true;
            this.lblCdItemPeca.Location = new System.Drawing.Point(94, 17);
            this.lblCdItemPeca.Name = "lblCdItemPeca";
            this.lblCdItemPeca.Size = new System.Drawing.Size(109, 13);
            this.lblCdItemPeca.TabIndex = 15;
            this.lblCdItemPeca.Text = "Codigo do Item Peca ";
            // 
            // txtNmKit
            // 
            this.txtNmKit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNmKit.Location = new System.Drawing.Point(156, 44);
            this.txtNmKit.MaxLength = 50;
            this.txtNmKit.Name = "txtNmKit";
            this.txtNmKit.Size = new System.Drawing.Size(188, 20);
            this.txtNmKit.TabIndex = 3;
            // 
            // lblNmKit
            // 
            this.lblNmKit.AutoSize = true;
            this.lblNmKit.Location = new System.Drawing.Point(85, 46);
            this.lblNmKit.Name = "lblNmKit";
            this.lblNmKit.Size = new System.Drawing.Size(65, 13);
            this.lblNmKit.TabIndex = 15;
            this.lblNmKit.Text = "Nome do Kit";
            // 
            // btnBuscaItemPeca
            // 
            this.btnBuscaItemPeca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaItemPeca.BackgroundImage")));
            this.btnBuscaItemPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaItemPeca.Location = new System.Drawing.Point(247, 15);
            this.btnBuscaItemPeca.Name = "btnBuscaItemPeca";
            this.btnBuscaItemPeca.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaItemPeca.TabIndex = 1;
            this.toolTipLegenda.SetToolTip(this.btnBuscaItemPeca, "Buscar Item Peça");
            this.btnBuscaItemPeca.UseVisualStyleBackColor = true;
            this.btnBuscaItemPeca.Click += new System.EventHandler(this.btnCdItemPeca_Click);
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // gbBuscaItem
            // 
            this.gbBuscaItem.Controls.Add(this.btnAdicionaItem);
            this.gbBuscaItem.Controls.Add(this.dgItems);
            this.gbBuscaItem.Controls.Add(this.txtBuscaFiltro);
            this.gbBuscaItem.Controls.Add(this.lblQtdPeca);
            this.gbBuscaItem.Controls.Add(this.txtQtdItem);
            this.gbBuscaItem.Controls.Add(this.btnBuscarItemDtGrid);
            this.gbBuscaItem.Controls.Add(this.lblNmItem);
            this.gbBuscaItem.Controls.Add(this.rdbFiltro1);
            this.gbBuscaItem.Controls.Add(this.rdbfiltro0);
            this.gbBuscaItem.Controls.Add(this.TxtNmItem);
            this.gbBuscaItem.Location = new System.Drawing.Point(83, 116);
            this.gbBuscaItem.Name = "gbBuscaItem";
            this.gbBuscaItem.Size = new System.Drawing.Size(498, 243);
            this.gbBuscaItem.TabIndex = 16;
            this.gbBuscaItem.TabStop = false;
            this.gbBuscaItem.Text = "Items do Kit";
            // 
            // btnAdicionaItem
            // 
            this.btnAdicionaItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionaItem.BackgroundImage")));
            this.btnAdicionaItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionaItem.Location = new System.Drawing.Point(62, 173);
            this.btnAdicionaItem.Name = "btnAdicionaItem";
            this.btnAdicionaItem.Size = new System.Drawing.Size(40, 35);
            this.btnAdicionaItem.TabIndex = 22;
            this.toolTipLegenda.SetToolTip(this.btnAdicionaItem, "Adiciona ITem");
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
            this.lblQtdPeca.Location = new System.Drawing.Point(33, 114);
            this.lblQtdPeca.Name = "lblQtdPeca";
            this.lblQtdPeca.Size = new System.Drawing.Size(62, 13);
            this.lblQtdPeca.TabIndex = 18;
            this.lblQtdPeca.Text = "Quantidade";
            // 
            // txtQtdItem
            // 
            this.txtQtdItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdItem.Location = new System.Drawing.Point(36, 130);
            this.txtQtdItem.MaxLength = 20;
            this.txtQtdItem.Name = "txtQtdItem";
            this.txtQtdItem.Size = new System.Drawing.Size(102, 20);
            this.txtQtdItem.TabIndex = 16;
            // 
            // btnBuscarItemDtGrid
            // 
            this.btnBuscarItemDtGrid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarItemDtGrid.BackgroundImage")));
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
            this.lblNmItem.Location = new System.Drawing.Point(33, 56);
            this.lblNmItem.Name = "lblNmItem";
            this.lblNmItem.Size = new System.Drawing.Size(58, 13);
            this.lblNmItem.TabIndex = 17;
            this.lblNmItem.Text = "Nome Item";
            // 
            // rdbFiltro1
            // 
            this.rdbFiltro1.AutoSize = true;
            this.rdbFiltro1.Location = new System.Drawing.Point(279, 19);
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
            this.rdbfiltro0.Location = new System.Drawing.Point(215, 19);
            this.rdbfiltro0.Name = "rdbfiltro0";
            this.rdbfiltro0.Size = new System.Drawing.Size(58, 17);
            this.rdbfiltro0.TabIndex = 19;
            this.rdbfiltro0.TabStop = true;
            this.rdbfiltro0.Text = "Codigo";
            this.rdbfiltro0.UseVisualStyleBackColor = true;
            // 
            // TxtNmItem
            // 
            this.TxtNmItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNmItem.Location = new System.Drawing.Point(36, 72);
            this.TxtNmItem.MaxLength = 20;
            this.TxtNmItem.Name = "TxtNmItem";
            this.TxtNmItem.Size = new System.Drawing.Size(102, 20);
            this.TxtNmItem.TabIndex = 14;
            // 
            // frmCadKitGrupoPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.ControlBox = false;
            this.Controls.Add(this.gbBuscaItem);
            this.Controls.Add(this.lblNmKit);
            this.Controls.Add(this.txtNmKit);
            this.Controls.Add(this.lblCdItemPeca);
            this.Controls.Add(this.txtCdItemPeca);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBuscaItemPeca);
            this.Controls.Add(this.btnAceitar);
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
        private System.Windows.Forms.TextBox txtCdItemPeca;
        private System.Windows.Forms.Label lblCdItemPeca;
        private System.Windows.Forms.TextBox txtNmKit;
        private System.Windows.Forms.Label lblNmKit;
        private System.Windows.Forms.Button btnBuscaItemPeca;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.GroupBox gbBuscaItem;
        private System.Windows.Forms.Button btnAdicionaItem;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NmItem;
        private System.Windows.Forms.TextBox txtBuscaFiltro;
        private System.Windows.Forms.Label lblQtdPeca;
        private System.Windows.Forms.TextBox txtQtdItem;
        private System.Windows.Forms.Button btnBuscarItemDtGrid;
        private System.Windows.Forms.Label lblNmItem;
        private System.Windows.Forms.RadioButton rdbFiltro1;
        private System.Windows.Forms.RadioButton rdbfiltro0;
        private System.Windows.Forms.TextBox TxtNmItem;
    }
}