namespace TCC.UI
{
    partial class frmCadCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCliente));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.btnVolta = new System.Windows.Forms.Button();
            this.lblTlefone = new System.Windows.Forms.Label();
            this.lblDDD = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNumero = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnInsere = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtDDD = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.gbxEscolhePaisEstado = new System.Windows.Forms.GroupBox();
            this.lblNmPais = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.rdbOutros = new System.Windows.Forms.RadioButton();
            this.rdbBrasil = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.txtTelefoneInter = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.txtDDI = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.lblDDI = new System.Windows.Forms.Label();
            this.panelBrasil = new System.Windows.Forms.Panel();
            this.rdbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rdbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.panelOutros = new System.Windows.Forms.Panel();
            this.txtIdentInter = new System.Windows.Forms.TextBox();
            this.lblIdentInter = new System.Windows.Forms.Label();
            this.gbxEscolhePaisEstado.SuspendLayout();
            this.panelBrasil.SuspendLayout();
            this.panelOutros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(96, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.AccessibleDescription = "";
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Location = new System.Drawing.Point(146, 7);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(399, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(114, 157);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 13);
            this.lblRua.TabIndex = 0;
            this.lblRua.Text = "Rua";
            // 
            // txtRua
            // 
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRua.Location = new System.Drawing.Point(147, 155);
            this.txtRua.MaxLength = 100;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(398, 20);
            this.txtRua.TabIndex = 8;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(97, 188);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(235, 184);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 0;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.Location = new System.Drawing.Point(312, 182);
            this.txtComplemento.MaxLength = 20;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(233, 20);
            this.txtComplemento.TabIndex = 10;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(449, 211);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 0;
            this.lblCep.Text = "CEP";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(107, 216);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 0;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(16, 86);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 0;
            this.lblCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Location = new System.Drawing.Point(147, 209);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(227, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Location = new System.Drawing.Point(63, 84);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(362, 20);
            this.txtCidade.TabIndex = 7;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(97, 14);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(27, 13);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "U.F.";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(130, 11);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(65, 21);
            this.cboEstado.TabIndex = 4;
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(6, 129);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(40, 35);
            this.btnVolta.TabIndex = 24;
            this.toolTipLegenda.SetToolTip(this.btnVolta, "Fechar");
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // lblTlefone
            // 
            this.lblTlefone.AutoSize = true;
            this.lblTlefone.Location = new System.Drawing.Point(258, 263);
            this.lblTlefone.Name = "lblTlefone";
            this.lblTlefone.Size = new System.Drawing.Size(49, 13);
            this.lblTlefone.TabIndex = 0;
            this.lblTlefone.Text = "Telefone";
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(190, 263);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(31, 13);
            this.lblDDD.TabIndex = 16;
            this.lblDDD.Text = "DDD";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(147, 235);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(399, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(105, 242);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.Location = new System.Drawing.Point(147, 181);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(73, 20);
            this.txtNumero.TabIndex = 9;
            this.txtNumero.TipoTexto = Controles.MegaTextBox.TipoTexto.Texto;
            // 
            // txtCep
            // 
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Location = new System.Drawing.Point(483, 208);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(63, 20);
            this.txtCep.TabIndex = 12;
            this.txtCep.ValidatingType = typeof(int);
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
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(6, 88);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(40, 35);
            this.btnBuscaAlteracaoDelecao.TabIndex = 23;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            this.btnBuscaAlteracaoDelecao.Click += new System.EventHandler(this.btnBuscaAlteracaoDelecao_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpa.BackgroundImage")));
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpa.Location = new System.Drawing.Point(6, 47);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(40, 35);
            this.btnLimpa.TabIndex = 22;
            this.toolTipLegenda.SetToolTip(this.btnLimpa, "Limpar");
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnInsere
            // 
            this.btnInsere.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnInsere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsere.Location = new System.Drawing.Point(6, 6);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(40, 35);
            this.btnInsere.TabIndex = 21;
            this.toolTipLegenda.SetToolTip(this.btnInsere, "Salvar");
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Click += new System.EventHandler(this.btnInsere_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Location = new System.Drawing.Point(308, 261);
            this.txtTelefone.Mask = "0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(66, 20);
            this.txtTelefone.TabIndex = 16;
            this.txtTelefone.ValidatingType = typeof(int);
            // 
            // txtDDD
            // 
            this.txtDDD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDDD.Location = new System.Drawing.Point(227, 261);
            this.txtDDD.MaxLength = 2;
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(31, 20);
            this.txtDDD.TabIndex = 15;
            this.txtDDD.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // gbxEscolhePaisEstado
            // 
            this.gbxEscolhePaisEstado.Controls.Add(this.lblNmPais);
            this.gbxEscolhePaisEstado.Controls.Add(this.txtEstado);
            this.gbxEscolhePaisEstado.Controls.Add(this.txtPais);
            this.gbxEscolhePaisEstado.Controls.Add(this.rdbOutros);
            this.gbxEscolhePaisEstado.Controls.Add(this.rdbBrasil);
            this.gbxEscolhePaisEstado.Controls.Add(this.cboEstado);
            this.gbxEscolhePaisEstado.Controls.Add(this.label1);
            this.gbxEscolhePaisEstado.Controls.Add(this.lblEstado);
            this.gbxEscolhePaisEstado.Controls.Add(this.lblCidade);
            this.gbxEscolhePaisEstado.Controls.Add(this.txtCidade);
            this.gbxEscolhePaisEstado.Location = new System.Drawing.Point(104, 38);
            this.gbxEscolhePaisEstado.Name = "gbxEscolhePaisEstado";
            this.gbxEscolhePaisEstado.Size = new System.Drawing.Size(440, 111);
            this.gbxEscolhePaisEstado.TabIndex = 22;
            this.gbxEscolhePaisEstado.TabStop = false;
            // 
            // lblNmPais
            // 
            this.lblNmPais.AutoSize = true;
            this.lblNmPais.Location = new System.Drawing.Point(30, 60);
            this.lblNmPais.Name = "lblNmPais";
            this.lblNmPais.Size = new System.Drawing.Size(27, 13);
            this.lblNmPais.TabIndex = 10;
            this.lblNmPais.Text = "Pais";
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.Location = new System.Drawing.Point(273, 58);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(152, 20);
            this.txtEstado.TabIndex = 6;
            // 
            // txtPais
            // 
            this.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPais.Location = new System.Drawing.Point(63, 56);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(138, 20);
            this.txtPais.TabIndex = 5;
            // 
            // rdbOutros
            // 
            this.rdbOutros.AutoSize = true;
            this.rdbOutros.Location = new System.Drawing.Point(41, 33);
            this.rdbOutros.Name = "rdbOutros";
            this.rdbOutros.Size = new System.Drawing.Size(56, 17);
            this.rdbOutros.TabIndex = 3;
            this.rdbOutros.Text = "Outros";
            this.rdbOutros.UseVisualStyleBackColor = true;
            this.rdbOutros.CheckedChanged += new System.EventHandler(this.rdbOutros_CheckedChanged);
            // 
            // rdbBrasil
            // 
            this.rdbBrasil.AutoSize = true;
            this.rdbBrasil.Checked = true;
            this.rdbBrasil.Location = new System.Drawing.Point(41, 12);
            this.rdbBrasil.Name = "rdbBrasil";
            this.rdbBrasil.Size = new System.Drawing.Size(50, 17);
            this.rdbBrasil.TabIndex = 2;
            this.rdbBrasil.TabStop = true;
            this.rdbBrasil.Text = "Brasil";
            this.rdbBrasil.UseVisualStyleBackColor = true;
            this.rdbBrasil.CheckedChanged += new System.EventHandler(this.rdbBrasil_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Província";
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodPostal.Location = new System.Drawing.Point(447, 208);
            this.txtCodPostal.MaxLength = 20;
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(99, 20);
            this.txtCodPostal.TabIndex = 12;
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(375, 210);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(72, 13);
            this.lblCodPostal.TabIndex = 46;
            this.lblCodPostal.Text = "Código Postal";
            // 
            // txtTelefoneInter
            // 
            this.txtTelefoneInter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefoneInter.Location = new System.Drawing.Point(308, 261);
            this.txtTelefoneInter.MaxLength = 8;
            this.txtTelefoneInter.Name = "txtTelefoneInter";
            this.txtTelefoneInter.Size = new System.Drawing.Size(66, 20);
            this.txtTelefoneInter.TabIndex = 16;
            this.txtTelefoneInter.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // txtDDI
            // 
            this.txtDDI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDDI.Location = new System.Drawing.Point(146, 263);
            this.txtDDI.MaxLength = 2;
            this.txtDDI.Name = "txtDDI";
            this.txtDDI.Size = new System.Drawing.Size(35, 20);
            this.txtDDI.TabIndex = 14;
            this.txtDDI.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            this.txtDDI.TextChanged += new System.EventHandler(this.txtDDI_TextChanged);
            // 
            // lblDDI
            // 
            this.lblDDI.AutoSize = true;
            this.lblDDI.Location = new System.Drawing.Point(117, 265);
            this.lblDDI.Name = "lblDDI";
            this.lblDDI.Size = new System.Drawing.Size(26, 13);
            this.lblDDI.TabIndex = 50;
            this.lblDDI.Text = "DDI";
            // 
            // panelBrasil
            // 
            this.panelBrasil.Controls.Add(this.rdbPessoaJuridica);
            this.panelBrasil.Controls.Add(this.rdbPessoaFisica);
            this.panelBrasil.Controls.Add(this.txtCnpj);
            this.panelBrasil.Controls.Add(this.txtCPF);
            this.panelBrasil.Controls.Add(this.lblCnpj);
            this.panelBrasil.Controls.Add(this.lblCPF);
            this.panelBrasil.Location = new System.Drawing.Point(104, 294);
            this.panelBrasil.Name = "panelBrasil";
            this.panelBrasil.Size = new System.Drawing.Size(440, 62);
            this.panelBrasil.TabIndex = 53;
            // 
            // rdbPessoaJuridica
            // 
            this.rdbPessoaJuridica.AutoSize = true;
            this.rdbPessoaJuridica.Location = new System.Drawing.Point(275, 9);
            this.rdbPessoaJuridica.Name = "rdbPessoaJuridica";
            this.rdbPessoaJuridica.Size = new System.Drawing.Size(101, 17);
            this.rdbPessoaJuridica.TabIndex = 18;
            this.rdbPessoaJuridica.Text = "Pessoa Jurídica";
            this.rdbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rdbPessoaJuridica.CheckedChanged += new System.EventHandler(this.rdbPessoaJuridica_CheckedChanged);
            // 
            // rdbPessoaFisica
            // 
            this.rdbPessoaFisica.AutoSize = true;
            this.rdbPessoaFisica.Checked = true;
            this.rdbPessoaFisica.Location = new System.Drawing.Point(58, 9);
            this.rdbPessoaFisica.Name = "rdbPessoaFisica";
            this.rdbPessoaFisica.Size = new System.Drawing.Size(92, 17);
            this.rdbPessoaFisica.TabIndex = 17;
            this.rdbPessoaFisica.TabStop = true;
            this.rdbPessoaFisica.Text = "Pessoa Física";
            this.rdbPessoaFisica.UseVisualStyleBackColor = true;
            this.rdbPessoaFisica.CheckedChanged += new System.EventHandler(this.rdbPessoaFisica_CheckedChanged);
            // 
            // txtCnpj
            // 
            this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnpj.Location = new System.Drawing.Point(282, 32);
            this.txtCnpj.Mask = "00,000,000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(115, 20);
            this.txtCnpj.TabIndex = 20;
            this.txtCnpj.ValidatingType = typeof(int);
            // 
            // txtCPF
            // 
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPF.Location = new System.Drawing.Point(63, 32);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 19;
            this.txtCPF.ValidatingType = typeof(int);
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(242, 34);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(34, 13);
            this.lblCnpj.TabIndex = 17;
            this.lblCnpj.Text = "CNPJ";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(30, 34);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 18;
            this.lblCPF.Text = "CPF";
            // 
            // panelOutros
            // 
            this.panelOutros.Controls.Add(this.txtIdentInter);
            this.panelOutros.Controls.Add(this.lblIdentInter);
            this.panelOutros.Location = new System.Drawing.Point(105, 294);
            this.panelOutros.Name = "panelOutros";
            this.panelOutros.Size = new System.Drawing.Size(440, 62);
            this.panelOutros.TabIndex = 54;
            // 
            // txtIdentInter
            // 
            this.txtIdentInter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdentInter.Location = new System.Drawing.Point(149, 36);
            this.txtIdentInter.MaxLength = 50;
            this.txtIdentInter.Name = "txtIdentInter";
            this.txtIdentInter.Size = new System.Drawing.Size(122, 20);
            this.txtIdentInter.TabIndex = 17;
            // 
            // lblIdentInter
            // 
            this.lblIdentInter.AutoSize = true;
            this.lblIdentInter.Location = new System.Drawing.Point(150, 15);
            this.lblIdentInter.Name = "lblIdentInter";
            this.lblIdentInter.Size = new System.Drawing.Size(119, 13);
            this.lblIdentInter.TabIndex = 45;
            this.lblIdentInter.Text = "Código de Identificação";
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 368);
            this.ControlBox = false;
            this.Controls.Add(this.panelOutros);
            this.Controls.Add(this.panelBrasil);
            this.Controls.Add(this.txtTelefoneInter);
            this.Controls.Add(this.txtDDI);
            this.Controls.Add(this.lblDDI);
            this.Controls.Add(this.txtCodPostal);
            this.Controls.Add(this.lblCodPostal);
            this.Controls.Add(this.gbxEscolhePaisEstado);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDDD);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnInsere);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.lblTlefone);
            this.Controls.Add(this.lblRua);
            this.MaximizeBox = false;
            this.Name = "frmCadCliente";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmCadCliente_Load);
            this.gbxEscolhePaisEstado.ResumeLayout(false);
            this.gbxEscolhePaisEstado.PerformLayout();
            this.panelBrasil.ResumeLayout(false);
            this.panelBrasil.PerformLayout();
            this.panelOutros.ResumeLayout(false);
            this.panelOutros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btnInsere;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Label lblTlefone;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private Controles.MegaTextBox.MegaTextBox txtNumero;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private Controles.MegaTextBox.MegaTextBox txtDDD;
        private System.Windows.Forms.GroupBox gbxEscolhePaisEstado;
        private System.Windows.Forms.RadioButton rdbOutros;
        private System.Windows.Forms.RadioButton rdbBrasil;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblNmPais;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.Label lblCodPostal;
        private Controles.MegaTextBox.MegaTextBox txtTelefoneInter;
        private Controles.MegaTextBox.MegaTextBox txtDDI;
        private System.Windows.Forms.Label lblDDI;
        private System.Windows.Forms.Panel panelBrasil;
        private System.Windows.Forms.RadioButton rdbPessoaJuridica;
        private System.Windows.Forms.RadioButton rdbPessoaFisica;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Panel panelOutros;
        private System.Windows.Forms.TextBox txtIdentInter;
        private System.Windows.Forms.Label lblIdentInter;
    }
}