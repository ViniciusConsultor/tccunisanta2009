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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadColaborador));
            this.lblCdUsuario = new System.Windows.Forms.Label();
            this.lblCdDepart = new System.Windows.Forms.Label();
            this.lblNmColaborador = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.lblNmRua = new System.Windows.Forms.Label();
            this.lblNumeroEnd = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCdUsuario = new System.Windows.Forms.TextBox();
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
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnApaga = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnBuscaUsuario = new System.Windows.Forms.Button();
            this.btnBuscaDepartamento = new System.Windows.Forms.Button();
            this.lblDDD = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtDDD = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.txtNumero = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCdUsuario
            // 
            this.lblCdUsuario.AutoSize = true;
            this.lblCdUsuario.Location = new System.Drawing.Point(97, 17);
            this.lblCdUsuario.Name = "lblCdUsuario";
            this.lblCdUsuario.Size = new System.Drawing.Size(79, 13);
            this.lblCdUsuario.TabIndex = 0;
            this.lblCdUsuario.Text = "Codigo Usuario";
            // 
            // lblCdDepart
            // 
            this.lblCdDepart.AutoSize = true;
            this.lblCdDepart.Location = new System.Drawing.Point(351, 17);
            this.lblCdDepart.Name = "lblCdDepart";
            this.lblCdDepart.Size = new System.Drawing.Size(110, 13);
            this.lblCdDepart.TabIndex = 0;
            this.lblCdDepart.Text = "Codigo Departamento";
            // 
            // lblNmColaborador
            // 
            this.lblNmColaborador.AutoSize = true;
            this.lblNmColaborador.Location = new System.Drawing.Point(97, 56);
            this.lblNmColaborador.Name = "lblNmColaborador";
            this.lblNmColaborador.Size = new System.Drawing.Size(38, 13);
            this.lblNmColaborador.TabIndex = 0;
            this.lblNmColaborador.Text = "Nome ";
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Location = new System.Drawing.Point(97, 91);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(89, 13);
            this.lblDtNasc.TabIndex = 0;
            this.lblDtNasc.Text = "Data Nascimento";
            // 
            // lblNmRua
            // 
            this.lblNmRua.AutoSize = true;
            this.lblNmRua.Location = new System.Drawing.Point(97, 123);
            this.lblNmRua.Name = "lblNmRua";
            this.lblNmRua.Size = new System.Drawing.Size(27, 13);
            this.lblNmRua.TabIndex = 0;
            this.lblNmRua.Text = "Rua";
            // 
            // lblNumeroEnd
            // 
            this.lblNumeroEnd.AutoSize = true;
            this.lblNumeroEnd.Location = new System.Drawing.Point(97, 159);
            this.lblNumeroEnd.Name = "lblNumeroEnd";
            this.lblNumeroEnd.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroEnd.TabIndex = 0;
            this.lblNumeroEnd.Text = "Numero";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(226, 159);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 0;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(442, 196);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 0;
            this.lblCep.Text = "CEP";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(97, 196);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 0;
            this.lblBairro.Text = "Bairro";
            // 
            // txtCdUsuario
            // 
            this.txtCdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdUsuario.Enabled = false;
            this.txtCdUsuario.Location = new System.Drawing.Point(182, 15);
            this.txtCdUsuario.Name = "txtCdUsuario";
            this.txtCdUsuario.ReadOnly = true;
            this.txtCdUsuario.Size = new System.Drawing.Size(50, 20);
            this.txtCdUsuario.TabIndex = 1;
            this.txtCdUsuario.TabStop = false;
            // 
            // txtCdDepartamento
            // 
            this.txtCdDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdDepartamento.Enabled = false;
            this.txtCdDepartamento.Location = new System.Drawing.Point(467, 14);
            this.txtCdDepartamento.Name = "txtCdDepartamento";
            this.txtCdDepartamento.ReadOnly = true;
            this.txtCdDepartamento.Size = new System.Drawing.Size(50, 20);
            this.txtCdDepartamento.TabIndex = 3;
            this.txtCdDepartamento.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(136, 53);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(410, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtRua
            // 
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRua.Location = new System.Drawing.Point(127, 121);
            this.txtRua.MaxLength = 50;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(419, 20);
            this.txtRua.TabIndex = 8;
            // 
            // txtComplemento
            // 
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.Location = new System.Drawing.Point(299, 156);
            this.txtComplemento.MaxLength = 20;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(247, 20);
            this.txtComplemento.TabIndex = 10;
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Location = new System.Drawing.Point(136, 194);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(297, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(97, 235);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 2;
            this.lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Location = new System.Drawing.Point(142, 233);
            this.txtCidade.MaxLength = 40;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(282, 20);
            this.txtCidade.TabIndex = 13;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(430, 236);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(97, 271);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(23, 13);
            this.lblRg.TabIndex = 2;
            this.lblRg.Text = "RG";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(330, 271);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF";
            // 
            // txtRg
            // 
            this.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRg.Location = new System.Drawing.Point(126, 269);
            this.txtRg.MaxLength = 15;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(171, 20);
            this.txtRg.TabIndex = 15;
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.Location = new System.Drawing.Point(359, 271);
            this.txtCpf.MaxLength = 15;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(187, 20);
            this.txtCpf.TabIndex = 16;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(263, 91);
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
            this.CbSexo.Location = new System.Drawing.Point(303, 87);
            this.CbSexo.Name = "CbSexo";
            this.CbSexo.Size = new System.Drawing.Size(47, 21);
            this.CbSexo.TabIndex = 5;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirma.BackgroundImage")));
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(7, 6);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(40, 35);
            this.btnConfirma.TabIndex = 18;
            this.toolTipLegenda.SetToolTip(this.btnConfirma, "Cadastrar");
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(7, 84);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(40, 35);
            this.btnVoltar.TabIndex = 20;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnApaga
            // 
            this.btnApaga.BackgroundImage = global::TCC.Properties.Resources.trash_can;
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
            this.cbEstado.Location = new System.Drawing.Point(476, 233);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(70, 21);
            this.cbEstado.TabIndex = 14;
            // 
            // btnBuscaUsuario
            // 
            this.btnBuscaUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaUsuario.BackgroundImage")));
            this.btnBuscaUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaUsuario.Location = new System.Drawing.Point(238, 14);
            this.btnBuscaUsuario.Name = "btnBuscaUsuario";
            this.btnBuscaUsuario.Size = new System.Drawing.Size(24, 23);
            this.btnBuscaUsuario.TabIndex = 1;
            this.toolTipLegenda.SetToolTip(this.btnBuscaUsuario, "Buscar Usuário");
            this.btnBuscaUsuario.UseVisualStyleBackColor = true;
            this.btnBuscaUsuario.Click += new System.EventHandler(this.btnBuscaUsuario_Click);
            // 
            // btnBuscaDepartamento
            // 
            this.btnBuscaDepartamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaDepartamento.BackgroundImage")));
            this.btnBuscaDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaDepartamento.Location = new System.Drawing.Point(523, 12);
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
            this.lblDDD.Location = new System.Drawing.Point(356, 91);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(31, 13);
            this.lblDDD.TabIndex = 21;
            this.lblDDD.Text = "DDD";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(424, 90);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 23;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(97, 310);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(131, 308);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(415, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(189, 88);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(71, 20);
            this.txtDataNasc.TabIndex = 4;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // txtDDD
            // 
            this.txtDDD.Location = new System.Drawing.Point(390, 88);
            this.txtDDD.MaxLength = 2;
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(28, 20);
            this.txtDDD.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(144, 156);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(76, 20);
            this.txtNumero.TabIndex = 9;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(476, 194);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(70, 20);
            this.txtCep.TabIndex = 12;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Location = new System.Drawing.Point(476, 89);
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
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.Properties.Resources.corel_draw;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(550, 334);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(40, 31);
            this.btnBuscaAlteracaoDelecao.TabIndex = 26;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar Registro");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            this.btnBuscaAlteracaoDelecao.Click += new System.EventHandler(this.btnBuscaAlteracaoDelecao_Click);
            // 
            // frmCadColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 368);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblDDD);
            this.Controls.Add(this.btnBuscaDepartamento);
            this.Controls.Add(this.btnBuscaUsuario);
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
            this.Controls.Add(this.txtCdUsuario);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblNumeroEnd);
            this.Controls.Add(this.lblNmRua);
            this.Controls.Add(this.lblDtNasc);
            this.Controls.Add(this.lblNmColaborador);
            this.Controls.Add(this.lblCdDepart);
            this.Controls.Add(this.lblCdUsuario);
            this.MaximizeBox = false;
            this.Name = "frmCadColaborador";
            this.Text = "Cadastro de Colaborador";
            this.Load += new System.EventHandler(this.frmCadColaborador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCdUsuario;
        private System.Windows.Forms.Label lblCdDepart;
        private System.Windows.Forms.Label lblNmColaborador;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.Label lblNmRua;
        private System.Windows.Forms.Label lblNumeroEnd;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtCdUsuario;
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
        private System.Windows.Forms.Button btnBuscaUsuario;
        private System.Windows.Forms.Button btnBuscaDepartamento;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private Controles.MegaTextBox.MegaTextBox txtDDD;
        private Controles.MegaTextBox.MegaTextBox txtNumero;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
    }
}