namespace TCC.UI.BUSCA
{
    partial class frmBuscaUsinagem
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
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgUsinagem = new System.Windows.Forms.DataGridView();
            this.huid_usinagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hudta_envio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.huid_peca = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnFechar.BackgroundImage = global::TCC.resImg.btnVoltaCad;
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
            this.btnOK.BackgroundImage = global::TCC.resImg.btnOk;
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
            this.btnBuscar.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(249, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 23);
            this.btnBuscar.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::TCC.resImg.btnLixo;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Location = new System.Drawing.Point(199, 225);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(40, 35);
            this.btnExcluir.TabIndex = 6;
            this.toolTipLegenda.SetToolTip(this.btnExcluir, "Excluir");
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::TCC.resImg.btnalterar;
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
            this.huid_usinagem,
            this.hudta_envio,
            this.huid_peca,
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
            // huid_usinagem
            // 
            this.huid_usinagem.HeaderText = "id";
            this.huid_usinagem.Name = "huid_usinagem";
            this.huid_usinagem.ReadOnly = true;
            this.huid_usinagem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.huid_usinagem.Visible = false;
            this.huid_usinagem.Width = 21;
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
            // huid_peca
            // 
            this.huid_peca.HeaderText = "idpeca";
            this.huid_peca.Name = "huid_peca";
            this.huid_peca.ReadOnly = true;
            this.huid_peca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.huid_peca.Visible = false;
            this.huid_peca.Width = 45;
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
            this.Controls.Add(this.btnExcluir);
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
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn huid_usinagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn hudta_envio;
        private System.Windows.Forms.DataGridViewTextBoxColumn huid_peca;
        private System.Windows.Forms.DataGridViewTextBoxColumn hpid_peca_real;
    }
}