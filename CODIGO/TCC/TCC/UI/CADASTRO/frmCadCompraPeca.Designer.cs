namespace TCC.UI
{
    partial class frmCadCompraPeca
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtCdPeca = new System.Windows.Forms.TextBox();
            this.txtUltimoPreco = new System.Windows.Forms.TextBox();
            this.txtCdCompra = new System.Windows.Forms.TextBox();
            this.btnBuscaPeca = new System.Windows.Forms.Button();
            this.lblCdPeca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscaCompra = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::TCC.resImg.btnLimpa;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(0, 29);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(30, 25);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(0, 56);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(30, 25);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtCdPeca
            // 
            this.txtCdPeca.Location = new System.Drawing.Point(154, 57);
            this.txtCdPeca.Name = "txtCdPeca";
            this.txtCdPeca.ReadOnly = true;
            this.txtCdPeca.Size = new System.Drawing.Size(100, 20);
            this.txtCdPeca.TabIndex = 1;
            // 
            // txtUltimoPreco
            // 
            this.txtUltimoPreco.Location = new System.Drawing.Point(154, 123);
            this.txtUltimoPreco.MaxLength = 17;
            this.txtUltimoPreco.Name = "txtUltimoPreco";
            this.txtUltimoPreco.Size = new System.Drawing.Size(100, 20);
            this.txtUltimoPreco.TabIndex = 5;
            // 
            // txtCdCompra
            // 
            this.txtCdCompra.Location = new System.Drawing.Point(154, 89);
            this.txtCdCompra.Name = "txtCdCompra";
            this.txtCdCompra.ReadOnly = true;
            this.txtCdCompra.Size = new System.Drawing.Size(100, 20);
            this.txtCdCompra.TabIndex = 3;
            // 
            // btnBuscaPeca
            // 
            this.btnBuscaPeca.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscaPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaPeca.Location = new System.Drawing.Point(260, 55);
            this.btnBuscaPeca.Name = "btnBuscaPeca";
            this.btnBuscaPeca.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaPeca.TabIndex = 2;
            this.btnBuscaPeca.UseVisualStyleBackColor = true;
            this.btnBuscaPeca.Click += new System.EventHandler(this.btnBuscaPeca_Click);
            // 
            // lblCdPeca
            // 
            this.lblCdPeca.AutoSize = true;
            this.lblCdPeca.Location = new System.Drawing.Point(80, 60);
            this.lblCdPeca.Name = "lblCdPeca";
            this.lblCdPeca.Size = new System.Drawing.Size(68, 13);
            this.lblCdPeca.TabIndex = 7;
            this.lblCdPeca.Text = "Codigo Peca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ultimo Peço";
            // 
            // btnBuscaCompra
            // 
            this.btnBuscaCompra.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscaCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaCompra.Location = new System.Drawing.Point(260, 87);
            this.btnBuscaCompra.Name = "btnBuscaCompra";
            this.btnBuscaCompra.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaCompra.TabIndex = 4;
            this.btnBuscaCompra.UseVisualStyleBackColor = true;
            this.btnBuscaCompra.Click += new System.EventHandler(this.btnBuscaCompra_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(0, 2);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(30, 25);
            this.btnConfirma.TabIndex = 0;
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // frmCadCompraPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(340, 216);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscaCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCdPeca);
            this.Controls.Add(this.btnBuscaPeca);
            this.Controls.Add(this.txtCdCompra);
            this.Controls.Add(this.txtUltimoPreco);
            this.Controls.Add(this.txtCdPeca);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConfirma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadCompraPeca";
            this.Text = "Compra Peca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtCdPeca;
        private System.Windows.Forms.TextBox txtUltimoPreco;
        private System.Windows.Forms.TextBox txtCdCompra;
        private System.Windows.Forms.Button btnBuscaPeca;
        private System.Windows.Forms.Label lblCdPeca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscaCompra;
    }
}