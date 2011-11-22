namespace TCC.UI
{
    partial class frmCadPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadPerfil));
            this.lblDescPerfil = new System.Windows.Forms.Label();
            this.txtDescPerfil = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescPerfil
            // 
            this.lblDescPerfil.AutoSize = true;
            this.lblDescPerfil.Location = new System.Drawing.Point(74, 40);
            this.lblDescPerfil.Name = "lblDescPerfil";
            this.lblDescPerfil.Size = new System.Drawing.Size(96, 13);
            this.lblDescPerfil.TabIndex = 1;
            this.lblDescPerfil.Text = "Descrição do Perfil";
            // 
            // txtDescPerfil
            // 
            this.txtDescPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescPerfil.Location = new System.Drawing.Point(77, 57);
            this.txtDescPerfil.MaxLength = 50;
            this.txtDescPerfil.Multiline = true;
            this.txtDescPerfil.Name = "txtDescPerfil";
            this.txtDescPerfil.Size = new System.Drawing.Size(217, 107);
            this.txtDescPerfil.TabIndex = 1;
            this.txtDescPerfil.TextChanged += new System.EventHandler(this.txtDescPerfil_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(2, 30);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::TCC.Telas.resImg.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(2, 80);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 5;
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
            this.btnConfirma.BackgroundImage = global::TCC.Telas.resImg.btnSalvar;
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(2, 4);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(27, 23);
            this.btnConfirma.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnConfirma, "Salvar");
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.Telas.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(2, 54);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaAlteracaoDelecao.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            // 
            // frmCadPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.Telas.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 218);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtDescPerfil);
            this.Controls.Add(this.lblDescPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadPerfil";
            this.Text = "Cadastro de Perfis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescPerfil;
        private System.Windows.Forms.TextBox txtDescPerfil;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
    }
}