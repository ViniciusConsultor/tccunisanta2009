﻿namespace TCC.UI
{
    partial class frmBuscaMotor
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
            this.dgMotor = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnExclUIr = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.hid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hMotor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMotor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = global::TCC.UI.resImg.btnOk;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Location = new System.Drawing.Point(103, 227);
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
            this.txtFiltro.Location = new System.Drawing.Point(16, 12);
            this.txtFiltro.MaxLength = 25;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(227, 20);
            this.txtFiltro.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::TCC.UI.resImg.btnBusca;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(249, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 23);
            this.btnBuscar.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgMotor
            // 
            this.dgMotor.AllowUserToAddRows = false;
            this.dgMotor.AllowUserToDeleteRows = false;
            this.dgMotor.AllowUserToResizeColumns = false;
            this.dgMotor.AllowUserToResizeRows = false;
            this.dgMotor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgMotor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMotor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hid,
            this.hMotor});
            this.dgMotor.Location = new System.Drawing.Point(16, 44);
            this.dgMotor.MultiSelect = false;
            this.dgMotor.Name = "dgMotor";
            this.dgMotor.ReadOnly = true;
            this.dgMotor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMotor.ShowEditingIcon = false;
            this.dgMotor.Size = new System.Drawing.Size(260, 177);
            this.dgMotor.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = global::TCC.UI.resImg.btnVoltaCad;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(57, 227);
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
            this.btnExclUIr.Location = new System.Drawing.Point(195, 226);
            this.btnExclUIr.Name = "btnExclUIr";
            this.btnExclUIr.Size = new System.Drawing.Size(40, 35);
            this.btnExclUIr.TabIndex = 6;
            this.toolTipLegenda.SetToolTip(this.btnExclUIr, "ExclUIr");
            this.btnExclUIr.UseVisualStyleBackColor = true;
            this.btnExclUIr.Click += new System.EventHandler(this.btnExclUIr_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::TCC.UI.resImg.btnalterar;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(149, 227);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(40, 35);
            this.btnAlterar.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnAlterar, "Alterar");
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // hid
            // 
            this.hid.DataPropertyName = "id_motor";
            this.hid.HeaderText = "Id";
            this.hid.Name = "hid";
            this.hid.ReadOnly = true;
            this.hid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hid.Visible = false;
            this.hid.Width = 20;
            // 
            // hMotor
            // 
            this.hMotor.DataPropertyName = "Motor";
            this.hMotor.HeaderText = "Motor";
            this.hMotor.Name = "hMotor";
            this.hMotor.ReadOnly = true;
            this.hMotor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hMotor.Width = 38;
            // 
            // frmBuscaMotor
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
            this.Controls.Add(this.dgMotor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "frmBuscaMotor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busca Motor";
            this.Load += new System.EventHandler(this.frmBuscaMotor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMotor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgMotor;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnExclUIr;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn hid;
        private System.Windows.Forms.DataGridViewTextBoxColumn hMotor;
    }
}