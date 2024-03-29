﻿namespace TCC.UI
{
    partial class frmBuscaPerfil
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
            this.dgPerfil = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnExclUIr = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.hid_perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdsc_perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPerfil
            // 
            this.dgPerfil.AllowUserToAddRows = false;
            this.dgPerfil.AllowUserToDeleteRows = false;
            this.dgPerfil.AllowUserToResizeColumns = false;
            this.dgPerfil.AllowUserToResizeRows = false;
            this.dgPerfil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPerfil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hid_perfil,
            this.hdsc_perfil});
            this.dgPerfil.Location = new System.Drawing.Point(15, 42);
            this.dgPerfil.MultiSelect = false;
            this.dgPerfil.Name = "dgPerfil";
            this.dgPerfil.ReadOnly = true;
            this.dgPerfil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPerfil.ShowEditingIcon = false;
            this.dgPerfil.Size = new System.Drawing.Size(260, 177);
            this.dgPerfil.TabIndex = 0;
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
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = global::TCC.UI.resImg.btnVoltaCad;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(59, 225);
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
            this.btnExclUIr.Location = new System.Drawing.Point(197, 225);
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
            this.btnAlterar.Location = new System.Drawing.Point(151, 225);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(40, 35);
            this.btnAlterar.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnAlterar, "Alterar");
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = global::TCC.UI.resImg.btnOk;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Location = new System.Drawing.Point(105, 225);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(40, 35);
            this.btnOK.TabIndex = 7;
            this.toolTipLegenda.SetToolTip(this.btnOK, "Confirmar");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // hid_perfil
            // 
            this.hid_perfil.DataPropertyName = "id_perfil";
            this.hid_perfil.HeaderText = "id";
            this.hid_perfil.Name = "hid_perfil";
            this.hid_perfil.ReadOnly = true;
            this.hid_perfil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hid_perfil.Visible = false;
            this.hid_perfil.Width = 19;
            // 
            // hdsc_perfil
            // 
            this.hdsc_perfil.DataPropertyName = "Perfil";
            this.hdsc_perfil.HeaderText = "Perfil";
            this.hdsc_perfil.Name = "hdsc_perfil";
            this.hdsc_perfil.ReadOnly = true;
            this.hdsc_perfil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hdsc_perfil.Width = 34;
            // 
            // frmBuscaPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 266);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnExclUIr);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmBuscaPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busca Perfil";
            this.Load += new System.EventHandler(this.frmBuscaPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPerfil;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnExclUIr;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn hid_perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdsc_perfil;
    }
}