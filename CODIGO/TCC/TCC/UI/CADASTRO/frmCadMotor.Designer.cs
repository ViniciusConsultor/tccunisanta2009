namespace TCC.UI
{
    partial class frmCadMotor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadMotor));
            this.lblCdMotor = new System.Windows.Forms.Label();
            this.txtCdMotor = new System.Windows.Forms.TextBox();
            this.lblDsMotor = new System.Windows.Forms.Label();
            this.txtDsMotor = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCdMotor
            // 
            this.lblCdMotor.AutoSize = true;
            this.lblCdMotor.Location = new System.Drawing.Point(61, 36);
            this.lblCdMotor.Name = "lblCdMotor";
            this.lblCdMotor.Size = new System.Drawing.Size(85, 13);
            this.lblCdMotor.TabIndex = 0;
            this.lblCdMotor.Text = "Codigo do Motor";
            // 
            // txtCdMotor
            // 
            this.txtCdMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdMotor.Location = new System.Drawing.Point(152, 33);
            this.txtCdMotor.Name = "txtCdMotor";
            this.txtCdMotor.ReadOnly = true;
            this.txtCdMotor.Size = new System.Drawing.Size(100, 20);
            this.txtCdMotor.TabIndex = 1;
            // 
            // lblDsMotor
            // 
            this.lblDsMotor.AutoSize = true;
            this.lblDsMotor.Location = new System.Drawing.Point(61, 81);
            this.lblDsMotor.Name = "lblDsMotor";
            this.lblDsMotor.Size = new System.Drawing.Size(100, 13);
            this.lblDsMotor.TabIndex = 0;
            this.lblDsMotor.Text = "Descrição do Motor";
            // 
            // txtDsMotor
            // 
            this.txtDsMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDsMotor.Location = new System.Drawing.Point(64, 97);
            this.txtDsMotor.Name = "txtDsMotor";
            this.txtDsMotor.Size = new System.Drawing.Size(194, 20);
            this.txtDsMotor.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(1, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 22);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(1, 26);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceitar.BackgroundImage")));
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(1, 52);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(27, 23);
            this.btnAceitar.TabIndex = 14;
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // frmCadMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(312, 188);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.txtDsMotor);
            this.Controls.Add(this.txtCdMotor);
            this.Controls.Add(this.lblDsMotor);
            this.Controls.Add(this.lblCdMotor);
            this.MaximizeBox = false;
            this.Name = "frmCadMotor";
            this.Text = "Cadastro de Motor";
            this.Load += new System.EventHandler(this.frmMotor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCdMotor;
        private System.Windows.Forms.TextBox txtCdMotor;
        private System.Windows.Forms.Label lblDsMotor;
        private System.Windows.Forms.TextBox txtDsMotor;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAceitar;
    }
}