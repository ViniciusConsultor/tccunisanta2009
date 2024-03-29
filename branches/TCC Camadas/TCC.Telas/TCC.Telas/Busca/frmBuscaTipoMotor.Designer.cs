﻿namespace TCC.UI
{
    partial class frmBuscaTipoMotor
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgTipoMotor = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnExclUIr = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.hIdTipoMotor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDescTipoMotor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTipoMotor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = global::TCC.UI.resImg.btnOk;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Location = new System.Drawing.Point(104, 225);
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
            this.txtFiltro.Location = new System.Drawing.Point(15, 10);
            this.txtFiltro.MaxLength = 25;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(227, 20);
            this.txtFiltro.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::TCC.UI.resImg.btnBusca;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(248, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 23);
            this.btnBuscar.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgTipoMotor
            // 
            this.dgTipoMotor.AllowUserToAddRows = false;
            this.dgTipoMotor.AllowUserToDeleteRows = false;
            this.dgTipoMotor.AllowUserToResizeColumns = false;
            this.dgTipoMotor.AllowUserToResizeRows = false;
            this.dgTipoMotor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgTipoMotor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTipoMotor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hIdTipoMotor,
            this.hCodigo,
            this.hDescTipoMotor});
            this.dgTipoMotor.Location = new System.Drawing.Point(15, 42);
            this.dgTipoMotor.MultiSelect = false;
            this.dgTipoMotor.Name = "dgTipoMotor";
            this.dgTipoMotor.ReadOnly = true;
            this.dgTipoMotor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTipoMotor.ShowEditingIcon = false;
            this.dgTipoMotor.Size = new System.Drawing.Size(260, 177);
            this.dgTipoMotor.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = global::TCC.UI.resImg.btnVoltaCad;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(58, 225);
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
            // btnExclUIr
            // 
            this.btnExclUIr.BackgroundImage = global::TCC.UI.resImg.btnLixo;
            this.btnExclUIr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExclUIr.Location = new System.Drawing.Point(196, 225);
            this.btnExclUIr.Name = "btnExclUIr";
            this.btnExclUIr.Size = new System.Drawing.Size(40, 35);
            this.btnExclUIr.TabIndex = 8;
            this.toolTipLegenda.SetToolTip(this.btnExclUIr, "ExclUIr");
            this.btnExclUIr.UseVisualStyleBackColor = true;
            this.btnExclUIr.Click += new System.EventHandler(this.btnExclUIr_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::TCC.UI.resImg.btnalterar;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(150, 225);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(40, 35);
            this.btnAlterar.TabIndex = 7;
            this.toolTipLegenda.SetToolTip(this.btnAlterar, "Alterar");
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // hIdTipoMotor
            // 
            this.hIdTipoMotor.DataPropertyName = "id_tipo_motor";
            this.hIdTipoMotor.HeaderText = "Id";
            this.hIdTipoMotor.Name = "hIdTipoMotor";
            this.hIdTipoMotor.ReadOnly = true;
            this.hIdTipoMotor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hIdTipoMotor.Visible = false;
            this.hIdTipoMotor.Width = 20;
            // 
            // hCodigo
            // 
            this.hCodigo.DataPropertyName = "id_tipo_motor_real";
            this.hCodigo.HeaderText = "Código";
            this.hCodigo.Name = "hCodigo";
            this.hCodigo.ReadOnly = true;
            this.hCodigo.Width = 63;
            // 
            // hDescTipoMotor
            // 
            this.hDescTipoMotor.DataPropertyName = "dsc_tipo_motor";
            this.hDescTipoMotor.HeaderText = "Descrição";
            this.hDescTipoMotor.Name = "hDescTipoMotor";
            this.hDescTipoMotor.ReadOnly = true;
            this.hDescTipoMotor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hDescTipoMotor.Width = 59;
            // 
            // frmBuscaTipoMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 266);
            this.ControlBox = false;
            this.Controls.Add(this.btnExclUIr);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgTipoMotor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmBuscaTipoMotor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busca Tipo Motor";
            this.Load += new System.EventHandler(this.frmBuscaTipoMotor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTipoMotor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgTipoMotor;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnExclUIr;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIdTipoMotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDescTipoMotor;
    }
}