namespace TCC.UI
{
    partial class frmCadNumeroMotor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadNumeroMotor));
            this.txtDscNumeroMotor = new System.Windows.Forms.TextBox();
            this.lblDsNumeroMotor = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.txtIdRealMotor = new System.Windows.Forms.TextBox();
            this.lblIdReal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDscNumeroMotor
            // 
            this.txtDscNumeroMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDscNumeroMotor.Location = new System.Drawing.Point(61, 79);
            this.txtDscNumeroMotor.MaxLength = 50;
            this.txtDscNumeroMotor.Multiline = true;
            this.txtDscNumeroMotor.Name = "txtDscNumeroMotor";
            this.txtDscNumeroMotor.Size = new System.Drawing.Size(260, 72);
            this.txtDscNumeroMotor.TabIndex = 1;
            // 
            // lblDsNumeroMotor
            // 
            this.lblDsNumeroMotor.AutoSize = true;
            this.lblDsNumeroMotor.Location = new System.Drawing.Point(58, 58);
            this.lblDsNumeroMotor.Name = "lblDsNumeroMotor";
            this.lblDsNumeroMotor.Size = new System.Drawing.Size(155, 13);
            this.lblDsNumeroMotor.TabIndex = 21;
            this.lblDsNumeroMotor.Text = "Descrição do Numero do Motor";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(2, 62);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::TCC.Properties.Resources.eraser;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(2, 33);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = global::TCC.Properties.Resources.btnSalvar;
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(3, 4);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(27, 23);
            this.btnAceitar.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnAceitar, "Cadastrar");
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // txtIdRealMotor
            // 
            this.txtIdRealMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdRealMotor.Location = new System.Drawing.Point(61, 25);
            this.txtIdRealMotor.MaxLength = 50;
            this.txtIdRealMotor.Name = "txtIdRealMotor";
            this.txtIdRealMotor.Size = new System.Drawing.Size(227, 20);
            this.txtIdRealMotor.TabIndex = 22;
            // 
            // lblIdReal
            // 
            this.lblIdReal.AutoSize = true;
            this.lblIdReal.Location = new System.Drawing.Point(58, 9);
            this.lblIdReal.Name = "lblIdReal";
            this.lblIdReal.Size = new System.Drawing.Size(89, 13);
            this.lblIdReal.TabIndex = 23;
            this.lblIdReal.Text = "Numero do Motor";
            // 
            // frmCadNumeroMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 218);
            this.ControlBox = false;
            this.Controls.Add(this.txtIdRealMotor);
            this.Controls.Add(this.lblIdReal);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.txtDscNumeroMotor);
            this.Controls.Add(this.lblDsNumeroMotor);
            this.MaximizeBox = false;
            this.Name = "frmCadNumeroMotor";
            this.Text = "Numero Motor";
            this.Load += new System.EventHandler(this.frmCadNumeroMotor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDscNumeroMotor;
        private System.Windows.Forms.Label lblDsNumeroMotor;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.TextBox txtIdRealMotor;
        private System.Windows.Forms.Label lblIdReal;
    }
}