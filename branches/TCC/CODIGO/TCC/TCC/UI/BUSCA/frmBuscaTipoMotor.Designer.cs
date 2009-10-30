namespace TCC.UI
{
    partial class frmBuscaTipoMotor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaTipoMotor));
            this.btnOK = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgTipoMotor = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.toolTipFechar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipOK = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBuscar = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgTipoMotor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Location = new System.Drawing.Point(103, 229);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(59, 32);
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
            this.txtFiltro.Size = new System.Drawing.Size(198, 20);
            this.txtFiltro.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(226, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(46, 30);
            this.btnBuscar.TabIndex = 2;
            this.toolTipBuscar.SetToolTip(this.btnBuscar, "Buscar");
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
            this.dgTipoMotor.Location = new System.Drawing.Point(12, 45);
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
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(12, 228);
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
            // frmBuscaTipoMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.ControlBox = false;
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
        private System.Windows.Forms.ToolTip toolTipFechar;
        private System.Windows.Forms.ToolTip toolTipOK;
        private System.Windows.Forms.ToolTip toolTipBuscar;
    }
}