namespace TCC.UI
{
    partial class frmCadDepartamento
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
            this.txtDescricaoDepartamento = new System.Windows.Forms.TextBox();
            this.lblDescricaoDepartamento = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.txtNomeDepartamento = new System.Windows.Forms.TextBox();
            this.lblNomeDepartamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDescricaoDepartamento
            // 
            this.txtDescricaoDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoDepartamento.Location = new System.Drawing.Point(62, 120);
            this.txtDescricaoDepartamento.MaxLength = 100;
            this.txtDescricaoDepartamento.Multiline = true;
            this.txtDescricaoDepartamento.Name = "txtDescricaoDepartamento";
            this.txtDescricaoDepartamento.Size = new System.Drawing.Size(253, 60);
            this.txtDescricaoDepartamento.TabIndex = 1;
            // 
            // lblDescricaoDepartamento
            // 
            this.lblDescricaoDepartamento.AutoSize = true;
            this.lblDescricaoDepartamento.Location = new System.Drawing.Point(59, 104);
            this.lblDescricaoDepartamento.Name = "lblDescricaoDepartamento";
            this.lblDescricaoDepartamento.Size = new System.Drawing.Size(55, 13);
            this.lblDescricaoDepartamento.TabIndex = 2;
            this.lblDescricaoDepartamento.Text = "Descrição";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::TCC.resImg.btnLimpa;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(1, 29);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(30, 25);
            this.btnLimpar.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(1, 83);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(30, 25);
            this.btnVoltar.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(1, 3);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(30, 25);
            this.btnConfirma.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnConfirma, "Cadastrar");
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(1, 56);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(30, 25);
            this.btnBuscaAlteracaoDelecao.TabIndex = 17;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar Registro");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            // 
            // txtNomeDepartamento
            // 
            this.txtNomeDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeDepartamento.Location = new System.Drawing.Point(62, 56);
            this.txtNomeDepartamento.Name = "txtNomeDepartamento";
            this.txtNomeDepartamento.Size = new System.Drawing.Size(253, 20);
            this.txtNomeDepartamento.TabIndex = 5;
            this.txtNomeDepartamento.TextChanged += new System.EventHandler(this.txtNomeDepartamento_TextChanged);
            // 
            // lblNomeDepartamento
            // 
            this.lblNomeDepartamento.AutoSize = true;
            this.lblNomeDepartamento.Location = new System.Drawing.Point(62, 37);
            this.lblNomeDepartamento.Name = "lblNomeDepartamento";
            this.lblNomeDepartamento.Size = new System.Drawing.Size(120, 13);
            this.lblNomeDepartamento.TabIndex = 6;
            this.lblNomeDepartamento.Text = "Nome do Departamento";
            // 
            // frmCadDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 234);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.lblNomeDepartamento);
            this.Controls.Add(this.txtNomeDepartamento);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtDescricaoDepartamento);
            this.Controls.Add(this.lblDescricaoDepartamento);
            this.MaximizeBox = false;
            this.Name = "frmCadDepartamento";
            this.Text = "Cadastro de Departamentos";
            this.Load += new System.EventHandler(this.frmCadDepartamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricaoDepartamento;
        private System.Windows.Forms.Label lblDescricaoDepartamento;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.TextBox txtNomeDepartamento;
        private System.Windows.Forms.Label lblNomeDepartamento;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
    }
}