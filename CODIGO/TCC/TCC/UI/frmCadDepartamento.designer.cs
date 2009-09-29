namespace TCC.UI
{
    partial class frmCadDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadDepartamento));
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtCodigoDepartamento = new System.Windows.Forms.TextBox();
            this.txtDescricaoDepartamento = new System.Windows.Forms.TextBox();
            this.lblDescricaoDepartamento = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(61, 47);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(110, 13);
            this.lblDepartamento.TabIndex = 0;
            this.lblDepartamento.Text = "Codigo Departamento";
            // 
            // txtCodigoDepartamento
            // 
            this.txtCodigoDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoDepartamento.Enabled = false;
            this.txtCodigoDepartamento.Location = new System.Drawing.Point(187, 44);
            this.txtCodigoDepartamento.Name = "txtCodigoDepartamento";
            this.txtCodigoDepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDepartamento.TabIndex = 0;
            // 
            // txtDescricaoDepartamento
            // 
            this.txtDescricaoDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoDepartamento.Location = new System.Drawing.Point(187, 70);
            this.txtDescricaoDepartamento.MaxLength = 30;
            this.txtDescricaoDepartamento.Name = "txtDescricaoDepartamento";
            this.txtDescricaoDepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtDescricaoDepartamento.TabIndex = 1;
            // 
            // lblDescricaoDepartamento
            // 
            this.lblDescricaoDepartamento.AutoSize = true;
            this.lblDescricaoDepartamento.Location = new System.Drawing.Point(59, 73);
            this.lblDescricaoDepartamento.Name = "lblDescricaoDepartamento";
            this.lblDescricaoDepartamento.Size = new System.Drawing.Size(122, 13);
            this.lblDescricaoDepartamento.TabIndex = 2;
            this.lblDescricaoDepartamento.Text = "Descição Departamento";
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(63, 144);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(75, 23);
            this.btnConfirma.TabIndex = 2;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(144, 144);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(225, 144);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmCadDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(327, 195);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtDescricaoDepartamento);
            this.Controls.Add(this.lblDescricaoDepartamento);
            this.Controls.Add(this.txtCodigoDepartamento);
            this.Controls.Add(this.lblDepartamento);
            this.Name = "frmCadDepartamento";
            this.Text = "Cad Departamento";
            this.Load += new System.EventHandler(this.frmCadDepartamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtCodigoDepartamento;
        private System.Windows.Forms.TextBox txtDescricaoDepartamento;
        private System.Windows.Forms.Label lblDescricaoDepartamento;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
    }
}