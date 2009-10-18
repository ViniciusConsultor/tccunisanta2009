namespace TCC.UI
{
    partial class frmCadEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadEstoque));
            this.lblcodigoEstoque = new System.Windows.Forms.Label();
            this.txtCdEstoque = new System.Windows.Forms.TextBox();
            this.txtCdDepartamento = new System.Windows.Forms.TextBox();
            this.lblCodigoDepartamento = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnInsere = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnBuscaDepartamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcodigoEstoque
            // 
            this.lblcodigoEstoque.AutoSize = true;
            this.lblcodigoEstoque.Location = new System.Drawing.Point(67, 30);
            this.lblcodigoEstoque.Name = "lblcodigoEstoque";
            this.lblcodigoEstoque.Size = new System.Drawing.Size(40, 13);
            this.lblcodigoEstoque.TabIndex = 0;
            this.lblcodigoEstoque.Text = "Codigo";
            // 
            // txtCdEstoque
            // 
            this.txtCdEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdEstoque.Enabled = false;
            this.txtCdEstoque.Location = new System.Drawing.Point(113, 27);
            this.txtCdEstoque.Name = "txtCdEstoque";
            this.txtCdEstoque.Size = new System.Drawing.Size(100, 20);
            this.txtCdEstoque.TabIndex = 0;
            // 
            // txtCdDepartamento
            // 
            this.txtCdDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdDepartamento.Enabled = false;
            this.txtCdDepartamento.Location = new System.Drawing.Point(358, 27);
            this.txtCdDepartamento.Name = "txtCdDepartamento";
            this.txtCdDepartamento.Size = new System.Drawing.Size(65, 20);
            this.txtCdDepartamento.TabIndex = 0;
            // 
            // lblCodigoDepartamento
            // 
            this.lblCodigoDepartamento.AutoSize = true;
            this.lblCodigoDepartamento.Location = new System.Drawing.Point(227, 30);
            this.lblCodigoDepartamento.Name = "lblCodigoDepartamento";
            this.lblCodigoDepartamento.Size = new System.Drawing.Size(125, 13);
            this.lblCodigoDepartamento.TabIndex = 2;
            this.lblCodigoDepartamento.Text = "Codigo do Departamento";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(113, 63);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(341, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(72, 66);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // btnInsere
            // 
            this.btnInsere.Location = new System.Drawing.Point(217, 113);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(75, 23);
            this.btnInsere.TabIndex = 3;
            this.btnInsere.Text = "Confirmar";
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Click += new System.EventHandler(this.btnInsere_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(298, 113);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 23);
            this.btnLimpa.TabIndex = 4;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolta.BackgroundImage")));
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(2, 2);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(39, 23);
            this.btnVolta.TabIndex = 5;
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // btnBuscaDepartamento
            // 
            this.btnBuscaDepartamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaDepartamento.BackgroundImage")));
            this.btnBuscaDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaDepartamento.Location = new System.Drawing.Point(429, 25);
            this.btnBuscaDepartamento.Name = "btnBuscaDepartamento";
            this.btnBuscaDepartamento.Size = new System.Drawing.Size(25, 23);
            this.btnBuscaDepartamento.TabIndex = 1;
            this.btnBuscaDepartamento.UseVisualStyleBackColor = true;
            this.btnBuscaDepartamento.Click += new System.EventHandler(this.btnBuscaDepartamento_Click);
            // 
            // frmCadEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 167);
            this.Controls.Add(this.btnBuscaDepartamento);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnInsere);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCdDepartamento);
            this.Controls.Add(this.lblCodigoDepartamento);
            this.Controls.Add(this.txtCdEstoque);
            this.Controls.Add(this.lblcodigoEstoque);
            this.Name = "frmCadEstoque";
            this.Text = "Cadastro de Estoque";
            this.Load += new System.EventHandler(this.frmCadEstoque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigoEstoque;
        private System.Windows.Forms.TextBox txtCdEstoque;
        private System.Windows.Forms.TextBox txtCdDepartamento;
        private System.Windows.Forms.Label lblCodigoDepartamento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnInsere;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnBuscaDepartamento;
    }
}