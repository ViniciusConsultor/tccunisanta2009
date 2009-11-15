﻿namespace TCC.UI.CADASTRO
{
    partial class frmPecaFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPecaFornecedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNomePeca = new System.Windows.Forms.TextBox();
            this.lblNomePeca = new System.Windows.Forms.Label();
            this.txtBuscaFiltroFornecedor = new System.Windows.Forms.TextBox();
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnBuscarFornecedorDtGrid = new System.Windows.Forms.Button();
            this.dgFornecedores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscaPeca = new System.Windows.Forms.Button();
            this.hSelecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hIdFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomePeca
            // 
            this.txtNomePeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomePeca.Enabled = false;
            this.txtNomePeca.Location = new System.Drawing.Point(95, 42);
            this.txtNomePeca.Name = "txtNomePeca";
            this.txtNomePeca.ReadOnly = true;
            this.txtNomePeca.Size = new System.Drawing.Size(179, 20);
            this.txtNomePeca.TabIndex = 1;
            // 
            // lblNomePeca
            // 
            this.lblNomePeca.AutoSize = true;
            this.lblNomePeca.Location = new System.Drawing.Point(92, 26);
            this.lblNomePeca.Name = "lblNomePeca";
            this.lblNomePeca.Size = new System.Drawing.Size(32, 13);
            this.lblNomePeca.TabIndex = 37;
            this.lblNomePeca.Text = "Peca";
            // 
            // txtBuscaFiltroFornecedor
            // 
            this.txtBuscaFiltroFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscaFiltroFornecedor.Location = new System.Drawing.Point(95, 106);
            this.txtBuscaFiltroFornecedor.MaxLength = 20;
            this.txtBuscaFiltroFornecedor.Name = "txtBuscaFiltroFornecedor";
            this.txtBuscaFiltroFornecedor.Size = new System.Drawing.Size(182, 20);
            this.txtBuscaFiltroFornecedor.TabIndex = 2;
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(0, 72);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(33, 32);
            this.btnBuscaAlteracaoDelecao.TabIndex = 7;
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            this.btnBuscaAlteracaoDelecao.Click += new System.EventHandler(this.btnBuscaAlteracaoDelecao_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(0, 109);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(33, 32);
            this.btnVolta.TabIndex = 8;
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpa.BackgroundImage")));
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpa.Location = new System.Drawing.Point(0, 36);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(33, 33);
            this.btnLimpa.TabIndex = 6;
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(0, 2);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(33, 31);
            this.btnConfirma.TabIndex = 5;
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnBuscarFornecedorDtGrid
            // 
            this.btnBuscarFornecedorDtGrid.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscarFornecedorDtGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarFornecedorDtGrid.Location = new System.Drawing.Point(278, 92);
            this.btnBuscarFornecedorDtGrid.Name = "btnBuscarFornecedorDtGrid";
            this.btnBuscarFornecedorDtGrid.Size = new System.Drawing.Size(40, 35);
            this.btnBuscarFornecedorDtGrid.TabIndex = 3;
            this.btnBuscarFornecedorDtGrid.UseVisualStyleBackColor = true;
            this.btnBuscarFornecedorDtGrid.Click += new System.EventHandler(this.btnBuscarFornecedorDtGrid_Click);
            // 
            // dgFornecedores
            // 
            this.dgFornecedores.AllowUserToAddRows = false;
            this.dgFornecedores.AllowUserToDeleteRows = false;
            this.dgFornecedores.AllowUserToResizeColumns = false;
            this.dgFornecedores.AllowUserToResizeRows = false;
            this.dgFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hSelecionar,
            this.hIdFornecedor,
            this.hNome});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFornecedores.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgFornecedores.Location = new System.Drawing.Point(73, 133);
            this.dgFornecedores.MultiSelect = false;
            this.dgFornecedores.Name = "dgFornecedores";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFornecedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFornecedores.ShowEditingIcon = false;
            this.dgFornecedores.Size = new System.Drawing.Size(295, 177);
            this.dgFornecedores.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Fornecedor";
            // 
            // btnBuscaPeca
            // 
            this.btnBuscaPeca.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscaPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaPeca.Location = new System.Drawing.Point(278, 27);
            this.btnBuscaPeca.Name = "btnBuscaPeca";
            this.btnBuscaPeca.Size = new System.Drawing.Size(40, 35);
            this.btnBuscaPeca.TabIndex = 40;
            this.btnBuscaPeca.UseVisualStyleBackColor = true;
            this.btnBuscaPeca.Click += new System.EventHandler(this.btnBuscaPeca_Click);
            // 
            // hSelecionar
            // 
            this.hSelecionar.HeaderText = "Selecionar";
            this.hSelecionar.Name = "hSelecionar";
            this.hSelecionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hSelecionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hSelecionar.Width = 80;
            // 
            // hIdFornecedor
            // 
            this.hIdFornecedor.DataPropertyName = "id_forn";
            this.hIdFornecedor.HeaderText = "IdFornecedor";
            this.hIdFornecedor.Name = "hIdFornecedor";
            this.hIdFornecedor.ReadOnly = true;
            this.hIdFornecedor.Visible = false;
            this.hIdFornecedor.Width = 93;
            // 
            // hNome
            // 
            this.hNome.DataPropertyName = "Fornecedor";
            this.hNome.HeaderText = "Nome";
            this.hNome.Name = "hNome";
            this.hNome.ReadOnly = true;
            this.hNome.Width = 58;
            // 
            // frmPecaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(377, 316);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscaPeca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgFornecedores);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.txtNomePeca);
            this.Controls.Add(this.lblNomePeca);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtBuscaFiltroFornecedor);
            this.Controls.Add(this.btnBuscarFornecedorDtGrid);
            this.MaximizeBox = false;
            this.Name = "frmPecaFornecedor";
            this.Text = "Peca/Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private System.Windows.Forms.TextBox txtNomePeca;
        private System.Windows.Forms.Label lblNomePeca;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.TextBox txtBuscaFiltroFornecedor;
        private System.Windows.Forms.Button btnBuscarFornecedorDtGrid;
        private System.Windows.Forms.DataGridView dgFornecedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscaPeca;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIdFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNome;
    }
}