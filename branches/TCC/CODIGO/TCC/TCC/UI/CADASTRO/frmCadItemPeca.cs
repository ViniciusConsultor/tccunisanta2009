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
    public partial class frmCadItemPeca : FormPai
    {
        mPeca _modelPeca;

        public frmCadItemPeca()
        {
            InitializeComponent();
            _modelPeca = new mPeca();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
        }

        private void Insere()
        {
            mItemPeca model;
            rItemPeca regra = new rItemPeca();
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

        private mItemPeca PegaDadosTela()
        {
            mItemPeca model = new mItemPeca();
            try
            {
                model.Flg_ativo = true;
                model.Id_item_peca = Convert.ToInt32(this.txtCodItemPeca.Text);
                model.Id_peca = this._modelPeca.IdPeca;
                model.Nom_item_peca = this.txtDescItemPeca.Text;

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

        private void btnVolta_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this.BuscaIdMaximo();
        }

        protected override void BuscaIdMaximo()
        {
            rItemPeca regra = new rItemPeca();
            try
            {
                this.txtCodItemPeca.Text = regra.BuscaIdMaximo();
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

        private void btnBuscaPeca_Click(object sender, EventArgs e)
        {
            frmBuscaPeca frmTela = new frmBuscaPeca(this._modelPeca);
            try
            {
                frmTela.ShowDialog();
                this.txtCodigoPeca.Text = this._modelPeca.Nom;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                frmTela = null;
            }
        }

        private void frmCadItemPeca_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }
    }
} 