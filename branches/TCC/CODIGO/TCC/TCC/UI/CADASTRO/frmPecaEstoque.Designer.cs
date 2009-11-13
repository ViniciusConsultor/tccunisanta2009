﻿namespace TCC.UI.CADASTRO
{
    partial class frmPecaEstoque
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
            this.gbBuscaPecaItem = new System.Windows.Forms.GroupBox();
            this.btnRemovePeca = new System.Windows.Forms.Button();
            this.btnAdicionaPeca = new System.Windows.Forms.Button();
            this.dgPeca = new System.Windows.Forms.DataGridView();
            this.CdPecaReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NmPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblQtdPeca = new System.Windows.Forms.Label();
            this.btnBuscarPecaDtGrid = new System.Windows.Forms.Button();
            this.lblNmPeca = new System.Windows.Forms.Label();
            this.rdbFiltro1 = new System.Windows.Forms.RadioButton();
            this.rdbfiltro0 = new System.Windows.Forms.RadioButton();
            this.TxtNmPeca = new System.Windows.Forms.TextBox();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtQtdPeca = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.gbBuscaPecaItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeca)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBuscaPecaItem
            // 
            this.gbBuscaPecaItem.Controls.Add(this.txtQtdPeca);
            this.gbBuscaPecaItem.Controls.Add(this.btnRemovePeca);
            this.gbBuscaPecaItem.Controls.Add(this.btnAdicionaPeca);
            this.gbBuscaPecaItem.Controls.Add(this.dgPeca);
            this.gbBuscaPecaItem.Controls.Add(this.txtFiltro);
            this.gbBuscaPecaItem.Controls.Add(this.lblQtdPeca);
            this.gbBuscaPecaItem.Controls.Add(this.btnBuscarPecaDtGrid);
            this.gbBuscaPecaItem.Controls.Add(this.lblNmPeca);
            this.gbBuscaPecaItem.Controls.Add(this.rdbFiltro1);
            this.gbBuscaPecaItem.Controls.Add(this.rdbfiltro0);
            this.gbBuscaPecaItem.Controls.Add(this.TxtNmPeca);
            this.gbBuscaPecaItem.Location = new System.Drawing.Point(82, 111);
            this.gbBuscaPecaItem.Name = "gbBuscaPecaItem";
            this.gbBuscaPecaItem.Size = new System.Drawing.Size(498, 243);
            this.gbBuscaPecaItem.TabIndex = 9;
            this.gbBuscaPecaItem.TabStop = false;
            this.gbBuscaPecaItem.Text = "Peças do Estoque ";
            // 
            // btnRemovePeca
            // 
            this.btnRemovePeca.BackgroundImage = global::TCC.resImg.btnLess;
            this.btnRemovePeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemovePeca.Location = new System.Drawing.Point(98, 175);
            this.btnRemovePeca.Name = "btnRemovePeca";
            this.btnRemovePeca.Size = new System.Drawing.Size(40, 35);
            this.btnRemovePeca.TabIndex = 23;
            this.btnRemovePeca.UseVisualStyleBackColor = true;
            // 
            // btnAdicionaPeca
            // 
            this.btnAdicionaPeca.BackgroundImage = global::TCC.resImg.btnAdd_;
            this.btnAdicionaPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionaPeca.Location = new System.Drawing.Point(36, 175);
            this.btnAdicionaPeca.Name = "btnAdicionaPeca";
            this.btnAdicionaPeca.Size = new System.Drawing.Size(40, 35);
            this.btnAdicionaPeca.TabIndex = 22;
            this.btnAdicionaPeca.UseVisualStyleBackColor = true;
            // 
            // dgPeca
            // 
            this.dgPeca.AllowUserToAddRows = false;
            this.dgPeca.AllowUserToDeleteRows = false;
            this.dgPeca.AllowUserToResizeColumns = false;
            this.dgPeca.AllowUserToResizeRows = false;
            this.dgPeca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPeca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdPecaReal,
            this.NmPeca});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPeca.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgPeca.Location = new System.Drawing.Point(170, 56);
            this.dgPeca.MultiSelect = false;
            this.dgPeca.Name = "dgPeca";
            this.dgPeca.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPeca.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPeca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPeca.ShowEditingIcon = false;
            this.dgPeca.Size = new System.Drawing.Size(295, 177);
            this.dgPeca.TabIndex = 21;
            // 
            // CdPecaReal
            // 
            this.CdPecaReal.HeaderText = "Codigo";
            this.CdPecaReal.Name = "CdPecaReal";
            this.CdPecaReal.ReadOnly = true;
            this.CdPecaReal.Width = 65;
            // 
            // NmPeca
            // 
            this.NmPeca.HeaderText = "Nome";
            this.NmPeca.Name = "NmPeca";
            this.NmPeca.ReadOnly = true;
            this.NmPeca.Width = 60;
            // 
            // txtFiltro
            // 
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Location = new System.Drawing.Point(216, 36);
            this.txtFiltro.MaxLength = 25;
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
            this.btnBuscarPecaDtGrid.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscarPecaDtGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPecaDtGrid.Location = new System.Drawing.Point(395, 22);
            this.btnBuscarPecaDtGrid.Name = "btnBuscarPecaDtGrid";
            this.btnBuscarPecaDtGrid.Size = new System.Drawing.Size(40, 35);
            this.btnBuscarPecaDtGrid.TabIndex = 13;
            this.btnBuscarPecaDtGrid.UseVisualStyleBackColor = true;
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
            // rdbFiltro1
            // 
            this.rdbFiltro1.AutoSize = true;
            this.rdbFiltro1.Location = new System.Drawing.Point(279, 19);
            this.rdbFiltro1.Name = "rdbFiltro1";
            this.rdbFiltro1.Size = new System.Drawing.Size(53, 17);
            this.rdbFiltro1.TabIndex = 20;
            this.rdbFiltro1.Text = "Nome";
            this.rdbFiltro1.UseVisualStyleBackColor = true;
            // 
            // rdbfiltro0
            // 
            this.rdbfiltro0.AutoSize = true;
            this.rdbfiltro0.Checked = true;
            this.rdbfiltro0.Location = new System.Drawing.Point(215, 19);
            this.rdbfiltro0.Name = "rdbfiltro0";
            this.rdbfiltro0.Size = new System.Drawing.Size(58, 17);
            this.rdbfiltro0.TabIndex = 19;
            this.rdbfiltro0.TabStop = true;
            this.rdbfiltro0.Text = "Codigo";
            this.rdbfiltro0.UseVisualStyleBackColor = true;
            // 
            // TxtNmPeca
            // 
            this.TxtNmPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNmPeca.Location = new System.Drawing.Point(36, 72);
            this.TxtNmPeca.MaxLength = 25;
            this.TxtNmPeca.Name = "TxtNmPeca";
            this.TxtNmPeca.ReadOnly = true;
            this.TxtNmPeca.Size = new System.Drawing.Size(102, 20);
            this.TxtNmPeca.TabIndex = 14;
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackgroundImage = global::TCC.resImg.btnLimpa;
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpa.Location = new System.Drawing.Point(8, 46);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(40, 35);
            this.btnLimpa.TabIndex = 11;
            this.btnLimpa.UseVisualStyleBackColor = true;
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(8, 87);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(40, 35);
            this.btnVolta.TabIndex = 12;
            this.btnVolta.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.Location = new System.Drawing.Point(7, 6);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(40, 35);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // txtQtdPeca
            // 
            this.txtQtdPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdPeca.Location = new System.Drawing.Point(36, 130);
            this.txtQtdPeca.MaxLength = 2;
            this.txtQtdPeca.Name = "txtQtdPeca";
            this.txtQtdPeca.Size = new System.Drawing.Size(100, 20);
            this.txtQtdPeca.TabIndex = 24;
            this.txtQtdPeca.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // frmPecaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gbBuscaPecaItem);
            this.Name = "frmPecaEstoque";
            this.Text = "Peça Estoque";
            this.gbBuscaPecaItem.ResumeLayout(false);
            this.gbBuscaPecaItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscaPecaItem;
        private System.Windows.Forms.Button btnAdicionaPeca;
        private System.Windows.Forms.DataGridView dgPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdPecaReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NmPeca;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblQtdPeca;
        private System.Windows.Forms.Button btnBuscarPecaDtGrid;
        private System.Windows.Forms.Label lblNmPeca;
        private System.Windows.Forms.RadioButton rdbFiltro1;
        private System.Windows.Forms.RadioButton rdbfiltro0;
        private System.Windows.Forms.TextBox TxtNmPeca;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnRemovePeca;
        private Controles.MegaTextBox.MegaTextBox txtQtdPeca;
    }
}