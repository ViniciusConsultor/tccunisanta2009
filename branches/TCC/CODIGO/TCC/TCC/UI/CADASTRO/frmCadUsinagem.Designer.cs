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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadUsinagem));
            this.lblCdPeca = new System.Windows.Forms.Label();
            this.txtCdPeca = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCdPeca = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnAceitar = new System.Windows.Forms.Button();
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.btnRelacioranEstoque = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtdPecasDefeito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbDefeitoSim = new System.Windows.Forms.RadioButton();
            this.rdbDefeitoNao = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCdPeca
            // 
            this.lblCdPeca.AutoSize = true;
            this.lblCdPeca.Location = new System.Drawing.Point(72, 27);
            this.lblCdPeca.Name = "lblCdPeca";
            this.lblCdPeca.Size = new System.Drawing.Size(32, 13);
            this.lblCdPeca.TabIndex = 0;
            this.lblCdPeca.Text = "Peça";
            // 
            // txtCdPeca
            // 
            this.txtCdPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdPeca.Enabled = false;
            this.txtCdPeca.Location = new System.Drawing.Point(110, 22);
            this.txtCdPeca.Name = "txtCdPeca";
            this.txtCdPeca.ReadOnly = true;
            this.txtCdPeca.Size = new System.Drawing.Size(143, 20);
            this.txtCdPeca.TabIndex = 1;
            this.txtCdPeca.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(1, 76);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 9;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(1, 27);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 7;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCdPeca
            // 
            this.btnCdPeca.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnCdPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdPeca.Location = new System.Drawing.Point(259, 20);
            this.btnCdPeca.Name = "btnCdPeca";
            this.btnCdPeca.Size = new System.Drawing.Size(27, 23);
            this.btnCdPeca.TabIndex = 1;
            this.toolTipLegenda.SetToolTip(this.btnCdPeca, "Buscar Peça");
            this.btnCdPeca.UseVisualStyleBackColor = true;
            this.btnCdPeca.Click += new System.EventHandler(this.btnCdPeca_Click);
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
            this.btnAceitar.Location = new System.Drawing.Point(1, 3);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(27, 23);
            this.btnAceitar.TabIndex = 6;
            this.toolTipLegenda.SetToolTip(this.btnAceitar, "Cadastrar");
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(1, 51);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaAlteracaoDelecao.TabIndex = 8;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar Registro");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            // 
            // btnRelacioranEstoque
            // 
            this.btnRelacioranEstoque.BackgroundImage = global::TCC.resImg.btnRlacionaEstoque;
            this.btnRelacioranEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelacioranEstoque.Location = new System.Drawing.Point(78, 8);
            this.btnRelacioranEstoque.Name = "btnRelacioranEstoque";
            this.btnRelacioranEstoque.Size = new System.Drawing.Size(40, 35);
            this.btnRelacioranEstoque.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnRelacioranEstoque, "Relacionar Estoque");
            this.btnRelacioranEstoque.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Qtd. de Peças defeituosas";
            // 
            // txtQtdPecasDefeito
            // 
            this.txtQtdPecasDefeito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdPecasDefeito.Location = new System.Drawing.Point(110, 82);
            this.txtQtdPecasDefeito.Name = "txtQtdPecasDefeito";
            this.txtQtdPecasDefeito.Size = new System.Drawing.Size(143, 20);
            this.txtQtdPecasDefeito.TabIndex = 2;
            this.txtQtdPecasDefeito.TextChanged += new System.EventHandler(this.txtQtdPecasDefeito_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Peças OK?";
            // 
            // rdbDefeitoSim
            // 
            this.rdbDefeitoSim.AutoSize = true;
            this.rdbDefeitoSim.Location = new System.Drawing.Point(133, 125);
            this.rdbDefeitoSim.Name = "rdbDefeitoSim";
            this.rdbDefeitoSim.Size = new System.Drawing.Size(42, 17);
            this.rdbDefeitoSim.TabIndex = 3;
            this.rdbDefeitoSim.TabStop = true;
            this.rdbDefeitoSim.Text = "Sim";
            this.rdbDefeitoSim.UseVisualStyleBackColor = true;
            // 
            // rdbDefeitoNao
            // 
            this.rdbDefeitoNao.AutoSize = true;
            this.rdbDefeitoNao.Location = new System.Drawing.Point(180, 125);
            this.rdbDefeitoNao.Name = "rdbDefeitoNao";
            this.rdbDefeitoNao.Size = new System.Drawing.Size(45, 17);
            this.rdbDefeitoNao.TabIndex = 4;
            this.rdbDefeitoNao.TabStop = true;
            this.rdbDefeitoNao.Text = "Não";
            this.rdbDefeitoNao.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnRelacioranEstoque);
            this.panel1.Location = new System.Drawing.Point(116, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 50);
            this.panel1.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Estoque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Relacionar";
            // 
            // frmCadUsinagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 218);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdbDefeitoNao);
            this.Controls.Add(this.rdbDefeitoSim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQtdPecasDefeito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtdPecasDefeito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbDefeitoSim;
        private System.Windows.Forms.RadioButton rdbDefeitoNao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRelacioranEstoque;
    }
}