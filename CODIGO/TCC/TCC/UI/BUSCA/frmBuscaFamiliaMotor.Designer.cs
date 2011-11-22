namespace TCC.UI
{
    partial class frmBuscaFamiliaMotor
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgFamMotor = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.hIdFamMotor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgFamMotor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = global::TCC.Telas.resImg.btnOk;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Location = new System.Drawing.Point(108, 227);
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
            this.txtFiltro.Location = new System.Drawing.Point(15, 12);
            this.txtFiltro.MaxLength = 25;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(227, 20);
            this.txtFiltro.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::TCC.Telas.resImg.btnBusca;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(248, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 23);
            this.btnBuscar.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgFamMotor
            // 
            this.dgFamMotor.AllowUserToAddRows = false;
            this.dgFamMotor.AllowUserToDeleteRows = false;
            this.dgFamMotor.AllowUserToResizeColumns = false;
            this.dgFamMotor.AllowUserToResizeRows = false;
            this.dgFamMotor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgFamMotor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFamMotor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hIdFamMotor,
            this.hCodigo,
            this.hNome});
            this.dgFamMotor.Location = new System.Drawing.Point(15, 44);
            this.dgFamMotor.MultiSelect = false;
            this.dgFamMotor.Name = "dgFamMotor";
            this.dgFamMotor.ReadOnly = true;
            this.dgFamMotor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFamMotor.ShowEditingIcon = false;
            this.dgFamMotor.Size = new System.Drawing.Size(260, 177);
            this.dgFamMotor.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = global::TCC.Telas.resImg.btnVoltaCad;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(62, 227);
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
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::TCC.Telas.resImg.btnLixo;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Location = new System.Drawing.Point(200, 227);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(40, 35);
            this.btnExcluir.TabIndex = 6;
            this.toolTipLegenda.SetToolTip(this.btnExcluir, "Excluir");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::TCC.Telas.resImg.btnalterar;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(154, 227);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(40, 35);
            this.btnAlterar.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnAlterar, "Alterar");
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // hIdFamMotor
            // 
            this.hIdFamMotor.DataPropertyName = "Id";
            this.hIdFamMotor.HeaderText = "IdFamMotor";
            this.hIdFamMotor.Name = "hIdFamMotor";
            this.hIdFamMotor.ReadOnly = true;
            this.hIdFamMotor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hIdFamMotor.Visible = false;
            this.hIdFamMotor.Width = 69;
            // 
            // hCodigo
            // 
            this.hCodigo.DataPropertyName = "Codigo";
            this.hCodigo.HeaderText = "Codigo";
            this.hCodigo.Name = "hCodigo";
            this.hCodigo.ReadOnly = true;
            this.hCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hCodigo.Width = 46;
            // 
            // hNome
            // 
            this.hNome.DataPropertyName = "Nome";
            this.hNome.HeaderText = "Nome";
            this.hNome.Name = "hNome";
            this.hNome.ReadOnly = true;
            this.hNome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hNome.Width = 41;
            // 
            // frmBuscaFamiliaMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 266);
            this.ControlBox = false;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgFamMotor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmBuscaFamiliaMotor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busca Familia Motor";
            this.Load += new System.EventHandler(this.frmBuscaFamiliaMotor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFamMotor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgFamMotor;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIdFamMotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNome;
    }
}