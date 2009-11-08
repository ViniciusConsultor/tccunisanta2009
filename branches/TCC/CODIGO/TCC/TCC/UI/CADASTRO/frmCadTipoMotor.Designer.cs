namespace TCC.UI
{
    partial class frmCadTipoMotor
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNmTipoMotor = new System.Windows.Forms.TextBox();
            this.lblNmTipoMotor = new System.Windows.Forms.Label();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.lblIdReal = new System.Windows.Forms.Label();
            this.txtIdReal = new System.Windows.Forms.TextBox();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(2, 62);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar / Voltar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::TCC.resImg.btnLimpa;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(2, 33);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtNmTipoMotor
            // 
            this.txtNmTipoMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNmTipoMotor.Location = new System.Drawing.Point(77, 127);
            this.txtNmTipoMotor.MaxLength = 50;
            this.txtNmTipoMotor.Name = "txtNmTipoMotor";
            this.txtNmTipoMotor.Size = new System.Drawing.Size(227, 20);
            this.txtNmTipoMotor.TabIndex = 1;
            // 
            // lblNmTipoMotor
            // 
            this.lblNmTipoMotor.AutoSize = true;
            this.lblNmTipoMotor.Location = new System.Drawing.Point(74, 111);
            this.lblNmTipoMotor.Name = "lblNmTipoMotor";
            this.lblNmTipoMotor.Size = new System.Drawing.Size(139, 13);
            this.lblNmTipoMotor.TabIndex = 19;
            this.lblNmTipoMotor.Text = "Descrição do Tipo do Motor";
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // lblIdReal
            // 
            this.lblIdReal.AutoSize = true;
            this.lblIdReal.Location = new System.Drawing.Point(74, 62);
            this.lblIdReal.Name = "lblIdReal";
            this.lblIdReal.Size = new System.Drawing.Size(124, 13);
            this.lblIdReal.TabIndex = 19;
            this.lblIdReal.Text = "Código do Tipo do Motor";
            // 
            // txtIdReal
            // 
            this.txtIdReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdReal.Location = new System.Drawing.Point(77, 78);
            this.txtIdReal.MaxLength = 50;
            this.txtIdReal.Name = "txtIdReal";
            this.txtIdReal.Size = new System.Drawing.Size(227, 20);
            this.txtIdReal.TabIndex = 1;
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(2, 4);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(27, 23);
            this.btnAceitar.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnAceitar, "Cadastrar");
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // frmCadTipoMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 218);
            this.ControlBox = false;
            this.Controls.Add(this.txtIdReal);
            this.Controls.Add(this.lblIdReal);
            this.Controls.Add(this.txtNmTipoMotor);
            this.Controls.Add(this.lblNmTipoMotor);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAceitar);
            this.MaximizeBox = false;
            this.Name = "frmCadTipoMotor";
            this.Text = "Tipo de Motor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.TextBox txtNmTipoMotor;
        private System.Windows.Forms.Label lblNmTipoMotor;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Label lblIdReal;
        private System.Windows.Forms.TextBox txtIdReal;
    }
}