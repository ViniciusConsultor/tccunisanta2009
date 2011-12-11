﻿namespace TCC.UI.Resumo
{
    partial class frmResumoItemPeca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.hIdPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceitar
            // 
            this.btnAceitar.Location = new System.Drawing.Point(143, 282);
            this.btnAceitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(100, 28);
            this.btnAceitar.TabIndex = 2;
            this.btnAceitar.Text = "Aceitar";
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(373, 282);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 28);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 16);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
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
            this.dgItems.Location = new System.Drawing.Point(16, 36);
            this.dgItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dgItems.Size = new System.Drawing.Size(513, 218);
            this.dgItems.TabIndex = 22;
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
            this.hCodigo.Width = 77;
            // 
            // hNome
            // 
            this.hNome.DataPropertyName = "Peça";
            this.hNome.HeaderText = "Nome";
            this.hNome.Name = "hNome";
            this.hNome.ReadOnly = true;
            this.hNome.Width = 70;
            // 
            // hQtd
            // 
            this.hQtd.DataPropertyName = "qtd";
            this.hQtd.HeaderText = "Quantidade";
            this.hQtd.Name = "hQtd";
            this.hQtd.ReadOnly = true;
            this.hQtd.Width = 107;
            // 
            // frmResumoItemPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 403);
            this.ControlBox = false;
            this.Controls.Add(this.dgItems);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAceitar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmResumoItemPeca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resumo Item - Peças";
            this.Load += new System.EventHandler(this.frmResumoItemPeca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIdPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQtd;
    }
}