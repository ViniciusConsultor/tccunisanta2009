namespace TCC.UI
{
    partial class frmCadTipoMotor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadTipoMotor));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.lblCdTipoMotor = new System.Windows.Forms.Label();
            this.txtCdTipoMotor = new System.Windows.Forms.TextBox();
            this.txtNmTipoMotor = new System.Windows.Forms.TextBox();
            this.lblNmTipoMotor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(1, 1);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(24, 22);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(124, 113);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnAceitar
            // 
            this.btnAceitar.Location = new System.Drawing.Point(43, 113);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(75, 23);
            this.btnAceitar.TabIndex = 14;
            this.btnAceitar.Text = "Confirmar";
            this.btnAceitar.UseVisualStyleBackColor = true;
            // 
            // lblCdTipoMotor
            // 
            this.lblCdTipoMotor.AutoSize = true;
            this.lblCdTipoMotor.Location = new System.Drawing.Point(40, 40);
            this.lblCdTipoMotor.Name = "lblCdTipoMotor";
            this.lblCdTipoMotor.Size = new System.Drawing.Size(124, 13);
            this.lblCdTipoMotor.TabIndex = 17;
            this.lblCdTipoMotor.Text = "Codigo do Tipo do Motor";
            // 
            // txtCdTipoMotor
            // 
            this.txtCdTipoMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdTipoMotor.Location = new System.Drawing.Point(170, 33);
            this.txtCdTipoMotor.Name = "txtCdTipoMotor";
            this.txtCdTipoMotor.Size = new System.Drawing.Size(100, 20);
            this.txtCdTipoMotor.TabIndex = 18;
            // 
            // txtNmTipoMotor
            // 
            this.txtNmTipoMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNmTipoMotor.Location = new System.Drawing.Point(170, 63);
            this.txtNmTipoMotor.Name = "txtNmTipoMotor";
            this.txtNmTipoMotor.Size = new System.Drawing.Size(100, 20);
            this.txtNmTipoMotor.TabIndex = 20;
            // 
            // lblNmTipoMotor
            // 
            this.lblNmTipoMotor.AutoSize = true;
            this.lblNmTipoMotor.Location = new System.Drawing.Point(45, 70);
            this.lblNmTipoMotor.Name = "lblNmTipoMotor";
            this.lblNmTipoMotor.Size = new System.Drawing.Size(119, 13);
            this.lblNmTipoMotor.TabIndex = 19;
            this.lblNmTipoMotor.Text = "Nome do Tipo do Motor";
            // 
            // frmCadTipoMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(292, 159);
            this.Controls.Add(this.txtNmTipoMotor);
            this.Controls.Add(this.lblNmTipoMotor);
            this.Controls.Add(this.txtCdTipoMotor);
            this.Controls.Add(this.lblCdTipoMotor);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAceitar);
            this.Name = "frmCadTipoMotor";
            this.Text = "Tipo Motor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.Label lblCdTipoMotor;
        private System.Windows.Forms.TextBox txtCdTipoMotor;
        private System.Windows.Forms.TextBox txtNmTipoMotor;
        private System.Windows.Forms.Label lblNmTipoMotor;
    }
}