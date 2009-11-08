namespace TCC.UI.Resumo
{
    partial class frmResumoVendaProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.hId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 27;
            this.lblNome.Text = "Nome";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(206, 218);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAceitar
            // 
            this.btnAceitar.Location = new System.Drawing.Point(15, 218);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(75, 23);
            this.btnAceitar.TabIndex = 29;
            this.btnAceitar.Text = "Aceitar";
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // dgProdutos
            // 
            this.dgProdutos.AllowUserToAddRows = false;
            this.dgProdutos.AllowUserToDeleteRows = false;
            this.dgProdutos.AllowUserToResizeColumns = false;
            this.dgProdutos.AllowUserToResizeRows = false;
            this.dgProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hId,
            this.hDescricao,
            this.hQtd});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProdutos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgProdutos.Location = new System.Drawing.Point(12, 25);
            this.dgProdutos.MultiSelect = false;
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdutos.ShowEditingIcon = false;
            this.dgProdutos.Size = new System.Drawing.Size(388, 177);
            this.dgProdutos.TabIndex = 31;
            // 
            // hId
            // 
            this.hId.DataPropertyName = "id_prdto";
            this.hId.HeaderText = "Id";
            this.hId.Name = "hId";
            this.hId.ReadOnly = true;
            this.hId.Visible = false;
            this.hId.Width = 41;
            // 
            // hDescricao
            // 
            this.hDescricao.DataPropertyName = "dsc_prdto";
            this.hDescricao.HeaderText = "Descrição";
            this.hDescricao.Name = "hDescricao";
            this.hDescricao.ReadOnly = true;
            this.hDescricao.Width = 80;
            // 
            // hQtd
            // 
            this.hQtd.DataPropertyName = "Qtd";
            this.hQtd.HeaderText = "Quantidade";
            this.hQtd.Name = "hQtd";
            this.hQtd.ReadOnly = true;
            this.hQtd.Width = 87;
            // 
            // frmResumoVendaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 264);
            this.ControlBox = false;
            this.Controls.Add(this.dgProdutos);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.lblNome);
            this.MaximizeBox = false;
            this.Name = "frmResumoVendaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmResumoVendaProduto";
            this.Load += new System.EventHandler(this.frmResumoVendaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn hId;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQtd;

    }
}