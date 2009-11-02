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
        List<mPeca> _modelPeca;
        mItemPeca _modelItemPeca;

        public frmCadKitGrupoPeca()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelItemPeca = null;
            this._modelPeca = null;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

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

        /*protected override void BuscaIdMaximo()
        {
            rKitGrupoPeca regra = new rKitGrupoPeca();
            try
            {
                this.txtCdKit.Text = regra.BuscaIdMaximo();
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

        private void frmCadKitGrupoPeca_Load(object sender, EventArgs e)
        {
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Insere();
        }

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
            }
            catch (BUSINESS.Exceptions.CodigoPecaVazioExeception)
            {
                MessageBox.Show("É Necessário Buscar o código da Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
    }
}
