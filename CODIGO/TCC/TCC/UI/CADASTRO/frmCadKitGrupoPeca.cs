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
        mPeca _modelPeca;
        mItemPeca _modelItemPeca;

        public frmCadKitGrupoPeca()
        {
            InitializeComponent();
            _modelPeca = new mPeca();
            _modelItemPeca = new mItemPeca();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this.BuscaIdMaximo();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnCdPeca_Click(object sender, EventArgs e)
        {
            frmBuscaPeca objFrmPeca = new frmBuscaPeca(this._modelPeca);
            try
            {
                objFrmPeca.ShowDialog();
                this.txtCdPeca.Text = this._modelPeca.Nom;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objFrmPeca = null;
            }
        }

        private void btnCdItemPeca_Click(object sender, EventArgs e)
        {
            frmBuscaItemPeca objTela = new frmBuscaItemPeca(this._modelItemPeca);
            try
            {
                objTela.ShowDialog();
                this.txtCdItemPeca.Text = this._modelItemPeca.Nom_item_peca;
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

        protected override void BuscaIdMaximo()
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
        }

        private void frmCadKitGrupoPeca_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
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
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                base.LimpaDadosTela(this);
                this.BuscaIdMaximo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                model = null;
                regra = null;
            }
        }

        private mKitGrupoPeca PegaDadosTela()
        {
            mKitGrupoPeca model = new mKitGrupoPeca();
            try
            {
                model.Dat_alt = DateTime.Now;
                model.Flg_ativo = true;
                model.Id_grupo = Convert.ToInt32(this.txtCdKit.Text);
                model.Id_item_peca = this._modelItemPeca.Id_item_peca;
                model.Id_peca = this._modelPeca.IdPeca;
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
