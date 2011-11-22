namespace TCC.UI
{
    partial class frmBuscaVenda
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
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgVenda = new System.Windows.Forms.DataGridView();
            this.hVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFechar = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataVenda = new TCC.Controle.MegaMaskedTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = global::TCC.Telas.resImg.btnOk;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Location = new System.Drawing.Point(107, 225);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(40, 35);
            this.btnOK.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnOK, "Confirmar");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCliente.Location = new System.Drawing.Point(16, 63);
            this.txtNomeCliente.MaxLength = 25;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(227, 20);
            this.txtNomeCliente.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::TCC.Telas.resImg.btnBusca;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(249, 61);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 23);
            this.btnBuscar.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgVenda
            // 
            this.dgVenda.AllowUserToAddRows = false;
            this.dgVenda.AllowUserToDeleteRows = false;
            this.dgVenda.AllowUserToResizeColumns = false;
            this.dgVenda.AllowUserToResizeRows = false;
            this.dgVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hVenda,
            this.hCliente,
            this.hData});
            this.dgVenda.Location = new System.Drawing.Point(16, 89);
            this.dgVenda.MultiSelect = false;
            this.dgVenda.Name = "dgVenda";
            this.dgVenda.ReadOnly = true;
            this.dgVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVenda.ShowEditingIcon = false;
            this.dgVenda.Size = new System.Drawing.Size(260, 130);
            this.dgVenda.TabIndex = 0;
            // 
            // hVenda
            // 
            this.hVenda.HeaderText = "Venda";
            this.hVenda.Name = "hVenda";
            this.hVenda.ReadOnly = true;
            this.hVenda.Width = 61;
            // 
            // hCliente
            // 
            this.hCliente.HeaderText = "Cliente";
            this.hCliente.Name = "hCliente";
            this.hCliente.ReadOnly = true;
            this.hCliente.Width = 62;
            // 
            // hData
            // 
            this.hData.HeaderText = "Data";
            this.hData.Name = "hData";
            this.hData.ReadOnly = true;
            this.hData.Width = 53;
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = global::TCC.Telas.resImg.btnVoltaCad;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(61, 225);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 35);
            this.btnFechar.TabIndex = 4;
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
            this.btnExcluir.Location = new System.Drawing.Point(199, 225);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(40, 35);
            this.btnExcluir.TabIndex = 7;
            this.toolTipLegenda.SetToolTip(this.btnExcluir, "Excluir");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::TCC.Telas.resImg.btnalterar;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(153, 225);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(40, 35);
            this.btnAlterar.TabIndex = 6;
            this.toolTipLegenda.SetToolTip(this.btnAlterar, "Alterar");
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data da Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome do Cliente";
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataVenda.Location = new System.Drawing.Point(16, 22);
            this.txtDataVenda.Mask = "00/00/0000";
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(69, 20);
            this.txtDataVenda.TabIndex = 1;
            this.txtDataVenda.ValidatingType = typeof(System.DateTime);
            // 
            // frmBuscaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 266);
            this.ControlBox = false;
            this.Controls.Add(this.txtDataVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmBuscaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busca Venda";
            this.Load += new System.EventHandler(this.frmBuscaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgVenda;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private TCC.Controle.MegaMaskedTextBox txtDataVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn hVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn hData;
    }
}