namespace TCC.UI
{
    partial class frmCadItemPeca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadItemPeca));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.txtCodigoPeca = new System.Windows.Forms.TextBox();
            this.txtDescItemPeca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodPeca = new System.Windows.Forms.Label();
            this.btnBuscaPeca = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.BackgroundImage")));
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.Location = new System.Drawing.Point(2, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(27, 23);
            this.btnConfirmar.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnConfirmar, "Cadastrar");
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolta.BackgroundImage")));
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(2, 61);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(27, 23);
            this.btnVolta.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnVolta, "Fechar");
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackgroundImage = global::TCC.Properties.Resources.trash_can;
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpa.Location = new System.Drawing.Point(2, 32);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(27, 23);
            this.btnLimpa.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnLimpa, "Limpar");
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // txtCodigoPeca
            // 
            this.txtCodigoPeca.Location = new System.Drawing.Point(179, 57);
            this.txtCodigoPeca.Name = "txtCodigoPeca";
            this.txtCodigoPeca.ReadOnly = true;
            this.txtCodigoPeca.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPeca.TabIndex = 4;
            this.txtCodigoPeca.TabStop = false;
            // 
            // txtDescItemPeca
            // 
            this.txtDescItemPeca.Location = new System.Drawing.Point(179, 101);
            this.txtDescItemPeca.MaxLength = 20;
            this.txtDescItemPeca.Name = "txtDescItemPeca";
            this.txtDescItemPeca.Size = new System.Drawing.Size(133, 20);
            this.txtDescItemPeca.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descrição Item Peça";
            // 
            // lblCodPeca
            // 
            this.lblCodPeca.AutoSize = true;
            this.lblCodPeca.Location = new System.Drawing.Point(116, 60);
            this.lblCodPeca.Name = "lblCodPeca";
            this.lblCodPeca.Size = new System.Drawing.Size(57, 13);
            this.lblCodPeca.TabIndex = 8;
            this.lblCodPeca.Text = "Cod. Peça";
            // 
            // btnBuscaPeca
            // 
            this.btnBuscaPeca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaPeca.BackgroundImage")));
            this.btnBuscaPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaPeca.Location = new System.Drawing.Point(284, 56);
            this.btnBuscaPeca.Name = "btnBuscaPeca";
            this.btnBuscaPeca.Size = new System.Drawing.Size(28, 23);
            this.btnBuscaPeca.TabIndex = 1;
            this.toolTipLegenda.SetToolTip(this.btnBuscaPeca, "Buscar Peça");
            this.btnBuscaPeca.UseVisualStyleBackColor = true;
            this.btnBuscaPeca.Click += new System.EventHandler(this.btnBuscaPeca_Click);
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // frmCadItemPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 218);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscaPeca);
            this.Controls.Add(this.lblCodPeca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescItemPeca);
            this.Controls.Add(this.txtCodigoPeca);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnConfirmar);
            this.MaximizeBox = false;
            this.Name = "frmCadItemPeca";
            this.Text = "Item Peca";
            this.Load += new System.EventHandler(this.frmCadItemPeca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.TextBox txtCodigoPeca;
        private System.Windows.Forms.TextBox txtDescItemPeca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodPeca;
        private System.Windows.Forms.Button btnBuscaPeca;
        private System.Windows.Forms.ToolTip toolTipLegenda;
    }
}