namespace TCC.UI.BUSCA
{
    partial class frmBuscaUsinagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaUsinagem));
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgUsinagem = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsinagem)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(12, 12);
            this.txtFiltro.MaxLength = 50;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(195, 20);
            this.txtFiltro.TabIndex = 6;
            // 
            // dgUsinagem
            // 
            this.dgUsinagem.AllowUserToAddRows = false;
            this.dgUsinagem.AllowUserToDeleteRows = false;
            this.dgUsinagem.AllowUserToResizeColumns = false;
            this.dgUsinagem.AllowUserToResizeRows = false;
            this.dgUsinagem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgUsinagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsinagem.Location = new System.Drawing.Point(12, 44);
            this.dgUsinagem.MultiSelect = false;
            this.dgUsinagem.Name = "dgUsinagem";
            this.dgUsinagem.ReadOnly = true;
            this.dgUsinagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsinagem.ShowEditingIcon = false;
            this.dgUsinagem.Size = new System.Drawing.Size(260, 177);
            this.dgUsinagem.TabIndex = 5;
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(12, 226);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(49, 34);
            this.btnFechar.TabIndex = 8;
            this.toolTipLegenda.SetToolTip(this.btnFechar, "Fechar Busca");
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Location = new System.Drawing.Point(114, 228);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(55, 31);
            this.btnOK.TabIndex = 9;
            this.toolTipLegenda.SetToolTip(this.btnOK, "OK");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(213, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(59, 28);
            this.btnBuscar.TabIndex = 7;
            this.toolTipLegenda.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmBuscaUsinagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgUsinagem);
            this.Name = "frmBuscaUsinagem";
            this.Text = "frmBuscaUsinagem";
            ((System.ComponentModel.ISupportInitialize)(this.dgUsinagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgUsinagem;
    }
}