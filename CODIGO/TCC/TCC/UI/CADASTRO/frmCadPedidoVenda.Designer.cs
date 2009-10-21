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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadPedidoVenda));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.txtCdPedidoVenda = new System.Windows.Forms.TextBox();
            this.lblCdPedidoVenda = new System.Windows.Forms.Label();
            this.txtCdVendaMotor = new System.Windows.Forms.TextBox();
            this.lblCdVendaMotor = new System.Windows.Forms.Label();
            this.txtCdDepartamento = new System.Windows.Forms.TextBox();
            this.lblCdDepartamento = new System.Windows.Forms.Label();
            this.txtDsPedido = new System.Windows.Forms.TextBox();
            this.lblDsPedido = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(1, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(32, 27);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(1, 32);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(32, 23);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceitar.BackgroundImage")));
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(1, 61);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(32, 23);
            this.btnAceitar.TabIndex = 17;
            this.btnAceitar.UseVisualStyleBackColor = true;
            // 
            // txtCdPedidoVenda
            // 
            this.txtCdPedidoVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdPedidoVenda.Location = new System.Drawing.Point(267, 20);
            this.txtCdPedidoVenda.Name = "txtCdPedidoVenda";
            this.txtCdPedidoVenda.ReadOnly = true;
            this.txtCdPedidoVenda.Size = new System.Drawing.Size(92, 20);
            this.txtCdPedidoVenda.TabIndex = 20;
            // 
            // lblCdPedidoVenda
            // 
            this.lblCdPedidoVenda.AutoSize = true;
            this.lblCdPedidoVenda.Location = new System.Drawing.Point(82, 22);
            this.lblCdPedidoVenda.Name = "lblCdPedidoVenda";
            this.lblCdPedidoVenda.Size = new System.Drawing.Size(140, 13);
            this.lblCdPedidoVenda.TabIndex = 21;
            this.lblCdPedidoVenda.Text = "Codigo do Pedido de Venda";
            // 
            // txtCdVendaMotor
            // 
            this.txtCdVendaMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdVendaMotor.Location = new System.Drawing.Point(267, 57);
            this.txtCdVendaMotor.Name = "txtCdVendaMotor";
            this.txtCdVendaMotor.Size = new System.Drawing.Size(56, 20);
            this.txtCdVendaMotor.TabIndex = 20;
            // 
            // lblCdVendaMotor
            // 
            this.lblCdVendaMotor.AutoSize = true;
            this.lblCdVendaMotor.Location = new System.Drawing.Point(82, 57);
            this.lblCdVendaMotor.Name = "lblCdVendaMotor";
            this.lblCdVendaMotor.Size = new System.Drawing.Size(134, 13);
            this.lblCdVendaMotor.TabIndex = 21;
            this.lblCdVendaMotor.Text = "Codigo de Venda do Motor";
            // 
            // txtCdDepartamento
            // 
            this.txtCdDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdDepartamento.Location = new System.Drawing.Point(265, 92);
            this.txtCdDepartamento.Name = "txtCdDepartamento";
            this.txtCdDepartamento.Size = new System.Drawing.Size(56, 20);
            this.txtCdDepartamento.TabIndex = 20;
            // 
            // lblCdDepartamento
            // 
            this.lblCdDepartamento.AutoSize = true;
            this.lblCdDepartamento.Location = new System.Drawing.Point(80, 91);
            this.lblCdDepartamento.Name = "lblCdDepartamento";
            this.lblCdDepartamento.Size = new System.Drawing.Size(125, 13);
            this.lblCdDepartamento.TabIndex = 21;
            this.lblCdDepartamento.Text = "Codigo do Departamento";
            // 
            // txtDsPedido
            // 
            this.txtDsPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDsPedido.Location = new System.Drawing.Point(75, 136);
            this.txtDsPedido.Name = "txtDsPedido";
            this.txtDsPedido.Size = new System.Drawing.Size(274, 20);
            this.txtDsPedido.TabIndex = 20;
            // 
            // lblDsPedido
            // 
            this.lblDsPedido.AutoSize = true;
            this.lblDsPedido.Location = new System.Drawing.Point(72, 120);
            this.lblDsPedido.Name = "lblDsPedido";
            this.lblDsPedido.Size = new System.Drawing.Size(103, 13);
            this.lblDsPedido.TabIndex = 21;
            this.lblDsPedido.Text = "Descriçãodo Pedido";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(329, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(327, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmCadPedidoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(398, 191);
            this.ControlBox = false;
            this.Controls.Add(this.lblDsPedido);
            this.Controls.Add(this.txtDsPedido);
            this.Controls.Add(this.lblCdDepartamento);
            this.Controls.Add(this.txtCdDepartamento);
            this.Controls.Add(this.lblCdVendaMotor);
            this.Controls.Add(this.txtCdVendaMotor);
            this.Controls.Add(this.lblCdPedidoVenda);
            this.Controls.Add(this.txtCdPedidoVenda);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.TextBox txtCdPedidoVenda;
        private System.Windows.Forms.Label lblCdPedidoVenda;
        private System.Windows.Forms.TextBox txtCdVendaMotor;
        private System.Windows.Forms.Label lblCdVendaMotor;
        private System.Windows.Forms.TextBox txtCdDepartamento;
        private System.Windows.Forms.Label lblCdDepartamento;
        private System.Windows.Forms.TextBox txtDsPedido;
        private System.Windows.Forms.Label lblDsPedido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}