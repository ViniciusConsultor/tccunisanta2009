namespace TCC.UI.Resumo
{
    partial class frmResumoOrdemProducao
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
            this.tvOrdemProducao = new System.Windows.Forms.TreeView();
            this.btnGerarArquivo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvOrdemProducao
            // 
            this.tvOrdemProducao.Location = new System.Drawing.Point(16, 15);
            this.tvOrdemProducao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tvOrdemProducao.Name = "tvOrdemProducao";
            this.tvOrdemProducao.Size = new System.Drawing.Size(367, 293);
            this.tvOrdemProducao.TabIndex = 0;
            // 
            // btnGerarArquivo
            // 
            this.btnGerarArquivo.Location = new System.Drawing.Point(17, 322);
            this.btnGerarArquivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGerarArquivo.Name = "btnGerarArquivo";
            this.btnGerarArquivo.Size = new System.Drawing.Size(147, 28);
            this.btnGerarArquivo.TabIndex = 1;
            this.btnGerarArquivo.Text = "Gerar Arquivo";
            this.btnGerarArquivo.UseVisualStyleBackColor = true;
            this.btnGerarArquivo.Click += new System.EventHandler(this.btnGerarArquivo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(284, 322);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 28);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmResumoOrdemProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 415);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnGerarArquivo);
            this.Controls.Add(this.tvOrdemProducao);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmResumoOrdemProducao";
            this.Text = "frmResumoOrdemProducao";
            this.Load += new System.EventHandler(this.frmResumoOrdemProducao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvOrdemProducao;
        private System.Windows.Forms.Button btnGerarArquivo;
        private System.Windows.Forms.Button btnVoltar;
    }
}