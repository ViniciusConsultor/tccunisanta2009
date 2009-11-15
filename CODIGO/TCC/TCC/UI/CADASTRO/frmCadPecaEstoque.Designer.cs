namespace TCC.UI.CADASTRO
{
    partial class frmCadPecaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadPecaEstoque));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPeca = new System.Windows.Forms.TextBox();
            this.lblCdPeca = new System.Windows.Forms.Label();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscarEstoqueDtGrid = new System.Windows.Forms.Button();
            this.btnBuscaPeca = new System.Windows.Forms.Button();
            this.txtBuscaFiltroEstoque = new System.Windows.Forms.TextBox();
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgEstoques = new System.Windows.Forms.DataGridView();
            this.hSelecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hIdEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoques)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPeca
            // 
            this.txtPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeca.Enabled = false;
            this.txtPeca.Location = new System.Drawing.Point(86, 43);
            this.txtPeca.MaxLength = 50;
            this.txtPeca.Name = "txtPeca";
            this.txtPeca.Size = new System.Drawing.Size(181, 20);
            this.txtPeca.TabIndex = 1;
            this.txtPeca.TabStop = false;
            // 
            // lblCdPeca
            // 
            this.lblCdPeca.AutoSize = true;
            this.lblCdPeca.Location = new System.Drawing.Point(83, 28);
            this.lblCdPeca.Name = "lblCdPeca";
            this.lblCdPeca.Size = new System.Drawing.Size(32, 13);
            this.lblCdPeca.TabIndex = 3;
            this.lblCdPeca.Text = "Peça";
            // 
            // btnBuscarEstoqueDtGrid
            // 
            this.btnBuscarEstoqueDtGrid.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscarEstoqueDtGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarEstoqueDtGrid.Location = new System.Drawing.Point(268, 98);
            this.btnBuscarEstoqueDtGrid.Name = "btnBuscarEstoqueDtGrid";
            this.btnBuscarEstoqueDtGrid.Size = new System.Drawing.Size(40, 35);
            this.btnBuscarEstoqueDtGrid.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnBuscarEstoqueDtGrid, "Buscar Estoques");
            this.btnBuscarEstoqueDtGrid.UseVisualStyleBackColor = true;
            this.btnBuscarEstoqueDtGrid.Click += new System.EventHandler(this.btnBuscarEstoqueDtGrid_Click);
            // 
            // btnBuscaPeca
            // 
            this.btnBuscaPeca.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscaPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaPeca.Location = new System.Drawing.Point(268, 28);
            this.btnBuscaPeca.Name = "btnBuscaPeca";
            this.btnBuscaPeca.Size = new System.Drawing.Size(40, 35);
            this.btnBuscaPeca.TabIndex = 1;
            this.toolTipLegenda.SetToolTip(this.btnBuscaPeca, "Buscar Peça");
            this.btnBuscaPeca.UseVisualStyleBackColor = true;
            this.btnBuscaPeca.Click += new System.EventHandler(this.btnBuscaPeca_Click);
            // 
            // txtBuscaFiltroEstoque
            // 
            this.txtBuscaFiltroEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscaFiltroEstoque.Location = new System.Drawing.Point(86, 112);
            this.txtBuscaFiltroEstoque.MaxLength = 20;
            this.txtBuscaFiltroEstoque.Name = "txtBuscaFiltroEstoque";
            this.txtBuscaFiltroEstoque.Size = new System.Drawing.Size(181, 20);
            this.txtBuscaFiltroEstoque.TabIndex = 3;
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(1, 71);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(33, 32);
            this.btnBuscaAlteracaoDelecao.TabIndex = 8;
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            this.btnBuscaAlteracaoDelecao.Click += new System.EventHandler(this.btnBuscaAlteracaoDelecao_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(1, 104);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(33, 32);
            this.btnVolta.TabIndex = 9;
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpa.BackgroundImage")));
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpa.Location = new System.Drawing.Point(1, 35);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(33, 33);
            this.btnLimpa.TabIndex = 7;
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(1, 1);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(33, 31);
            this.btnConfirma.TabIndex = 6;
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Estoque";
            // 
            // dgEstoques
            // 
            this.dgEstoques.AllowUserToAddRows = false;
            this.dgEstoques.AllowUserToDeleteRows = false;
            this.dgEstoques.AllowUserToResizeColumns = false;
            this.dgEstoques.AllowUserToResizeRows = false;
            this.dgEstoques.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEstoques.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEstoques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstoques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hSelecionar,
            this.hIdEstoque,
            this.hNome,
            this.hQuantidade});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEstoques.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgEstoques.Location = new System.Drawing.Point(72, 138);
            this.dgEstoques.MultiSelect = false;
            this.dgEstoques.Name = "dgEstoques";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEstoques.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgEstoques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEstoques.ShowEditingIcon = false;
            this.dgEstoques.Size = new System.Drawing.Size(295, 177);
            this.dgEstoques.TabIndex = 39;
            // 
            // hSelecionar
            // 
            this.hSelecionar.HeaderText = "Selecionar";
            this.hSelecionar.Name = "hSelecionar";
            this.hSelecionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hSelecionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hSelecionar.Width = 80;
            // 
            // hIdEstoque
            // 
            this.hIdEstoque.DataPropertyName = "id_estoq";
            this.hIdEstoque.HeaderText = "IdEstoque";
            this.hIdEstoque.Name = "hIdEstoque";
            this.hIdEstoque.ReadOnly = true;
            this.hIdEstoque.Visible = false;
            this.hIdEstoque.Width = 78;
            // 
            // hNome
            // 
            this.hNome.DataPropertyName = "Estoque";
            this.hNome.HeaderText = "Nome";
            this.hNome.Name = "hNome";
            this.hNome.ReadOnly = true;
            this.hNome.Width = 58;
            // 
            // hQuantidade
            // 
            this.hQuantidade.DataPropertyName = "qtd_peca";
            this.hQuantidade.HeaderText = "Quantidade";
            this.hQuantidade.Name = "hQuantidade";
            this.hQuantidade.Width = 85;
            // 
            // frmCadPecaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(372, 320);
            this.ControlBox = false;
            this.Controls.Add(this.dgEstoques);
            this.Controls.Add(this.btnBuscaPeca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtBuscaFiltroEstoque);
            this.Controls.Add(this.btnBuscarEstoqueDtGrid);
            this.Controls.Add(this.lblCdPeca);
            this.Controls.Add(this.txtPeca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadPecaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Peça/Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoques)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPeca;
        private System.Windows.Forms.Label lblCdPeca;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.TextBox txtBuscaFiltroEstoque;
        private System.Windows.Forms.Button btnBuscarEstoqueDtGrid;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscaPeca;
        private System.Windows.Forms.DataGridView dgEstoques;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIdEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQuantidade;
    }
}