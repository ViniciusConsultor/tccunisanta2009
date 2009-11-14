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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnBuscaFornecedor = new System.Windows.Forms.Button();
            this.btnBuscaPeca = new System.Windows.Forms.Button();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtPeca = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblPeca = new System.Windows.Forms.Label();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(2, 34);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(2, 63);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar / Voltar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnBuscaFornecedor
            // 
            this.btnBuscaFornecedor.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscaFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaFornecedor.Location = new System.Drawing.Point(262, 68);
            this.btnBuscaFornecedor.Name = "btnBuscaFornecedor";
            this.btnBuscaFornecedor.Size = new System.Drawing.Size(25, 23);
            this.btnBuscaFornecedor.TabIndex = 1;
            this.toolTipLegenda.SetToolTip(this.btnBuscaFornecedor, "Buscar Fornecedor");
            this.btnBuscaFornecedor.UseVisualStyleBackColor = true;
            this.btnBuscaFornecedor.Click += new System.EventHandler(this.btnBuscaFornecedor_Click);
            // 
            // btnBuscaPeca
            // 
            this.btnBuscaPeca.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscaPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaPeca.Location = new System.Drawing.Point(262, 97);
            this.btnBuscaPeca.Name = "btnBuscaPeca";
            this.btnBuscaPeca.Size = new System.Drawing.Size(25, 23);
            this.btnBuscaPeca.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnBuscaPeca, "Buscar Peça");
            this.btnBuscaPeca.UseVisualStyleBackColor = true;
            this.btnBuscaPeca.Click += new System.EventHandler(this.btnBuscaPeca_Click);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(144, 70);
            this.txtFornecedor.MaxLength = 50;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.ReadOnly = true;
            this.txtFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtFornecedor.TabIndex = 5;
            // 
            // txtPeca
            // 
            this.txtPeca.Location = new System.Drawing.Point(144, 99);
            this.txtPeca.MaxLength = 50;
            this.txtPeca.Name = "txtPeca";
            this.txtPeca.ReadOnly = true;
            this.txtPeca.Size = new System.Drawing.Size(100, 20);
            this.txtPeca.TabIndex = 6;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(77, 73);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 7;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // lblPeca
            // 
            this.lblPeca.AutoSize = true;
            this.lblPeca.Location = new System.Drawing.Point(106, 102);
            this.lblPeca.Name = "lblPeca";
            this.lblPeca.Size = new System.Drawing.Size(32, 13);
            this.lblPeca.TabIndex = 8;
            this.lblPeca.Text = "Peça";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.Location = new System.Drawing.Point(2, 5);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(27, 23);
            this.btnConfirmar.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnConfirmar, "OK");
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmCadPecaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
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