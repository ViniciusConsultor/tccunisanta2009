namespace TCC.UI
{
    partial class frmBuscaPeca
    {
        /// <summary>
        /// ReqUIred designer variable.
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
        /// ReqUIred method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnExclUIr = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgPeca = new System.Windows.Forms.DataGridView();
            this.hIdPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hIdPecaReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = global::TCC.UI.resImg.btnOk;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Location = new System.Drawing.Point(101, 226);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(40, 35);
            this.btnOK.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnOK, "Confirmar");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Location = new System.Drawing.Point(15, 11);
            this.txtFiltro.MaxLength = 25;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(227, 20);
            this.txtFiltro.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::TCC.UI.resImg.btnBusca;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(248, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 23);
            this.btnBuscar.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = global::TCC.UI.resImg.btnVoltaCad;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(55, 226);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 35);
            this.btnFechar.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnFechar, "Fechar/Voltar");
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // btnExclUIr
            // 
            this.btnExclUIr.BackgroundImage = global::TCC.UI.resImg.btnLixo;
            this.btnExclUIr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExclUIr.Location = new System.Drawing.Point(193, 226);
            this.btnExclUIr.Name = "btnExclUIr";
            this.btnExclUIr.Size = new System.Drawing.Size(40, 35);
            this.btnExclUIr.TabIndex = 6;
            this.toolTipLegenda.SetToolTip(this.btnExclUIr, "ExclUIr");
            this.btnExclUIr.UseVisualStyleBackColor = true;
            this.btnExclUIr.Click += new System.EventHandler(this.btnExclUIr_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::TCC.UI.resImg.btnalterar;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(147, 226);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(40, 35);
            this.btnAlterar.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnAlterar, "Alterar");
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dgPeca
            // 
            this.dgPeca.AllowUserToAddRows = false;
            this.dgPeca.AllowUserToDeleteRows = false;
            this.dgPeca.AllowUserToResizeColumns = false;
            this.dgPeca.AllowUserToResizeRows = false;
            this.dgPeca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hIdPeca,
            this.hIdPecaReal,
            this.hNome,
            this.hQuantidade});
            this.dgPeca.Location = new System.Drawing.Point(15, 45);
            this.dgPeca.MultiSelect = false;
            this.dgPeca.Name = "dgPeca";
            this.dgPeca.ReadOnly = true;
            this.dgPeca.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgPeca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPeca.ShowEditingIcon = false;
            this.dgPeca.Size = new System.Drawing.Size(260, 177);
            this.dgPeca.TabIndex = 7;
            // 
            // hIdPeca
            // 
            this.hIdPeca.DataPropertyName = "id_peca";
            this.hIdPeca.HeaderText = "IdPeca";
            this.hIdPeca.Name = "hIdPeca";
            this.hIdPeca.ReadOnly = true;
            this.hIdPeca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hIdPeca.Visible = false;
            this.hIdPeca.Width = 47;
            // 
            // hIdPecaReal
            // 
            this.hIdPecaReal.DataPropertyName = "id_peca_real";
            this.hIdPecaReal.HeaderText = "Código Peca";
            this.hIdPecaReal.Name = "hIdPecaReal";
            this.hIdPecaReal.ReadOnly = true;
            this.hIdPecaReal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hIdPecaReal.Width = 74;
            // 
            // hNome
            // 
            this.hNome.DataPropertyName = "nom";
            this.hNome.HeaderText = "Nome Peça";
            this.hNome.Name = "hNome";
            this.hNome.ReadOnly = true;
            this.hNome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hNome.Width = 69;
            // 
            // hQuantidade
            // 
            this.hQuantidade.DataPropertyName = "qtd";
            this.hQuantidade.HeaderText = "Quantidade";
            this.hQuantidade.Name = "hQuantidade";
            this.hQuantidade.ReadOnly = true;
            this.hQuantidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hQuantidade.Visible = false;
            this.hQuantidade.Width = 68;
            // 
            // frmBuscaPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 266);
            this.ControlBox = false;
            this.Controls.Add(this.dgPeca);
            this.Controls.Add(this.btnExclUIr);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmBuscaPeca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busca Peca";
            this.Load += new System.EventHandler(this.frmBuscaPeca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPeca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnExclUIr;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dgPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIdPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIdPecaReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQuantidade;
    }
}