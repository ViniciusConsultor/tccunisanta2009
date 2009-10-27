namespace TCC.UI
{
    partial class frmCadFamiliaMotor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadFamiliaMotor));
            this.lblCdMotor = new System.Windows.Forms.Label();
            this.txtCdMotor = new System.Windows.Forms.TextBox();
            this.lblCdNumeroMotor = new System.Windows.Forms.Label();
            this.txtCdNumeroMotor = new System.Windows.Forms.TextBox();
            this.lblCdTipoMotor = new System.Windows.Forms.Label();
            this.txtCdTipoMotor = new System.Windows.Forms.TextBox();
            this.lblCdKit = new System.Windows.Forms.Label();
            this.txtCdKit = new System.Windows.Forms.TextBox();
            this.lblDsMotor = new System.Windows.Forms.Label();
            this.txtDsMotor = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.lblCdEstoque = new System.Windows.Forms.Label();
            this.txtCdEstoque = new System.Windows.Forms.TextBox();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnBuscaCdNumMotor = new System.Windows.Forms.Button();
            this.btnCdKit = new System.Windows.Forms.Button();
            this.btnCdMotorCompra = new System.Windows.Forms.Button();
            this.btnCdTipoMotor = new System.Windows.Forms.Button();
            this.btnCdEstoque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCdMotor
            // 
            this.lblCdMotor.AutoSize = true;
            this.lblCdMotor.Location = new System.Drawing.Point(98, 58);
            this.lblCdMotor.Name = "lblCdMotor";
            this.lblCdMotor.Size = new System.Drawing.Size(87, 13);
            this.lblCdMotor.TabIndex = 0;
            this.lblCdMotor.Text = "Codigo Do Motor";
            // 
            // txtCdMotor
            // 
            this.txtCdMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdMotor.Location = new System.Drawing.Point(191, 56);
            this.txtCdMotor.Name = "txtCdMotor";
            this.txtCdMotor.ReadOnly = true;
            this.txtCdMotor.Size = new System.Drawing.Size(52, 20);
            this.txtCdMotor.TabIndex = 1;
            // 
            // lblCdNumeroMotor
            // 
            this.lblCdNumeroMotor.AutoSize = true;
            this.lblCdNumeroMotor.Location = new System.Drawing.Point(98, 93);
            this.lblCdNumeroMotor.Name = "lblCdNumeroMotor";
            this.lblCdNumeroMotor.Size = new System.Drawing.Size(145, 13);
            this.lblCdNumeroMotor.TabIndex = 0;
            this.lblCdNumeroMotor.Text = "Codigo Do Numero do Motor ";
            // 
            // txtCdNumeroMotor
            // 
            this.txtCdNumeroMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdNumeroMotor.Location = new System.Drawing.Point(244, 91);
            this.txtCdNumeroMotor.Name = "txtCdNumeroMotor";
            this.txtCdNumeroMotor.ReadOnly = true;
            this.txtCdNumeroMotor.Size = new System.Drawing.Size(38, 20);
            this.txtCdNumeroMotor.TabIndex = 3;
            // 
            // lblCdTipoMotor
            // 
            this.lblCdTipoMotor.AutoSize = true;
            this.lblCdTipoMotor.Location = new System.Drawing.Point(336, 93);
            this.lblCdTipoMotor.Name = "lblCdTipoMotor";
            this.lblCdTipoMotor.Size = new System.Drawing.Size(126, 13);
            this.lblCdTipoMotor.TabIndex = 0;
            this.lblCdTipoMotor.Text = "Codigo Do Tipo do Motor";
            // 
            // txtCdTipoMotor
            // 
            this.txtCdTipoMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdTipoMotor.Location = new System.Drawing.Point(468, 88);
            this.txtCdTipoMotor.Name = "txtCdTipoMotor";
            this.txtCdTipoMotor.ReadOnly = true;
            this.txtCdTipoMotor.Size = new System.Drawing.Size(52, 20);
            this.txtCdTipoMotor.TabIndex = 5;
            // 
            // lblCdKit
            // 
            this.lblCdKit.AutoSize = true;
            this.lblCdKit.Location = new System.Drawing.Point(98, 128);
            this.lblCdKit.Name = "lblCdKit";
            this.lblCdKit.Size = new System.Drawing.Size(72, 13);
            this.lblCdKit.TabIndex = 0;
            this.lblCdKit.Text = "Codigo Do Kit";
            // 
            // txtCdKit
            // 
            this.txtCdKit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdKit.Location = new System.Drawing.Point(175, 126);
            this.txtCdKit.Name = "txtCdKit";
            this.txtCdKit.ReadOnly = true;
            this.txtCdKit.Size = new System.Drawing.Size(38, 20);
            this.txtCdKit.TabIndex = 7;
            // 
            // lblDsMotor
            // 
            this.lblDsMotor.AutoSize = true;
            this.lblDsMotor.Location = new System.Drawing.Point(98, 189);
            this.lblDsMotor.Name = "lblDsMotor";
            this.lblDsMotor.Size = new System.Drawing.Size(100, 13);
            this.lblDsMotor.TabIndex = 0;
            this.lblDsMotor.Text = "Descrição do Motor";
            // 
            // txtDsMotor
            // 
            this.txtDsMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDsMotor.Location = new System.Drawing.Point(202, 187);
            this.txtDsMotor.Multiline = true;
            this.txtDsMotor.MaxLength = 500;
            this.txtDsMotor.Name = "txtDsMotor";
            this.txtDsMotor.Size = new System.Drawing.Size(351, 87);
            this.txtDsMotor.TabIndex = 11;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirma.BackgroundImage")));
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(7, 4);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(40, 35);
            this.btnConfirma.TabIndex = 2;
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackgroundImage = global::TCC.Properties.Resources.trash_can;
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpa.Location = new System.Drawing.Point(7, 47);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(40, 35);
            this.btnLimpa.TabIndex = 2;
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // lblCdEstoque
            // 
            this.lblCdEstoque.AutoSize = true;
            this.lblCdEstoque.Location = new System.Drawing.Point(363, 128);
            this.lblCdEstoque.Name = "lblCdEstoque";
            this.lblCdEstoque.Size = new System.Drawing.Size(99, 13);
            this.lblCdEstoque.TabIndex = 0;
            this.lblCdEstoque.Text = "Codigo Do Estoque";
            // 
            // txtCdEstoque
            // 
            this.txtCdEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdEstoque.Location = new System.Drawing.Point(468, 126);
            this.txtCdEstoque.Name = "txtCdEstoque";
            this.txtCdEstoque.ReadOnly = true;
            this.txtCdEstoque.Size = new System.Drawing.Size(52, 20);
            this.txtCdEstoque.TabIndex = 9;
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolta.BackgroundImage")));
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(7, 92);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(40, 35);
            this.btnVolta.TabIndex = 2;
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // btnBuscaCdNumMotor
            // 
            this.btnBuscaCdNumMotor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaCdNumMotor.BackgroundImage")));
            this.btnBuscaCdNumMotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaCdNumMotor.Location = new System.Drawing.Point(288, 88);
            this.btnBuscaCdNumMotor.Name = "btnBuscaCdNumMotor";
            this.btnBuscaCdNumMotor.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaCdNumMotor.TabIndex = 4;
            this.btnBuscaCdNumMotor.UseVisualStyleBackColor = true;
            this.btnBuscaCdNumMotor.Click += new System.EventHandler(this.btnBuscaCdNumMotor_Click);
            // 
            // btnCdKit
            // 
            this.btnCdKit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCdKit.BackgroundImage")));
            this.btnCdKit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdKit.Location = new System.Drawing.Point(219, 125);
            this.btnCdKit.Name = "btnCdKit";
            this.btnCdKit.Size = new System.Drawing.Size(27, 23);
            this.btnCdKit.TabIndex = 8;
            this.btnCdKit.UseVisualStyleBackColor = true;
            this.btnCdKit.Click += new System.EventHandler(this.btnCdKit_Click);
            // 
            // btnCdMotorCompra
            // 
            this.btnCdMotorCompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCdMotorCompra.BackgroundImage")));
            this.btnCdMotorCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdMotorCompra.Location = new System.Drawing.Point(249, 56);
            this.btnCdMotorCompra.Name = "btnCdMotorCompra";
            this.btnCdMotorCompra.Size = new System.Drawing.Size(27, 23);
            this.btnCdMotorCompra.TabIndex = 2;
            this.btnCdMotorCompra.UseVisualStyleBackColor = true;
            this.btnCdMotorCompra.Click += new System.EventHandler(this.btnCdMotorCompra_Click);
            // 
            // btnCdTipoMotor
            // 
            this.btnCdTipoMotor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCdTipoMotor.BackgroundImage")));
            this.btnCdTipoMotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdTipoMotor.Location = new System.Drawing.Point(526, 88);
            this.btnCdTipoMotor.Name = "btnCdTipoMotor";
            this.btnCdTipoMotor.Size = new System.Drawing.Size(27, 23);
            this.btnCdTipoMotor.TabIndex = 6;
            this.btnCdTipoMotor.UseVisualStyleBackColor = true;
            this.btnCdTipoMotor.Click += new System.EventHandler(this.btnCdTipoMotor_Click);
            // 
            // btnCdEstoque
            // 
            this.btnCdEstoque.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCdEstoque.BackgroundImage")));
            this.btnCdEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdEstoque.Location = new System.Drawing.Point(526, 123);
            this.btnCdEstoque.Name = "btnCdEstoque";
            this.btnCdEstoque.Size = new System.Drawing.Size(27, 23);
            this.btnCdEstoque.TabIndex = 10;
            this.btnCdEstoque.UseVisualStyleBackColor = true;
            this.btnCdEstoque.Click += new System.EventHandler(this.btnCdEstoque_Click);
            // 
            // frmCadFamiliaMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 368);
            this.ControlBox = false;
            this.Controls.Add(this.btnCdEstoque);
            this.Controls.Add(this.btnCdTipoMotor);
            this.Controls.Add(this.btnCdMotorCompra);
            this.Controls.Add(this.btnCdKit);
            this.Controls.Add(this.btnBuscaCdNumMotor);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtDsMotor);
            this.Controls.Add(this.txtCdEstoque);
            this.Controls.Add(this.txtCdKit);
            this.Controls.Add(this.txtCdTipoMotor);
            this.Controls.Add(this.txtCdNumeroMotor);
            this.Controls.Add(this.txtCdMotor);
            this.Controls.Add(this.lblDsMotor);
            this.Controls.Add(this.lblCdEstoque);
            this.Controls.Add(this.lblCdKit);
            this.Controls.Add(this.lblCdTipoMotor);
            this.Controls.Add(this.lblCdNumeroMotor);
            this.Controls.Add(this.lblCdMotor);
            this.MaximizeBox = false;
            this.Name = "frmCadFamiliaMotor";
            this.Text = "Familia do  Motor";
            this.Load += new System.EventHandler(this.frmCadFamiliaMotor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCdMotor;
        private System.Windows.Forms.TextBox txtCdMotor;
        private System.Windows.Forms.Label lblCdNumeroMotor;
        private System.Windows.Forms.TextBox txtCdNumeroMotor;
        private System.Windows.Forms.Label lblCdTipoMotor;
        private System.Windows.Forms.TextBox txtCdTipoMotor;
        private System.Windows.Forms.Label lblCdKit;
        private System.Windows.Forms.TextBox txtCdKit;
        private System.Windows.Forms.Label lblDsMotor;
        private System.Windows.Forms.TextBox txtDsMotor;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Label lblCdEstoque;
        private System.Windows.Forms.TextBox txtCdEstoque;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnBuscaCdNumMotor;
        private System.Windows.Forms.Button btnCdKit;
        private System.Windows.Forms.Button btnCdMotorCompra;
        private System.Windows.Forms.Button btnCdTipoMotor;
        private System.Windows.Forms.Button btnCdEstoque;
    }
}