﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;
using TCC.MODEL;

namespace TCC.UI
{
    public partial class frmCadTipoProduto : FormPai
    {
        public frmCadTipoProduto()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
        }

        /*protected override void BuscaIdMaximo()
        {
            rTipoProduto regra = new rTipoProduto();
            try
            {
                this.txtCodigo.Text = regra.BuscaIdMaximo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
            }
        }*/

        private void frmCadTipoProduto_Load(object sender, EventArgs e)
        {
        }

        private mTipoProduto PegaDadosTela()
        {
            mTipoProduto model = new mTipoProduto();
            rTipoProduto regra = new rTipoProduto();
            try
            {
                model.DatAlt = DateTime.Now;
                model.FlgAtivo = true;
                model.Nom = this.txtNome.Text;

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                model = null;
            }
        }

        private void Insere()
        {
            mTipoProduto model;
            rTipoProduto regra = new rTipoProduto();
            try
            {
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                base.LimpaDadosTela(this);
                MessageBox.Show("Registro Salvo com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                model = null;
                regra = null;
            }
        }
    }
}
