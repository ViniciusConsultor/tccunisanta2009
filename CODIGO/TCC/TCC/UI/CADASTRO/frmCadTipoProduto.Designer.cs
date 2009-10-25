namespace TCC.UI
{
    partial class frmCadTipoProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadTipoProduto));
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDscNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(2, 63);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(27, 23);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirma.BackgroundImage")));
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(2, 5);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(27, 23);
            this.btnConfirma.TabIndex = 1;
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::TCC.Properties.Resources.trash_can;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(2, 34);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(75, 75);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(234, 80);
            this.txtNome.TabIndex = 6;
            // 
            // lblDscNome
            // 
            this.lblDscNome.AutoSize = true;
            this.lblDscNome.Location = new System.Drawing.Point(72, 59);
            this.lblDscNome.Name = "lblDscNome";
            this.lblDscNome.Size = new System.Drawing.Size(55, 13);
            this.lblDscNome.TabIndex = 5;
            this.lblDscNome.Text = "Descrição";
            // 
            // frmCadTipoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 218);
            this.ControlBox = false;
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblDscNome);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.btnFechar);
            this.MinimizeBox = false;
            this.Name = "frmCadTipoProduto";
            this.Text = "Tipo de Produto";
            this.Load += new System.EventHandler(this.frmCadTipoProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDscNome;
    }
}