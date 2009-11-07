namespace TCC.UI
{
    partial class frmCadItemPeca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadItemPeca));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.txtNmItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdicionaPeca = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCdItemReal = new System.Windows.Forms.Label();
            this.gbBuscaPecaItem = new System.Windows.Forms.GroupBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.hIdPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblQtdPeca = new System.Windows.Forms.Label();
            this.btnBuscarPecaDtGrid = new System.Windows.Forms.Button();
            this.lblNmPeca = new System.Windows.Forms.Label();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.TxtNmPeca = new System.Windows.Forms.TextBox();
            this.txtQtdPeca = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.gbBuscaPecaItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackgroundImage = global::TCC.Properties.Resources.btnSalvar;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.Location = new System.Drawing.Point(6, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(40, 35);
            this.btnConfirmar.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnConfirmar, "Cadastrar");
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolta.BackgroundImage")));
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(7, 85);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(40, 35);
            this.btnVolta.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnVolta, "Fechar");
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackgroundImage = global::TCC.Properties.Resources.eraser;
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpa.Location = new System.Drawing.Point(7, 44);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(40, 35);
            this.btnLimpa.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnLimpa, "Limpar");
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // txtNmItem
            // 
            this.txtNmItem.Location = new System.Drawing.Point(163, 51);
            this.txtNmItem.MaxLength = 20;
            this.txtNmItem.Name = "txtNmItem";
            this.txtNmItem.Size = new System.Drawing.Size(137, 20);
            this.txtNmItem.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome Item ";
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // btnAdicionaPeca
            // 
            this.btnAdicionaPeca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionaPeca.BackgroundImage")));
            this.btnAdicionaPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionaPeca.Location = new System.Drawing.Point(66, 175);
            this.btnAdicionaPeca.Name = "btnAdicionaPeca";
            this.btnAdicionaPeca.Size = new System.Drawing.Size(40, 35);
            this.btnAdicionaPeca.TabIndex = 22;
            this.toolTipLegenda.SetToolTip(this.btnAdicionaPeca, "Adiciona Peça");
            this.btnAdicionaPeca.UseVisualStyleBackColor = true;
            this.btnAdicionaPeca.Click += new System.EventHandler(this.btnAdicionaPeca_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 22);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblCdItemReal
            // 
            this.lblCdItemReal.AutoSize = true;
            this.lblCdItemReal.Location = new System.Drawing.Point(80, 25);
            this.lblCdItemReal.Name = "lblCdItemReal";
            this.lblCdItemReal.Size = new System.Drawing.Size(81, 13);
            this.lblCdItemReal.TabIndex = 7;
            this.lblCdItemReal.Text = "Codigo do Item ";
            // 
            // gbBuscaPecaItem
            // 
            this.gbBuscaPecaItem.Controls.Add(this.txtQtdPeca);
            this.gbBuscaPecaItem.Controls.Add(this.btnAdicionaPeca);
            this.gbBuscaPecaItem.Controls.Add(this.dgItems);
            this.gbBuscaPecaItem.Controls.Add(this.txtFiltro);
            this.gbBuscaPecaItem.Controls.Add(this.lblQtdPeca);
            this.gbBuscaPecaItem.Controls.Add(this.btnBuscarPecaDtGrid);
            this.gbBuscaPecaItem.Controls.Add(this.lblNmPeca);
            this.gbBuscaPecaItem.Controls.Add(this.rdbNome);
            this.gbBuscaPecaItem.Controls.Add(this.rdbCodigo);
            this.gbBuscaPecaItem.Controls.Add(this.TxtNmPeca);
            this.gbBuscaPecaItem.Location = new System.Drawing.Point(80, 116);
            this.gbBuscaPecaItem.Name = "gbBuscaPecaItem";
            this.gbBuscaPecaItem.Size = new System.Drawing.Size(498, 243);
            this.gbBuscaPecaItem.TabIndex = 8;
            this.gbBuscaPecaItem.TabStop = false;
            this.gbBuscaPecaItem.Text = "Peças do Item ";
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.AllowUserToResizeColumns = false;
            this.dgItems.AllowUserToResizeRows = false;
            this.dgItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hIdPeca,
            this.hCodigo,
            this.hNome,
            this.hQtd});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgItems.Location = new System.Drawing.Point(188, 60);
            this.dgItems.MultiSelect = false;
            this.dgItems.Name = "dgItems";
            this.dgItems.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItems.ShowEditingIcon = false;
            this.dgItems.Size = new System.Drawing.Size(295, 177);
            this.dgItems.TabIndex = 21;
            this.dgItems.SelectionChanged += new System.EventHandler(this.dgItems_SelectionChanged);
            // 
            // hIdPeca
            // 
            this.hIdPeca.DataPropertyName = "id_peca";
            this.hIdPeca.HeaderText = "IdPeca";
            this.hIdPeca.Name = "hIdPeca";
            this.hIdPeca.ReadOnly = true;
            this.hIdPeca.Visible = false;
            this.hIdPeca.Width = 66;
            // 
            // hCodigo
            // 
            this.hCodigo.DataPropertyName = "Codigo";
            this.hCodigo.HeaderText = "Código";
            this.hCodigo.Name = "hCodigo";
            this.hCodigo.ReadOnly = true;
            this.hCodigo.Width = 65;
            // 
            // hNome
            // 
            this.hNome.DataPropertyName = "Peça";
            this.hNome.HeaderText = "Nome";
            this.hNome.Name = "hNome";
            this.hNome.ReadOnly = true;
            this.hNome.Width = 60;
            // 
            // hQtd
            // 
            this.hQtd.DataPropertyName = "qtd";
            this.hQtd.HeaderText = "Quantidade";
            this.hQtd.Name = "hQtd";
            this.hQtd.ReadOnly = true;
            this.hQtd.Width = 87;
            // 
            // txtFiltro
            // 
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Location = new System.Drawing.Point(216, 36);
            this.txtFiltro.MaxLength = 20;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(179, 20);
            this.txtFiltro.TabIndex = 15;
            // 
            // lblQtdPeca
            // 
            this.lblQtdPeca.AutoSize = true;
            this.lblQtdPeca.Location = new System.Drawing.Point(33, 114);
            this.lblQtdPeca.Name = "lblQtdPeca";
            this.lblQtdPeca.Size = new System.Drawing.Size(62, 13);
            this.lblQtdPeca.TabIndex = 18;
            this.lblQtdPeca.Text = "Quantidade";
            // 
            // btnBuscarPecaDtGrid
            // 
            this.btnBuscarPecaDtGrid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarPecaDtGrid.BackgroundImage")));
            this.btnBuscarPecaDtGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPecaDtGrid.Location = new System.Drawing.Point(395, 22);
            this.btnBuscarPecaDtGrid.Name = "btnBuscarPecaDtGrid";
            this.btnBuscarPecaDtGrid.Size = new System.Drawing.Size(40, 35);
            this.btnBuscarPecaDtGrid.TabIndex = 13;
            this.btnBuscarPecaDtGrid.UseVisualStyleBackColor = true;
            this.btnBuscarPecaDtGrid.Click += new System.EventHandler(this.btnBuscarPecaDtGrid_Click);
            // 
            // lblNmPeca
            // 
            this.lblNmPeca.AutoSize = true;
            this.lblNmPeca.Location = new System.Drawing.Point(33, 56);
            this.lblNmPeca.Name = "lblNmPeca";
            this.lblNmPeca.Size = new System.Drawing.Size(63, 13);
            this.lblNmPeca.TabIndex = 17;
            this.lblNmPeca.Text = "Nome Peça";
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(279, 19);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(53, 17);
            this.rdbNome.TabIndex = 20;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Checked = true;
            this.rdbCodigo.Location = new System.Drawing.Point(215, 19);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(58, 17);
            this.rdbCodigo.TabIndex = 19;
            this.rdbCodigo.TabStop = true;
            this.rdbCodigo.Text = "Codigo";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            // 
            // TxtNmPeca
            // 
            this.TxtNmPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNmPeca.Location = new System.Drawing.Point(36, 72);
            this.TxtNmPeca.MaxLength = 20;
            this.TxtNmPeca.Name = "TxtNmPeca";
            this.TxtNmPeca.Size = new System.Drawing.Size(102, 20);
            this.TxtNmPeca.TabIndex = 14;
            // 
            // txtQtdPeca
            // 
            this.txtQtdPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdPeca.Location = new System.Drawing.Point(36, 131);
            this.txtQtdPeca.Name = "txtQtdPeca";
            this.txtQtdPeca.Size = new System.Drawing.Size(100, 20);
            this.txtQtdPeca.TabIndex = 23;
            this.txtQtdPeca.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // frmCadItemPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 364);
            this.ControlBox = false;
            this.Controls.Add(this.gbBuscaPecaItem);
            this.Controls.Add(this.lblCdItemReal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNmItem);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnConfirmar);
            this.MaximizeBox = false;
            this.Name = "frmCadItemPeca";
            this.Text = "Item";
            this.Load += new System.EventHandler(this.frmCadItemPeca_Load);
            this.gbBuscaPecaItem.ResumeLayout(false);
            this.gbBuscaPecaItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.TextBox txtNmItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCdItemReal;
        private System.Windows.Forms.GroupBox gbBuscaPecaItem;
        private System.Windows.Forms.Button btnAdicionaPeca;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblQtdPeca;
        private System.Windows.Forms.Button btnBuscarPecaDtGrid;
        private System.Windows.Forms.Label lblNmPeca;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.TextBox TxtNmPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIdPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQtd;
        private Controles.MegaTextBox.MegaTextBox txtQtdPeca;
    }
}