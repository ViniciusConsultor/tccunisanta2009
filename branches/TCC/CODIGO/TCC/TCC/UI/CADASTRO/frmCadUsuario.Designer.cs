namespace TCC.UI
{
    partial class frmCadUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadUsuario));
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtPerfilUsuario = new System.Windows.Forms.TextBox();
            this.lblPerfilUsuario = new System.Windows.Forms.Label();
            this.btnBuscaPerfilUsuario = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnAceitar = new System.Windows.Forms.Button();
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Location = new System.Drawing.Point(103, 65);
            this.txtLogin.MaxLength = 25;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(206, 20);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(64, 67);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.Location = new System.Drawing.Point(67, 140);
            this.txtObservacao.MaxLength = 100;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(242, 44);
            this.txtObservacao.TabIndex = 4;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(64, 124);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 4;
            this.lblObservacao.Text = "Observação";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(2, 28);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 6;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::TCC.Telas.resImg.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(2, 78);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 8;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Location = new System.Drawing.Point(103, 94);
            this.txtSenha.MaxLength = 15;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(206, 20);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(64, 96);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "Senha";
            // 
            // txtPerfilUsuario
            // 
            this.txtPerfilUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPerfilUsuario.Enabled = false;
            this.txtPerfilUsuario.Location = new System.Drawing.Point(147, 31);
            this.txtPerfilUsuario.MaxLength = 50;
            this.txtPerfilUsuario.Name = "txtPerfilUsuario";
            this.txtPerfilUsuario.ReadOnly = true;
            this.txtPerfilUsuario.Size = new System.Drawing.Size(132, 20);
            this.txtPerfilUsuario.TabIndex = 0;
            this.txtPerfilUsuario.TabStop = false;
            // 
            // lblPerfilUsuario
            // 
            this.lblPerfilUsuario.AutoSize = true;
            this.lblPerfilUsuario.Location = new System.Drawing.Point(64, 33);
            this.lblPerfilUsuario.Name = "lblPerfilUsuario";
            this.lblPerfilUsuario.Size = new System.Drawing.Size(84, 13);
            this.lblPerfilUsuario.TabIndex = 13;
            this.lblPerfilUsuario.Text = "Perfil do Usuário";
            // 
            // btnBuscaPerfilUsuario
            // 
            this.btnBuscaPerfilUsuario.BackgroundImage = global::TCC.Telas.resImg.btnBusca;
            this.btnBuscaPerfilUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaPerfilUsuario.Location = new System.Drawing.Point(285, 29);
            this.btnBuscaPerfilUsuario.Name = "btnBuscaPerfilUsuario";
            this.btnBuscaPerfilUsuario.Size = new System.Drawing.Size(24, 23);
            this.btnBuscaPerfilUsuario.TabIndex = 1;
            this.toolTipLegenda.SetToolTip(this.btnBuscaPerfilUsuario, "Buscar Perfil");
            this.btnBuscaPerfilUsuario.UseVisualStyleBackColor = true;
            this.btnBuscaPerfilUsuario.Click += new System.EventHandler(this.btnBuscaPerfilUsuario_Click);
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
            this.btnAceitar.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnAceitar, "Salvar");
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.Telas.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(2, 53);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaAlteracaoDelecao.TabIndex = 7;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            // 
            // frmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.Telas.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 218);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.btnBuscaPerfilUsuario);
            this.Controls.Add(this.txtPerfilUsuario);
            this.Controls.Add(this.lblPerfilUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadUsuario";
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.frmCadUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtPerfilUsuario;
        private System.Windows.Forms.Label lblPerfilUsuario;
        private System.Windows.Forms.Button btnBuscaPerfilUsuario;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
    }
}