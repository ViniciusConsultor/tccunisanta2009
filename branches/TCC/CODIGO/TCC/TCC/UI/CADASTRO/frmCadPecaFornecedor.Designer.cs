namespace TCC.UI
{
    partial class frmCadPecaFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadPecaFornecedor));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnBuscaFornecedor = new System.Windows.Forms.Button();
            this.btnBuscaPeca = new System.Windows.Forms.Button();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtPeca = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblPeca = new System.Windows.Forms.Label();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackgroundImage = global::TCC.Properties.Resources.btnSalvar;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.Location = new System.Drawing.Point(2, 5);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(27, 23);
            this.btnConfirmar.TabIndex = 0;
            this.toolTipLegenda.SetToolTip(this.btnConfirmar, "OK");
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::TCC.Properties.Resources.eraser;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(2, 34);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 1;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(2, 63);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar / Voltar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnBuscaFornecedor
            // 
            this.btnBuscaFornecedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaFornecedor.BackgroundImage")));
            this.btnBuscaFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaFornecedor.Location = new System.Drawing.Point(268, 67);
            this.btnBuscaFornecedor.Name = "btnBuscaFornecedor";
            this.btnBuscaFornecedor.Size = new System.Drawing.Size(25, 23);
            this.btnBuscaFornecedor.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnBuscaFornecedor, "Buscar Fornecedor");
            this.btnBuscaFornecedor.UseVisualStyleBackColor = true;
            this.btnBuscaFornecedor.Click += new System.EventHandler(this.btnBuscaFornecedor_Click);
            // 
            // btnBuscaPeca
            // 
            this.btnBuscaPeca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaPeca.BackgroundImage")));
            this.btnBuscaPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaPeca.Location = new System.Drawing.Point(268, 96);
            this.btnBuscaPeca.Name = "btnBuscaPeca";
            this.btnBuscaPeca.Size = new System.Drawing.Size(25, 23);
            this.btnBuscaPeca.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnBuscaPeca, "Buscar Peça");
            this.btnBuscaPeca.UseVisualStyleBackColor = true;
            this.btnBuscaPeca.Click += new System.EventHandler(this.btnBuscaPeca_Click);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(150, 69);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.ReadOnly = true;
            this.txtFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtFornecedor.TabIndex = 5;
            // 
            // txtPeca
            // 
            this.txtPeca.Location = new System.Drawing.Point(150, 98);
            this.txtPeca.Name = "txtPeca";
            this.txtPeca.ReadOnly = true;
            this.txtPeca.Size = new System.Drawing.Size(100, 20);
            this.txtPeca.TabIndex = 6;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(83, 72);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 7;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // lblPeca
            // 
            this.lblPeca.AutoSize = true;
            this.lblPeca.Location = new System.Drawing.Point(112, 101);
            this.lblPeca.Name = "lblPeca";
            this.lblPeca.Size = new System.Drawing.Size(32, 13);
            this.lblPeca.TabIndex = 8;
            this.lblPeca.Text = "Peça";
            // 
            // frmCadPecaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 218);
            this.ControlBox = false;
            this.Controls.Add(this.lblPeca);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txtPeca);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.btnBuscaPeca);
            this.Controls.Add(this.btnBuscaFornecedor);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConfirmar);
            this.MaximizeBox = false;
            this.Name = "frmCadPecaFornecedor";
            this.Text = "Peca Fornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnBuscaFornecedor;
        private System.Windows.Forms.Button btnBuscaPeca;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtPeca;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblPeca;
        private System.Windows.Forms.ToolTip toolTipLegenda;
    }
}