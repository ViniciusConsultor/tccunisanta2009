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
            this.lblDsMotor = new System.Windows.Forms.Label();
            this.txtDsMotor = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnAceitar = new System.Windows.Forms.Button();
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.btnRelacionarDepto = new System.Windows.Forms.Button();
            this.btnRelacioranEstoque = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDsMotor
            // 
            this.lblDsMotor.AutoSize = true;
            this.lblDsMotor.Location = new System.Drawing.Point(65, 52);
            this.lblDsMotor.Name = "lblDsMotor";
            this.lblDsMotor.Size = new System.Drawing.Size(100, 13);
            this.lblDsMotor.TabIndex = 0;
            this.lblDsMotor.Text = "Descrição do Motor";
            // 
            // txtDsMotor
            // 
            this.txtDsMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDsMotor.Location = new System.Drawing.Point(68, 71);
            this.txtDsMotor.MaxLength = 100;
            this.txtDsMotor.Multiline = true;
            this.txtDsMotor.Name = "txtDsMotor";
            this.txtDsMotor.Size = new System.Drawing.Size(249, 80);
            this.txtDsMotor.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(2, 77);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::TCC.resImg.btnLimpa;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(2, 28);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 3;
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
            this.btnAceitar.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(2, 4);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(27, 23);
            this.btnAceitar.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnAceitar, "Cadastrar");
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(2, 52);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaAlteracaoDelecao.TabIndex = 19;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar Registro");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            // 
            // btnRelacionarDepto
            // 
            this.btnRelacionarDepto.BackgroundImage = global::TCC.resImg.btnFornecedorDepto;
            this.btnRelacionarDepto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelacionarDepto.Location = new System.Drawing.Point(128, 171);
            this.btnRelacionarDepto.Name = "btnRelacionarDepto";
            this.btnRelacionarDepto.Size = new System.Drawing.Size(40, 35);
            this.btnRelacionarDepto.TabIndex = 34;
            this.toolTipLegenda.SetToolTip(this.btnRelacionarDepto, "Relacionar Departamento");
            this.btnRelacionarDepto.UseVisualStyleBackColor = true;
            // 
            // btnRelacioranEstoque
            // 
            this.btnRelacioranEstoque.BackgroundImage = global::TCC.resImg.btnRlacionaEstoque;
            this.btnRelacioranEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelacioranEstoque.Location = new System.Drawing.Point(278, 171);
            this.btnRelacioranEstoque.Name = "btnRelacioranEstoque";
            this.btnRelacioranEstoque.Size = new System.Drawing.Size(40, 35);
            this.btnRelacioranEstoque.TabIndex = 33;
            this.toolTipLegenda.SetToolTip(this.btnRelacioranEstoque, "Relacionar Estoque");
            this.btnRelacioranEstoque.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Estoque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Relacionar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Relacionar";
            // 
            // frmCadMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 218);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRelacionarDepto);
            this.Controls.Add(this.btnRelacioranEstoque);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.txtDsMotor);
            this.Controls.Add(this.lblDsMotor);
            this.MaximizeBox = false;
            this.Name = "frmCadMotor";
            this.Text = "Cadastro de Motores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDsMotor;
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
        private System.Windows.Forms.Button btnRelacionarDepto;
        private System.Windows.Forms.Button btnRelacioranEstoque;
    }
}