namespace TCC.UI
{
    partial class frmCadFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadFornecedor));
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNumeroEndereco = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.lblNomeFornecedor = new System.Windows.Forms.Label();
            this.lblcnpj = new System.Windows.Forms.Label();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.lblDDD = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnInsere = new System.Windows.Forms.Button();
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.btnRelacionarDepto = new System.Windows.Forms.Button();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtDDD = new TCC.Controle.MegaTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxEscolhePaisEstado = new System.Windows.Forms.GroupBox();
            this.lblNmPais = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.rdbOutros = new System.Windows.Forms.RadioButton();
            this.rdbBrasil = new System.Windows.Forms.RadioButton();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtDDI = new TCC.Controle.MegaTextBox(this.components);
            this.lblDDI = new System.Windows.Forms.Label();
            this.lblIdentInter = new System.Windows.Forms.Label();
            this.txtTelefoneInter = new TCC.Controle.MegaTextBox(this.components);
            this.txtIdentInter = new System.Windows.Forms.TextBox();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtNumeroEndereco = new TCC.Controle.MegaTextBox(this.components);
            this.gbxEscolhePaisEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Location = new System.Drawing.Point(150, 225);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(252, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(109, 227);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 4;
            this.lblBairro.Text = "Bairro";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.Location = new System.Drawing.Point(338, 195);
            this.txtComplemento.MaxLength = 20;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(241, 20);
            this.txtComplemento.TabIndex = 10;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(263, 197);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 8;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblNumeroEndereco
            // 
            this.lblNumeroEndereco.AutoSize = true;
            this.lblNumeroEndereco.Location = new System.Drawing.Point(97, 197);
            this.lblNumeroEndereco.Name = "lblNumeroEndereco";
            this.lblNumeroEndereco.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroEndereco.TabIndex = 10;
            this.lblNumeroEndereco.Text = "Número";
            // 
            // txtRua
            // 
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRua.Location = new System.Drawing.Point(150, 160);
            this.txtRua.MaxLength = 50;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(429, 20);
            this.txtRua.TabIndex = 8;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(109, 162);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 13);
            this.lblRua.TabIndex = 12;
            this.lblRua.Text = "Rua";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFornecedor.Location = new System.Drawing.Point(150, 9);
            this.txtNomeFornecedor.MaxLength = 100;
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(429, 20);
            this.txtNomeFornecedor.TabIndex = 1;
            this.txtNomeFornecedor.TextChanged += new System.EventHandler(this.txtNomeFornecedor_TextChanged);
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.AutoSize = true;
            this.lblNomeFornecedor.Location = new System.Drawing.Point(109, 11);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(35, 13);
            this.lblNomeFornecedor.TabIndex = 14;
            this.lblNomeFornecedor.Text = "Nome";
            // 
            // lblcnpj
            // 
            this.lblcnpj.AutoSize = true;
            this.lblcnpj.Location = new System.Drawing.Point(110, 257);
            this.lblcnpj.Name = "lblcnpj";
            this.lblcnpj.Size = new System.Drawing.Size(34, 13);
            this.lblcnpj.TabIndex = 2;
            this.lblcnpj.Text = "CNPJ";
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = global::TCC.Telas.resImg.btnVoltar;
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(7, 128);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(40, 35);
            this.btnVolta.TabIndex = 22;
            this.toolTipLegenda.SetToolTip(this.btnVolta, "Fechar");
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlimpar.BackgroundImage")));
            this.btnlimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpar.Location = new System.Drawing.Point(7, 46);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(40, 35);
            this.btnlimpar.TabIndex = 20;
            this.toolTipLegenda.SetToolTip(this.btnlimpar, "Limpar");
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(402, 257);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(31, 13);
            this.lblDDD.TabIndex = 19;
            this.lblDDD.Text = "DDD";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(466, 257);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 21;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(150, 287);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(430, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(109, 294);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Email";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Location = new System.Drawing.Point(522, 255);
            this.txtTelefone.Mask = "0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(58, 20);
            this.txtTelefone.TabIndex = 16;
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // btnInsere
            // 
            this.btnInsere.BackgroundImage = global::TCC.Telas.resImg.btnSalvar;
            this.btnInsere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsere.Location = new System.Drawing.Point(7, 5);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(40, 35);
            this.btnInsere.TabIndex = 19;
            this.toolTipLegenda.SetToolTip(this.btnInsere, "Salvar");
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Click += new System.EventHandler(this.btnInsere_Click);
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.Telas.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(7, 87);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(40, 35);
            this.btnBuscaAlteracaoDelecao.TabIndex = 21;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            this.btnBuscaAlteracaoDelecao.Click += new System.EventHandler(this.btnBuscaAlteracaoDelecao_Click);
            // 
            // btnRelacionarDepto
            // 
            this.btnRelacionarDepto.BackgroundImage = global::TCC.Telas.resImg.btnFornecedorDepto;
            this.btnRelacionarDepto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelacionarDepto.Location = new System.Drawing.Point(540, 321);
            this.btnRelacionarDepto.Name = "btnRelacionarDepto";
            this.btnRelacionarDepto.Size = new System.Drawing.Size(40, 35);
            this.btnRelacionarDepto.TabIndex = 18;
            this.toolTipLegenda.SetToolTip(this.btnRelacionarDepto, "Relacionar Departamento");
            this.btnRelacionarDepto.UseVisualStyleBackColor = true;
            this.btnRelacionarDepto.Click += new System.EventHandler(this.btnRelacionarDepto_Click);
            // 
            // txtCnpj
            // 
            this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnpj.Location = new System.Drawing.Point(150, 255);
            this.txtCnpj.Mask = "00,000,000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(110, 20);
            this.txtCnpj.TabIndex = 13;
            this.txtCnpj.ValidatingType = typeof(int);
            // 
            // txtDDD
            // 
            this.txtDDD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDDD.Location = new System.Drawing.Point(432, 255);
            this.txtDDD.MaxLength = 2;
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(35, 20);
            this.txtDDD.TabIndex = 15;
            this.txtDDD.TipoTexto = TCC.Controle.TipoTexto.Numerico;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Relacionar";
            // 
            // gbxEscolhePaisEstado
            // 
            this.gbxEscolhePaisEstado.Controls.Add(this.lblNmPais);
            this.gbxEscolhePaisEstado.Controls.Add(this.txtEstado);
            this.gbxEscolhePaisEstado.Controls.Add(this.txtPais);
            this.gbxEscolhePaisEstado.Controls.Add(this.rdbOutros);
            this.gbxEscolhePaisEstado.Controls.Add(this.rdbBrasil);
            this.gbxEscolhePaisEstado.Controls.Add(this.cboEstado);
            this.gbxEscolhePaisEstado.Controls.Add(this.label3);
            this.gbxEscolhePaisEstado.Controls.Add(this.lblEstado);
            this.gbxEscolhePaisEstado.Controls.Add(this.lblCidade);
            this.gbxEscolhePaisEstado.Controls.Add(this.txtCidade);
            this.gbxEscolhePaisEstado.Location = new System.Drawing.Point(100, 35);
            this.gbxEscolhePaisEstado.Name = "gbxEscolhePaisEstado";
            this.gbxEscolhePaisEstado.Size = new System.Drawing.Size(479, 111);
            this.gbxEscolhePaisEstado.TabIndex = 2;
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
            this.txtEstado.Location = new System.Drawing.Point(317, 58);
            this.txtEstado.MaxLength = 50;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(152, 20);
            this.txtEstado.TabIndex = 6;
            // 
            // txtPais
            // 
            this.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPais.Location = new System.Drawing.Point(63, 56);
            this.txtPais.MaxLength = 50;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(191, 20);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Província";
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
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(16, 86);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 0;
            this.lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Location = new System.Drawing.Point(63, 84);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(406, 20);
            this.txtCidade.TabIndex = 7;
            // 
            // txtDDI
            // 
            this.txtDDI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDDI.Location = new System.Drawing.Point(367, 255);
            this.txtDDI.MaxLength = 2;
            this.txtDDI.Name = "txtDDI";
            this.txtDDI.Size = new System.Drawing.Size(35, 20);
            this.txtDDI.TabIndex = 14;
            this.txtDDI.TipoTexto = TCC.Controle.TipoTexto.Numerico;
            // 
            // lblDDI
            // 
            this.lblDDI.AutoSize = true;
            this.lblDDI.Location = new System.Drawing.Point(338, 257);
            this.lblDDI.Name = "lblDDI";
            this.lblDDI.Size = new System.Drawing.Size(26, 13);
            this.lblDDI.TabIndex = 38;
            this.lblDDI.Text = "DDI";
            // 
            // lblIdentInter
            // 
            this.lblIdentInter.AutoSize = true;
            this.lblIdentInter.Location = new System.Drawing.Point(97, 262);
            this.lblIdentInter.Name = "lblIdentInter";
            this.lblIdentInter.Size = new System.Drawing.Size(119, 13);
            this.lblIdentInter.TabIndex = 39;
            this.lblIdentInter.Text = "Código de Identificação";
            // 
            // txtTelefoneInter
            // 
            this.txtTelefoneInter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefoneInter.Location = new System.Drawing.Point(514, 255);
            this.txtTelefoneInter.MaxLength = 10;
            this.txtTelefoneInter.Name = "txtTelefoneInter";
            this.txtTelefoneInter.Size = new System.Drawing.Size(66, 20);
            this.txtTelefoneInter.TabIndex = 16;
            this.txtTelefoneInter.TipoTexto = TCC.Controle.TipoTexto.Numerico;
            // 
            // txtIdentInter
            // 
            this.txtIdentInter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdentInter.Location = new System.Drawing.Point(229, 255);
            this.txtIdentInter.MaxLength = 50;
            this.txtIdentInter.Name = "txtIdentInter";
            this.txtIdentInter.Size = new System.Drawing.Size(100, 20);
            this.txtIdentInter.TabIndex = 13;
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(409, 227);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(72, 13);
            this.lblCodPostal.TabIndex = 44;
            this.lblCodPostal.Text = "Código Postal";
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodPostal.Location = new System.Drawing.Point(481, 225);
            this.txtCodPostal.MaxLength = 20;
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(99, 20);
            this.txtCodPostal.TabIndex = 12;
            // 
            // txtCep
            // 
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Location = new System.Drawing.Point(522, 225);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(58, 20);
            this.txtCep.TabIndex = 12;
            this.txtCep.ValidatingType = typeof(int);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(483, 228);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 12;
            this.lblCep.Text = "CEP";
            // 
            // txtNumeroEndereco
            // 
            this.txtNumeroEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroEndereco.Location = new System.Drawing.Point(150, 194);
            this.txtNumeroEndereco.MaxLength = 5;
            this.txtNumeroEndereco.Name = "txtNumeroEndereco";
            this.txtNumeroEndereco.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroEndereco.TabIndex = 9;
            this.txtNumeroEndereco.TipoTexto = TCC.Controle.TipoTexto.Numerico;
            // 
            // frmCadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.Telas.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 368);
            this.ControlBox = false;
            this.Controls.Add(this.txtNumeroEndereco);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txtCodPostal);
            this.Controls.Add(this.lblCodPostal);
            this.Controls.Add(this.txtIdentInter);
            this.Controls.Add(this.txtTelefoneInter);
            this.Controls.Add(this.lblIdentInter);
            this.Controls.Add(this.txtDDI);
            this.Controls.Add(this.lblDDI);
            this.Controls.Add(this.gbxEscolhePaisEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRelacionarDepto);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblDDD);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnInsere);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.lblNomeFornecedor);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblNumeroEndereco);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblcnpj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCadFornecedor";
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.frmCadFornecedor_Load);
            this.gbxEscolhePaisEstado.ResumeLayout(false);
            this.gbxEscolhePaisEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumeroEndereco;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Label lblNomeFornecedor;
        private System.Windows.Forms.Label lblcnpj;
        private System.Windows.Forms.Button btnInsere;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private TCC.Controle.MegaTextBox txtDDD;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private System.Windows.Forms.Button btnRelacionarDepto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxEscolhePaisEstado;
        private System.Windows.Forms.Label lblNmPais;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.RadioButton rdbOutros;
        private System.Windows.Forms.RadioButton rdbBrasil;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private TCC.Controle.MegaTextBox txtDDI;
        private System.Windows.Forms.Label lblDDI;
        private System.Windows.Forms.Label lblIdentInter;
        private TCC.Controle.MegaTextBox txtTelefoneInter;
        private System.Windows.Forms.TextBox txtIdentInter;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label lblCep;
        private TCC.Controle.MegaTextBox txtNumeroEndereco;
    }
}