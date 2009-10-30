namespace TCC.UI
{
    partial class frmBuscaFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaFornecedor));
            this.btnOK = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgFornecedor = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.toolTipFechar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipOK = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBuscar = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Location = new System.Drawing.Point(114, 228);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(51, 31);
            this.btnOK.TabIndex = 4;
            this.toolTipOK.SetToolTip(this.btnOK, "OK!");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(12, 13);
            this.txtFiltro.MaxLength = 50;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(191, 20);
            this.txtFiltro.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(209, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(63, 33);
            this.btnBuscar.TabIndex = 2;
            this.toolTipBuscar.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgFornecedor
            // 
            this.dgFornecedor.AllowUserToAddRows = false;
            this.dgFornecedor.AllowUserToDeleteRows = false;
            this.dgFornecedor.AllowUserToResizeColumns = false;
            this.dgFornecedor.AllowUserToResizeRows = false;
            this.dgFornecedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFornecedor.Location = new System.Drawing.Point(12, 45);
            this.dgFornecedor.MultiSelect = false;
            this.dgFornecedor.Name = "dgFornecedor";
            this.dgFornecedor.ReadOnly = true;
            this.dgFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFornecedor.ShowEditingIcon = false;
            this.dgFornecedor.Size = new System.Drawing.Size(260, 177);
            this.dgFornecedor.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(12, 226);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(49, 34);
            this.btnFechar.TabIndex = 3;
            this.toolTipFechar.SetToolTip(this.btnFechar, "Fechar Busca");
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // toolTipFechar
            // 
            this.toolTipFechar.BackColor = System.Drawing.Color.LightGray;
            this.toolTipFechar.ForeColor = System.Drawing.Color.Black;
            // 
            // toolTipOK
            // 
            this.toolTipOK.BackColor = System.Drawing.Color.LightGray;
            this.toolTipOK.ForeColor = System.Drawing.Color.Black;
            // 
            // toolTipBuscar
            // 
            this.toolTipBuscar.BackColor = System.Drawing.Color.LightGray;
            this.toolTipBuscar.ForeColor = System.Drawing.Color.Black;
            // 
            // frmBuscaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.ControlBox = false;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmBuscaFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busca Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgFornecedor;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ToolTip toolTipOK;
        private System.Windows.Forms.ToolTip toolTipBuscar;
        private System.Windows.Forms.ToolTip toolTipFechar;
    }
}