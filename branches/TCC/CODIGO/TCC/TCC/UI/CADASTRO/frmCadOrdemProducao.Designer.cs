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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadOrdemProducao));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.lblCdOrdemMotor = new System.Windows.Forms.Label();
            this.txtCdOrdemMotor = new System.Windows.Forms.TextBox();
            this.lblcdMotor = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(3, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(40, 28);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(341, 219);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAceitar
            // 
            this.btnAceitar.Location = new System.Drawing.Point(260, 219);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(75, 23);
            this.btnAceitar.TabIndex = 14;
            this.btnAceitar.Text = "Confirmar";
            this.btnAceitar.UseVisualStyleBackColor = true;
            // 
            // lblCdOrdemMotor
            // 
            this.lblCdOrdemMotor.AutoSize = true;
            this.lblCdOrdemMotor.Location = new System.Drawing.Point(77, 35);
            this.lblCdOrdemMotor.Name = "lblCdOrdemMotor";
            this.lblCdOrdemMotor.Size = new System.Drawing.Size(136, 13);
            this.lblCdOrdemMotor.TabIndex = 17;
            this.lblCdOrdemMotor.Text = "Codigo da Ordem Do Motor";
            // 
            // txtCdOrdemMotor
            // 
            this.txtCdOrdemMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdOrdemMotor.Location = new System.Drawing.Point(227, 27);
            this.txtCdOrdemMotor.Name = "txtCdOrdemMotor";
            this.txtCdOrdemMotor.ReadOnly = true;
            this.txtCdOrdemMotor.Size = new System.Drawing.Size(82, 20);
            this.txtCdOrdemMotor.TabIndex = 18;
            // 
            // lblcdMotor
            // 
            this.lblcdMotor.AutoSize = true;
            this.lblcdMotor.Location = new System.Drawing.Point(318, 33);
            this.lblcdMotor.Name = "lblcdMotor";
            this.lblcdMotor.Size = new System.Drawing.Size(85, 13);
            this.lblcdMotor.TabIndex = 17;
            this.lblcdMotor.Text = "Codigo do Motor";
            // 
            // txtCdMotor
            // 
            this.txtCdMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdMotor.Location = new System.Drawing.Point(409, 29);
            this.txtCdMotor.Name = "txtCdMotor";
            this.txtCdMotor.ReadOnly = true;
            this.txtCdMotor.Size = new System.Drawing.Size(41, 20);
            this.txtCdMotor.TabIndex = 18;
            // 
            // lblCdDepartamento
            // 
            this.lblCdDepartamento.AutoSize = true;
            this.lblCdDepartamento.Location = new System.Drawing.Point(77, 78);
            this.lblCdDepartamento.Name = "lblCdDepartamento";
            this.lblCdDepartamento.Size = new System.Drawing.Size(125, 13);
            this.lblCdDepartamento.TabIndex = 17;
            this.lblCdDepartamento.Text = "Codigo do Departamento";
            // 
            // txtCdDepartamento
            // 
            this.txtCdDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdDepartamento.Location = new System.Drawing.Point(227, 70);
            this.txtCdDepartamento.Name = "txtCdDepartamento";
            this.txtCdDepartamento.ReadOnly = true;
            this.txtCdDepartamento.Size = new System.Drawing.Size(46, 20);
            this.txtCdDepartamento.TabIndex = 18;
            // 
            // lblCdKit
            // 
            this.lblCdKit.AutoSize = true;
            this.lblCdKit.Location = new System.Drawing.Point(318, 79);
            this.lblCdKit.Name = "lblCdKit";
            this.lblCdKit.Size = new System.Drawing.Size(70, 13);
            this.lblCdKit.TabIndex = 17;
            this.lblCdKit.Text = "Codigo do Kit";
            // 
            // txtCdKit
            // 
            this.txtCdKit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdKit.Location = new System.Drawing.Point(409, 71);
            this.txtCdKit.Name = "txtCdKit";
            this.txtCdKit.ReadOnly = true;
            this.txtCdKit.Size = new System.Drawing.Size(41, 20);
            this.txtCdKit.TabIndex = 18;
            // 
            // lblCdTipoProduto
            // 
            this.lblCdTipoProduto.AutoSize = true;
            this.lblCdTipoProduto.Location = new System.Drawing.Point(77, 127);
            this.lblCdTipoProduto.Name = "lblCdTipoProduto";
            this.lblCdTipoProduto.Size = new System.Drawing.Size(136, 13);
            this.lblCdTipoProduto.TabIndex = 17;
            this.lblCdTipoProduto.Text = "Codigo Do Tipo do Produto";
            // 
            // txtCdTipoProduto
            // 
            this.txtCdTipoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdTipoProduto.Location = new System.Drawing.Point(227, 119);
            this.txtCdTipoProduto.Name = "txtCdTipoProduto";
            this.txtCdTipoProduto.ReadOnly = true;
            this.txtCdTipoProduto.Size = new System.Drawing.Size(46, 20);
            this.txtCdTipoProduto.TabIndex = 18;
            // 
            // lblDs
            // 
            this.lblDs.AutoSize = true;
            this.lblDs.Location = new System.Drawing.Point(77, 169);
            this.lblDs.Name = "lblDs";
            this.lblDs.Size = new System.Drawing.Size(55, 13);
            this.lblDs.TabIndex = 17;
            this.lblDs.Text = "Descrição";
            // 
            // txtDs
            // 
            this.txtDs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDs.Location = new System.Drawing.Point(227, 162);
            this.txtDs.Name = "txtDs";
            this.txtDs.Size = new System.Drawing.Size(282, 20);
            this.txtDs.TabIndex = 18;
            // 
            // btnCdMotor
            // 
            this.btnCdMotor.Location = new System.Drawing.Point(456, 27);
            this.btnCdMotor.Name = "btnCdMotor";
            this.btnCdMotor.Size = new System.Drawing.Size(30, 23);
            this.btnCdMotor.TabIndex = 14;
            this.btnCdMotor.Text = "...";
            this.btnCdMotor.UseVisualStyleBackColor = true;
            this.btnCdMotor.Click += new System.EventHandler(this.btnCdMotor_Click);
            // 
            // btnCdDep
            // 
            this.btnCdDep.Location = new System.Drawing.Point(282, 70);
            this.btnCdDep.Name = "btnCdDep";
            this.btnCdDep.Size = new System.Drawing.Size(30, 23);
            this.btnCdDep.TabIndex = 14;
            this.btnCdDep.Text = "...";
            this.btnCdDep.UseVisualStyleBackColor = true;
            this.btnCdDep.Click += new System.EventHandler(this.btnCdDep_Click);
            // 
            // btnCdKit
            // 
            this.btnCdKit.Location = new System.Drawing.Point(456, 69);
            this.btnCdKit.Name = "btnCdKit";
            this.btnCdKit.Size = new System.Drawing.Size(30, 23);
            this.btnCdKit.TabIndex = 14;
            this.btnCdKit.Text = "...";
            this.btnCdKit.UseVisualStyleBackColor = true;
            this.btnCdKit.Click += new System.EventHandler(this.btnCdKit_Click);
            // 
            // btnCdTipoProduto
            // 
            this.btnCdTipoProduto.Location = new System.Drawing.Point(282, 116);
            this.btnCdTipoProduto.Name = "btnCdTipoProduto";
            this.btnCdTipoProduto.Size = new System.Drawing.Size(30, 23);
            this.btnCdTipoProduto.TabIndex = 14;
            this.btnCdTipoProduto.Text = "...";
            this.btnCdTipoProduto.UseVisualStyleBackColor = true;
            this.btnCdTipoProduto.Click += new System.EventHandler(this.btnCdTipoProduto_Click);
            // 
            // frmCadOrdemProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(521, 268);
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
            this.Controls.Add(this.lblcdMotor);
            this.Controls.Add(this.txtCdOrdemMotor);
            this.Controls.Add(this.lblCdOrdemMotor);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.Label lblCdOrdemMotor;
        private System.Windows.Forms.TextBox txtCdOrdemMotor;
        private System.Windows.Forms.Label lblcdMotor;
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
    }
}