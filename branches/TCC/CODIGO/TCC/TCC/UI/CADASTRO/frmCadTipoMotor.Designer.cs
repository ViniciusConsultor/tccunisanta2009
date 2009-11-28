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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadTipoMotor));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNmTipoMotor = new System.Windows.Forms.TextBox();
            this.lblNmTipoMotor = new System.Windows.Forms.Label();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnAceitar = new System.Windows.Forms.Button();
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.lblIdReal = new System.Windows.Forms.Label();
            this.txtIdReal = new Controles.MegaTextBox.MegaTextBox(this.components);
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(2, 79);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 23);
            this.btnVoltar.TabIndex = 6;
            this.toolTipLegenda.SetToolTip(this.btnVoltar, "Fechar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(2, 28);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(27, 23);
            this.btnLimpar.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtNmTipoMotor
            // 
            this.txtNmTipoMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNmTipoMotor.Location = new System.Drawing.Point(77, 100);
            this.txtNmTipoMotor.MaxLength = 500;
            this.txtNmTipoMotor.Multiline = true;
            this.txtNmTipoMotor.Name = "txtNmTipoMotor";
            this.txtNmTipoMotor.Size = new System.Drawing.Size(227, 61);
            this.txtNmTipoMotor.TabIndex = 2;
            // 
            // lblNmTipoMotor
            // 
            this.lblNmTipoMotor.AutoSize = true;
            this.lblNmTipoMotor.Location = new System.Drawing.Point(74, 84);
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
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(2, 4);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(27, 23);
            this.btnAceitar.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnAceitar, "Salvar");
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(2, 53);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaAlteracaoDelecao.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            // 
            // lblIdReal
            // 
            this.lblIdReal.AutoSize = true;
            this.lblIdReal.Location = new System.Drawing.Point(74, 35);
            this.lblIdReal.Name = "lblIdReal";
            this.lblIdReal.Size = new System.Drawing.Size(124, 13);
            this.lblIdReal.TabIndex = 19;
            this.lblIdReal.Text = "Código do Tipo do Motor";
            // 
            // txtIdReal
            // 
            this.txtIdReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdReal.Location = new System.Drawing.Point(77, 52);
            this.txtIdReal.Name = "txtIdReal";
            this.txtIdReal.Size = new System.Drawing.Size(227, 20);
            this.txtIdReal.TabIndex = 1;
            this.txtIdReal.TipoTexto = Controles.MegaTextBox.TipoTexto.SoLetra;
            // 
            // frmCadTipoMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(340, 220);
            this.ControlBox = false;
            this.Controls.Add(this.txtIdReal);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.lblIdReal);
            this.Controls.Add(this.txtNmTipoMotor);
            this.Controls.Add(this.lblNmTipoMotor);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAceitar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private Controles.MegaTextBox.MegaTextBox txtIdReal;
    }
}