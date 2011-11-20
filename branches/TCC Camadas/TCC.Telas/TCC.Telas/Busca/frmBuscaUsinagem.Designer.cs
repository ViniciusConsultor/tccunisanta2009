namespace TCC.UI.BUSCA
{
    partial class frmBuscaUsinagem
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
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExclUIr = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgUsinagem = new System.Windows.Forms.DataGridView();
            this.hUId_usinagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hudta_envio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hUId_peca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hpid_peca_real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsinagem)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = global::TCC.UI.resImg.btnVoltaCad;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(61, 225);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 35);
            this.btnFechar.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnFechar, "Fechar/Voltar");
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = global::TCC.UI.resImg.btnOk;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Location = new System.Drawing.Point(107, 225);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(40, 35);
            this.btnOK.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnOK, "Confirmar");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::TCC.UI.resImg.btnBusca;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(249, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 23);
            this.btnBuscar.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExclUIr
            // 
            this.btnExclUIr.BackgroundImage = global::TCC.UI.resImg.btnLixo;
            this.btnExclUIr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExclUIr.Location = new System.Drawing.Point(199, 225);
            this.btnExclUIr.Name = "btnExclUIr";
            this.btnExclUIr.Size = new System.Drawing.Size(40, 35);
            this.btnExclUIr.TabIndex = 6;
            this.toolTipLegenda.SetToolTip(this.btnExclUIr, "ExclUIr");
            this.btnExclUIr.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::TCC.UI.resImg.btnalterar;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(153, 225);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(40, 35);
            this.btnAlterar.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnAlterar, "Alterar");
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Location = new System.Drawing.Point(16, 10);
            this.txtFiltro.MaxLength = 25;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(227, 20);
            this.txtFiltro.TabIndex = 1;
            // 
            // dgUsinagem
            // 
            this.dgUsinagem.AllowUserToAddRows = false;
            this.dgUsinagem.AllowUserToDeleteRows = false;
            this.dgUsinagem.AllowUserToResizeColumns = false;
            this.dgUsinagem.AllowUserToResizeRows = false;
            this.dgUsinagem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgUsinagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsinagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hUId_usinagem,
            this.hudta_envio,
            this.hUId_peca,
            this.hpid_peca_real});
            this.dgUsinagem.Location = new System.Drawing.Point(16, 42);
            this.dgUsinagem.MultiSelect = false;
            this.dgUsinagem.Name = "dgUsinagem";
            this.dgUsinagem.ReadOnly = true;
            this.dgUsinagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsinagem.ShowEditingIcon = false;
            this.dgUsinagem.Size = new System.Drawing.Size(260, 177);
            this.dgUsinagem.TabIndex = 5;
            // 
            // hUId_usinagem
            // 
            this.hUId_usinagem.HeaderText = "id";
            this.hUId_usinagem.Name = "hUId_usinagem";
            this.hUId_usinagem.ReadOnly = true;
            this.hUId_usinagem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hUId_usinagem.Visible = false;
            this.hUId_usinagem.Width = 21;
            // 
            // hudta_envio
            // 
            this.hudta_envio.HeaderText = "data";
            this.hudta_envio.Name = "hudta_envio";
            this.hudta_envio.ReadOnly = true;
            this.hudta_envio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hudta_envio.Visible = false;
            this.hudta_envio.Width = 34;
            // 
            // hUId_peca
            // 
            this.hUId_peca.HeaderText = "idpeca";
            this.hUId_peca.Name = "hUId_peca";
            this.hUId_peca.ReadOnly = true;
            this.hUId_peca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hUId_peca.Visible = false;
            this.hUId_peca.Width = 45;
            // 
            // hpid_peca_real
            // 
            this.hpid_peca_real.HeaderText = "codigo";
            this.hpid_peca_real.Name = "hpid_peca_real";
            this.hpid_peca_real.ReadOnly = true;
            this.hpid_peca_real.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hpid_peca_real.Width = 45;
            // 
            // frmBuscaUsinagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 268);
            this.Controls.Add(this.btnExclUIr);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgUsinagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmBuscaUsinagem";
            this.Text = "Busca Usinagem";
            ((System.ComponentModel.ISupportInitialize)(this.dgUsinagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgUsinagem;
        private System.Windows.Forms.Button btnExclUIr;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn hUId_usinagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn hudta_envio;
        private System.Windows.Forms.DataGridViewTextBoxColumn hUId_peca;
        private System.Windows.Forms.DataGridViewTextBoxColumn hpid_peca_real;
    }
}