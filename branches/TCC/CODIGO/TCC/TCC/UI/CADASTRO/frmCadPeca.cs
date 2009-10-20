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
    public partial class frmCadPeca : FormPai
    {
        mEstoque _modelEstoque;
        mTipoPeca _modelTipoPeca;
        public frmCadPeca()
        {
            InitializeComponent();
            _modelEstoque = new mEstoque();
            _modelTipoPeca = new mTipoPeca();
        }

        protected override void  BuscaIdMaximo()
        {
            rPeca regra = new rPeca();
            try
            {
                this.txtCdPeca.Text = regra.BuscaIdMaximoPeca();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnCdTipoPeca_Click(object sender, EventArgs e)
        {
            frmBuscaTipoPeca objTela = new frmBuscaTipoPeca(_modelTipoPeca);
            try
            {
                objTela.ShowDialog();
                this.txtCdTipoPeca.Text = this._modelTipoPeca.DscTipoPeca;
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

        private void btnCdEstoque_Click(object sender, EventArgs e)
        {
            frmBuscaEstoque objTela = new frmBuscaEstoque(_modelEstoque);
            try
            {
                objTela.ShowDialog();
                this.txtCdEstoque.Text = this._modelEstoque.Dsc_estoque;
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

        private void frmCadPeca_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this.BuscaIdMaximo();
        }

        private mPeca PegaDadosTela()
        {
            mPeca model = new mPeca();
            try
            {
                model.DatAlt = DateTime.Now;
                model.DscPeca = this.txtDsPeca.Text;
                model.FlgAtivo = true;
                model.IdEstoque = this._modelEstoque.Id_estoque;
                model.IdPeca = Convert.ToInt32(this.txtCdPeca.Text);
                model.IdPecaReal = this.txtCodigoReal.Text;
                model.IdTipoPeca = this._modelTipoPeca.IdTipoPeca;
                model.Nom = this.txtNmPeca.Text;
                model.Peso = Convert.ToInt32(this.txtPesoPeca.Text);
                model.QtdMin = Convert.ToInt32(this.txtQtdPeca.Text);

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

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
        }

        private void Insere()
        {
            mPeca model;
            rPeca regra = new rPeca();
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
    }
}
