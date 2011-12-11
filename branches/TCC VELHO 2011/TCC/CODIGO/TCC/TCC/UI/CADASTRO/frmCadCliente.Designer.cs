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
            this.txtNumero = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.gbxEscolhePaisEstado.SuspendLayout();
            this.panelBrasil.SuspendLayout();
            this.panelOutros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(128, 11);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.AccessibleDescription = "";
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Location = new System.Drawing.Point(195, 9);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(531, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(152, 193);
            this.lblRua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(34, 17);
            this.lblRua.TabIndex = 0;
            this.lblRua.Text = "Rua";
            // 
            // txtRua
            // 
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRua.Location = new System.Drawing.Point(196, 191);
            this.txtRua.Margin = new System.Windows.Forms.Padding(4);
            this.txtRua.MaxLength = 100;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(530, 22);
            this.txtRua.TabIndex = 7;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(129, 231);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 17);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(313, 226);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(94, 17);
            this.lblComplemento.TabIndex = 0;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.Location = new System.Drawing.Point(416, 224);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplemento.MaxLength = 20;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(310, 22);
            this.txtComplemento.TabIndex = 9;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(599, 260);
            this.lblCep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(35, 17);
            this.lblCep.TabIndex = 0;
            this.lblCep.Text = "CEP";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(143, 266);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(46, 17);
            this.lblBairro.TabIndex = 0;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(21, 106);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(52, 17);
            this.lblCidade.TabIndex = 0;
            this.lblCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Location = new System.Drawing.Point(196, 257);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(302, 22);
            this.txtBairro.TabIndex = 10;
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Location = new System.Drawing.Point(84, 103);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(482, 22);
            this.txtCidade.TabIndex = 6;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(129, 17);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(34, 17);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "U.F.";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(173, 14);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(85, 24);
            this.cboEstado.TabIndex = 3;
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(8, 159);
            this.btnVolta.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(53, 43);
            this.btnVolta.TabIndex = 20;
            this.toolTipLegenda.SetToolTip(this.btnVolta, "Fechar");
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // lblTlefone
            // 
            this.lblTlefone.AutoSize = true;
            this.lblTlefone.Location = new System.Drawing.Point(344, 324);
            this.lblTlefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTlefone.Name = "lblTlefone";
            this.lblTlefone.Size = new System.Drawing.Size(64, 17);
            this.lblTlefone.TabIndex = 0;
            this.lblTlefone.Text = "Telefone";
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(253, 324);
            this.lblDDD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(38, 17);
            this.lblDDD.TabIndex = 16;
            this.lblDDD.Text = "DDD";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(196, 289);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(531, 22);
            this.txtEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(140, 298);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            // 
            // txtCep
            // 
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Location = new System.Drawing.Point(644, 256);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(83, 22);
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
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(8, 108);
            this.btnBuscaAlteracaoDelecao.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(53, 43);
            this.btnBuscaAlteracaoDelecao.TabIndex = 19;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            this.btnBuscaAlteracaoDelecao.Click += new System.EventHandler(this.btnBuscaAlteracaoDelecao_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpa.BackgroundImage")));
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpa.Location = new System.Drawing.Point(8, 58);
            this.btnLimpa.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(53, 43);
            this.btnLimpa.TabIndex = 18;
            this.toolTipLegenda.SetToolTip(this.btnLimpa, "Limpar");
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnInsere
            // 
            this.btnInsere.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnInsere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsere.Location = new System.Drawing.Point(8, 7);
            this.btnInsere.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(53, 43);
            this.btnInsere.TabIndex = 17;
            this.toolTipLegenda.SetToolTip(this.btnInsere, "Salvar");
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Click += new System.EventHandler(this.btnInsere_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Location = new System.Drawing.Point(411, 321);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Mask = "0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(87, 22);
            this.txtTelefone.TabIndex = 16;
            this.txtTelefone.ValidatingType = typeof(int);
            // 
            // txtDDD
            // 
            this.txtDDD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDDD.Location = new System.Drawing.Point(303, 321);
            this.txtDDD.Margin = new System.Windows.Forms.Padding(4);
            this.txtDDD.MaxLength = 2;
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(41, 22);
            this.txtDDD.TabIndex = 14;
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
            this.gbxEscolhePaisEstado.Location = new System.Drawing.Point(139, 47);
            this.gbxEscolhePaisEstado.Margin = new System.Windows.Forms.Padding(4);
            this.gbxEscolhePaisEstado.Name = "gbxEscolhePaisEstado";
            this.gbxEscolhePaisEstado.Padding = new System.Windows.Forms.Padding(4);
            this.gbxEscolhePaisEstado.Size = new System.Drawing.Size(587, 137);
            this.gbxEscolhePaisEstado.TabIndex = 2;
            this.gbxEscolhePaisEstado.TabStop = false;
            // 
            // lblNmPais
            // 
            this.lblNmPais.AutoSize = true;
            this.lblNmPais.Location = new System.Drawing.Point(40, 74);
            this.lblNmPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNmPais.Name = "lblNmPais";
            this.lblNmPais.Size = new System.Drawing.Size(35, 17);
            this.lblNmPais.TabIndex = 10;
            this.lblNmPais.Text = "Pais";
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.Location = new System.Drawing.Point(364, 71);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(202, 22);
            this.txtEstado.TabIndex = 5;
            // 
            // txtPais
            // 
            this.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPais.Location = new System.Drawing.Point(84, 69);
            this.txtPais.Margin = new System.Windows.Forms.Padding(4);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(183, 22);
            this.txtPais.TabIndex = 4;
            // 
            // rdbOutros
            // 
            this.rdbOutros.AutoSize = true;
            this.rdbOutros.Location = new System.Drawing.Point(55, 41);
            this.rdbOutros.Margin = new System.Windows.Forms.Padding(4);
            this.rdbOutros.Name = "rdbOutros";
            this.rdbOutros.Size = new System.Drawing.Size(72, 21);
            this.rdbOutros.TabIndex = 2;
            this.rdbOutros.Text = "Outros";
            this.rdbOutros.UseVisualStyleBackColor = true;
            this.rdbOutros.CheckedChanged += new System.EventHandler(this.rdbOutros_CheckedChanged);
            // 
            // rdbBrasil
            // 
            this.rdbBrasil.AutoSize = true;
            this.rdbBrasil.Checked = true;
            this.rdbBrasil.Location = new System.Drawing.Point(55, 15);
            this.rdbBrasil.Margin = new System.Windows.Forms.Padding(4);
            this.rdbBrasil.Name = "rdbBrasil";
            this.rdbBrasil.Size = new System.Drawing.Size(64, 21);
            this.rdbBrasil.TabIndex = 2;
            this.rdbBrasil.TabStop = true;
            this.rdbBrasil.Text = "Brasil";
            this.rdbBrasil.UseVisualStyleBackColor = true;
            this.rdbBrasil.CheckedChanged += new System.EventHandler(this.rdbBrasil_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Província";
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodPostal.Location = new System.Drawing.Point(596, 256);
            this.txtCodPostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodPostal.MaxLength = 20;
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(131, 22);
            this.txtCodPostal.TabIndex = 11;
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(500, 258);
            this.lblCodPostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(95, 17);
            this.lblCodPostal.TabIndex = 46;
            this.lblCodPostal.Text = "Código Postal";
            // 
            // txtTelefoneInter
            // 
            this.txtTelefoneInter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefoneInter.Location = new System.Drawing.Point(411, 321);
            this.txtTelefoneInter.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefoneInter.MaxLength = 8;
            this.txtTelefoneInter.Name = "txtTelefoneInter";
            this.txtTelefoneInter.Size = new System.Drawing.Size(87, 22);
            this.txtTelefoneInter.TabIndex = 15;
            this.txtTelefoneInter.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // txtDDI
            // 
            this.txtDDI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDDI.Location = new System.Drawing.Point(195, 324);
            this.txtDDI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDDI.MaxLength = 2;
            this.txtDDI.Name = "txtDDI";
            this.txtDDI.Size = new System.Drawing.Size(46, 22);
            this.txtDDI.TabIndex = 13;
            this.txtDDI.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // lblDDI
            // 
            this.lblDDI.AutoSize = true;
            this.lblDDI.Location = new System.Drawing.Point(156, 326);
            this.lblDDI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDDI.Name = "lblDDI";
            this.lblDDI.Size = new System.Drawing.Size(31, 17);
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
            this.panelBrasil.Location = new System.Drawing.Point(139, 362);
            this.panelBrasil.Margin = new System.Windows.Forms.Padding(4);
            this.panelBrasil.Name = "panelBrasil";
            this.panelBrasil.Size = new System.Drawing.Size(587, 76);
            this.panelBrasil.TabIndex = 17;
            // 
            // rdbPessoaJuridica
            // 
            this.rdbPessoaJuridica.AutoSize = true;
            this.rdbPessoaJuridica.Location = new System.Drawing.Point(367, 11);
            this.rdbPessoaJuridica.Margin = new System.Windows.Forms.Padding(4);
            this.rdbPessoaJuridica.Name = "rdbPessoaJuridica";
            this.rdbPessoaJuridica.Size = new System.Drawing.Size(129, 21);
            this.rdbPessoaJuridica.TabIndex = 18;
            this.rdbPessoaJuridica.Text = "Pessoa Jurídica";
            this.rdbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rdbPessoaJuridica.CheckedChanged += new System.EventHandler(this.rdbPessoaJuridica_CheckedChanged);
            // 
            // rdbPessoaFisica
            // 
            this.rdbPessoaFisica.AutoSize = true;
            this.rdbPessoaFisica.Checked = true;
            this.rdbPessoaFisica.Location = new System.Drawing.Point(77, 11);
            this.rdbPessoaFisica.Margin = new System.Windows.Forms.Padding(4);
            this.rdbPessoaFisica.Name = "rdbPessoaFisica";
            this.rdbPessoaFisica.Size = new System.Drawing.Size(116, 21);
            this.rdbPessoaFisica.TabIndex = 17;
            this.rdbPessoaFisica.TabStop = true;
            this.rdbPessoaFisica.Text = "Pessoa Física";
            this.rdbPessoaFisica.UseVisualStyleBackColor = true;
            this.rdbPessoaFisica.CheckedChanged += new System.EventHandler(this.rdbPessoaFisica_CheckedChanged);
            // 
            // txtCnpj
            // 
            this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnpj.Location = new System.Drawing.Point(376, 39);
            this.txtCnpj.Margin = new System.Windows.Forms.Padding(4);
            this.txtCnpj.Mask = "00,000,000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(153, 22);
            this.txtCnpj.TabIndex = 20;
            this.txtCnpj.ValidatingType = typeof(int);
            // 
            // txtCPF
            // 
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPF.Location = new System.Drawing.Point(84, 39);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(133, 22);
            this.txtCPF.TabIndex = 19;
            this.txtCPF.ValidatingType = typeof(int);
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(323, 42);
            this.lblCnpj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(43, 17);
            this.lblCnpj.TabIndex = 17;
            this.lblCnpj.Text = "CNPJ";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(40, 42);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 17);
            this.lblCPF.TabIndex = 18;
            this.lblCPF.Text = "CPF";
            // 
            // panelOutros
            // 
            this.panelOutros.Controls.Add(this.txtIdentInter);
            this.panelOutros.Controls.Add(this.lblIdentInter);
            this.panelOutros.Location = new System.Drawing.Point(140, 362);
            this.panelOutros.Margin = new System.Windows.Forms.Padding(4);
            this.panelOutros.Name = "panelOutros";
            this.panelOutros.Size = new System.Drawing.Size(587, 76);
            this.panelOutros.TabIndex = 17;
            // 
            // txtIdentInter
            // 
            this.txtIdentInter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdentInter.Location = new System.Drawing.Point(199, 44);
            this.txtIdentInter.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentInter.MaxLength = 50;
            this.txtIdentInter.Name = "txtIdentInter";
            this.txtIdentInter.Size = new System.Drawing.Size(162, 22);
            this.txtIdentInter.TabIndex = 16;
            // 
            // lblIdentInter
            // 
            this.lblIdentInter.AutoSize = true;
            this.lblIdentInter.Location = new System.Drawing.Point(200, 18);
            this.lblIdentInter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentInter.Name = "lblIdentInter";
            this.lblIdentInter.Size = new System.Drawing.Size(155, 17);
            this.lblIdentInter.TabIndex = 45;
            this.lblIdentInter.Text = "Código de Identificação";
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.Location = new System.Drawing.Point(196, 223);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(98, 22);
            this.txtNumero.TabIndex = 8;
            this.txtNumero.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 482);
            this.ControlBox = false;
            this.Controls.Add(this.txtNumero);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private Controles.MegaTextBox.MegaTextBox txtNumero;
    }
}