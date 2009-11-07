﻿namespace TCC.UI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.txtNmKit = new System.Windows.Forms.TextBox();
            this.lblNmKit = new System.Windows.Forms.Label();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdicionaItem = new System.Windows.Forms.Button();
            this.gbBuscaItem = new System.Windows.Forms.GroupBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.hIdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscaFiltro = new System.Windows.Forms.TextBox();
            this.lblQtdPeca = new System.Windows.Forms.Label();
            this.txtQtdItem = new System.Windows.Forms.TextBox();
            this.btnBuscarItemDtGrid = new System.Windows.Forms.Button();
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
            // txtNmKit
            // 
            this.txtNmKit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNmKit.Location = new System.Drawing.Point(156, 44);
            this.txtNmKit.MaxLength = 50;
            this.txtNmKit.Name = "txtNmKit";
            this.txtNmKit.Size = new System.Drawing.Size(133, 20);
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
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
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
            this.btnAdicionaItem.Click += new System.EventHandler(this.btnAdicionaItem_Click);
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
            this.gbBuscaItem.Controls.Add(this.rdbNome);
            this.gbBuscaItem.Controls.Add(this.rdbCodigo);
            this.gbBuscaItem.Controls.Add(this.TxtNmItem);
            this.gbBuscaItem.Location = new System.Drawing.Point(83, 116);
            this.gbBuscaItem.Name = "gbBuscaItem";
            this.gbBuscaItem.Size = new System.Drawing.Size(498, 243);
            this.gbBuscaItem.TabIndex = 16;
            this.gbBuscaItem.TabStop = false;
            this.gbBuscaItem.Text = "Items do Kit";
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
            this.hIdItem,
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
            this.dgItems.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgItems.Location = new System.Drawing.Point(170, 56);
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
            this.dgItems.Size = new System.Drawing.Size(295, 177);
            this.dgItems.TabIndex = 21;
            this.dgItems.SelectionChanged += new System.EventHandler(this.dgItems_SelectionChanged);
            // 
            // hIdItem
            // 
            this.hIdItem.DataPropertyName = "id_item";
            this.hIdItem.HeaderText = "IdItem";
            this.hIdItem.Name = "hIdItem";
            this.hIdItem.ReadOnly = true;
            this.hIdItem.Visible = false;
            this.hIdItem.Width = 59;
            // 
            // hCodigo
            // 
            this.hCodigo.DataPropertyName = "Codigo";
            this.hCodigo.HeaderText = "Codigo";
            this.hCodigo.Name = "hCodigo";
            this.hCodigo.ReadOnly = true;
            this.hCodigo.Width = 63;
            // 
            // hNome
            // 
            this.hNome.DataPropertyName = "Item";
            this.hNome.HeaderText = "Nome";
            this.hNome.Name = "hNome";
            this.hNome.ReadOnly = true;
            this.hNome.Width = 58;
            // 
            // hQtd
            // 
            this.hQtd.DataPropertyName = "qtd";
            this.hQtd.HeaderText = "Quantidade";
            this.hQtd.Name = "hQtd";
            this.hQtd.ReadOnly = true;
            this.hQtd.Width = 85;
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
            this.btnBuscarItemDtGrid.Click += new System.EventHandler(this.btnBuscarItemDtGrid_Click);
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
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(279, 19);
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
            this.rdbCodigo.Location = new System.Drawing.Point(215, 19);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(58, 17);
            this.rdbCodigo.TabIndex = 19;
            this.rdbCodigo.TabStop = true;
            this.rdbCodigo.Text = "Codigo";
            this.rdbCodigo.UseVisualStyleBackColor = true;
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
            // lblCdKitReal
            // 
            this.lblCdKitReal.AutoSize = true;
            this.lblCdKitReal.Location = new System.Drawing.Point(85, 15);
            this.lblCdKitReal.Name = "lblCdKitReal";
            this.lblCdKitReal.Size = new System.Drawing.Size(70, 13);
            this.lblCdKitReal.TabIndex = 24;
            this.lblCdKitReal.Text = "Codigo do Kit";
            // 
            // txtCodigoKit
            // 
            this.txtCodigoKit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoKit.Location = new System.Drawing.Point(156, 12);
            this.txtCodigoKit.MaxLength = 20;
            this.txtCodigoKit.Name = "txtCodigoKit";
            this.txtCodigoKit.Size = new System.Drawing.Size(133, 20);
            this.txtCodigoKit.TabIndex = 23;
            // 
            // frmCadKitGrupoPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.ControlBox = false;
            this.Controls.Add(this.lblCdKitReal);
            this.Controls.Add(this.txtCodigoKit);
            this.Controls.Add(this.gbBuscaItem);
            this.Controls.Add(this.lblNmKit);
            this.Controls.Add(this.txtNmKit);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
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
        private System.Windows.Forms.TextBox txtNmKit;
        private System.Windows.Forms.Label lblNmKit;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.GroupBox gbBuscaItem;
        private System.Windows.Forms.Button btnAdicionaItem;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.TextBox txtBuscaFiltro;
        private System.Windows.Forms.Label lblQtdPeca;
        private System.Windows.Forms.TextBox txtQtdItem;
        private System.Windows.Forms.Button btnBuscarItemDtGrid;
        private System.Windows.Forms.Label lblNmItem;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.TextBox TxtNmItem;
        private System.Windows.Forms.Label lblCdKitReal;
        private System.Windows.Forms.TextBox txtCodigoKit;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQtd;
    }
}