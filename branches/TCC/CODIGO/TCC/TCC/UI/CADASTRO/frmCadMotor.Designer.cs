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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadMotor));
            this.lblNomeMotor = new System.Windows.Forms.Label();
            this.txtDsMotor = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnAceitar = new System.Windows.Forms.Button();
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.btnRelacionarFornecedor = new System.Windows.Forms.Button();
            this.btnRelacioranEstoque = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeMotor
            // 
            this.lblNomeMotor.AutoSize = true;
            this.lblNomeMotor.Location = new System.Drawing.Point(65, 36);
            this.lblNomeMotor.Name = "lblNomeMotor";
            this.lblNomeMotor.Size = new System.Drawing.Size(80, 13);
            this.lblNomeMotor.TabIndex = 0;
            this.lblNomeMotor.Text = "Nome do Motor";
            // 
            // txtDsMotor
            // 
            this.txtDsMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDsMotor.Location = new System.Drawing.Point(68, 55);
            this.txtDsMotor.MaxLength = 100;
            this.txtDsMotor.Multiline = true;
            this.txtDsMotor.Name = "txtDsMotor";
            this.txtDsMotor.Size = new System.Drawing.Size(249, 80);
            this.txtDsMotor.TabIndex = 1;
            this.txtDsMotor.TextChanged += new System.EventHandler(this.txtDsMotor_TextChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::TCC.Telas.resImg.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(2, 77);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 7;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(2, 28);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = global::TCC.Telas.resImg.btnSalvar;
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(2, 4);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(27, 23);
            this.btnAceitar.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnAceitar, "Salvar");
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.Telas.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(2, 52);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaAlteracaoDelecao.TabIndex = 6;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            // 
            // btnRelacionarFornecedor
            // 
            this.btnRelacionarFornecedor.BackgroundImage = global::TCC.Telas.resImg.btnFornecedorDepto;
            this.btnRelacionarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelacionarFornecedor.Location = new System.Drawing.Point(128, 155);
            this.btnRelacionarFornecedor.Name = "btnRelacionarFornecedor";
            this.btnRelacionarFornecedor.Size = new System.Drawing.Size(40, 35);
            this.btnRelacionarFornecedor.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnRelacionarFornecedor, "Relacionar Fornecedor");
            this.btnRelacionarFornecedor.UseVisualStyleBackColor = true;
            this.btnRelacionarFornecedor.Click += new System.EventHandler(this.btnRelacionarFornecedor_Click);
            // 
            // btnRelacioranEstoque
            // 
            this.btnRelacioranEstoque.BackgroundImage = global::TCC.Telas.resImg.btnRlacionaEstoque;
            this.btnRelacioranEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelacioranEstoque.Location = new System.Drawing.Point(278, 155);
            this.btnRelacioranEstoque.Name = "btnRelacioranEstoque";
            this.btnRelacioranEstoque.Size = new System.Drawing.Size(40, 35);
            this.btnRelacioranEstoque.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnRelacioranEstoque, "Relacionar Estoque");
            this.btnRelacioranEstoque.UseVisualStyleBackColor = true;
            this.btnRelacioranEstoque.Click += new System.EventHandler(this.btnRelacioranEstoque_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Estoque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Relacionar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Relacionar";
            // 
            // frmCadMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.Telas.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 218);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRelacionarFornecedor);
            this.Controls.Add(this.btnRelacioranEstoque);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.txtDsMotor);
            this.Controls.Add(this.lblNomeMotor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadMotor";
            this.Text = "Cadastro de Motores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeMotor;
        private System.Windows.Forms.TextBox txtDsMotor;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRelacionarFornecedor;
        private System.Windows.Forms.Button btnRelacioranEstoque;
    }
}