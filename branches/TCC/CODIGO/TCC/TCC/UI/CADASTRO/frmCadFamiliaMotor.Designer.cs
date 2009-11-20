namespace TCC.UI
{
    partial class frmCadFamiliaMotor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadFamiliaMotor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDsMotor = new System.Windows.Forms.Label();
            this.txtDsMotor = new System.Windows.Forms.TextBox();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdicionaKit = new System.Windows.Forms.Button();
            this.btnBuscarKitDtGrid = new System.Windows.Forms.Button();
            this.btnBuscaEstoque = new System.Windows.Forms.Button();
            this.btnBuscaMotorCompra = new System.Windows.Forms.Button();
            this.btnBuscaTipoMotor = new System.Windows.Forms.Button();
            this.btnRemoveKit = new System.Windows.Forms.Button();
            this.btnBuscaNumMotor = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.gbBuscaKit = new System.Windows.Forms.GroupBox();
            this.txtQtdKit = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.dgKits = new System.Windows.Forms.DataGridView();
            this.txtBuscaFiltro = new System.Windows.Forms.TextBox();
            this.lblQtdKit = new System.Windows.Forms.Label();
            this.lblNmItem = new System.Windows.Forms.Label();
            this.rdbFiltroNome = new System.Windows.Forms.RadioButton();
            this.rdbFiltroCodigo = new System.Windows.Forms.RadioButton();
            this.TxtNmKit = new System.Windows.Forms.TextBox();
            this.gbMotor = new System.Windows.Forms.GroupBox();
            this.txtNumeroMotor = new System.Windows.Forms.TextBox();
            this.lblNumeroMotor = new System.Windows.Forms.Label();
            this.txtTipoMotor = new System.Windows.Forms.TextBox();
            this.lblTipoMotor = new System.Windows.Forms.Label();
            this.txtMotorCompra = new System.Windows.Forms.TextBox();
            this.lblMotorCompra = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtCodigoFamMotor = new System.Windows.Forms.TextBox();
            this.lblCodigoFamMotor = new System.Windows.Forms.Label();
            this.hIdKit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBuscaKit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKits)).BeginInit();
            this.gbMotor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDsMotor
            // 
            this.lblDsMotor.AutoSize = true;
            this.lblDsMotor.Location = new System.Drawing.Point(76, 28);
            this.lblDsMotor.Name = "lblDsMotor";
            this.lblDsMotor.Size = new System.Drawing.Size(161, 13);
            this.lblDsMotor.TabIndex = 0;
            this.lblDsMotor.Text = "Descrição da Familia de Motores";
            // 
            // txtDsMotor
            // 
            this.txtDsMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDsMotor.Location = new System.Drawing.Point(79, 44);
            this.txtDsMotor.MaxLength = 500;
            this.txtDsMotor.Multiline = true;
            this.txtDsMotor.Name = "txtDsMotor";
            this.txtDsMotor.Size = new System.Drawing.Size(354, 20);
            this.txtDsMotor.TabIndex = 1;
            this.txtDsMotor.TextChanged += new System.EventHandler(this.txtDsMotor_TextChanged);
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpa.BackgroundImage")));
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpa.Location = new System.Drawing.Point(7, 47);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(40, 35);
            this.btnLimpa.TabIndex = 14;
            this.toolTipLegenda.SetToolTip(this.btnLimpa, "Limpar");
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(7, 129);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(40, 35);
            this.btnVolta.TabIndex = 16;
            this.toolTipLegenda.SetToolTip(this.btnVolta, "Fechar");
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // btnAdicionaKit
            // 
            this.btnAdicionaKit.BackgroundImage = global::TCC.resImg.btnAdd_;
            this.btnAdicionaKit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionaKit.Location = new System.Drawing.Point(36, 172);
            this.btnAdicionaKit.Name = "btnAdicionaKit";
            this.btnAdicionaKit.Size = new System.Drawing.Size(40, 35);
            this.btnAdicionaKit.TabIndex = 11;
            this.toolTipLegenda.SetToolTip(this.btnAdicionaKit, "Adicionar Kits");
            this.btnAdicionaKit.UseVisualStyleBackColor = true;
            this.btnAdicionaKit.Click += new System.EventHandler(this.btnAdicionaKit_Click);
            // 
            // btnBuscarKitDtGrid
            // 
            this.btnBuscarKitDtGrid.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscarKitDtGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarKitDtGrid.Location = new System.Drawing.Point(439, 23);
            this.btnBuscarKitDtGrid.Name = "btnBuscarKitDtGrid";
            this.btnBuscarKitDtGrid.Size = new System.Drawing.Size(27, 23);
            this.btnBuscarKitDtGrid.TabIndex = 9;
            this.toolTipLegenda.SetToolTip(this.btnBuscarKitDtGrid, "Buscar Kits");
            this.btnBuscarKitDtGrid.UseVisualStyleBackColor = true;
            this.btnBuscarKitDtGrid.Click += new System.EventHandler(this.btnBuscarKitDtGrid_Click);
            // 
            // btnBuscaEstoque
            // 
            this.btnBuscaEstoque.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscaEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaEstoque.Location = new System.Drawing.Point(548, 42);
            this.btnBuscaEstoque.Name = "btnBuscaEstoque";
            this.btnBuscaEstoque.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaEstoque.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnBuscaEstoque, "Buscar Estoque");
            this.btnBuscaEstoque.UseVisualStyleBackColor = true;
            this.btnBuscaEstoque.Click += new System.EventHandler(this.btnBuscaEstoque_Click);
            // 
            // btnBuscaMotorCompra
            // 
            this.btnBuscaMotorCompra.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscaMotorCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaMotorCompra.Location = new System.Drawing.Point(196, 21);
            this.btnBuscaMotorCompra.Name = "btnBuscaMotorCompra";
            this.btnBuscaMotorCompra.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaMotorCompra.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnBuscaMotorCompra, "Buscar Motor");
            this.btnBuscaMotorCompra.UseVisualStyleBackColor = true;
            this.btnBuscaMotorCompra.Click += new System.EventHandler(this.btnBuscaMotorCompra_Click);
            // 
            // btnBuscaTipoMotor
            // 
            this.btnBuscaTipoMotor.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscaTipoMotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaTipoMotor.Location = new System.Drawing.Point(465, 37);
            this.btnBuscaTipoMotor.Name = "btnBuscaTipoMotor";
            this.btnBuscaTipoMotor.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaTipoMotor.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnBuscaTipoMotor, "Buscar Tipo do Motor");
            this.btnBuscaTipoMotor.UseVisualStyleBackColor = true;
            this.btnBuscaTipoMotor.Click += new System.EventHandler(this.btnBuscaTipoMotor_Click);
            // 
            // btnRemoveKit
            // 
            this.btnRemoveKit.BackgroundImage = global::TCC.resImg.btnLess;
            this.btnRemoveKit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveKit.Location = new System.Drawing.Point(98, 172);
            this.btnRemoveKit.Name = "btnRemoveKit";
            this.btnRemoveKit.Size = new System.Drawing.Size(40, 35);
            this.btnRemoveKit.TabIndex = 12;
            this.toolTipLegenda.SetToolTip(this.btnRemoveKit, "Remover Kits");
            this.btnRemoveKit.UseVisualStyleBackColor = true;
            // 
            // btnBuscaNumMotor
            // 
            this.btnBuscaNumMotor.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscaNumMotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaNumMotor.Location = new System.Drawing.Point(466, 8);
            this.btnBuscaNumMotor.Name = "btnBuscaNumMotor";
            this.btnBuscaNumMotor.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaNumMotor.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnBuscaNumMotor, "Buscar Número do Motor");
            this.btnBuscaNumMotor.UseVisualStyleBackColor = true;
            this.btnBuscaNumMotor.Click += new System.EventHandler(this.btnBuscaNumMotor_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(7, 4);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(40, 35);
            this.btnConfirma.TabIndex = 13;
            this.toolTipLegenda.SetToolTip(this.btnConfirma, "Salvar");
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(7, 87);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(40, 35);
            this.btnBuscaAlteracaoDelecao.TabIndex = 15;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            // 
            // gbBuscaKit
            // 
            this.gbBuscaKit.Controls.Add(this.txtQtdKit);
            this.gbBuscaKit.Controls.Add(this.btnRemoveKit);
            this.gbBuscaKit.Controls.Add(this.btnAdicionaKit);
            this.gbBuscaKit.Controls.Add(this.dgKits);
            this.gbBuscaKit.Controls.Add(this.txtBuscaFiltro);
            this.gbBuscaKit.Controls.Add(this.lblQtdKit);
            this.gbBuscaKit.Controls.Add(this.btnBuscarKitDtGrid);
            this.gbBuscaKit.Controls.Add(this.lblNmItem);
            this.gbBuscaKit.Controls.Add(this.rdbFiltroNome);
            this.gbBuscaKit.Controls.Add(this.rdbFiltroCodigo);
            this.gbBuscaKit.Controls.Add(this.TxtNmKit);
            this.gbBuscaKit.Location = new System.Drawing.Point(82, 131);
            this.gbBuscaKit.Name = "gbBuscaKit";
            this.gbBuscaKit.Size = new System.Drawing.Size(498, 235);
            this.gbBuscaKit.TabIndex = 10;
            this.gbBuscaKit.TabStop = false;
            this.gbBuscaKit.Text = "Kits da Familia Motor";
            // 
            // txtQtdKit
            // 
            this.txtQtdKit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdKit.Location = new System.Drawing.Point(36, 131);
            this.txtQtdKit.MaxLength = 2;
            this.txtQtdKit.Name = "txtQtdKit";
            this.txtQtdKit.Size = new System.Drawing.Size(100, 20);
            this.txtQtdKit.TabIndex = 10;
            this.txtQtdKit.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // dgKits
            // 
            this.dgKits.AllowUserToAddRows = false;
            this.dgKits.AllowUserToDeleteRows = false;
            this.dgKits.AllowUserToResizeColumns = false;
            this.dgKits.AllowUserToResizeRows = false;
            this.dgKits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgKits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgKits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hIdKit,
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
            this.dgKits.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgKits.Location = new System.Drawing.Point(171, 52);
            this.dgKits.MultiSelect = false;
            this.dgKits.Name = "dgKits";
            this.dgKits.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgKits.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgKits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKits.ShowEditingIcon = false;
            this.dgKits.Size = new System.Drawing.Size(295, 177);
            this.dgKits.TabIndex = 0;
            this.dgKits.SelectionChanged += new System.EventHandler(this.dgKits_SelectionChanged);
            // 
            // txtBuscaFiltro
            // 
            this.txtBuscaFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscaFiltro.Location = new System.Drawing.Point(171, 26);
            this.txtBuscaFiltro.MaxLength = 20;
            this.txtBuscaFiltro.Name = "txtBuscaFiltro";
            this.txtBuscaFiltro.Size = new System.Drawing.Size(262, 20);
            this.txtBuscaFiltro.TabIndex = 8;
            // 
            // lblQtdKit
            // 
            this.lblQtdKit.AutoSize = true;
            this.lblQtdKit.Location = new System.Drawing.Point(33, 114);
            this.lblQtdKit.Name = "lblQtdKit";
            this.lblQtdKit.Size = new System.Drawing.Size(62, 13);
            this.lblQtdKit.TabIndex = 18;
            this.lblQtdKit.Text = "Quantidade";
            // 
            // lblNmItem
            // 
            this.lblNmItem.AutoSize = true;
            this.lblNmItem.Location = new System.Drawing.Point(33, 56);
            this.lblNmItem.Name = "lblNmItem";
            this.lblNmItem.Size = new System.Drawing.Size(50, 13);
            this.lblNmItem.TabIndex = 17;
            this.lblNmItem.Text = "Nome Kit";
            // 
            // rdbFiltroNome
            // 
            this.rdbFiltroNome.AutoSize = true;
            this.rdbFiltroNome.Location = new System.Drawing.Point(234, 9);
            this.rdbFiltroNome.Name = "rdbFiltroNome";
            this.rdbFiltroNome.Size = new System.Drawing.Size(53, 17);
            this.rdbFiltroNome.TabIndex = 7;
            this.rdbFiltroNome.Text = "Nome";
            this.rdbFiltroNome.UseVisualStyleBackColor = true;
            // 
            // rdbFiltroCodigo
            // 
            this.rdbFiltroCodigo.AutoSize = true;
            this.rdbFiltroCodigo.Checked = true;
            this.rdbFiltroCodigo.Location = new System.Drawing.Point(170, 9);
            this.rdbFiltroCodigo.Name = "rdbFiltroCodigo";
            this.rdbFiltroCodigo.Size = new System.Drawing.Size(58, 17);
            this.rdbFiltroCodigo.TabIndex = 6;
            this.rdbFiltroCodigo.TabStop = true;
            this.rdbFiltroCodigo.Text = "Codigo";
            this.rdbFiltroCodigo.UseVisualStyleBackColor = true;
            // 
            // TxtNmKit
            // 
            this.TxtNmKit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNmKit.Enabled = false;
            this.TxtNmKit.Location = new System.Drawing.Point(36, 72);
            this.TxtNmKit.MaxLength = 20;
            this.TxtNmKit.Name = "TxtNmKit";
            this.TxtNmKit.ReadOnly = true;
            this.TxtNmKit.Size = new System.Drawing.Size(102, 20);
            this.TxtNmKit.TabIndex = 6;
            // 
            // gbMotor
            // 
            this.gbMotor.Controls.Add(this.btnBuscaNumMotor);
            this.gbMotor.Controls.Add(this.txtNumeroMotor);
            this.gbMotor.Controls.Add(this.lblNumeroMotor);
            this.gbMotor.Controls.Add(this.btnBuscaTipoMotor);
            this.gbMotor.Controls.Add(this.txtTipoMotor);
            this.gbMotor.Controls.Add(this.lblTipoMotor);
            this.gbMotor.Controls.Add(this.btnBuscaMotorCompra);
            this.gbMotor.Controls.Add(this.txtMotorCompra);
            this.gbMotor.Controls.Add(this.lblMotorCompra);
            this.gbMotor.Location = new System.Drawing.Point(82, 70);
            this.gbMotor.Name = "gbMotor";
            this.gbMotor.Size = new System.Drawing.Size(498, 63);
            this.gbMotor.TabIndex = 11;
            this.gbMotor.TabStop = false;
            this.gbMotor.Text = "Motor";
            // 
            // txtNumeroMotor
            // 
            this.txtNumeroMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroMotor.Enabled = false;
            this.txtNumeroMotor.Location = new System.Drawing.Point(357, 11);
            this.txtNumeroMotor.Name = "txtNumeroMotor";
            this.txtNumeroMotor.ReadOnly = true;
            this.txtNumeroMotor.Size = new System.Drawing.Size(105, 20);
            this.txtNumeroMotor.TabIndex = 36;
            this.txtNumeroMotor.TabStop = false;
            // 
            // lblNumeroMotor
            // 
            this.lblNumeroMotor.AutoSize = true;
            this.lblNumeroMotor.Location = new System.Drawing.Point(259, 16);
            this.lblNumeroMotor.Name = "lblNumeroMotor";
            this.lblNumeroMotor.Size = new System.Drawing.Size(92, 13);
            this.lblNumeroMotor.TabIndex = 38;
            this.lblNumeroMotor.Text = "Numero do Motor ";
            // 
            // txtTipoMotor
            // 
            this.txtTipoMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipoMotor.Enabled = false;
            this.txtTipoMotor.Location = new System.Drawing.Point(357, 37);
            this.txtTipoMotor.Name = "txtTipoMotor";
            this.txtTipoMotor.ReadOnly = true;
            this.txtTipoMotor.Size = new System.Drawing.Size(105, 20);
            this.txtTipoMotor.TabIndex = 0;
            this.txtTipoMotor.TabStop = false;
            // 
            // lblTipoMotor
            // 
            this.lblTipoMotor.AutoSize = true;
            this.lblTipoMotor.Location = new System.Drawing.Point(259, 45);
            this.lblTipoMotor.Name = "lblTipoMotor";
            this.lblTipoMotor.Size = new System.Drawing.Size(73, 13);
            this.lblTipoMotor.TabIndex = 34;
            this.lblTipoMotor.Text = "Tipo do Motor";
            // 
            // txtMotorCompra
            // 
            this.txtMotorCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotorCompra.Enabled = false;
            this.txtMotorCompra.Location = new System.Drawing.Point(50, 24);
            this.txtMotorCompra.Name = "txtMotorCompra";
            this.txtMotorCompra.ReadOnly = true;
            this.txtMotorCompra.Size = new System.Drawing.Size(140, 20);
            this.txtMotorCompra.TabIndex = 0;
            this.txtMotorCompra.TabStop = false;
            this.txtMotorCompra.TextChanged += new System.EventHandler(this.txtMotorCompra_TextChanged);
            // 
            // lblMotorCompra
            // 
            this.lblMotorCompra.AutoSize = true;
            this.lblMotorCompra.Location = new System.Drawing.Point(6, 29);
            this.lblMotorCompra.Name = "lblMotorCompra";
            this.lblMotorCompra.Size = new System.Drawing.Size(34, 13);
            this.lblMotorCompra.TabIndex = 26;
            this.lblMotorCompra.Text = "Motor";
            // 
            // txtEstoque
            // 
            this.txtEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstoque.Enabled = false;
            this.txtEstoque.Location = new System.Drawing.Point(439, 44);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.ReadOnly = true;
            this.txtEstoque.Size = new System.Drawing.Size(105, 20);
            this.txtEstoque.TabIndex = 0;
            this.txtEstoque.TabStop = false;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(439, 28);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(46, 13);
            this.lblEstoque.TabIndex = 25;
            this.lblEstoque.Text = "Estoque";
            // 
            // txtCodigoFamMotor
            // 
            this.txtCodigoFamMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoFamMotor.Location = new System.Drawing.Point(187, 5);
            this.txtCodigoFamMotor.MaxLength = 500;
            this.txtCodigoFamMotor.Name = "txtCodigoFamMotor";
            this.txtCodigoFamMotor.ReadOnly = true;
            this.txtCodigoFamMotor.Size = new System.Drawing.Size(246, 20);
            this.txtCodigoFamMotor.TabIndex = 0;
            this.txtCodigoFamMotor.TabStop = false;
            // 
            // lblCodigoFamMotor
            // 
            this.lblCodigoFamMotor.AutoSize = true;
            this.lblCodigoFamMotor.Location = new System.Drawing.Point(76, 7);
            this.lblCodigoFamMotor.Name = "lblCodigoFamMotor";
            this.lblCodigoFamMotor.Size = new System.Drawing.Size(105, 13);
            this.lblCodigoFamMotor.TabIndex = 26;
            this.lblCodigoFamMotor.Text = "Codigo Familia Motor";
            // 
            // hIdKit
            // 
            this.hIdKit.DataPropertyName = "id_kit";
            this.hIdKit.HeaderText = "IdKit";
            this.hIdKit.Name = "hIdKit";
            this.hIdKit.ReadOnly = true;
            this.hIdKit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hIdKit.Visible = false;
            this.hIdKit.Width = 34;
            // 
            // hCodigo
            // 
            this.hCodigo.DataPropertyName = "id_kit_real";
            this.hCodigo.HeaderText = "Codigo";
            this.hCodigo.Name = "hCodigo";
            this.hCodigo.ReadOnly = true;
            this.hCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hCodigo.Width = 46;
            // 
            // hNome
            // 
            this.hNome.DataPropertyName = "nom";
            this.hNome.HeaderText = "Nome";
            this.hNome.Name = "hNome";
            this.hNome.ReadOnly = true;
            this.hNome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hNome.Width = 41;
            // 
            // hQtd
            // 
            this.hQtd.DataPropertyName = "Qtd";
            this.hQtd.HeaderText = "Qtd";
            this.hQtd.Name = "hQtd";
            this.hQtd.ReadOnly = true;
            this.hQtd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hQtd.Width = 30;
            // 
            // frmCadFamiliaMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 368);
            this.ControlBox = false;
            this.Controls.Add(this.txtCodigoFamMotor);
            this.Controls.Add(this.lblCodigoFamMotor);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.btnBuscaEstoque);
            this.Controls.Add(this.gbMotor);
            this.Controls.Add(this.gbBuscaKit);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtDsMotor);
            this.Controls.Add(this.lblDsMotor);
            this.Controls.Add(this.lblEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadFamiliaMotor";
            this.Text = "Familia do  Motor";
            this.Load += new System.EventHandler(this.frmCadFamiliaMotor_Load);
            this.gbBuscaKit.ResumeLayout(false);
            this.gbBuscaKit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKits)).EndInit();
            this.gbMotor.ResumeLayout(false);
            this.gbMotor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDsMotor;
        private System.Windows.Forms.TextBox txtDsMotor;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.GroupBox gbBuscaKit;
        private System.Windows.Forms.Button btnAdicionaKit;
        private System.Windows.Forms.DataGridView dgKits;
        private System.Windows.Forms.TextBox txtBuscaFiltro;
        private System.Windows.Forms.Label lblQtdKit;
        private System.Windows.Forms.Button btnBuscarKitDtGrid;
        private System.Windows.Forms.Label lblNmItem;
        private System.Windows.Forms.RadioButton rdbFiltroNome;
        private System.Windows.Forms.RadioButton rdbFiltroCodigo;
        private System.Windows.Forms.TextBox TxtNmKit;
        private System.Windows.Forms.GroupBox gbMotor;
        private System.Windows.Forms.Button btnBuscaTipoMotor;
        private System.Windows.Forms.TextBox txtTipoMotor;
        private System.Windows.Forms.Label lblTipoMotor;
        private System.Windows.Forms.Button btnBuscaMotorCompra;
        private System.Windows.Forms.TextBox txtMotorCompra;
        private System.Windows.Forms.Label lblMotorCompra;
        private System.Windows.Forms.Button btnBuscaEstoque;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Button btnRemoveKit;
        private System.Windows.Forms.Button btnBuscaNumMotor;
        private System.Windows.Forms.TextBox txtNumeroMotor;
        private System.Windows.Forms.Label lblNumeroMotor;
        private Controles.MegaTextBox.MegaTextBox txtQtdKit;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private System.Windows.Forms.TextBox txtCodigoFamMotor;
        private System.Windows.Forms.Label lblCodigoFamMotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIdKit;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQtd;
    }
}