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
    public partial class frmCadKitGrupoPeca : FormPai
    {
        #region Atributos
        List<mPeca> _modelPeca;
        mItemPeca _modelItemPeca;
        #endregion Atributos

        #region Construtor
        public frmCadKitGrupoPeca()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region Form Load
        private void frmCadKitGrupoPeca_Load(object sender, EventArgs e)
        {
        }
        #endregion Form Load
        
        #region btnLimpar Click
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelItemPeca = null;
            this._modelPeca = null;
        }
        #endregion btnLimpar Click

        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVoltar Click

        #region btnCdItemPeca Click
        private void btnCdItemPeca_Click(object sender, EventArgs e)
        {
            this._modelItemPeca = new mItemPeca();
            frmBuscaItemPeca objTela = new frmBuscaItemPeca(this._modelItemPeca);
            try
            {
                DialogResult resultado = objTela.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelItemPeca = null;
                }
                else
                {
                    //   this.txtCdItemPeca.Text = this._modelItemPeca.Nom_item_peca;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objTela = null;
            }
        }
        #endregion btnCdItemPeca Click

        #region btnAceitar Click
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnAceitar Click

        #endregion Eventos

        #region Metodos

        #region Insere
        /// <summary>
        /// Insere no banco os dados do model
        /// </summary>
        private void Insere()
        {
            mKitGrupoPeca model;
            rKitGrupoPeca regra = new rKitGrupoPeca();
            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                base.LimpaDadosTela(this);
            }
            catch (BUSINESS.Exceptions.CodigoItemPecaVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código do Item da Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscaItemPeca.Focus();
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
        #endregion Insere

        #region Valida Dados Nulos
        /// <summary>
        /// Valida os dados que não podem ser nulos na tela
        /// </summary>
        private void ValidaDadosNulos()
        {
            if (this._modelItemPeca == null)
            {
                throw new BUSINESS.Exceptions.CodigoItemPecaVazioException();
            }
            else if (this._modelPeca == null)
            {
                throw new BUSINESS.Exceptions.CodigoPecaVazioExeception();
            }
        }
        #endregion Valida Dados Nulos

        #region Pega Dados Tela
        /// <summary>
        /// Pega os dados da tela para popular um model
        /// </summary>
        /// <returns>Model populado</returns>
        private mKitGrupoPeca PegaDadosTela()
        {
            mKitGrupoPeca model = new mKitGrupoPeca();
            rKitGrupoPeca regra = new rKitGrupoPeca();

            try
            {
                model.Dat_alt = DateTime.Now;
                model.Flg_ativo = true;
                model.Nom_grupo = this.txtNmKit.Text;

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
        #endregion Pega Dados Tela 

        #endregion Metodos
    }
}
