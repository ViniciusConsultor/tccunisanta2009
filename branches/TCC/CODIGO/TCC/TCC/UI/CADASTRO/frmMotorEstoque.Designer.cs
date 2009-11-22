namespace TCC.UI.CADASTRO
{
    partial class frmMotorEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMotorEstoque));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnBuscaMotor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescMotor = new System.Windows.Forms.TextBox();
            this.lblCdRealMotor = new System.Windows.Forms.Label();
            this.txtBuscaFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscarFornecedorDtGrid = new System.Windows.Forms.Button();
            this.dgEstoque = new System.Windows.Forms.DataGridView();
            this.hSelecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hIdForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveMotor = new System.Windows.Forms.Button();
            this.txtQtdMotor = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.btnAdicionaMotor = new System.Windows.Forms.Button();
            this.lblQtdPeca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(1, 72);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(33, 31);
            this.btnBuscaAlteracaoDelecao.TabIndex = 11;
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(1, 106);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(33, 31);
            this.btnVolta.TabIndex = 12;
            this.btnVolta.UseVisualStyleBackColor = true;
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpa.BackgroundImage")));
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpa.Location = new System.Drawing.Point(1, 39);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(33, 31);
            this.btnLimpa.TabIndex = 10;
            this.btnLimpa.UseVisualStyleBackColor = true;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(1, 5);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(33, 31);
            this.btnConfirma.TabIndex = 9;
            this.btnConfirma.UseVisualStyleBackColor = true;
            // 
            // btnBuscaMotor
            // 
            this.btnBuscaMotor.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscaMotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaMotor.Location = new System.Drawing.Point(165, 41);
            this.btnBuscaMotor.Name = "btnBuscaMotor";
            this.btnBuscaMotor.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaMotor.TabIndex = 59;
            this.btnBuscaMotor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Estoque";
            // 
            // txtDescMotor
            // 
            this.txtDescMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescMotor.Enabled = false;
            this.txtDescMotor.Location = new System.Drawing.Point(60, 44);
            this.txtDescMotor.Name = "txtDescMotor";
            this.txtDescMotor.Size = new System.Drawing.Size(99, 20);
            this.txtDescMotor.TabIndex = 54;
            this.txtDescMotor.TabStop = false;
            // 
            // lblCdRealMotor
            // 
            this.lblCdRealMotor.AutoSize = true;
            this.lblCdRealMotor.Location = new System.Drawing.Point(57, 25);
            this.lblCdRealMotor.Name = "lblCdRealMotor";
            this.lblCdRealMotor.Size = new System.Drawing.Size(34, 13);
            this.lblCdRealMotor.TabIndex = 57;
            this.lblCdRealMotor.Text = "Motor";
            // 
            // txtBuscaFiltro
            // 
            this.txtBuscaFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscaFiltro.Location = new System.Drawing.Point(60, 98);
            this.txtBuscaFiltro.MaxLength = 20;
            this.txtBuscaFiltro.Name = "txtBuscaFiltro";
            this.txtBuscaFiltro.Size = new System.Drawing.Size(271, 20);
            this.txtBuscaFiltro.TabIndex = 55;
            // 
            // btnBuscarFornecedorDtGrid
            // 
            this.btnBuscarFornecedorDtGrid.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscarFornecedorDtGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarFornecedorDtGrid.Location = new System.Drawing.Point(337, 95);
            this.btnBuscarFornecedorDtGrid.Name = "btnBuscarFornecedorDtGrid";
            this.btnBuscarFornecedorDtGrid.Size = new System.Drawing.Size(27, 23);
            this.btnBuscarFornecedorDtGrid.TabIndex = 56;
            this.btnBuscarFornecedorDtGrid.UseVisualStyleBackColor = true;
            // 
            // dgEstoque
            // 
            this.dgEstoque.AllowUserToAddRows = false;
            this.dgEstoque.AllowUserToDeleteRows = false;
            this.dgEstoque.AllowUserToResizeColumns = false;
            this.dgEstoque.AllowUserToResizeRows = false;
            this.dgEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgEstoque.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgEstoque.Location = new System.Drawing.Point(60, 124);
            this.dgEstoque.MultiSelect = false;
            this.dgEstoque.Name = "dgEstoque";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEstoque.ShowEditingIcon = false;
            this.dgEstoque.Size = new System.Drawing.Size(304, 154);
            this.dgEstoque.TabIndex = 60;
            // 
            // hSelecionar
            // 
            this.hSelecionar.HeaderText = "Selecionar";
            this.hSelecionar.Name = "hSelecionar";
            this.hSelecionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hSelecionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hSelecionar.Width = 82;
            // 
            // hIdForn
            // 
            this.hIdForn.DataPropertyName = "id_estoq";
            this.hIdForn.HeaderText = "IdForn";
            this.hIdForn.Name = "hIdForn";
            this.hIdForn.ReadOnly = true;
            this.hIdForn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hIdForn.Visible = false;
            this.hIdForn.Width = 43;
            // 
            // hNome
            // 
            this.hNome.DataPropertyName = "Motor";
            this.hNome.HeaderText = "Nome";
            this.hNome.Name = "hNome";
            this.hNome.ReadOnly = true;
            this.hNome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hNome.Width = 41;
            // 
            // btnRemoveMotor
            // 
            this.btnRemoveMotor.BackgroundImage = global::TCC.resImg.btnLess;
            this.btnRemoveMotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveMotor.Location = new System.Drawing.Point(337, 41);
            this.btnRemoveMotor.Name = "btnRemoveMotor";
            this.btnRemoveMotor.Size = new System.Drawing.Size(27, 23);
            this.btnRemoveMotor.TabIndex = 63;
            this.btnRemoveMotor.UseVisualStyleBackColor = true;
            // 
            // txtQtdMotor
            // 
            this.txtQtdMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdMotor.Location = new System.Drawing.Point(198, 44);
            this.txtQtdMotor.MaxLength = 2;
            this.txtQtdMotor.Name = "txtQtdMotor";
            this.txtQtdMotor.Size = new System.Drawing.Size(100, 20);
            this.txtQtdMotor.TabIndex = 61;
            this.txtQtdMotor.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // btnAdicionaMotor
            // 
            this.btnAdicionaMotor.BackgroundImage = global::TCC.resImg.btnAdd_;
            this.btnAdicionaMotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionaMotor.Location = new System.Drawing.Point(304, 41);
            this.btnAdicionaMotor.Name = "btnAdicionaMotor";
            this.btnAdicionaMotor.Size = new System.Drawing.Size(27, 23);
            this.btnAdicionaMotor.TabIndex = 62;
            this.btnAdicionaMotor.UseVisualStyleBackColor = true;
            this.btnAdicionaMotor.Click += new System.EventHandler(this.btnAdicionaPeca_Click);
            // 
            // lblQtdPeca
            // 
            this.lblQtdPeca.AutoSize = true;
            this.lblQtdPeca.Location = new System.Drawing.Point(195, 27);
            this.lblQtdPeca.Name = "lblQtdPeca";
            this.lblQtdPeca.Size = new System.Drawing.Size(62, 13);
            this.lblQtdPeca.TabIndex = 64;
            this.lblQtdPeca.Text = "Quantidade";
            // 
            // frmMotorEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(379, 290);
            this.Controls.Add(this.btnRemoveMotor);
            this.Controls.Add(this.txtQtdMotor);
            this.Controls.Add(this.btnAdicionaMotor);
            this.Controls.Add(this.lblQtdPeca);
            this.Controls.Add(this.dgEstoque);
            this.Controls.Add(this.btnBuscaMotor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescMotor);
            this.Controls.Add(this.lblCdRealMotor);
            this.Controls.Add(this.txtBuscaFiltro);
            this.Controls.Add(this.btnBuscarFornecedorDtGrid);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnConfirma);
            this.Name = "frmMotorEstoque";
            this.Text = "Motor Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnBuscaMotor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescMotor;
        private System.Windows.Forms.Label lblCdRealMotor;
        private System.Windows.Forms.TextBox txtBuscaFiltro;
        private System.Windows.Forms.Button btnBuscarFornecedorDtGrid;
        private System.Windows.Forms.DataGridView dgEstoque;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIdForn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNome;
        private System.Windows.Forms.Button btnRemoveMotor;
        private Controles.MegaTextBox.MegaTextBox txtQtdMotor;
        private System.Windows.Forms.Button btnAdicionaMotor;
        private System.Windows.Forms.Label lblQtdPeca;
    }
}