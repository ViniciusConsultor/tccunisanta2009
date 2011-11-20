namespace TCC.UI
{
    partial class frmBuscaEstoque
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
            this.dgEstoque = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnExclUIr = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.hIdEstoq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDescEstoq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hqtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = global::TCC.UI.resImg.btnOk;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Location = new System.Drawing.Point(107, 226);
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
            this.txtFiltro.Location = new System.Drawing.Point(14, 11);
            this.txtFiltro.MaxLength = 25;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(227, 20);
            this.txtFiltro.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::TCC.UI.resImg.btnBusca;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(247, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 23);
            this.btnBuscar.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgEstoque
            // 
            this.dgEstoque.AllowUserToAddRows = false;
            this.dgEstoque.AllowUserToDeleteRows = false;
            this.dgEstoque.AllowUserToResizeColumns = false;
            this.dgEstoque.AllowUserToResizeRows = false;
            this.dgEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hIdEstoq,
            this.hDescEstoq,
            this.hqtd});
            this.dgEstoque.Location = new System.Drawing.Point(14, 43);
            this.dgEstoque.MultiSelect = false;
            this.dgEstoque.Name = "dgEstoque";
            this.dgEstoque.ReadOnly = true;
            this.dgEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEstoque.ShowEditingIcon = false;
            this.dgEstoque.Size = new System.Drawing.Size(260, 177);
            this.dgEstoque.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = global::TCC.UI.resImg.btnVoltaCad;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(61, 226);
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
            this.btnExclUIr.Location = new System.Drawing.Point(199, 226);
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
            this.btnAlterar.Location = new System.Drawing.Point(153, 226);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(40, 35);
            this.btnAlterar.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnAlterar, "Alterar");
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // hIdEstoq
            // 
            this.hIdEstoq.DataPropertyName = "id_estoq";
            this.hIdEstoq.HeaderText = "Id";
            this.hIdEstoq.Name = "hIdEstoq";
            this.hIdEstoq.ReadOnly = true;
            this.hIdEstoq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hIdEstoq.Visible = false;
            this.hIdEstoq.Width = 20;
            // 
            // hDescEstoq
            // 
            this.hDescEstoq.DataPropertyName = "Estoque";
            this.hDescEstoq.HeaderText = "Nome";
            this.hDescEstoq.Name = "hDescEstoq";
            this.hDescEstoq.ReadOnly = true;
            this.hDescEstoq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hDescEstoq.Width = 39;
            // 
            // hqtd
            // 
            this.hqtd.DataPropertyName = "qtd_peca";
            this.hqtd.HeaderText = "Quantidade";
            this.hqtd.Name = "hqtd";
            this.hqtd.ReadOnly = true;
            this.hqtd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hqtd.Visible = false;
            this.hqtd.Width = 66;
            // 
            // frmBuscaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 266);
            this.ControlBox = false;
            this.Controls.Add(this.btnExclUIr);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmBuscaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busca Estoque";
            this.Load += new System.EventHandler(this.frmBuscaEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgEstoque;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnExclUIr;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIdEstoq;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDescEstoq;
        private System.Windows.Forms.DataGridViewTextBoxColumn hqtd;
    }
}