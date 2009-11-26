namespace TCC.UI
{
    partial class frmBuscaOrdemServico
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtFiltroOrdemServico = new System.Windows.Forms.TextBox();
            this.btnBuscarOrdemServico = new System.Windows.Forms.Button();
            this.dgOrdemServico = new System.Windows.Forms.DataGridView();
            this.hCodigoOrdemServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdemServico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::TCC.resImg.btnLixo;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Location = new System.Drawing.Point(191, 224);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(40, 35);
            this.btnExcluir.TabIndex = 13;
            this.toolTipLegenda.SetToolTip(this.btnExcluir, "Excluir");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(145, 224);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(40, 35);
            this.btnAlterar.TabIndex = 12;
            this.toolTipLegenda.SetToolTip(this.btnAlterar, "Alterar");
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = global::TCC.resImg.btnVoltaCad;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(53, 224);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 35);
            this.btnFechar.TabIndex = 10;
            this.toolTipLegenda.SetToolTip(this.btnFechar, "Fechar/Voltar");
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = global::TCC.resImg.btnOk;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Location = new System.Drawing.Point(99, 224);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(40, 35);
            this.btnOK.TabIndex = 11;
            this.toolTipLegenda.SetToolTip(this.btnOK, "Confirmar");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtFiltroOrdemServico
            // 
            this.txtFiltroOrdemServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroOrdemServico.Location = new System.Drawing.Point(16, 9);
            this.txtFiltroOrdemServico.MaxLength = 25;
            this.txtFiltroOrdemServico.Name = "txtFiltroOrdemServico";
            this.txtFiltroOrdemServico.Size = new System.Drawing.Size(227, 20);
            this.txtFiltroOrdemServico.TabIndex = 8;
            // 
            // btnBuscarOrdemServico
            // 
            this.btnBuscarOrdemServico.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscarOrdemServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarOrdemServico.Location = new System.Drawing.Point(249, 9);
            this.btnBuscarOrdemServico.Name = "btnBuscarOrdemServico";
            this.btnBuscarOrdemServico.Size = new System.Drawing.Size(27, 23);
            this.btnBuscarOrdemServico.TabIndex = 9;
            this.btnBuscarOrdemServico.UseVisualStyleBackColor = true;
            this.btnBuscarOrdemServico.Click += new System.EventHandler(this.btnBuscarOrdemServico_Click);
            // 
            // dgOrdemServico
            // 
            this.dgOrdemServico.AllowUserToAddRows = false;
            this.dgOrdemServico.AllowUserToDeleteRows = false;
            this.dgOrdemServico.AllowUserToResizeColumns = false;
            this.dgOrdemServico.AllowUserToResizeRows = false;
            this.dgOrdemServico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgOrdemServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrdemServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hCodigoOrdemServ});
            this.dgOrdemServico.Location = new System.Drawing.Point(16, 41);
            this.dgOrdemServico.MultiSelect = false;
            this.dgOrdemServico.Name = "dgOrdemServico";
            this.dgOrdemServico.ReadOnly = true;
            this.dgOrdemServico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgOrdemServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrdemServico.ShowEditingIcon = false;
            this.dgOrdemServico.Size = new System.Drawing.Size(260, 177);
            this.dgOrdemServico.TabIndex = 7;
            // 
            // hCodigoOrdemServ
            // 
            this.hCodigoOrdemServ.DataPropertyName = "id_ordem_serv";
            this.hCodigoOrdemServ.HeaderText = "Ordem de Servico";
            this.hCodigoOrdemServ.Name = "hCodigoOrdemServ";
            this.hCodigoOrdemServ.ReadOnly = true;
            this.hCodigoOrdemServ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hCodigoOrdemServ.Width = 86;
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // frmBuscaOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(292, 268);
            this.ControlBox = false;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFiltroOrdemServico);
            this.Controls.Add(this.btnBuscarOrdemServico);
            this.Controls.Add(this.dgOrdemServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmBuscaOrdemServico";
            this.Text = "Busca Ordem de Servico";
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdemServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtFiltroOrdemServico;
        private System.Windows.Forms.Button btnBuscarOrdemServico;
        private System.Windows.Forms.DataGridView dgOrdemServico;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCodigoOrdemServ;
    }
}