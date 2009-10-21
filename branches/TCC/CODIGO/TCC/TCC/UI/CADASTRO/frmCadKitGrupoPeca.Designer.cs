﻿namespace TCC.UI
{
    partial class frmCadKitGrupoPeca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadKitGrupoPeca));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.txtCdKit = new System.Windows.Forms.TextBox();
            this.lblCdKit = new System.Windows.Forms.Label();
            this.txtCdItemPeca = new System.Windows.Forms.TextBox();
            this.lblCdItemPeca = new System.Windows.Forms.Label();
            this.txtCdPeca = new System.Windows.Forms.TextBox();
            this.lblCdPeca = new System.Windows.Forms.Label();
            this.txtNmKit = new System.Windows.Forms.TextBox();
            this.lblNmKit = new System.Windows.Forms.Label();
            this.btnCdPeca = new System.Windows.Forms.Button();
            this.btnCdItemPeca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(2, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(32, 23);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(2, 24);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(32, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAceitar
            // 
            this.btnAceitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceitar.BackgroundImage")));
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.Location = new System.Drawing.Point(2, 46);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(32, 23);
            this.btnAceitar.TabIndex = 11;
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // txtCdKit
            // 
            this.txtCdKit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdKit.Location = new System.Drawing.Point(145, 27);
            this.txtCdKit.Name = "txtCdKit";
            this.txtCdKit.ReadOnly = true;
            this.txtCdKit.Size = new System.Drawing.Size(53, 20);
            this.txtCdKit.TabIndex = 14;
            // 
            // lblCdKit
            // 
            this.lblCdKit.AutoSize = true;
            this.lblCdKit.Location = new System.Drawing.Point(56, 30);
            this.lblCdKit.Name = "lblCdKit";
            this.lblCdKit.Size = new System.Drawing.Size(70, 13);
            this.lblCdKit.TabIndex = 15;
            this.lblCdKit.Text = "Codigo do Kit";
            // 
            // txtCdItemPeca
            // 
            this.txtCdItemPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdItemPeca.Location = new System.Drawing.Point(337, 27);
            this.txtCdItemPeca.Name = "txtCdItemPeca";
            this.txtCdItemPeca.ReadOnly = true;
            this.txtCdItemPeca.Size = new System.Drawing.Size(32, 20);
            this.txtCdItemPeca.TabIndex = 14;
            // 
            // lblCdItemPeca
            // 
            this.lblCdItemPeca.AutoSize = true;
            this.lblCdItemPeca.Location = new System.Drawing.Point(215, 30);
            this.lblCdItemPeca.Name = "lblCdItemPeca";
            this.lblCdItemPeca.Size = new System.Drawing.Size(109, 13);
            this.lblCdItemPeca.TabIndex = 15;
            this.lblCdItemPeca.Text = "Codigo do Item Peca ";
            // 
            // txtCdPeca
            // 
            this.txtCdPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdPeca.Location = new System.Drawing.Point(145, 61);
            this.txtCdPeca.Name = "txtCdPeca";
            this.txtCdPeca.ReadOnly = true;
            this.txtCdPeca.Size = new System.Drawing.Size(35, 20);
            this.txtCdPeca.TabIndex = 14;
            // 
            // lblCdPeca
            // 
            this.lblCdPeca.AutoSize = true;
            this.lblCdPeca.Location = new System.Drawing.Point(56, 64);
            this.lblCdPeca.Name = "lblCdPeca";
            this.lblCdPeca.Size = new System.Drawing.Size(83, 13);
            this.lblCdPeca.TabIndex = 15;
            this.lblCdPeca.Text = "Codigo da Peça";
            // 
            // txtNmKit
            // 
            this.txtNmKit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNmKit.Location = new System.Drawing.Point(337, 64);
            this.txtNmKit.Name = "txtNmKit";
            this.txtNmKit.Size = new System.Drawing.Size(53, 20);
            this.txtNmKit.TabIndex = 14;
            // 
            // lblNmKit
            // 
            this.lblNmKit.AutoSize = true;
            this.lblNmKit.Location = new System.Drawing.Point(215, 67);
            this.lblNmKit.Name = "lblNmKit";
            this.lblNmKit.Size = new System.Drawing.Size(65, 13);
            this.lblNmKit.TabIndex = 15;
            this.lblNmKit.Text = "Nome do Kit";
            // 
            // btnCdPeca
            // 
            this.btnCdPeca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCdPeca.BackgroundImage")));
            this.btnCdPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdPeca.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnCdPeca.Location = new System.Drawing.Point(186, 59);
            this.btnCdPeca.Name = "btnCdPeca";
            this.btnCdPeca.Size = new System.Drawing.Size(28, 23);
            this.btnCdPeca.TabIndex = 11;
            this.btnCdPeca.UseVisualStyleBackColor = true;
            this.btnCdPeca.Click += new System.EventHandler(this.btnCdPeca_Click);
            // 
            // btnCdItemPeca
            // 
            this.btnCdItemPeca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCdItemPeca.BackgroundImage")));
            this.btnCdItemPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCdItemPeca.Location = new System.Drawing.Point(375, 25);
            this.btnCdItemPeca.Name = "btnCdItemPeca";
            this.btnCdItemPeca.Size = new System.Drawing.Size(28, 23);
            this.btnCdItemPeca.TabIndex = 11;
            this.btnCdItemPeca.UseVisualStyleBackColor = true;
            this.btnCdItemPeca.Click += new System.EventHandler(this.btnCdItemPeca_Click);
            // 
            // frmCadKitGrupoPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 149);
            this.ControlBox = false;
            this.Controls.Add(this.lblNmKit);
            this.Controls.Add(this.txtNmKit);
            this.Controls.Add(this.lblCdPeca);
            this.Controls.Add(this.txtCdPeca);
            this.Controls.Add(this.lblCdItemPeca);
            this.Controls.Add(this.txtCdItemPeca);
            this.Controls.Add(this.lblCdKit);
            this.Controls.Add(this.txtCdKit);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCdItemPeca);
            this.Controls.Add(this.btnCdPeca);
            this.Controls.Add(this.btnAceitar);
            this.MaximizeBox = false;
            this.Name = "frmCadKitGrupoPeca";
            this.Text = "KitGrupoPeca";
            this.Load += new System.EventHandler(this.frmCadKitGrupoPeca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.TextBox txtCdKit;
        private System.Windows.Forms.Label lblCdKit;
        private System.Windows.Forms.TextBox txtCdItemPeca;
        private System.Windows.Forms.Label lblCdItemPeca;
        private System.Windows.Forms.TextBox txtCdPeca;
        private System.Windows.Forms.Label lblCdPeca;
        private System.Windows.Forms.TextBox txtNmKit;
        private System.Windows.Forms.Label lblNmKit;
        private System.Windows.Forms.Button btnCdPeca;
        private System.Windows.Forms.Button btnCdItemPeca;
    }
}