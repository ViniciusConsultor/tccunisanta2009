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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadFornecedor));
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtNumeroEndereco = new System.Windows.Forms.TextBox();
            this.lblNumeroEndereco = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.lblNomeFornecedor = new System.Windows.Forms.Label();
            this.cboUf = new System.Windows.Forms.ComboBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblcnpj = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.btnInsere = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.txtCep2 = new System.Windows.Forms.TextBox();
            this.txtDDD = new System.Windows.Forms.TextBox();
            this.lblDDD = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Location = new System.Drawing.Point(188, 166);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 9;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(142, 169);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 2;
            this.lblCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Location = new System.Drawing.Point(188, 114);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(200, 20);
            this.txtBairro.TabIndex = 4;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(148, 117);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 4;
            this.lblBairro.Text = "Bairro";
            // 
            // txtCep
            // 
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Location = new System.Drawing.Point(188, 140);
            this.txtCep.MaxLength = 5;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(60, 20);
            this.txtCep.TabIndex = 6;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(154, 143);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 6;
            this.lblCep.Text = "CEP";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.Location = new System.Drawing.Point(471, 117);
            this.txtComplemento.MaxLength = 20;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(100, 20);
            this.txtComplemento.TabIndex = 5;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(394, 120);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 8;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtNumeroEndereco
            // 
            this.txtNumeroEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroEndereco.Location = new System.Drawing.Point(471, 88);
            this.txtNumeroEndereco.MaxLength = 10;
            this.txtNumeroEndereco.Name = "txtNumeroEndereco";
            this.txtNumeroEndereco.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroEndereco.TabIndex = 3;
            // 
            // lblNumeroEndereco
            // 
            this.lblNumeroEndereco.AutoSize = true;
            this.lblNumeroEndereco.Location = new System.Drawing.Point(415, 91);
            this.lblNumeroEndereco.Name = "lblNumeroEndereco";
            this.lblNumeroEndereco.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroEndereco.TabIndex = 10;
            this.lblNumeroEndereco.Text = "Numero";
            // 
            // txtRua
            // 
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRua.Location = new System.Drawing.Point(188, 88);
            this.txtRua.MaxLength = 50;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(200, 20);
            this.txtRua.TabIndex = 2;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(155, 91);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 13);
            this.lblRua.TabIndex = 12;
            this.lblRua.Text = "Rua";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFornecedor.Location = new System.Drawing.Point(396, 31);
            this.txtNomeFornecedor.MaxLength = 100;
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(174, 20);
            this.txtNomeFornecedor.TabIndex = 1;
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.AutoSize = true;
            this.lblNomeFornecedor.Location = new System.Drawing.Point(295, 34);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(92, 13);
            this.lblNomeFornecedor.TabIndex = 14;
            this.lblNomeFornecedor.Text = "Nome Fornecedor";
            // 
            // cboUf
            // 
            this.cboUf.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cboUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboUf.Location = new System.Drawing.Point(471, 143);
            this.cboUf.Name = "cboUf";
            this.cboUf.Size = new System.Drawing.Size(100, 21);
            this.cboUf.TabIndex = 8;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(425, 147);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 17;
            this.lblestado.Text = "Estado";
            // 
            // lblcnpj
            // 
            this.lblcnpj.AutoSize = true;
            this.lblcnpj.Location = new System.Drawing.Point(425, 173);
            this.lblcnpj.Name = "lblcnpj";
            this.lblcnpj.Size = new System.Drawing.Size(34, 13);
            this.lblcnpj.TabIndex = 2;
            this.lblcnpj.Text = "CNPJ";
            // 
            // txtCnpj
            // 
            this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnpj.Location = new System.Drawing.Point(471, 170);
            this.txtCnpj.MaxLength = 15;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(100, 20);
            this.txtCnpj.TabIndex = 10;
            // 
            // btnInsere
            // 
            this.btnInsere.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsere.BackgroundImage")));
            this.btnInsere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsere.Location = new System.Drawing.Point(5, 73);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(42, 31);
            this.btnInsere.TabIndex = 11;
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Click += new System.EventHandler(this.btnInsere_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolta.BackgroundImage")));
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(5, 2);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(42, 35);
            this.btnVolta.TabIndex = 13;
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(5, 39);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(42, 28);
            this.btnlimpar.TabIndex = 12;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // txtCep2
            // 
            this.txtCep2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep2.Location = new System.Drawing.Point(254, 140);
            this.txtCep2.MaxLength = 3;
            this.txtCep2.Name = "txtCep2";
            this.txtCep2.Size = new System.Drawing.Size(34, 20);
            this.txtCep2.TabIndex = 7;
            this.txtCep2.TextChanged += new System.EventHandler(this.txtCep2_TextChanged);
            // 
            // txtDDD
            // 
            this.txtDDD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDDD.Location = new System.Drawing.Point(187, 57);
            this.txtDDD.MaxLength = 50;
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(36, 20);
            this.txtDDD.TabIndex = 18;
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(154, 60);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(31, 13);
            this.lblDDD.TabIndex = 19;
            this.lblDDD.Text = "DDD";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Location = new System.Drawing.Point(284, 57);
            this.txtTelefone.MaxLength = 50;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(101, 20);
            this.txtTelefone.TabIndex = 20;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(229, 60);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 21;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(469, 57);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(101, 20);
            this.txtEmail.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(431, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Email";
            // 
            // frmCadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 227);
            this.ControlBox = false;
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.lblDDD);
            this.Controls.Add(this.txtCep2);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnInsere);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.cboUf);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.lblNomeFornecedor);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.txtNumeroEndereco);
            this.Controls.Add(this.lblNumeroEndereco);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.lblcnpj);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.MaximizeBox = false;
            this.Name = "frmCadFornecedor";
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.frmCadFornecedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtNumeroEndereco;
        private System.Windows.Forms.Label lblNumeroEndereco;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Label lblNomeFornecedor;
        private System.Windows.Forms.ComboBox cboUf;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblcnpj;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Button btnInsere;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.TextBox txtCep2;
        private System.Windows.Forms.TextBox txtDDD;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}