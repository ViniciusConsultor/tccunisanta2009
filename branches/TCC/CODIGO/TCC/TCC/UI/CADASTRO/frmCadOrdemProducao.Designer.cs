namespace TCC.UI
{
    partial class frmCadOrdemProducao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadOrdemProducao));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.lblcdFamiliaMotor = new System.Windows.Forms.Label();
            this.txtCdMotor = new System.Windows.Forms.TextBox();
            this.lblCdDepartamento = new System.Windows.Forms.Label();
            this.txtCdDepartamento = new System.Windows.Forms.TextBox();
            this.lblCdKit = new System.Windows.Forms.Label();
            this.txtCdKit = new System.Windows.Forms.TextBox();
            this.lblCdTipoProduto = new System.Windows.Forms.Label();
            this.txtCdTipoProduto = new System.Windows.Forms.TextBox();
            this.lblDs = new System.Windows.Forms.Label();
            this.txtDs = new System.Windows.Forms.TextBox();
            this.btnCdMotor = new System.Windows.Forms.Button();
            this.btnCdDep = new System.Windows.Forms.Button();
            this.btnCdKit = new System.Windows.Forms.Button();
            this.btnCdTipoProduto = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(7, 89);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(40, 35);
            this.btnVoltar.TabIndex = 16;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar / Voltar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::TCC.Properties.Resources.trash_can;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(7, 48);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(40, 35);
            this.btnLimpar.TabIndex = 15;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceitar.BackgroundImage")));
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(7, 6);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(40, 35);
            this.btnAceitar.TabIndex = 14;
            this.toolTipLegenda.SetToolTip(this.btnAceitar, "OK");
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // lblcdFamiliaMotor
            // 
            this.lblcdFamiliaMotor.AutoSize = true;
            this.lblcdFamiliaMotor.Location = new System.Drawing.Point(111, 50);
            this.lblcdFamiliaMotor.Name = "lblcdFamiliaMotor";
            this.lblcdFamiliaMotor.Size = new System.Drawing.Size(105, 13);
            this.lblcdFamiliaMotor.TabIndex = 17;
            this.lblcdFamiliaMotor.Text = "Codigo Familia Motor";
            // 
            // txtCdMotor
            // 
            this.txtCdMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdMotor.Location = new System.Drawing.Point(222, 45);
            this.txtCdMotor.Name = "txtCdMotor";
            this.txtCdMotor.ReadOnly = true;
            this.txtCdMotor.Size = new System.Drawing.Size(41, 20);
            this.txtCdMotor.TabIndex = 18;
            // 
            // lblCdDepartamento
            // 
            this.lblCdDepartamento.AutoSize = true;
            this.lblCdDepartamento.Location = new System.Drawing.Point(324, 50);
            this.lblCdDepartamento.Name = "lblCdDepartamento";
            this.lblCdDepartamento.Size = new System.Drawing.Size(125, 13);
            this.lblCdDepartamento.TabIndex = 17;
            this.lblCdDepartamento.Text = "Codigo do Departamento";
            this.lblCdDepartamento.Click += new System.EventHandler(this.lblCdDepartamento_Click);
            // 
            // txtCdDepartamento
            // 
            this.txtCdDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdDepartamento.Location = new System.Drawing.Point(454, 48);
            this.txtCdDepartamento.Name = "txtCdDepartamento";
            this.txtCdDepartamento.ReadOnly = true;
            this.txtCdDepartamento.Size = new System.Drawing.Size(46, 20);
            this.txtCdDepartamento.TabIndex = 18;
            // 
            // lblCdKit
            // 
            this.lblCdKit.AutoSize = true;
            this.lblCdKit.Location = new System.Drawing.Point(111, 89);
            this.lblCdKit.Name = "lblCdKit";
            this.lblCdKit.Size = new System.Drawing.Size(70, 13);
            this.lblCdKit.TabIndex = 17;
            this.lblCdKit.Text = "Codigo do Kit";
            // 
            // txtCdKit
            // 
            this.txtCdKit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdKit.Location = new System.Drawing.Point(187, 87);
            this.txtCdKit.Name = "txtCdKit";
            this.txtCdKit.ReadOnly = true;
            this.txtCdKit.Size = new System.Drawing.Size(41, 20);
            this.txtCdKit.TabIndex = 18;
            // 
            // lblCdTipoProduto
            // 
            this.lblCdTipoProduto.AutoSize = true;
            this.lblCdTipoProduto.Location = new System.Drawing.Point(313, 89);
            this.lblCdTipoProduto.Name = "lblCdTipoProduto";
            this.lblCdTipoProduto.Size = new System.Drawing.Size(136, 13);
            this.lblCdTipoProduto.TabIndex = 17;
            this.lblCdTipoProduto.Text = "Codigo Do Tipo do Produto";
            // 
            // txtCdTipoProduto
            // 
            this.txtCdTipoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdTipoProduto.Location = new System.Drawing.Point(455, 88);
            this.txtCdTipoProduto.Name = "txtCdTipoProduto";
            this.txtCdTipoProduto.ReadOnly = true;
            this.txtCdTipoProduto.Size = new System.Drawing.Size(46, 20);
            this.txtCdTipoProduto.TabIndex = 18;
            // 
            // lblDs
            // 
            this.lblDs.AutoSize = true;
            this.lblDs.Location = new System.Drawing.Point(111, 179);
            this.lblDs.Name = "lblDs";
            this.lblDs.Size = new System.Drawing.Size(55, 13);
            this.lblDs.TabIndex = 17;
            this.lblDs.Text = "Descrição";
            // 
            // txtDs
            // 
            this.txtDs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDs.Location = new System.Drawing.Point(172, 177);
            this.txtDs.MaxLength = 500;
            this.txtDs.Multiline = true;
            this.txtDs.Name = "txtDs";
            this.txtDs.Size = new System.Drawing.Size(361, 80);
            this.txtDs.TabIndex = 18;
            // 
            // btnCdMotor
            // 
            this.btnCdMotor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCdMotor.BackgroundImage")));
            this.btnCdMotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdMotor.Location = new System.Drawing.Point(269, 45);
            this.btnCdMotor.Name = "btnCdMotor";
            this.btnCdMotor.Size = new System.Drawing.Size(27, 23);
            this.btnCdMotor.TabIndex = 14;
            this.toolTipLegenda.SetToolTip(this.btnCdMotor, "Buscar Familia Motor");
            this.btnCdMotor.UseVisualStyleBackColor = true;
            this.btnCdMotor.Click += new System.EventHandler(this.btnCdMotor_Click);
            // 
            // btnCdDep
            // 
            this.btnCdDep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCdDep.BackgroundImage")));
            this.btnCdDep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdDep.Location = new System.Drawing.Point(506, 45);
            this.btnCdDep.Name = "btnCdDep";
            this.btnCdDep.Size = new System.Drawing.Size(27, 23);
            this.btnCdDep.TabIndex = 14;
            this.toolTipLegenda.SetToolTip(this.btnCdDep, "Buscar Departamento");
            this.btnCdDep.UseVisualStyleBackColor = true;
            this.btnCdDep.Click += new System.EventHandler(this.btnCdDep_Click);
            // 
            // btnCdKit
            // 
            this.btnCdKit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCdKit.BackgroundImage")));
            this.btnCdKit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdKit.Location = new System.Drawing.Point(234, 85);
            this.btnCdKit.Name = "btnCdKit";
            this.btnCdKit.Size = new System.Drawing.Size(27, 23);
            this.btnCdKit.TabIndex = 14;
            this.toolTipLegenda.SetToolTip(this.btnCdKit, "Buscar Kit");
            this.btnCdKit.UseVisualStyleBackColor = true;
            this.btnCdKit.Click += new System.EventHandler(this.btnCdKit_Click);
            // 
            // btnCdTipoProduto
            // 
            this.btnCdTipoProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCdTipoProduto.BackgroundImage")));
            this.btnCdTipoProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdTipoProduto.Location = new System.Drawing.Point(506, 87);
            this.btnCdTipoProduto.Name = "btnCdTipoProduto";
            this.btnCdTipoProduto.Size = new System.Drawing.Size(27, 23);
            this.btnCdTipoProduto.TabIndex = 14;
            this.toolTipLegenda.SetToolTip(this.btnCdTipoProduto, "Buscar Tipo Produto");
            this.btnCdTipoProduto.UseVisualStyleBackColor = true;
            this.btnCdTipoProduto.Click += new System.EventHandler(this.btnCdTipoProduto_Click);
            // 
            // frmCadOrdemProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 368);
            this.ControlBox = false;
            this.Controls.Add(this.txtDs);
            this.Controls.Add(this.lblDs);
            this.Controls.Add(this.txtCdTipoProduto);
            this.Controls.Add(this.lblCdTipoProduto);
            this.Controls.Add(this.txtCdKit);
            this.Controls.Add(this.lblCdKit);
            this.Controls.Add(this.txtCdDepartamento);
            this.Controls.Add(this.lblCdDepartamento);
            this.Controls.Add(this.txtCdMotor);
            this.Controls.Add(this.lblcdFamiliaMotor);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCdTipoProduto);
            this.Controls.Add(this.btnCdKit);
            this.Controls.Add(this.btnCdDep);
            this.Controls.Add(this.btnCdMotor);
            this.Controls.Add(this.btnAceitar);
            this.MaximizeBox = false;
            this.Name = "frmCadOrdemProducao";
            this.Text = "Ordem de Produção";
            this.Load += new System.EventHandler(this.frmCadOrdemProducao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.Label lblcdFamiliaMotor;
        private System.Windows.Forms.TextBox txtCdMotor;
        private System.Windows.Forms.Label lblCdDepartamento;
        private System.Windows.Forms.TextBox txtCdDepartamento;
        private System.Windows.Forms.Label lblCdKit;
        private System.Windows.Forms.TextBox txtCdKit;
        private System.Windows.Forms.Label lblCdTipoProduto;
        private System.Windows.Forms.TextBox txtCdTipoProduto;
        private System.Windows.Forms.Label lblDs;
        private System.Windows.Forms.TextBox txtDs;
        private System.Windows.Forms.Button btnCdMotor;
        private System.Windows.Forms.Button btnCdDep;
        private System.Windows.Forms.Button btnCdKit;
        private System.Windows.Forms.Button btnCdTipoProduto;
        private System.Windows.Forms.ToolTip toolTipLegenda;
    }
}