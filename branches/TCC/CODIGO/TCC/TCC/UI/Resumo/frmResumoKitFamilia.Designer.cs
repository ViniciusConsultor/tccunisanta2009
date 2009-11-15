namespace TCC.UI.Resumo
{
    partial class frmResumoKitFamilia
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMotor = new System.Windows.Forms.Label();
            this.txtMotor = new System.Windows.Forms.TextBox();
            this.txtNomeFamiliaMotor = new System.Windows.Forms.TextBox();
            this.gbKits = new System.Windows.Forms.GroupBox();
            this.dgKits = new System.Windows.Forms.DataGridView();
            this.hIdKit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.gbKits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKits)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(74, 13);
            this.lblNome.TabIndex = 25;
            this.lblNome.Text = "Família Motor:";
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Location = new System.Drawing.Point(220, 9);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(80, 13);
            this.lblMotor.TabIndex = 27;
            this.lblMotor.Text = "Motor Utilizado:";
            // 
            // txtMotor
            // 
            this.txtMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotor.Enabled = false;
            this.txtMotor.Location = new System.Drawing.Point(306, 6);
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.ReadOnly = true;
            this.txtMotor.Size = new System.Drawing.Size(100, 20);
            this.txtMotor.TabIndex = 28;
            // 
            // txtNomeFamiliaMotor
            // 
            this.txtNomeFamiliaMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFamiliaMotor.Enabled = false;
            this.txtNomeFamiliaMotor.Location = new System.Drawing.Point(83, 6);
            this.txtNomeFamiliaMotor.Name = "txtNomeFamiliaMotor";
            this.txtNomeFamiliaMotor.Size = new System.Drawing.Size(100, 20);
            this.txtNomeFamiliaMotor.TabIndex = 0;
            this.txtNomeFamiliaMotor.TabStop = false;
            // 
            // gbKits
            // 
            this.gbKits.Controls.Add(this.dgKits);
            this.gbKits.Controls.Add(this.btnVoltar);
            this.gbKits.Controls.Add(this.btnAceitar);
            this.gbKits.Location = new System.Drawing.Point(1, 32);
            this.gbKits.Name = "gbKits";
            this.gbKits.Size = new System.Drawing.Size(411, 235);
            this.gbKits.TabIndex = 29;
            this.gbKits.TabStop = false;
            this.gbKits.Text = "Kits Utilizados:";
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
            this.dgKits.Location = new System.Drawing.Point(14, 28);
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
            this.dgKits.Size = new System.Drawing.Size(385, 177);
            this.dgKits.TabIndex = 29;
            // 
            // hIdKit
            // 
            this.hIdKit.DataPropertyName = "id_kit";
            this.hIdKit.HeaderText = "IdKit";
            this.hIdKit.Name = "hIdKit";
            this.hIdKit.ReadOnly = true;
            this.hIdKit.Visible = false;
            this.hIdKit.Width = 51;
            // 
            // hCodigo
            // 
            this.hCodigo.DataPropertyName = "id_kit_real";
            this.hCodigo.HeaderText = "Código";
            this.hCodigo.Name = "hCodigo";
            this.hCodigo.ReadOnly = true;
            this.hCodigo.Width = 65;
            // 
            // hNome
            // 
            this.hNome.DataPropertyName = "nom";
            this.hNome.HeaderText = "Nome";
            this.hNome.Name = "hNome";
            this.hNome.ReadOnly = true;
            this.hNome.Width = 60;
            // 
            // hQtd
            // 
            this.hQtd.DataPropertyName = "Qtd";
            this.hQtd.HeaderText = "Quantidade";
            this.hQtd.Name = "hQtd";
            this.hQtd.ReadOnly = true;
            this.hQtd.Width = 87;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(280, 211);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 28;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAceitar
            // 
            this.btnAceitar.Location = new System.Drawing.Point(107, 211);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(75, 23);
            this.btnAceitar.TabIndex = 27;
            this.btnAceitar.Text = "Aceitar";
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // frmResumoKitFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 268);
            this.ControlBox = false;
            this.Controls.Add(this.gbKits);
            this.Controls.Add(this.txtNomeFamiliaMotor);
            this.Controls.Add(this.txtMotor);
            this.Controls.Add(this.lblMotor);
            this.Controls.Add(this.lblNome);
            this.MaximizeBox = false;
            this.Name = "frmResumoKitFamilia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resumo Familia Motor";
            this.Load += new System.EventHandler(this.frmResumoKitFamilia_Load);
            this.gbKits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgKits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.TextBox txtMotor;
        private System.Windows.Forms.TextBox txtNomeFamiliaMotor;
        private System.Windows.Forms.GroupBox gbKits;
        private System.Windows.Forms.DataGridView dgKits;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIdKit;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQtd;
    }
}