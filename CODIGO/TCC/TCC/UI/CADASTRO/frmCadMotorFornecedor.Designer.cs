namespace TCC.UI.CADASTRO
{
    partial class frmCadMotorFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadMotorFornecedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDescMotor = new System.Windows.Forms.TextBox();
            this.lblCdRealMotor = new System.Windows.Forms.Label();
            this.txtBuscaFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscarFornecedorDtGrid = new System.Windows.Forms.Button();
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscaMotor = new System.Windows.Forms.Button();
            this.dgFornecedores = new System.Windows.Forms.DataGridView();
            this.hSelecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hIdForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescMotor
            // 
            this.txtDescMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescMotor.Enabled = false;
            this.txtDescMotor.Location = new System.Drawing.Point(64, 22);
            this.txtDescMotor.Name = "txtDescMotor";
            this.txtDescMotor.Size = new System.Drawing.Size(220, 20);
            this.txtDescMotor.TabIndex = 1;
            this.txtDescMotor.TabStop = false;
            // 
            // lblCdRealMotor
            // 
            this.lblCdRealMotor.AutoSize = true;
            this.lblCdRealMotor.Location = new System.Drawing.Point(61, 6);
            this.lblCdRealMotor.Name = "lblCdRealMotor";
            this.lblCdRealMotor.Size = new System.Drawing.Size(34, 13);
            this.lblCdRealMotor.TabIndex = 42;
            this.lblCdRealMotor.Text = "Motor";
            // 
            // txtBuscaFiltro
            // 
            this.txtBuscaFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscaFiltro.Location = new System.Drawing.Point(64, 64);
            this.txtBuscaFiltro.MaxLength = 20;
            this.txtBuscaFiltro.Name = "txtBuscaFiltro";
            this.txtBuscaFiltro.Size = new System.Drawing.Size(220, 20);
            this.txtBuscaFiltro.TabIndex = 2;
            // 
            // btnBuscarFornecedorDtGrid
            // 
            this.btnBuscarFornecedorDtGrid.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscarFornecedorDtGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarFornecedorDtGrid.Location = new System.Drawing.Point(290, 61);
            this.btnBuscarFornecedorDtGrid.Name = "btnBuscarFornecedorDtGrid";
            this.btnBuscarFornecedorDtGrid.Size = new System.Drawing.Size(27, 23);
            this.btnBuscarFornecedorDtGrid.TabIndex = 3;
            this.btnBuscarFornecedorDtGrid.UseVisualStyleBackColor = true;
            this.btnBuscarFornecedorDtGrid.Click += new System.EventHandler(this.btnBuscarFornecedorDtGrid_Click);
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(2, 60);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaAlteracaoDelecao.TabIndex = 7;
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            this.btnBuscaAlteracaoDelecao.Click += new System.EventHandler(this.btnBuscaAlteracaoDelecao_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(2, 89);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(27, 23);
            this.btnVolta.TabIndex = 8;
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpa.BackgroundImage")));
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpa.Location = new System.Drawing.Point(2, 31);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(27, 23);
            this.btnLimpa.TabIndex = 6;
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(2, 2);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(27, 23);
            this.btnConfirma.TabIndex = 5;
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Fornecedor";
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // btnBuscaMotor
            // 
            this.btnBuscaMotor.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscaMotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaMotor.Location = new System.Drawing.Point(290, 19);
            this.btnBuscaMotor.Name = "btnBuscaMotor";
            this.btnBuscaMotor.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaMotor.TabIndex = 53;
            this.toolTipLegenda.SetToolTip(this.btnBuscaMotor, "Buscar Motor");
            this.btnBuscaMotor.UseVisualStyleBackColor = true;
            this.btnBuscaMotor.Click += new System.EventHandler(this.btnBuscaMotor_Click);
            // 
            // dgFornecedores
            // 
            this.dgFornecedores.AllowUserToAddRows = false;
            this.dgFornecedores.AllowUserToDeleteRows = false;
            this.dgFornecedores.AllowUserToResizeColumns = false;
            this.dgFornecedores.AllowUserToResizeRows = false;
            this.dgFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hSelecionar,
            this.hIdForn,
            this.hNome});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFornecedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgFornecedores.Location = new System.Drawing.Point(64, 99);
            this.dgFornecedores.MultiSelect = false;
            this.dgFornecedores.Name = "dgFornecedores";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFornecedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFornecedores.ShowEditingIcon = false;
            this.dgFornecedores.Size = new System.Drawing.Size(253, 132);
            this.dgFornecedores.TabIndex = 44;
            // 
            // hSelecionar
            // 
            this.hSelecionar.HeaderText = "Selecionar";
            this.hSelecionar.Name = "hSelecionar";
            this.hSelecionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hSelecionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hSelecionar.Width = 80;
            // 
            // hIdForn
            // 
            this.hIdForn.DataPropertyName = "id_forn";
            this.hIdForn.HeaderText = "IdForn";
            this.hIdForn.Name = "hIdForn";
            this.hIdForn.ReadOnly = true;
            this.hIdForn.Visible = false;
            this.hIdForn.Width = 60;
            // 
            // hNome
            // 
            this.hNome.DataPropertyName = "Fornecedor";
            this.hNome.HeaderText = "Nome";
            this.hNome.Name = "hNome";
            this.hNome.ReadOnly = true;
            this.hNome.Width = 58;
            // 
            // frmCadMotorFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 243);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscaMotor);
            this.Controls.Add(this.dgFornecedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtDescMotor);
            this.Controls.Add(this.lblCdRealMotor);
            this.Controls.Add(this.txtBuscaFiltro);
            this.Controls.Add(this.btnBuscarFornecedorDtGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadMotorFornecedor";
            this.Text = "Motor/Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescMotor;
        private System.Windows.Forms.Label lblCdRealMotor;
        private System.Windows.Forms.TextBox txtBuscaFiltro;
        private System.Windows.Forms.Button btnBuscarFornecedorDtGrid;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.DataGridView dgFornecedores;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIdForn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNome;
        private System.Windows.Forms.Button btnBuscaMotor;
    }
}