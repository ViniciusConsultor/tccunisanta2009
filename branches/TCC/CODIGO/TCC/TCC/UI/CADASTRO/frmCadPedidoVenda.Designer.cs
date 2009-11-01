namespace TCC.UI
{
    partial class frmCadPedidoVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadPedidoVenda));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.txtCdDepartamento = new System.Windows.Forms.TextBox();
            this.lblNmDepartamento = new System.Windows.Forms.Label();
            this.txtDsPedido = new System.Windows.Forms.TextBox();
            this.lblDsPedido = new System.Windows.Forms.Label();
            this.btnBuscaDepartamento = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscaPeca = new System.Windows.Forms.Button();
            this.lblCodMotor = new System.Windows.Forms.Label();
            this.txtCodigoPeca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCodKit = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(2, 62);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar / Voltar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::TCC.Properties.Resources.trash_can;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(2, 33);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 6;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceitar.BackgroundImage")));
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(2, 4);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(27, 23);
            this.btnAceitar.TabIndex = 7;
            this.toolTipLegenda.SetToolTip(this.btnAceitar, "OK");
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // txtCdDepartamento
            // 
            this.txtCdDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdDepartamento.Location = new System.Drawing.Point(191, 20);
            this.txtCdDepartamento.Name = "txtCdDepartamento";
            this.txtCdDepartamento.ReadOnly = true;
            this.txtCdDepartamento.Size = new System.Drawing.Size(65, 20);
            this.txtCdDepartamento.TabIndex = 20;
            // 
            // lblNmDepartamento
            // 
            this.lblNmDepartamento.AutoSize = true;
            this.lblNmDepartamento.Location = new System.Drawing.Point(60, 22);
            this.lblNmDepartamento.Name = "lblNmDepartamento";
            this.lblNmDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblNmDepartamento.TabIndex = 21;
            this.lblNmDepartamento.Text = "Departamento";
            // 
            // txtDsPedido
            // 
            this.txtDsPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDsPedido.Location = new System.Drawing.Point(58, 116);
            this.txtDsPedido.MaxLength = 500;
            this.txtDsPedido.Multiline = true;
            this.txtDsPedido.Name = "txtDsPedido";
            this.txtDsPedido.Size = new System.Drawing.Size(253, 72);
            this.txtDsPedido.TabIndex = 4;
            // 
            // lblDsPedido
            // 
            this.lblDsPedido.AutoSize = true;
            this.lblDsPedido.Location = new System.Drawing.Point(55, 100);
            this.lblDsPedido.Name = "lblDsPedido";
            this.lblDsPedido.Size = new System.Drawing.Size(103, 13);
            this.lblDsPedido.TabIndex = 21;
            this.lblDsPedido.Text = "Descriçãodo Pedido";
            // 
            // btnBuscaDepartamento
            // 
            this.btnBuscaDepartamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaDepartamento.BackgroundImage")));
            this.btnBuscaDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaDepartamento.Location = new System.Drawing.Point(262, 20);
            this.btnBuscaDepartamento.Name = "btnBuscaDepartamento";
            this.btnBuscaDepartamento.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaDepartamento.TabIndex = 1;
            this.toolTipLegenda.SetToolTip(this.btnBuscaDepartamento, "Busca Departamento");
            this.btnBuscaDepartamento.UseVisualStyleBackColor = true;
            this.btnBuscaDepartamento.Click += new System.EventHandler(this.btnBuscaDepartamento_Click);
            // 
            // btnBuscaPeca
            // 
            this.btnBuscaPeca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaPeca.BackgroundImage")));
            this.btnBuscaPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaPeca.Location = new System.Drawing.Point(261, 48);
            this.btnBuscaPeca.Name = "btnBuscaPeca";
            this.btnBuscaPeca.Size = new System.Drawing.Size(28, 23);
            this.btnBuscaPeca.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnBuscaPeca, "Buscar Peça");
            this.btnBuscaPeca.UseVisualStyleBackColor = true;
            // 
            // lblCodMotor
            // 
            this.lblCodMotor.AutoSize = true;
            this.lblCodMotor.Location = new System.Drawing.Point(60, 52);
            this.lblCodMotor.Name = "lblCodMotor";
            this.lblCodMotor.Size = new System.Drawing.Size(85, 13);
            this.lblCodMotor.TabIndex = 24;
            this.lblCodMotor.Text = "Codigo do Motor";
            // 
            // txtCodigoPeca
            // 
            this.txtCodigoPeca.Location = new System.Drawing.Point(156, 49);
            this.txtCodigoPeca.Name = "txtCodigoPeca";
            this.txtCodigoPeca.ReadOnly = true;
            this.txtCodigoPeca.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPeca.TabIndex = 23;
            this.txtCodigoPeca.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(261, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.button1, "Buscar Peça");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblCodKit
            // 
            this.lblCodKit.AutoSize = true;
            this.lblCodKit.Location = new System.Drawing.Point(60, 78);
            this.lblCodKit.Name = "lblCodKit";
            this.lblCodKit.Size = new System.Drawing.Size(70, 13);
            this.lblCodKit.TabIndex = 27;
            this.lblCodKit.Text = "Codigo do Kit";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.TabStop = false;
            // 
            // frmCadPedidoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 218);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCodKit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBuscaPeca);
            this.Controls.Add(this.lblCodMotor);
            this.Controls.Add(this.txtCodigoPeca);
            this.Controls.Add(this.lblDsPedido);
            this.Controls.Add(this.txtDsPedido);
            this.Controls.Add(this.lblNmDepartamento);
            this.Controls.Add(this.txtCdDepartamento);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBuscaDepartamento);
            this.Controls.Add(this.btnAceitar);
            this.MaximizeBox = false;
            this.Name = "frmCadPedidoVenda";
            this.Text = "Pedido de Venda";
            this.Load += new System.EventHandler(this.frmCadPedidoVenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.TextBox txtCdDepartamento;
        private System.Windows.Forms.Label lblNmDepartamento;
        private System.Windows.Forms.TextBox txtDsPedido;
        private System.Windows.Forms.Label lblDsPedido;
        private System.Windows.Forms.Button btnBuscaDepartamento;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnBuscaPeca;
        private System.Windows.Forms.Label lblCodMotor;
        private System.Windows.Forms.TextBox txtCodigoPeca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCodKit;
        private System.Windows.Forms.TextBox textBox1;
    }
}