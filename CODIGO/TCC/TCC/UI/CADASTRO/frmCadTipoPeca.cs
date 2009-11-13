using System;
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
    public partial class frmCadTipoPeca : FormPai
    {
        #region Atributos
        mTipoPeca _mtipoPeca;
        #endregion Atributos

        #region Construtor
        public frmCadTipoPeca()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVoltar Click

        #region btnLimpar Click
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
        }
        #endregion btnLimpar Click

        #region btnAceitar Click
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Inserir();
        }
        #endregion btnAceitar Click

        #region txtDsTipoPeca TextChanged
        private void txtDsTipoPeca_TextChanged(object sender, EventArgs e)
        {
            this.btnAceitar.Enabled = true;
        }
        #endregion txtDsTipoPeca TextChanged

        #endregion Eventos

        #region Metodos

        #region LimparCampos
        private void LimparCampos()
        {
            try
            {
                foreach (Control controle in this.Controls)
                {
                    if (controle.GetType().Equals(new TextBox().GetType()) == true)
                    {
                        controle.Text = string.Empty;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion LimparCampos

        #region PegaDadosTela
        private mTipoPeca PegaDadosTela()
        {
            mTipoPeca model = new mTipoPeca();
            rTipoPeca regra = new rTipoPeca();
            try
            {
                model.IdTipoPeca = regra.BuscaIdMaximo();
                model.DscTipoPeca = this.txtDsTipoPeca.Text;
                model.FlgAtivo = true;

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
        #endregion PegaDadosTela

        #region Inserir
        public void Inserir()
        {
            mTipoPeca model = null;
            rTipoPeca regra = new rTipoPeca();
            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                this.LimparCampos();
                this.btnAceitar.Enabled = false;
            }
            catch (BUSINESS.Exceptions.TipoPeca.tipoPecaVazioExeption)
            {
                MessageBox.Show("Preencher o campo Descrição do tipo de Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDsTipoPeca.Focus();
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
        #endregion Inserir

        #region ValidaDadosNulos
        public void ValidaDadosNulos()
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtDsTipoPeca.Text) == true)
                {
                    throw new BUSINESS.Exceptions.TipoPeca.tipoPecaVazioExeption();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion ValidaDadosNulos

        #endregion Metodos
    }
}
