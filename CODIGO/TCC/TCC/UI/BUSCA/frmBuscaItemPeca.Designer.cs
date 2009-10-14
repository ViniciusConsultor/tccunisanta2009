namespace TCC.UI.BUSCA
{
    partial class frmBuscaItemPeca
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgCdItemPeca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCdItemPeca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(101, 230);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(12, 13);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(179, 20);
            this.txtFiltro.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(197, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgCdItemPeca
            // 
            this.dgCdItemPeca.AllowUserToAddRows = false;
            this.dgCdItemPeca.AllowUserToDeleteRows = false;
            this.dgCdItemPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCdItemPeca.Location = new System.Drawing.Point(12, 45);
            this.dgCdItemPeca.MultiSelect = false;
            this.dgCdItemPeca.Name = "dgCdItemPeca";
            this.dgCdItemPeca.ReadOnly = true;
            this.dgCdItemPeca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCdItemPeca.ShowEditingIcon = false;
            this.dgCdItemPeca.Size = new System.Drawing.Size(260, 177);
            this.dgCdItemPeca.TabIndex = 8;
            // 
            // frmBuscaItemPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgCdItemPeca);
            this.Name = "frmBuscaItemPeca";
            this.Text = "frmBuscaItemPeca";
            ((System.ComponentModel.ISupportInitialize)(this.dgCdItemPeca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgCdItemPeca;
    }
}