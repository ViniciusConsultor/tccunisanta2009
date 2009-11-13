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
            this.components = new System.ComponentModel.Container();
            this.txtCdDepartamento = new System.Windows.Forms.TextBox();
            this.lblCodigoDepartamento = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnBuscaDepartamento = new System.Windows.Forms.Button();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnInsere = new System.Windows.Forms.Button();
            this.btnBuscaAlteracaoDelecao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbDefeitoNao = new System.Windows.Forms.RadioButton();
            this.rdbDefeitoSim = new System.Windows.Forms.RadioButton();
            this.lblEstoqDefeito = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCdDepartamento
            // 
            this.txtCdDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdDepartamento.Enabled = false;
            this.txtCdDepartamento.Location = new System.Drawing.Point(84, 41);
            this.txtCdDepartamento.MaxLength = 15;
            this.txtCdDepartamento.Name = "txtCdDepartamento";
            this.txtCdDepartamento.ReadOnly = true;
            this.txtCdDepartamento.Size = new System.Drawing.Size(172, 20);
            this.txtCdDepartamento.TabIndex = 0;
            this.txtCdDepartamento.TabStop = false;
            // 
            // lblCodigoDepartamento
            // 
            this.lblCodigoDepartamento.AutoSize = true;
            this.lblCodigoDepartamento.Location = new System.Drawing.Point(81, 20);
            this.lblCodigoDepartamento.Name = "lblCodigoDepartamento";
            this.lblCodigoDepartamento.Size = new System.Drawing.Size(131, 13);
            this.lblCodigoDepartamento.TabIndex = 2;
            this.lblCodigoDepartamento.Text = "Departamento do Estoque";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(84, 88);
            this.txtNome.MaxLength = 100;
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(205, 62);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(81, 72);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackgroundImage = global::TCC.resImg.btnLimpa;
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpa.Location = new System.Drawing.Point(1, 28);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(30, 25);
            this.btnLimpa.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnLimpa, "Limpar");
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolta.Location = new System.Drawing.Point(1, 82);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(30, 25);
            this.btnVolta.TabIndex = 5;
            this.toolTipLegenda.SetToolTip(this.btnVolta, "Fechar");
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // btnBuscaDepartamento
            // 
            this.btnBuscaDepartamento.BackgroundImage = global::TCC.resImg.btnBusca;
            this.btnBuscaDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaDepartamento.Location = new System.Drawing.Point(262, 35);
            this.btnBuscaDepartamento.Name = "btnBuscaDepartamento";
            this.btnBuscaDepartamento.Size = new System.Drawing.Size(27, 27);
            this.btnBuscaDepartamento.TabIndex = 1;
            this.toolTipLegenda.SetToolTip(this.btnBuscaDepartamento, "Buscar Departamento Responsável");
            this.btnBuscaDepartamento.UseVisualStyleBackColor = true;
            this.btnBuscaDepartamento.Click += new System.EventHandler(this.btnBuscaDepartamento_Click);
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // btnInsere
            // 
            this.btnInsere.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnInsere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsere.Location = new System.Drawing.Point(1, 2);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(30, 25);
            this.btnInsere.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnInsere, "Cadastrar");
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Click += new System.EventHandler(this.btnInsere_Click);
            // 
            // btnBuscaAlteracaoDelecao
            // 
            this.btnBuscaAlteracaoDelecao.BackgroundImage = global::TCC.resImg.btnalterar;
            this.btnBuscaAlteracaoDelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAlteracaoDelecao.Location = new System.Drawing.Point(1, 54);
            this.btnBuscaAlteracaoDelecao.Name = "btnBuscaAlteracaoDelecao";
            this.btnBuscaAlteracaoDelecao.Size = new System.Drawing.Size(30, 25);
            this.btnBuscaAlteracaoDelecao.TabIndex = 18;
            this.toolTipLegenda.SetToolTip(this.btnBuscaAlteracaoDelecao, "Alterar Registro");
            this.btnBuscaAlteracaoDelecao.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbDefeitoNao);
            this.panel1.Controls.Add(this.rdbDefeitoSim);
            this.panel1.Controls.Add(this.lblEstoqDefeito);
            this.panel1.Location = new System.Drawing.Point(84, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 68);
            this.panel1.TabIndex = 19;
            // 
            // rdbDefeitoNao
            // 
            this.rdbDefeitoNao.AutoSize = true;
            this.rdbDefeitoNao.Location = new System.Drawing.Point(103, 36);
            this.rdbDefeitoNao.Name = "rdbDefeitoNao";
            this.rdbDefeitoNao.Size = new System.Drawing.Size(45, 17);
            this.rdbDefeitoNao.TabIndex = 11;
            this.rdbDefeitoNao.TabStop = true;
            this.rdbDefeitoNao.Text = "Não";
            this.rdbDefeitoNao.UseVisualStyleBackColor = true;
            // 
            // rdbDefeitoSim
            // 
            this.rdbDefeitoSim.AutoSize = true;
            this.rdbDefeitoSim.Location = new System.Drawing.Point(49, 36);
            this.rdbDefeitoSim.Name = "rdbDefeitoSim";
            this.rdbDefeitoSim.Size = new System.Drawing.Size(42, 17);
            this.rdbDefeitoSim.TabIndex = 10;
            this.rdbDefeitoSim.TabStop = true;
            this.rdbDefeitoSim.Text = "Sim";
            this.rdbDefeitoSim.UseVisualStyleBackColor = true;
            // 
            // lblEstoqDefeito
            // 
            this.lblEstoqDefeito.AutoSize = true;
            this.lblEstoqDefeito.Location = new System.Drawing.Point(23, 15);
            this.lblEstoqDefeito.Name = "lblEstoqDefeito";
            this.lblEstoqDefeito.Size = new System.Drawing.Size(158, 13);
            this.lblEstoqDefeito.TabIndex = 9;
            this.lblEstoqDefeito.Text = "Estoque de peças Defeituosas?";
            // 
            // frmCadEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 243);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscaAlteracaoDelecao);
            this.Controls.Add(this.btnBuscaDepartamento);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnInsere);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCdDepartamento);
            this.Controls.Add(this.lblCodigoDepartamento);
            this.MaximizeBox = false;
            this.Name = "frmCadEstoque";
            this.Text = "Cadastro de Estoques";
            this.Load += new System.EventHandler(this.frmCadEstoque_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCdDepartamento;
        private System.Windows.Forms.Label lblCodigoDepartamento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnInsere;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnBuscaDepartamento;
        private System.Windows.Forms.ToolTip toolTipLegenda;
        private System.Windows.Forms.Button btnBuscaAlteracaoDelecao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbDefeitoNao;
        private System.Windows.Forms.RadioButton rdbDefeitoSim;
        private System.Windows.Forms.Label lblEstoqDefeito;
    }
}