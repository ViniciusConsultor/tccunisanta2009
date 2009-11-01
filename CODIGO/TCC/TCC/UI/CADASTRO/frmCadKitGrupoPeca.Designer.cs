namespace TCC.UI
{
    partial class frmCadKitGrupoPeca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadKitGrupoPeca));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.txtCdItemPeca = new System.Windows.Forms.TextBox();
            this.lblCdItemPeca = new System.Windows.Forms.Label();
            this.txtCdPeca = new System.Windows.Forms.TextBox();
            this.lblCdPeca = new System.Windows.Forms.Label();
            this.txtNmKit = new System.Windows.Forms.TextBox();
            this.lblNmKit = new System.Windows.Forms.Label();
            this.btnCdPeca = new System.Windows.Forms.Button();
            this.btnCdItemPeca = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(2, 56);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 6;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::TCC.Properties.Resources.trash_can;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(2, 29);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Novo");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceitar.BackgroundImage")));
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(2, 2);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(27, 23);
            this.btnAceitar.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnAceitar, "Cadastrar");
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // txtCdItemPeca
            // 
            this.txtCdItemPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdItemPeca.Location = new System.Drawing.Point(176, 44);
            this.txtCdItemPeca.Name = "txtCdItemPeca";
            this.txtCdItemPeca.ReadOnly = true;
            this.txtCdItemPeca.Size = new System.Drawing.Size(32, 20);
            this.txtCdItemPeca.TabIndex = 14;
            this.txtCdItemPeca.TabStop = false;
            // 
            // lblCdItemPeca
            // 
            this.lblCdItemPeca.AutoSize = true;
            this.lblCdItemPeca.Location = new System.Drawing.Point(61, 46);
            this.lblCdItemPeca.Name = "lblCdItemPeca";
            this.lblCdItemPeca.Size = new System.Drawing.Size(109, 13);
            this.lblCdItemPeca.TabIndex = 15;
            this.lblCdItemPeca.Text = "Codigo do Item Peca ";
            // 
            // txtCdPeca
            // 
            this.txtCdPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdPeca.Location = new System.Drawing.Point(150, 81);
            this.txtCdPeca.Name = "txtCdPeca";
            this.txtCdPeca.ReadOnly = true;
            this.txtCdPeca.Size = new System.Drawing.Size(57, 20);
            this.txtCdPeca.TabIndex = 14;
            this.txtCdPeca.TabStop = false;
            // 
            // lblCdPeca
            // 
            this.lblCdPeca.AutoSize = true;
            this.lblCdPeca.Location = new System.Drawing.Point(61, 83);
            this.lblCdPeca.Name = "lblCdPeca";
            this.lblCdPeca.Size = new System.Drawing.Size(83, 13);
            this.lblCdPeca.TabIndex = 15;
            this.lblCdPeca.Text = "Codigo da Peça";
            // 
            // txtNmKit
            // 
            this.txtNmKit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNmKit.Location = new System.Drawing.Point(132, 118);
            this.txtNmKit.MaxLength = 50;
            this.txtNmKit.Name = "txtNmKit";
            this.txtNmKit.Size = new System.Drawing.Size(188, 20);
            this.txtNmKit.TabIndex = 3;
            // 
            // lblNmKit
            // 
            this.lblNmKit.AutoSize = true;
            this.lblNmKit.Location = new System.Drawing.Point(61, 120);
            this.lblNmKit.Name = "lblNmKit";
            this.lblNmKit.Size = new System.Drawing.Size(65, 13);
            this.lblNmKit.TabIndex = 15;
            this.lblNmKit.Text = "Nome do Kit";
            // 
            // btnCdPeca
            // 
            this.btnCdPeca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCdPeca.BackgroundImage")));
            this.btnCdPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdPeca.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCdPeca.Location = new System.Drawing.Point(213, 78);
            this.btnCdPeca.Name = "btnCdPeca";
            this.btnCdPeca.Size = new System.Drawing.Size(28, 23);
            this.btnCdPeca.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnCdPeca, "Buscar Peça");
            this.btnCdPeca.UseVisualStyleBackColor = true;
            this.btnCdPeca.Click += new System.EventHandler(this.btnCdPeca_Click);
            // 
            // btnCdItemPeca
            // 
            this.btnCdItemPeca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCdItemPeca.BackgroundImage")));
            this.btnCdItemPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdItemPeca.Location = new System.Drawing.Point(214, 44);
            this.btnCdItemPeca.Name = "btnCdItemPeca";
            this.btnCdItemPeca.Size = new System.Drawing.Size(27, 23);
            this.btnCdItemPeca.TabIndex = 1;
            this.toolTipLegenda.SetToolTip(this.btnCdItemPeca, "Buscar Item Peça");
            this.btnCdItemPeca.UseVisualStyleBackColor = true;
            this.btnCdItemPeca.Click += new System.EventHandler(this.btnCdItemPeca_Click);
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // frmCadKitGrupoPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 218);
            this.ControlBox = false;
            this.Controls.Add(this.lblNmKit);
            this.Controls.Add(this.txtNmKit);
            this.Controls.Add(this.lblCdPeca);
            this.Controls.Add(this.txtCdPeca);
            this.Controls.Add(this.lblCdItemPeca);
            this.Controls.Add(this.txtCdItemPeca);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCdItemPeca);
            this.Controls.Add(this.btnCdPeca);
            this.Controls.Add(this.btnAceitar);
            this.MaximizeBox = false;
            this.Name = "frmCadKitGrupoPeca";
            this.Text = "KitGrupoPeca";
            this.Load += new System.EventHandler(this.frmCadKitGrupoPeca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.TextBox txtCdItemPeca;
        private System.Windows.Forms.Label lblCdItemPeca;
        private System.Windows.Forms.TextBox txtCdPeca;
        private System.Windows.Forms.Label lblCdPeca;
        private System.Windows.Forms.TextBox txtNmKit;
        private System.Windows.Forms.Label lblNmKit;
        private System.Windows.Forms.Button btnCdPeca;
        private System.Windows.Forms.Button btnCdItemPeca;
        private System.Windows.Forms.ToolTip toolTipLegenda;
    }
}