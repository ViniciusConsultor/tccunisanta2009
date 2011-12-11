namespace TCC.UI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMotorEstoque));
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtQtde = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgEstoques = new System.Windows.Forms.DataGridView();
            this.hIdEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscaMotor = new System.Windows.Forms.Button();
            this.lblCdMotor = new System.Windows.Forms.Label();
            this.txtMotor = new System.Windows.Forms.TextBox();
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoques)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            this.btnRemover.BackgroundImage = global::TCC.resImg.btnLess;
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemover.Location = new System.Drawing.Point(660, 41);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(36, 28);
            this.btnRemover.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnRemover, "Remover");
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtQtde
            // 
            this.txtQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtde.Location = new System.Drawing.Point(483, 44);
            this.txtQtde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQtde.MaxLength = 8;
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(125, 22);
            this.txtQtde.TabIndex = 3;
            this.txtQtde.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = global::TCC.resImg.btnAdd_;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionar.Location = new System.Drawing.Point(616, 41);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(36, 28);
            this.btnAdicionar.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnAdicionar, "Adicionar");
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Quantidade";
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
            this.dgEstoques.Location = new System.Drawing.Point(147, 76);
            this.dgEstoques.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgEstoques.MultiSelect = false;
            this.dgEstoques.Name = "dgEstoques";
            this.dgEstoques.ReadOnly = true;
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
            this.dgEstoques.Size = new System.Drawing.Size(549, 331);
            this.dgEstoques.TabIndex = 48;
            this.dgEstoques.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEstoques_CellClick);
            // 
            // hIdEstoque
            // 
            this.hIdEstoque.DataPropertyName = "id_estoq";
            this.hIdEstoque.HeaderText = "IdEstoque";
            this.hIdEstoque.Name = "hIdEstoque";
            this.hIdEstoque.ReadOnly = true;
            this.hIdEstoque.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hIdEstoque.Visible = false;
            this.hIdEstoque.Width = 59;
            // 
            // hNome
            // 
            this.hNome.DataPropertyName = "Estoque";
            this.hNome.HeaderText = "Nome";
            this.hNome.Name = "hNome";
            this.hNome.ReadOnly = true;
            this.hNome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hNome.Width = 51;
            // 
            // hQuantidade
            // 
            this.hQuantidade.DataPropertyName = "qtd";
            this.hQuantidade.HeaderText = "Quantidade";
            this.hQuantidade.Name = "hQuantidade";
            this.hQuantidade.ReadOnly = true;
            this.hQuantidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hQuantidade.Width = 88;
            // 
            // btnBuscaMotor
            // 
            this.btnBuscaMotor.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscaMotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaMotor.Location = new System.Drawing.Point(397, 41);
            this.btnBuscaMotor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscaMotor.Name = "btnBuscaMotor";
            this.btnBuscaMotor.Size = new System.Drawing.Size(36, 28);
            this.btnBuscaMotor.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnBuscaMotor, "Buscar Peça");
            this.btnBuscaMotor.UseVisualStyleBackColor = true;
            this.btnBuscaMotor.Click += new System.EventHandler(this.btnBuscaMotor_Click);
            // 
            // lblCdMotor
            // 
            this.lblCdMotor.AutoSize = true;
            this.lblCdMotor.Location = new System.Drawing.Point(145, 26);
            this.lblCdMotor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCdMotor.Name = "lblCdMotor";
            this.lblCdMotor.Size = new System.Drawing.Size(44, 17);
            this.lblCdMotor.TabIndex = 47;
            this.lblCdMotor.Text = "Motor";
            // 
            // txtMotor
            // 
            this.txtMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotor.Enabled = false;
            this.txtMotor.Location = new System.Drawing.Point(148, 44);
            this.txtMotor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMotor.MaxLength = 50;
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.Size = new System.Drawing.Size(241, 22);
            this.txtMotor.TabIndex = 1;
            this.txtMotor.TabStop = false;
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(8, 103);
            this.btnBuscaAlteracaoDelecao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(53, 43);
            this.btnBuscaAlteracaoDelecao.TabIndex = 8;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            this.btnBuscaAlteracaoDelecao.Click += new System.EventHandler(this.btnBuscaAlteracaoDelecao_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(8, 154);
            this.btnVolta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(53, 43);
            this.btnVolta.TabIndex = 9;
            this.toolTipLegenda.SetToolTip(this.btnVolta, "Fechar");
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpa.BackgroundImage")));
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpa.Location = new System.Drawing.Point(8, 53);
            this.btnLimpa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(53, 43);
            this.btnLimpa.TabIndex = 7;
            this.toolTipLegenda.SetToolTip(this.btnLimpa, "Limpar");
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(8, 2);
            this.btnConfirma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(53, 43);
            this.btnConfirma.TabIndex = 6;
            this.toolTipLegenda.SetToolTip(this.btnConfirma, "Salvar");
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // frmMotorEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 503);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgEstoques);
            this.Controls.Add(this.btnBuscaMotor);
            this.Controls.Add(this.lblCdMotor);
            this.Controls.Add(this.txtMotor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmMotorEstoque";
            this.Text = "Motor/Estoque";
            this.Load += new System.EventHandler(this.frmMotorEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoques)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemover;
        private Controles.MegaTextBox.MegaTextBox txtQtde;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgEstoques;
        private System.Windows.Forms.Button btnBuscaMotor;
        private System.Windows.Forms.Label lblCdMotor;
        private System.Windows.Forms.TextBox txtMotor;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIdEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQuantidade;
    }
}