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
    public partial class frmCadCompraPeca : FormPai
    {
        mCompra _modelCompra;
        mPeca _modelPeca;

        public frmCadCompraPeca()
        {
            InitializeComponent();
            _modelCompra = new mCompra();
            _modelPeca = new mPeca();
        }

        protected override void BuscaIdMaximo()
        {
            base.BuscaIdMaximo();
        }

        private void frmCadCompraPeca_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }

        private void btnBuscaPeca_Click(object sender, EventArgs e)
        {
            frmBuscaPeca objForm = new frmBuscaPeca(this._modelPeca);
            try
            {
                objForm.ShowDialog();
                this.txtCdPeca.Text = this._modelPeca.Nom;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
        }

        private void Insere()
        {
            mCompraPeca model;
            rCompraPeca regra = new rCompraPeca();
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

        private mCompraPeca PegaDadosTela()
        {
            mCompraPeca model = new mCompraPeca();
            try
            {
                model.IdCompra = this._modelCompra.IdCompra;
                model.IdPeca = this._modelPeca.IdPeca;
                model.UltimoPreco = Convert.ToDouble(this.txtUltimoPreco.Text);

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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnBuscaCompra_Click(object sender, EventArgs e)
        {
            frmBuscaCompra objForm = new frmBuscaCompra(this._modelCompra);
            try
            {
                objForm.ShowDialog();
                this.txtCdCompra.Text = this._modelCompra.IdCompra.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objForm = null;
            }
        }
    }
}