namespace TCC.UI
{
    partial class frmCadUsinagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadUsinagem));
            this.lblCdPeca = new System.Windows.Forms.Label();
            this.txtCdPeca = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.btnCdPeca = new System.Windows.Forms.Button();
            this.chkPecaOk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblCdPeca
            // 
            this.lblCdPeca.AutoSize = true;
            this.lblCdPeca.Location = new System.Drawing.Point(90, 76);
            this.lblCdPeca.Name = "lblCdPeca";
            this.lblCdPeca.Size = new System.Drawing.Size(83, 13);
            this.lblCdPeca.TabIndex = 0;
            this.lblCdPeca.Text = "Codigo da Peça";
            // 
            // txtCdPeca
            // 
            this.txtCdPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdPeca.Location = new System.Drawing.Point(179, 74);
            this.txtCdPeca.Name = "txtCdPeca";
            this.txtCdPeca.ReadOnly = true;
            this.txtCdPeca.Size = new System.Drawing.Size(67, 20);
            this.txtCdPeca.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(3, 58);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::TCC.Properties.Resources.trash_can;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(3, 30);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceitar.BackgroundImage")));
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(3, 3);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(27, 23);
            this.btnAceitar.TabIndex = 8;
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // btnCdPeca
            // 
            this.btnCdPeca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCdPeca.BackgroundImage")));
            this.btnCdPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdPeca.Location = new System.Drawing.Point(252, 74);
            this.btnCdPeca.Name = "btnCdPeca";
            this.btnCdPeca.Size = new System.Drawing.Size(27, 23);
            this.btnCdPeca.TabIndex = 8;
            this.btnCdPeca.UseVisualStyleBackColor = true;
            this.btnCdPeca.Click += new System.EventHandler(this.btnCdPeca_Click);
            // 
            // chkPecaOk
            // 
            this.chkPecaOk.AutoSize = true;
            this.chkPecaOk.Location = new System.Drawing.Point(153, 110);
            this.chkPecaOk.Name = "chkPecaOk";
            this.chkPecaOk.Size = new System.Drawing.Size(69, 17);
            this.chkPecaOk.TabIndex = 11;
            this.chkPecaOk.Text = "Peça OK";
            this.chkPecaOk.UseVisualStyleBackColor = true;
            // 
            // frmCadUsinagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 218);
            this.ControlBox = false;
            this.Controls.Add(this.chkPecaOk);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCdPeca);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.txtCdPeca);
            this.Controls.Add(this.lblCdPeca);
            this.MaximizeBox = false;
            this.Name = "frmCadUsinagem";
            this.Text = "Usinagem";
            this.Load += new System.EventHandler(this.frmCadUsinagem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCdPeca;
        private System.Windows.Forms.TextBox txtCdPeca;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.Button btnCdPeca;
        private System.Windows.Forms.CheckBox chkPecaOk;
    }
}