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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCompraPeca));
            this.btnConfirma = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(35, 189);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(75, 23);
            this.btnConfirma.TabIndex = 0;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(116, 189);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(197, 189);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtCdPeca
            // 
            this.txtCdPeca.Location = new System.Drawing.Point(119, 16);
            this.txtCdPeca.Name = "txtCdPeca";
            this.txtCdPeca.ReadOnly = true;
            this.txtCdPeca.Size = new System.Drawing.Size(100, 20);
            this.txtCdPeca.TabIndex = 3;
            // 
            // txtUltimoPreco
            // 
            this.txtUltimoPreco.Location = new System.Drawing.Point(119, 68);
            this.txtUltimoPreco.Name = "txtUltimoPreco";
            this.txtUltimoPreco.Size = new System.Drawing.Size(100, 20);
            this.txtUltimoPreco.TabIndex = 4;
            // 
            // txtCdCompra
            // 
            this.txtCdCompra.Location = new System.Drawing.Point(119, 42);
            this.txtCdCompra.Name = "txtCdCompra";
            this.txtCdCompra.ReadOnly = true;
            this.txtCdCompra.Size = new System.Drawing.Size(100, 20);
            this.txtCdCompra.TabIndex = 5;
            // 
            // btnBuscaPeca
            // 
            this.btnBuscaPeca.Location = new System.Drawing.Point(225, 14);
            this.btnBuscaPeca.Name = "btnBuscaPeca";
            this.btnBuscaPeca.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaPeca.TabIndex = 6;
            this.btnBuscaPeca.Text = "...";
            this.btnBuscaPeca.UseVisualStyleBackColor = true;
            this.btnBuscaPeca.Click += new System.EventHandler(this.btnBuscaPeca_Click);
            // 
            // lblCdPeca
            // 
            this.lblCdPeca.AutoSize = true;
            this.lblCdPeca.Location = new System.Drawing.Point(45, 19);
            this.lblCdPeca.Name = "lblCdPeca";
            this.lblCdPeca.Size = new System.Drawing.Size(68, 13);
            this.lblCdPeca.TabIndex = 7;
            this.lblCdPeca.Text = "Codigo Peca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ultimo Peço";
            // 
            // btnBuscaCompra
            // 
            this.btnBuscaCompra.Location = new System.Drawing.Point(225, 40);
            this.btnBuscaCompra.Name = "btnBuscaCompra";
            this.btnBuscaCompra.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaCompra.TabIndex = 10;
            this.btnBuscaCompra.Text = "...";
            this.btnBuscaCompra.UseVisualStyleBackColor = true;
            this.btnBuscaCompra.Click += new System.EventHandler(this.btnBuscaCompra_Click);
            // 
            // frmCadCompraPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 264);
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
            this.MaximizeBox = false;
            this.Name = "frmCadCompraPeca";
            this.Text = "frmCadCompraPeca";
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