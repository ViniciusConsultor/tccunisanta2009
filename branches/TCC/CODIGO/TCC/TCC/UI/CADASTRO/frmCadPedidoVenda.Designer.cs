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
            this.txtCdVendaMotor = new System.Windows.Forms.TextBox();
            this.lblCdVendaMotor = new System.Windows.Forms.Label();
            this.txtCdDepartamento = new System.Windows.Forms.TextBox();
            this.lblCdDepartamento = new System.Windows.Forms.Label();
            this.txtDsPedido = new System.Windows.Forms.TextBox();
            this.lblDsPedido = new System.Windows.Forms.Label();
            this.btnBuscaVendaMotor = new System.Windows.Forms.Button();
            this.btnBuscaDepartamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(2, 62);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 19;
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
            this.btnLimpar.TabIndex = 18;
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
            this.btnAceitar.TabIndex = 17;
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // txtCdVendaMotor
            // 
            this.txtCdVendaMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdVendaMotor.Location = new System.Drawing.Point(206, 30);
            this.txtCdVendaMotor.Name = "txtCdVendaMotor";
            this.txtCdVendaMotor.ReadOnly = true;
            this.txtCdVendaMotor.Size = new System.Drawing.Size(56, 20);
            this.txtCdVendaMotor.TabIndex = 20;
            // 
            // lblCdVendaMotor
            // 
            this.lblCdVendaMotor.AutoSize = true;
            this.lblCdVendaMotor.Location = new System.Drawing.Point(66, 32);
            this.lblCdVendaMotor.Name = "lblCdVendaMotor";
            this.lblCdVendaMotor.Size = new System.Drawing.Size(134, 13);
            this.lblCdVendaMotor.TabIndex = 21;
            this.lblCdVendaMotor.Text = "Codigo de Venda do Motor";
            // 
            // txtCdDepartamento
            // 
            this.txtCdDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdDepartamento.Location = new System.Drawing.Point(197, 56);
            this.txtCdDepartamento.Name = "txtCdDepartamento";
            this.txtCdDepartamento.ReadOnly = true;
            this.txtCdDepartamento.Size = new System.Drawing.Size(65, 20);
            this.txtCdDepartamento.TabIndex = 20;
            // 
            // lblCdDepartamento
            // 
            this.lblCdDepartamento.AutoSize = true;
            this.lblCdDepartamento.Location = new System.Drawing.Point(66, 58);
            this.lblCdDepartamento.Name = "lblCdDepartamento";
            this.lblCdDepartamento.Size = new System.Drawing.Size(125, 13);
            this.lblCdDepartamento.TabIndex = 21;
            this.lblCdDepartamento.Text = "Codigo do Departamento";
            // 
            // txtDsPedido
            // 
            this.txtDsPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDsPedido.Location = new System.Drawing.Point(69, 103);
            this.txtDsPedido.Multiline = true;
            this.txtDsPedido.Name = "txtDsPedido";
            this.txtDsPedido.Size = new System.Drawing.Size(253, 72);
            this.txtDsPedido.TabIndex = 20;
            // 
            // lblDsPedido
            // 
            this.lblDsPedido.AutoSize = true;
            this.lblDsPedido.Location = new System.Drawing.Point(66, 87);
            this.lblDsPedido.Name = "lblDsPedido";
            this.lblDsPedido.Size = new System.Drawing.Size(103, 13);
            this.lblDsPedido.TabIndex = 21;
            this.lblDsPedido.Text = "Descriçãodo Pedido";
            // 
            // btnBuscaVendaMotor
            // 
            this.btnBuscaVendaMotor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaVendaMotor.BackgroundImage")));
            this.btnBuscaVendaMotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaVendaMotor.Location = new System.Drawing.Point(268, 30);
            this.btnBuscaVendaMotor.Name = "btnBuscaVendaMotor";
            this.btnBuscaVendaMotor.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaVendaMotor.TabIndex = 17;
            this.btnBuscaVendaMotor.UseVisualStyleBackColor = true;
            this.btnBuscaVendaMotor.Click += new System.EventHandler(this.btnBuscaVendaMotor_Click);
            // 
            // btnBuscaDepartamento
            // 
            this.btnBuscaDepartamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaDepartamento.BackgroundImage")));
            this.btnBuscaDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaDepartamento.Location = new System.Drawing.Point(268, 56);
            this.btnBuscaDepartamento.Name = "btnBuscaDepartamento";
            this.btnBuscaDepartamento.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaDepartamento.TabIndex = 17;
            this.btnBuscaDepartamento.UseVisualStyleBackColor = true;
            this.btnBuscaDepartamento.Click += new System.EventHandler(this.btnBuscaDepartamento_Click);
            // 
            // frmCadPedidoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 218);
            this.ControlBox = false;
            this.Controls.Add(this.lblDsPedido);
            this.Controls.Add(this.txtDsPedido);
            this.Controls.Add(this.lblCdDepartamento);
            this.Controls.Add(this.txtCdDepartamento);
            this.Controls.Add(this.lblCdVendaMotor);
            this.Controls.Add(this.txtCdVendaMotor);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBuscaDepartamento);
            this.Controls.Add(this.btnBuscaVendaMotor);
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
        private System.Windows.Forms.TextBox txtCdVendaMotor;
        private System.Windows.Forms.Label lblCdVendaMotor;
        private System.Windows.Forms.TextBox txtCdDepartamento;
        private System.Windows.Forms.Label lblCdDepartamento;
        private System.Windows.Forms.TextBox txtDsPedido;
        private System.Windows.Forms.Label lblDsPedido;
        private System.Windows.Forms.Button btnBuscaVendaMotor;
        private System.Windows.Forms.Button btnBuscaDepartamento;
    }
}