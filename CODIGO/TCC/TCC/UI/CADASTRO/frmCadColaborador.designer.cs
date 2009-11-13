namespace TCC.UI
{
    partial class frmCadColaborador
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
            this.lblCdDepart = new System.Windows.Forms.Label();
            this.lblNmColaborador = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.lblNmRua = new System.Windows.Forms.Label();
            this.lblNumeroEnd = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCdDepartamento = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.CbSexo = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnApaga = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnBuscaDepartamento = new System.Windows.Forms.Button();
            this.lblDDD = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnCadUsuario = new System.Windows.Forms.Button();
            this.txtDDD = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCdDepart
            // 
            this.lblCdDepart.AutoSize = true;
            this.lblCdDepart.Location = new System.Drawing.Point(99, 325);
            this.lblCdDepart.Name = "lblCdDepart";
            this.lblCdDepart.Size = new System.Drawing.Size(74, 13);
            this.lblCdDepart.TabIndex = 0;
            this.lblCdDepart.Text = "Departamento";
            // 
            // lblNmColaborador
            // 
            this.lblNmColaborador.AutoSize = true;
            this.lblNmColaborador.Location = new System.Drawing.Point(102, 29);
            this.lblNmColaborador.Name = "lblNmColaborador";
            this.lblNmColaborador.Size = new System.Drawing.Size(38, 13);
            this.lblNmColaborador.TabIndex = 0;
            this.lblNmColaborador.Text = "Nome ";
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Location = new System.Drawing.Point(102, 64);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(89, 13);
            this.lblDtNasc.TabIndex = 0;
            this.lblDtNasc.Text = "Data Nascimento";
            // 
            // lblNmRua
            // 
            this.lblNmRua.AutoSize = true;
            this.lblNmRua.Location = new System.Drawing.Point(102, 96);
            this.lblNmRua.Name = "lblNmRua";
            this.lblNmRua.Size = new System.Drawing.Size(27, 13);
            this.lblNmRua.TabIndex = 0;
            this.lblNmRua.Text = "Rua";
            // 
            // lblNumeroEnd
            // 
            this.lblNumeroEnd.AutoSize = true;
            this.lblNumeroEnd.Location = new System.Drawing.Point(102, 132);
            this.lblNumeroEnd.Name = "lblNumeroEnd";
            this.lblNumeroEnd.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroEnd.TabIndex = 0;
            this.lblNumeroEnd.Text = "Número";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(231, 132);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 0;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(447, 169);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 0;
            this.lblCep.Text = "CEP";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(102, 169);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 0;
            this.lblBairro.Text = "Bairro";
            // 
            // txtCdDepartamento
            // 
            this.txtCdDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdDepartamento.Enabled = false;
            this.txtCdDepartamento.Location = new System.Drawing.Point(179, 322);
            this.txtCdDepartamento.MaxLength = 10;
            this.txtCdDepartamento.Name = "txtCdDepartamento";
            this.txtCdDepartamento.ReadOnly = true;
            this.txtCdDepartamento.Size = new System.Drawing.Size(120, 20);
            this.txtCdDepartamento.TabIndex = 3;
            this.txtCdDepartamento.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(147, 26);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(404, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtRua
            // 
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRua.Location = new System.Drawing.Point(147, 94);
            this.txtRua.MaxLength = 100;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(404, 20);
            this.txtRua.TabIndex = 8;
            // 
            // txtComplemento
            // 
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.Location = new System.Drawing.Point(304, 129);
            this.txtComplemento.MaxLength = 25;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(247, 20);
            this.txtComplemento.TabIndex = 10;
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Location = new System.Drawing.Point(147, 167);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(291, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(102, 208);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 2;
            this.lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Location = new System.Drawing.Point(147, 206);
            this.txtCidade.MaxLength = 40;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(291, 20);
            this.txtCidade.TabIndex = 13;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(445, 213);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(30, 13);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "U. F.";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(102, 244);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(23, 13);
            this.lblRg.TabIndex = 2;
            this.lblRg.Text = "RG";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(335, 244);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF";
            // 
            // txtRg
            // 
            this.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRg.Location = new System.Drawing.Point(147, 242);
            this.txtRg.MaxLength = 15;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(155, 20);
            this.txtRg.TabIndex = 15;
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.Location = new System.Drawing.Point(364, 244);
            this.txtCpf.MaxLength = 15;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(187, 20);
            this.txtCpf.TabIndex = 16;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(268, 64);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Sexo";
            // 
            // CbSexo
            // 
            this.CbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbSexo.FormattingEnabled = true;
            this.CbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CbSexo.Location = new System.Drawing.Point(308, 60);
            this.CbSexo.Name = "CbSexo";
            this.CbSexo.Size = new System.Drawing.Size(47, 21);
            this.CbSexo.TabIndex = 5;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(7, 127);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(40, 35);
            this.btnVoltar.TabIndex = 20;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnApaga
            // 
            this.btnApaga.BackgroundImage = global::TCC.resImg.btnLimpa;
            this.btnApaga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApaga.Location = new System.Drawing.Point(7, 45);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(40, 35);
            this.btnApaga.TabIndex = 19;
            this.toolTipLegenda.SetToolTip(this.btnApaga, "Limpar");
            this.btnApaga.UseVisualStyleBackColor = true;
            this.btnApaga.Click += new System.EventHandler(this.btnApaga_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEstado.Location = new System.Drawing.Point(481, 206);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(70, 21);
            this.cbEstado.TabIndex = 14;
            // 
            // btnBuscaDepartamento
            // 
            this.btnBuscaDepartamento.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscaDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaDepartamento.Location = new System.Drawing.Point(304, 319);
            this.btnBuscaDepartamento.Name = "btnBuscaDepartamento";
            this.btnBuscaDepartamento.Size = new System.Drawing.Size(24, 23);
            this.btnBuscaDepartamento.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnBuscaDepartamento, "Buscar Departamento");
            this.btnBuscaDepartamento.UseVisualStyleBackColor = true;
            this.btnBuscaDepartamento.Click += new System.EventHandler(this.btnBuscaDepartamento_Click);
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(361, 64);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(31, 13);
            this.lblDDD.TabIndex = 21;
            this.lblDDD.Text = "DDD";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(429, 63);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 23;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(102, 283);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(147, 281);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(404, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataNasc.Location = new System.Drawing.Point(194, 61);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(71, 20);
            this.txtDataNasc.TabIndex = 4;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.Location = new System.Drawing.Point(147, 130);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(76, 20);
            this.txtNumero.TabIndex = 9;
            this.txtNumero.TipoTexto = Controles.MegaTextBox.TipoTexto.Texto;
            // 
            // txtCep
            // 
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Location = new System.Drawing.Point(481, 167);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(70, 20);
            this.txtCep.TabIndex = 12;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Location = new System.Drawing.Point(481, 62);
            this.txtTelefone.Mask = "0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(70, 20);
            this.txtTelefone.TabIndex = 7;
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(7, 86);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(40, 35);
            this.btnBuscaAlteracaoDelecao.TabIndex = 26;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar Registro");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            this.btnBuscaAlteracaoDelecao.Click += new System.EventHandler(this.btnBuscaAlteracaoDelecao_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(7, 6);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(40, 35);
            this.btnConfirma.TabIndex = 18;
            this.toolTipLegenda.SetToolTip(this.btnConfirma, "Cadastrar");
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnCadUsuario
            // 
            this.btnCadUsuario.BackgroundImage = global::TCC.resImg.btnNovoUsuario;
            this.btnCadUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadUsuario.Location = new System.Drawing.Point(504, 307);
            this.btnCadUsuario.Name = "btnCadUsuario";
            this.btnCadUsuario.Size = new System.Drawing.Size(47, 42);
            this.btnCadUsuario.TabIndex = 28;
            this.toolTipLegenda.SetToolTip(this.btnCadUsuario, "Cadastrar Usuário");
            this.btnCadUsuario.UseVisualStyleBackColor = true;
            // 
            // txtDDD
            // 
            this.txtDDD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDDD.Location = new System.Drawing.Point(392, 60);
            this.txtDDD.MaxLength = 2;
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(31, 20);
            this.txtDDD.TabIndex = 27;
            this.txtDDD.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Cadastrar";
            // 
            // frmCadColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 368);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCadUsuario);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblDDD);
            this.Controls.Add(this.btnBuscaDepartamento);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.btnApaga);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.CbSexo);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCdDepartamento);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblNumeroEnd);
            this.Controls.Add(this.lblNmRua);
            this.Controls.Add(this.lblDtNasc);
            this.Controls.Add(this.lblNmColaborador);
            this.Controls.Add(this.lblCdDepart);
            this.MaximizeBox = false;
            this.Name = "frmCadColaborador";
            this.Text = "Cadastro de Funcionários";
            this.Load += new System.EventHandler(this.frmCadColaborador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCdDepart;
        private System.Windows.Forms.Label lblNmColaborador;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.Label lblNmRua;
        private System.Windows.Forms.Label lblNumeroEnd;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtCdDepartamento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox CbSexo;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnApaga;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnBuscaDepartamento;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private Controles.MegaTextBox.MegaTextBox txtNumero;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private Controles.MegaTextBox.MegaTextBox txtDDD;
        private System.Windows.Forms.Button btnCadUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}