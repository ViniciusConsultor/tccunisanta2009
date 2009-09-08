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
            this.lblcodigoEstoque.Location = new System.Drawing.Point(34, 34);
            this.lblcodigoEstoque.Name = "lblcodigoEstoque";
            this.lblcodigoEstoque.Size = new System.Drawing.Size(40, 13);
            this.lblcodigoEstoque.TabIndex = 0;
            this.lblcodigoEstoque.Text = "Codigo";
            // 
            // txtCdEstoque
            // 
            this.txtCdEstoque.Enabled = false;
            this.txtCdEstoque.Location = new System.Drawing.Point(80, 31);
            this.txtCdEstoque.Name = "txtCdEstoque";
            this.txtCdEstoque.Size = new System.Drawing.Size(100, 20);
            this.txtCdEstoque.TabIndex = 0;
            // 
            // txtCdDepartamento
            // 
            this.txtCdDepartamento.Enabled = false;
            this.txtCdDepartamento.Location = new System.Drawing.Point(325, 31);
            this.txtCdDepartamento.Name = "txtCdDepartamento";
            this.txtCdDepartamento.Size = new System.Drawing.Size(65, 20);
            this.txtCdDepartamento.TabIndex = 1;
            // 
            // lblCodigoDepartamento
            // 
            this.lblCodigoDepartamento.AutoSize = true;
            this.lblCodigoDepartamento.Location = new System.Drawing.Point(194, 34);
            this.lblCodigoDepartamento.Name = "lblCodigoDepartamento";
            this.lblCodigoDepartamento.Size = new System.Drawing.Size(125, 13);
            this.lblCodigoDepartamento.TabIndex = 2;
            this.lblCodigoDepartamento.Text = "Codigo do Departamento";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(80, 67);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(39, 70);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // btnInsere
            // 
            this.btnInsere.Location = new System.Drawing.Point(80, 117);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(75, 23);
            this.btnInsere.TabIndex = 3;
            this.btnInsere.Text = "Insere";
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Click += new System.EventHandler(this.btnInsere_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(197, 117);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 23);
            this.btnLimpa.TabIndex = 4;
            this.btnLimpa.Text = "Limpa";
            this.btnLimpa.UseVisualStyleBackColor = true;
            // 
            // btnVolta
            // 
            this.btnVolta.Location = new System.Drawing.Point(315, 117);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(75, 23);
            this.btnVolta.TabIndex = 5;
            this.btnVolta.Text = "Volta";
            this.btnVolta.UseVisualStyleBackColor = true;
            // 
            // btnBuscaDepartamento
            // 
            this.btnBuscaDepartamento.Location = new System.Drawing.Point(396, 29);
            this.btnBuscaDepartamento.Name = "btnBuscaDepartamento";
            this.btnBuscaDepartamento.Size = new System.Drawing.Size(25, 23);
            this.btnBuscaDepartamento.TabIndex = 6;
            this.btnBuscaDepartamento.Text = "...";
            this.btnBuscaDepartamento.UseVisualStyleBackColor = true;
            this.btnBuscaDepartamento.Click += new System.EventHandler(this.btnBuscaDepartamento_Click);
            // 
            // frmCadEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 174);
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