namespace TCC.UI
{
    partial class frmCadItemPeca
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.txtCodItemPeca = new System.Windows.Forms.TextBox();
            this.txtCodigoPeca = new System.Windows.Forms.TextBox();
            this.txtDescItemPeca = new System.Windows.Forms.TextBox();
            this.lblCodigoItemPeca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodPeca = new System.Windows.Forms.Label();
            this.btnBuscaPeca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(63, 199);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirma";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.Location = new System.Drawing.Point(179, 199);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(75, 23);
            this.btnVolta.TabIndex = 1;
            this.btnVolta.Text = "Volta";
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(319, 199);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 23);
            this.btnLimpa.TabIndex = 2;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // txtCodItemPeca
            // 
            this.txtCodItemPeca.Location = new System.Drawing.Point(182, 38);
            this.txtCodItemPeca.Name = "txtCodItemPeca";
            this.txtCodItemPeca.ReadOnly = true;
            this.txtCodItemPeca.Size = new System.Drawing.Size(100, 20);
            this.txtCodItemPeca.TabIndex = 3;
            // 
            // txtCodigoPeca
            // 
            this.txtCodigoPeca.Location = new System.Drawing.Point(182, 90);
            this.txtCodigoPeca.Name = "txtCodigoPeca";
            this.txtCodigoPeca.ReadOnly = true;
            this.txtCodigoPeca.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPeca.TabIndex = 4;
            // 
            // txtDescItemPeca
            // 
            this.txtDescItemPeca.Location = new System.Drawing.Point(182, 64);
            this.txtDescItemPeca.Name = "txtDescItemPeca";
            this.txtDescItemPeca.Size = new System.Drawing.Size(100, 20);
            this.txtDescItemPeca.TabIndex = 5;
            // 
            // lblCodigoItemPeca
            // 
            this.lblCodigoItemPeca.AutoSize = true;
            this.lblCodigoItemPeca.Location = new System.Drawing.Point(96, 41);
            this.lblCodigoItemPeca.Name = "lblCodigoItemPeca";
            this.lblCodigoItemPeca.Size = new System.Drawing.Size(80, 13);
            this.lblCodigoItemPeca.TabIndex = 6;
            this.lblCodigoItemPeca.Text = "Cod. Item Peça";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descrição Item Peça";
            // 
            // lblCodPeca
            // 
            this.lblCodPeca.AutoSize = true;
            this.lblCodPeca.Location = new System.Drawing.Point(119, 93);
            this.lblCodPeca.Name = "lblCodPeca";
            this.lblCodPeca.Size = new System.Drawing.Size(57, 13);
            this.lblCodPeca.TabIndex = 8;
            this.lblCodPeca.Text = "Cod. Peça";
            // 
            // btnBuscaPeca
            // 
            this.btnBuscaPeca.Location = new System.Drawing.Point(288, 88);
            this.btnBuscaPeca.Name = "btnBuscaPeca";
            this.btnBuscaPeca.Size = new System.Drawing.Size(28, 23);
            this.btnBuscaPeca.TabIndex = 9;
            this.btnBuscaPeca.Text = "...";
            this.btnBuscaPeca.UseVisualStyleBackColor = true;
            this.btnBuscaPeca.Click += new System.EventHandler(this.btnBuscaPeca_Click);
            // 
            // frmCadItemPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 264);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscaPeca);
            this.Controls.Add(this.lblCodPeca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCodigoItemPeca);
            this.Controls.Add(this.txtDescItemPeca);
            this.Controls.Add(this.txtCodigoPeca);
            this.Controls.Add(this.txtCodItemPeca);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnConfirmar);
            this.MaximizeBox = false;
            this.Name = "frmCadItemPeca";
            this.Text = "frmCadItemPeca";
            this.Load += new System.EventHandler(this.frmCadItemPeca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.TextBox txtCodItemPeca;
        private System.Windows.Forms.TextBox txtCodigoPeca;
        private System.Windows.Forms.TextBox txtDescItemPeca;
        private System.Windows.Forms.Label lblCodigoItemPeca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodPeca;
        private System.Windows.Forms.Button btnBuscaPeca;
    }
}