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
            this.lblCodigoFornecedor = new System.Windows.Forms.Label();
            this.txtCodigoFornecedor = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // lblCodigoFornecedor
            // 
            this.lblCodigoFornecedor.AutoSize = true;
            this.lblCodigoFornecedor.Location = new System.Drawing.Point(84, 34);
            this.lblCodigoFornecedor.Name = "lblCodigoFornecedor";
            this.lblCodigoFornecedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCodigoFornecedor.Size = new System.Drawing.Size(97, 13);
            this.lblCodigoFornecedor.TabIndex = 0;
            this.lblCodigoFornecedor.Text = "Codigo Fornecedor";
            this.lblCodigoFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtCodigoFornecedor
            // 
            this.txtCodigoFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoFornecedor.Enabled = false;
            this.txtCodigoFornecedor.Location = new System.Drawing.Point(188, 31);
            this.txtCodigoFornecedor.Name = "txtCodigoFornecedor";
            this.txtCodigoFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoFornecedor.TabIndex = 0;
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Location = new System.Drawing.Point(187, 135);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 9;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(141, 138);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 2;
            this.lblCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Location = new System.Drawing.Point(187, 83);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(200, 20);
            this.txtBairro.TabIndex = 4;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(147, 86);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 4;
            this.lblBairro.Text = "Bairro";
            // 
            // txtCep
            // 
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Location = new System.Drawing.Point(187, 109);
            this.txtCep.MaxLength = 5;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(60, 20);
            this.txtCep.TabIndex = 6;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(153, 112);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 6;
            this.lblCep.Text = "CEP";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.Location = new System.Drawing.Point(470, 86);
            this.txtComplemento.MaxLength = 20;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(100, 20);
            this.txtComplemento.TabIndex = 5;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(393, 89);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 8;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtNumeroEndereco
            // 
            this.txtNumeroEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroEndereco.Location = new System.Drawing.Point(470, 57);
            this.txtNumeroEndereco.MaxLength = 10;
            this.txtNumeroEndereco.Name = "txtNumeroEndereco";
            this.txtNumeroEndereco.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroEndereco.TabIndex = 3;
            // 
            // lblNumeroEndereco
            // 
            this.lblNumeroEndereco.AutoSize = true;
            this.lblNumeroEndereco.Location = new System.Drawing.Point(414, 60);
            this.lblNumeroEndereco.Name = "lblNumeroEndereco";
            this.lblNumeroEndereco.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroEndereco.TabIndex = 10;
            this.lblNumeroEndereco.Text = "Numero";
            // 
            // txtRua
            // 
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRua.Location = new System.Drawing.Point(187, 57);
            this.txtRua.MaxLength = 50;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(200, 20);
            this.txtRua.TabIndex = 2;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(154, 60);
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
            this.cboUf.Location = new System.Drawing.Point(470, 112);
            this.cboUf.Name = "cboUf";
            this.cboUf.Size = new System.Drawing.Size(100, 21);
            this.cboUf.TabIndex = 8;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(424, 116);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 17;
            this.lblestado.Text = "Estado";
            // 
            // lblcnpj
            // 
            this.lblcnpj.AutoSize = true;
            this.lblcnpj.Location = new System.Drawing.Point(424, 142);
            this.lblcnpj.Name = "lblcnpj";
            this.lblcnpj.Size = new System.Drawing.Size(34, 13);
            this.lblcnpj.TabIndex = 2;
            this.lblcnpj.Text = "CNPJ";
            // 
            // txtCnpj
            // 
            this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnpj.Location = new System.Drawing.Point(470, 139);
            this.txtCnpj.MaxLength = 15;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(100, 20);
            this.txtCnpj.TabIndex = 10;
            // 
            // btnInsere
            // 
            this.btnInsere.Location = new System.Drawing.Point(333, 169);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(75, 23);
            this.btnInsere.TabIndex = 11;
            this.btnInsere.Text = "Confirmar";
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Click += new System.EventHandler(this.btnInsere_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolta.BackgroundImage")));
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(5, 2);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(42, 26);
            this.btnVolta.TabIndex = 13;
            this.btnVolta.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(414, 169);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 12;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // txtCep2
            // 
            this.txtCep2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep2.Location = new System.Drawing.Point(253, 109);
            this.txtCep2.MaxLength = 3;
            this.txtCep2.Name = "txtCep2";
            this.txtCep2.Size = new System.Drawing.Size(34, 20);
            this.txtCep2.TabIndex = 7;
            this.txtCep2.TextChanged += new System.EventHandler(this.txtCep2_TextChanged);
            // 
            // frmCadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 227);
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
            this.Controls.Add(this.txtCodigoFornecedor);
            this.Controls.Add(this.lblCodigoFornecedor);
            this.Name = "frmCadFornecedor";
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.frmCadFornecedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoFornecedor;
        private System.Windows.Forms.TextBox txtCodigoFornecedor;
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
    }
}