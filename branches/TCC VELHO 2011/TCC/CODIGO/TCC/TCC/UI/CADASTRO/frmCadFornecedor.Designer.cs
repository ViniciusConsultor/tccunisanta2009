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
            this.txtDDD = new Controles.MegaTextBox.MegaTextBox(this.components);
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
            this.txtDDI = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.lblDDI = new System.Windows.Forms.Label();
            this.lblIdentInter = new System.Windows.Forms.Label();
            this.txtTelefoneInter = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.txtIdentInter = new System.Windows.Forms.TextBox();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtNumeroEndereco = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.gbxEscolhePaisEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Location = new System.Drawing.Point(200, 277);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(335, 22);
            this.txtBairro.TabIndex = 11;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(145, 279);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(46, 17);
            this.lblBairro.TabIndex = 4;
            this.lblBairro.Text = "Bairro";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.Location = new System.Drawing.Point(451, 240);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComplemento.MaxLength = 20;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(321, 22);
            this.txtComplemento.TabIndex = 10;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(351, 242);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(94, 17);
            this.lblComplemento.TabIndex = 8;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblNumeroEndereco
            // 
            this.lblNumeroEndereco.AutoSize = true;
            this.lblNumeroEndereco.Location = new System.Drawing.Point(129, 242);
            this.lblNumeroEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroEndereco.Name = "lblNumeroEndereco";
            this.lblNumeroEndereco.Size = new System.Drawing.Size(58, 17);
            this.lblNumeroEndereco.TabIndex = 10;
            this.lblNumeroEndereco.Text = "Número";
            // 
            // txtRua
            // 
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRua.Location = new System.Drawing.Point(200, 197);
            this.txtRua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRua.MaxLength = 50;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(571, 22);
            this.txtRua.TabIndex = 8;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(145, 199);
            this.lblRua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(34, 17);
            this.lblRua.TabIndex = 12;
            this.lblRua.Text = "Rua";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFornecedor.Location = new System.Drawing.Point(200, 11);
            this.txtNomeFornecedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeFornecedor.MaxLength = 100;
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(571, 22);
            this.txtNomeFornecedor.TabIndex = 1;
            this.txtNomeFornecedor.TextChanged += new System.EventHandler(this.txtNomeFornecedor_TextChanged);
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.AutoSize = true;
            this.lblNomeFornecedor.Location = new System.Drawing.Point(145, 14);
            this.lblNomeFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(45, 17);
            this.lblNomeFornecedor.TabIndex = 14;
            this.lblNomeFornecedor.Text = "Nome";
            // 
            // lblcnpj
            // 
            this.lblcnpj.AutoSize = true;
            this.lblcnpj.Location = new System.Drawing.Point(147, 316);
            this.lblcnpj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcnpj.Name = "lblcnpj";
            this.lblcnpj.Size = new System.Drawing.Size(43, 17);
            this.lblcnpj.TabIndex = 2;
            this.lblcnpj.Text = "CNPJ";
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(9, 158);
            this.btnVolta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(53, 43);
            this.btnVolta.TabIndex = 22;
            this.toolTipLegenda.SetToolTip(this.btnVolta, "Fechar");
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlimpar.BackgroundImage")));
            this.btnlimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpar.Location = new System.Drawing.Point(9, 57);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(53, 43);
            this.btnlimpar.TabIndex = 20;
            this.toolTipLegenda.SetToolTip(this.btnlimpar, "Limpar");
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(536, 316);
            this.lblDDD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(38, 17);
            this.lblDDD.TabIndex = 19;
            this.lblDDD.Text = "DDD";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(621, 316);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(64, 17);
            this.lblTelefone.TabIndex = 21;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(200, 353);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(573, 22);
            this.txtEmail.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(145, 362);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Email";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Location = new System.Drawing.Point(696, 314);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefone.Mask = "0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(77, 22);
            this.txtTelefone.TabIndex = 16;
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // btnInsere
            // 
            this.btnInsere.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnInsere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsere.Location = new System.Drawing.Point(9, 6);
            this.btnInsere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(53, 43);
            this.btnInsere.TabIndex = 19;
            this.toolTipLegenda.SetToolTip(this.btnInsere, "Salvar");
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Click += new System.EventHandler(this.btnInsere_Click);
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(9, 107);
            this.btnBuscaAlteracaoDelecao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(53, 43);
            this.btnBuscaAlteracaoDelecao.TabIndex = 21;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            this.btnBuscaAlteracaoDelecao.Click += new System.EventHandler(this.btnBuscaAlteracaoDelecao_Click);
            // 
            // btnRelacionarDepto
            // 
            this.btnRelacionarDepto.BackgroundImage = global::TCC.resImg.btnFornecedorDepto;
            this.btnRelacionarDepto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelacionarDepto.Location = new System.Drawing.Point(720, 395);
            this.btnRelacionarDepto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRelacionarDepto.Name = "btnRelacionarDepto";
            this.btnRelacionarDepto.Size = new System.Drawing.Size(53, 43);
            this.btnRelacionarDepto.TabIndex = 18;
            this.toolTipLegenda.SetToolTip(this.btnRelacionarDepto, "Relacionar Departamento");
            this.btnRelacionarDepto.UseVisualStyleBackColor = true;
            this.btnRelacionarDepto.Click += new System.EventHandler(this.btnRelacionarDepto_Click);
            // 
            // txtCnpj
            // 
            this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnpj.Location = new System.Drawing.Point(200, 314);
            this.txtCnpj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCnpj.Mask = "00,000,000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(146, 22);
            this.txtCnpj.TabIndex = 13;
            this.txtCnpj.ValidatingType = typeof(int);
            // 
            // txtDDD
            // 
            this.txtDDD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDDD.Location = new System.Drawing.Point(576, 314);
            this.txtDDD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDDD.MaxLength = 2;
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(46, 22);
            this.txtDDD.TabIndex = 15;
            this.txtDDD.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 416);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 400);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
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
            this.gbxEscolhePaisEstado.Location = new System.Drawing.Point(133, 43);
            this.gbxEscolhePaisEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxEscolhePaisEstado.Name = "gbxEscolhePaisEstado";
            this.gbxEscolhePaisEstado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxEscolhePaisEstado.Size = new System.Drawing.Size(639, 137);
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
            this.txtEstado.Location = new System.Drawing.Point(423, 71);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEstado.MaxLength = 50;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(202, 22);
            this.txtEstado.TabIndex = 6;
            // 
            // txtPais
            // 
            this.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPais.Location = new System.Drawing.Point(84, 69);
            this.txtPais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPais.MaxLength = 50;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(254, 22);
            this.txtPais.TabIndex = 5;
            // 
            // rdbOutros
            // 
            this.rdbOutros.AutoSize = true;
            this.rdbOutros.Location = new System.Drawing.Point(55, 41);
            this.rdbOutros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbOutros.Name = "rdbOutros";
            this.rdbOutros.Size = new System.Drawing.Size(72, 21);
            this.rdbOutros.TabIndex = 3;
            this.rdbOutros.Text = "Outros";
            this.rdbOutros.UseVisualStyleBackColor = true;
            this.rdbOutros.CheckedChanged += new System.EventHandler(this.rdbOutros_CheckedChanged);
            // 
            // rdbBrasil
            // 
            this.rdbBrasil.AutoSize = true;
            this.rdbBrasil.Checked = true;
            this.rdbBrasil.Location = new System.Drawing.Point(55, 15);
            this.rdbBrasil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbBrasil.Name = "rdbBrasil";
            this.rdbBrasil.Size = new System.Drawing.Size(64, 21);
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
            this.cboEstado.Location = new System.Drawing.Point(173, 14);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(85, 24);
            this.cboEstado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Província";
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
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Location = new System.Drawing.Point(84, 103);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(541, 22);
            this.txtCidade.TabIndex = 7;
            // 
            // txtDDI
            // 
            this.txtDDI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDDI.Location = new System.Drawing.Point(489, 314);
            this.txtDDI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDDI.MaxLength = 2;
            this.txtDDI.Name = "txtDDI";
            this.txtDDI.Size = new System.Drawing.Size(46, 22);
            this.txtDDI.TabIndex = 14;
            this.txtDDI.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // lblDDI
            // 
            this.lblDDI.AutoSize = true;
            this.lblDDI.Location = new System.Drawing.Point(451, 316);
            this.lblDDI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDDI.Name = "lblDDI";
            this.lblDDI.Size = new System.Drawing.Size(31, 17);
            this.lblDDI.TabIndex = 38;
            this.lblDDI.Text = "DDI";
            // 
            // lblIdentInter
            // 
            this.lblIdentInter.AutoSize = true;
            this.lblIdentInter.Location = new System.Drawing.Point(129, 322);
            this.lblIdentInter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentInter.Name = "lblIdentInter";
            this.lblIdentInter.Size = new System.Drawing.Size(155, 17);
            this.lblIdentInter.TabIndex = 39;
            this.lblIdentInter.Text = "Código de Identificação";
            // 
            // txtTelefoneInter
            // 
            this.txtTelefoneInter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefoneInter.Location = new System.Drawing.Point(685, 314);
            this.txtTelefoneInter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefoneInter.MaxLength = 10;
            this.txtTelefoneInter.Name = "txtTelefoneInter";
            this.txtTelefoneInter.Size = new System.Drawing.Size(87, 22);
            this.txtTelefoneInter.TabIndex = 16;
            this.txtTelefoneInter.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // txtIdentInter
            // 
            this.txtIdentInter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdentInter.Location = new System.Drawing.Point(305, 314);
            this.txtIdentInter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdentInter.MaxLength = 50;
            this.txtIdentInter.Name = "txtIdentInter";
            this.txtIdentInter.Size = new System.Drawing.Size(133, 22);
            this.txtIdentInter.TabIndex = 13;
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(545, 279);
            this.lblCodPostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(95, 17);
            this.lblCodPostal.TabIndex = 44;
            this.lblCodPostal.Text = "Código Postal";
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodPostal.Location = new System.Drawing.Point(641, 277);
            this.txtCodPostal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodPostal.MaxLength = 20;
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(131, 22);
            this.txtCodPostal.TabIndex = 12;
            // 
            // txtCep
            // 
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Location = new System.Drawing.Point(696, 277);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(77, 22);
            this.txtCep.TabIndex = 12;
            this.txtCep.ValidatingType = typeof(int);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(644, 281);
            this.lblCep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(35, 17);
            this.lblCep.TabIndex = 12;
            this.lblCep.Text = "CEP";
            // 
            // txtNumeroEndereco
            // 
            this.txtNumeroEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroEndereco.Location = new System.Drawing.Point(200, 239);
            this.txtNumeroEndereco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroEndereco.MaxLength = 5;
            this.txtNumeroEndereco.Name = "txtNumeroEndereco";
            this.txtNumeroEndereco.Size = new System.Drawing.Size(133, 22);
            this.txtNumeroEndereco.TabIndex = 9;
            this.txtNumeroEndereco.TipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            // 
            // frmCadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 487);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private Controles.MegaTextBox.MegaTextBox txtDDD;
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
        private Controles.MegaTextBox.MegaTextBox txtDDI;
        private System.Windows.Forms.Label lblDDI;
        private System.Windows.Forms.Label lblIdentInter;
        private Controles.MegaTextBox.MegaTextBox txtTelefoneInter;
        private System.Windows.Forms.TextBox txtIdentInter;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label lblCep;
        private Controles.MegaTextBox.MegaTextBox txtNumeroEndereco;
    }
}