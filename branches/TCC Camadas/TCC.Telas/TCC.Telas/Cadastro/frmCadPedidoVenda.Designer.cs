﻿namespace TCC.UI
{
    partial class frmCadPedidoVenda
    {
        /// <summary>
        /// ReqUIred designer variable.
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
        /// ReqUIred method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadPedidoVenda));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCdDepartamento = new System.Windows.Forms.TextBox();
            this.lblNmDepartamento = new System.Windows.Forms.Label();
            this.txtDsPedido = new System.Windows.Forms.TextBox();
            this.lblDsPedido = new System.Windows.Forms.Label();
            this.btnBuscaDepartamento = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscaPeca = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.lblCodMotor = new System.Windows.Forms.Label();
            this.txtCodigoPeca = new System.Windows.Forms.TextBox();
            this.lblCodKit = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::TCC.UI.resImg.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(2, 62);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 7;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(2, 33);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 6;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtCdDepartamento
            // 
            this.txtCdDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdDepartamento.Location = new System.Drawing.Point(139, 20);
            this.txtCdDepartamento.MaxLength = 15;
            this.txtCdDepartamento.Name = "txtCdDepartamento";
            this.txtCdDepartamento.ReadOnly = true;
            this.txtCdDepartamento.Size = new System.Drawing.Size(137, 20);
            this.txtCdDepartamento.TabIndex = 20;
            // 
            // lblNmDepartamento
            // 
            this.lblNmDepartamento.AutoSize = true;
            this.lblNmDepartamento.Location = new System.Drawing.Point(59, 22);
            this.lblNmDepartamento.Name = "lblNmDepartamento";
            this.lblNmDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblNmDepartamento.TabIndex = 21;
            this.lblNmDepartamento.Text = "Departamento";
            // 
            // txtDsPedido
            // 
            this.txtDsPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDsPedido.Location = new System.Drawing.Point(62, 120);
            this.txtDsPedido.MaxLength = 500;
            this.txtDsPedido.Multiline = true;
            this.txtDsPedido.Name = "txtDsPedido";
            this.txtDsPedido.Size = new System.Drawing.Size(247, 72);
            this.txtDsPedido.TabIndex = 4;
            // 
            // lblDsPedido
            // 
            this.lblDsPedido.AutoSize = true;
            this.lblDsPedido.Location = new System.Drawing.Point(59, 104);
            this.lblDsPedido.Name = "lblDsPedido";
            this.lblDsPedido.Size = new System.Drawing.Size(103, 13);
            this.lblDsPedido.TabIndex = 21;
            this.lblDsPedido.Text = "Descriçãodo Pedido";
            // 
            // btnBuscaDepartamento
            // 
            this.btnBuscaDepartamento.BackgroundImage = global::TCC.UI.resImg.btnBusca;
            this.btnBuscaDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaDepartamento.Location = new System.Drawing.Point(282, 20);
            this.btnBuscaDepartamento.Name = "btnBuscaDepartamento";
            this.btnBuscaDepartamento.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaDepartamento.TabIndex = 1;
            this.toolTipLegenda.SetToolTip(this.btnBuscaDepartamento, "Busca Departamento");
            this.btnBuscaDepartamento.UseVisualStyleBackColor = true;
            this.btnBuscaDepartamento.Click += new System.EventHandler(this.btnBuscaDepartamento_Click);
            // 
            // btnBuscaPeca
            // 
            this.btnBuscaPeca.BackgroundImage = global::TCC.UI.resImg.btnBusca;
            this.btnBuscaPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaPeca.Location = new System.Drawing.Point(282, 48);
            this.btnBuscaPeca.Name = "btnBuscaPeca";
            this.btnBuscaPeca.Size = new System.Drawing.Size(28, 23);
            this.btnBuscaPeca.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnBuscaPeca, "Buscar Peça");
            this.btnBuscaPeca.UseVisualStyleBackColor = true;
            this.btnBuscaPeca.Click += new System.EventHandler(this.btnBuscaPeca_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TCC.UI.resImg.btnBusca;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(282, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.button1, "Buscar Peça");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = global::TCC.UI.resImg.btnSalvar;
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(2, 4);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(27, 23);
            this.btnAceitar.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnAceitar, "Salvar");
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // lblCodMotor
            // 
            this.lblCodMotor.AutoSize = true;
            this.lblCodMotor.Location = new System.Drawing.Point(59, 52);
            this.lblCodMotor.Name = "lblCodMotor";
            this.lblCodMotor.Size = new System.Drawing.Size(85, 13);
            this.lblCodMotor.TabIndex = 24;
            this.lblCodMotor.Text = "Codigo do Motor";
            // 
            // txtCodigoPeca
            // 
            this.txtCodigoPeca.Location = new System.Drawing.Point(150, 50);
            this.txtCodigoPeca.MaxLength = 50;
            this.txtCodigoPeca.Name = "txtCodigoPeca";
            this.txtCodigoPeca.ReadOnly = true;
            this.txtCodigoPeca.Size = new System.Drawing.Size(126, 20);
            this.txtCodigoPeca.TabIndex = 23;
            this.txtCodigoPeca.TabStop = false;
            // 
            // lblCodKit
            // 
            this.lblCodKit.AutoSize = true;
            this.lblCodKit.Location = new System.Drawing.Point(59, 78);
            this.lblCodKit.Name = "lblCodKit";
            this.lblCodKit.Size = new System.Drawing.Size(70, 13);
            this.lblCodKit.TabIndex = 27;
            this.lblCodKit.Text = "Codigo do Kit";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 76);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.TabStop = false;
            // 
            // frmCadPedidoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.UI.resImg.bg_UI;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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