namespace TCC.UI
{
    partial class frmCadProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadProduto));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnAceitar = new System.Windows.Forms.Button();
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbFamMotor = new System.Windows.Forms.RadioButton();
            this.rdbKit = new System.Windows.Forms.RadioButton();
            this.txtFiltroBusca = new System.Windows.Forms.TextBox();
            this.txtDescProduto = new System.Windows.Forms.TextBox();
            this.lblDs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(2, 75);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 9;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar / Voltar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(2, 25);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 7;
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
            this.btnAceitar.Location = new System.Drawing.Point(2, 1);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(27, 23);
            this.btnAceitar.TabIndex = 6;
            this.toolTipLegenda.SetToolTip(this.btnAceitar, "OK");
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(2, 49);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaAlteracaoDelecao.TabIndex = 8;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarProduto.Location = new System.Drawing.Point(291, 65);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(27, 23);
            this.btnBuscarProduto.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnBuscarProduto, "Buscar Peças");
            this.btnBuscarProduto.UseVisualStyleBackColor = true;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tipo do Produto";
            // 
            // rdbFamMotor
            // 
            this.rdbFamMotor.AutoSize = true;
            this.rdbFamMotor.Checked = true;
            this.rdbFamMotor.Location = new System.Drawing.Point(56, 36);
            this.rdbFamMotor.Name = "rdbFamMotor";
            this.rdbFamMotor.Size = new System.Drawing.Size(102, 17);
            this.rdbFamMotor.TabIndex = 1;
            this.rdbFamMotor.TabStop = true;
            this.rdbFamMotor.Text = "Familia de Motor";
            this.rdbFamMotor.UseVisualStyleBackColor = true;
            this.rdbFamMotor.CheckedChanged += new System.EventHandler(this.rdbFamMotor_CheckedChanged);
            // 
            // rdbKit
            // 
            this.rdbKit.AutoSize = true;
            this.rdbKit.Location = new System.Drawing.Point(164, 36);
            this.rdbKit.Name = "rdbKit";
            this.rdbKit.Size = new System.Drawing.Size(85, 17);
            this.rdbKit.TabIndex = 2;
            this.rdbKit.Text = "Kit de Peças";
            this.rdbKit.UseVisualStyleBackColor = true;
            this.rdbKit.CheckedChanged += new System.EventHandler(this.rdbKit_CheckedChanged);
            // 
            // txtFiltroBusca
            // 
            this.txtFiltroBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroBusca.Enabled = false;
            this.txtFiltroBusca.Location = new System.Drawing.Point(56, 65);
            this.txtFiltroBusca.MaxLength = 25;
            this.txtFiltroBusca.Name = "txtFiltroBusca";
            this.txtFiltroBusca.Size = new System.Drawing.Size(229, 20);
            this.txtFiltroBusca.TabIndex = 3;
            this.txtFiltroBusca.TabStop = false;
            this.txtFiltroBusca.TextChanged += new System.EventHandler(this.txtFiltroBusca_TextChanged);
            // 
            // txtDescProduto
            // 
            this.txtDescProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescProduto.Location = new System.Drawing.Point(56, 137);
            this.txtDescProduto.MaxLength = 500;
            this.txtDescProduto.Multiline = true;
            this.txtDescProduto.Name = "txtDescProduto";
            this.txtDescProduto.Size = new System.Drawing.Size(262, 43);
            this.txtDescProduto.TabIndex = 5;
            // 
            // lblDs
            // 
            this.lblDs.AutoSize = true;
            this.lblDs.Location = new System.Drawing.Point(53, 121);
            this.lblDs.Name = "lblDs";
            this.lblDs.Size = new System.Drawing.Size(55, 13);
            this.lblDs.TabIndex = 40;
            this.lblDs.Text = "Descrição";
            // 
            // frmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(340, 220);
            this.ControlBox = false;
            this.Controls.Add(this.txtDescProduto);
            this.Controls.Add(this.lblDs);
            this.Controls.Add(this.txtFiltroBusca);
            this.Controls.Add(this.btnBuscarProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbFamMotor);
            this.Controls.Add(this.rdbKit);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAceitar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadProduto";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmCadOrdemProducao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbFamMotor;
        private System.Windows.Forms.RadioButton rdbKit;
        private System.Windows.Forms.TextBox txtFiltroBusca;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.TextBox txtDescProduto;
        private System.Windows.Forms.Label lblDs;
    }
}