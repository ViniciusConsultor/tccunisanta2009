namespace TCC.UI
{
    partial class frmCadNumeroMotor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadNumeroMotor));
            this.txtCdNumeroMotor = new System.Windows.Forms.TextBox();
            this.lblCdNumeroMotor = new System.Windows.Forms.Label();
            this.txtDscNumeroMotor = new System.Windows.Forms.TextBox();
            this.lblDsNumeroMotor = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCdNumeroMotor
            // 
            this.txtCdNumeroMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdNumeroMotor.Location = new System.Drawing.Point(196, 40);
            this.txtCdNumeroMotor.Name = "txtCdNumeroMotor";
            this.txtCdNumeroMotor.ReadOnly = true;
            this.txtCdNumeroMotor.Size = new System.Drawing.Size(100, 20);
            this.txtCdNumeroMotor.TabIndex = 20;
            // 
            // lblCdNumeroMotor
            // 
            this.lblCdNumeroMotor.AutoSize = true;
            this.lblCdNumeroMotor.Location = new System.Drawing.Point(53, 47);
            this.lblCdNumeroMotor.Name = "lblCdNumeroMotor";
            this.lblCdNumeroMotor.Size = new System.Drawing.Size(140, 13);
            this.lblCdNumeroMotor.TabIndex = 19;
            this.lblCdNumeroMotor.Text = "Codigo do Numero do Motor";
            // 
            // txtDscNumeroMotor
            // 
            this.txtDscNumeroMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDscNumeroMotor.Location = new System.Drawing.Point(56, 100);
            this.txtDscNumeroMotor.Name = "txtDscNumeroMotor";
            this.txtDscNumeroMotor.Size = new System.Drawing.Size(240, 20);
            this.txtDscNumeroMotor.TabIndex = 22;
            // 
            // lblDsNumeroMotor
            // 
            this.lblDsNumeroMotor.AutoSize = true;
            this.lblDsNumeroMotor.Location = new System.Drawing.Point(53, 84);
            this.lblDsNumeroMotor.Name = "lblDsNumeroMotor";
            this.lblDsNumeroMotor.Size = new System.Drawing.Size(155, 13);
            this.lblDsNumeroMotor.TabIndex = 21;
            this.lblDsNumeroMotor.Text = "Descrição do Numero do Motor";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(1, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(28, 25);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(1, 30);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(28, 25);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceitar.BackgroundImage")));
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(1, 59);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(28, 24);
            this.btnAceitar.TabIndex = 23;
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // frmCadNumeroMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(324, 189);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.txtDscNumeroMotor);
            this.Controls.Add(this.lblDsNumeroMotor);
            this.Controls.Add(this.txtCdNumeroMotor);
            this.Controls.Add(this.lblCdNumeroMotor);
            this.MaximizeBox = false;
            this.Name = "frmCadNumeroMotor";
            this.Text = "frmCadNumeroMotor";
            this.Load += new System.EventHandler(this.frmCadNumeroMotor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCdNumeroMotor;
        private System.Windows.Forms.Label lblCdNumeroMotor;
        private System.Windows.Forms.TextBox txtDscNumeroMotor;
        private System.Windows.Forms.Label lblDsNumeroMotor;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAceitar;
    }
}