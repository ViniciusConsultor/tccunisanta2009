﻿namespace TCC.UI
{
    partial class frmCadTipoProduto
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDscNome = new System.Windows.Forms.Label();
            this.toolTipLegenda = new System.Windows.Forms.ToolTip(this.components);
            this.btnConfirma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = global::TCC.resImg.btnVoltar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(3, 78);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(36, 28);
            this.btnFechar.TabIndex = 4;
            this.toolTipLegenda.SetToolTip(this.btnFechar, "Fechar");
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::TCC.resImg.btnLimpa;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(3, 42);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(36, 28);
            this.btnLimpar.TabIndex = 3;
            this.toolTipLegenda.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(100, 92);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.MaxLength = 100;
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(311, 98);
            this.txtNome.TabIndex = 1;
            // 
            // lblDscNome
            // 
            this.lblDscNome.AutoSize = true;
            this.lblDscNome.Location = new System.Drawing.Point(96, 73);
            this.lblDscNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDscNome.Name = "lblDscNome";
            this.lblDscNome.Size = new System.Drawing.Size(71, 17);
            this.lblDscNome.TabIndex = 5;
            this.lblDscNome.Text = "Descrição";
            // 
            // toolTipLegenda
            // 
            this.toolTipLegenda.BackColor = System.Drawing.Color.LightGray;
            this.toolTipLegenda.ForeColor = System.Drawing.Color.Black;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = global::TCC.resImg.btnSalvar;
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(3, 6);
            this.btnConfirma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(36, 28);
            this.btnConfirma.TabIndex = 2;
            this.toolTipLegenda.SetToolTip(this.btnConfirma, "Salvar");
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // frmCadTipoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.resImg.bg_telas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 324);
            this.ControlBox = false;
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblDscNome);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "frmCadTipoProduto";
            this.Text = "Tipo de Produto";
            this.Load += new System.EventHandler(this.frmCadTipoProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDscNome;
        private System.Windows.Forms.ToolTip toolTipLegenda;
    }
}