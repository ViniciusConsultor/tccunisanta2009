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
    public partial class frmCadVenda : FormPai
    {
        mCliente _modelCliente;
        mMotor _modelMotor;
        mOrdemProducao _modelOrdemProd;
        mTipoProduto _modelTipoProd;
        mKitGrupoPeca _modelKit;

        public frmCadVenda()
        {
            InitializeComponent();
            _modelCliente = new mCliente();
            _modelMotor = new mMotor();
            _modelOrdemProd = new mOrdemProducao();
            _modelTipoProd = new mTipoProduto();
            _modelKit = new mKitGrupoPeca();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this.BuscaIdMaximo();
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }


        protected override void BuscaIdMaximo()
        {
            rVenda regra = new rVenda();
            try
            {
                this.txtCdVenda.Text = regra.BuscaidMaximo();
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

        private void frmCadVenda_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }

        private mVenda PegaDadosTela()
        {
            mVenda model = new mVenda();
            try
            {
                model.DatVenda = Convert.ToDateTime(this.txtDataVenda.Text);
                model.DatSaida = DateTime.Now;
                model.IdCli = this._modelCliente.IdCliente;
                model.IdGrupo = this._modelKit.Id_grupo;
                model.IdMotor = this._modelMotor.IdMotor;
                model.IdOrdem = this._modelOrdemProd.Id_ordem;
                model.IdTipoProduto = this._modelTipoProd.IdTipoProd;
                model.IdVenda = Convert.ToInt32(this.txtCdVenda.Text);
                model.NotaFisc = this.txtNotaFiscal.Text;
                model.Qtd = Convert.ToInt32(this.txtQtdVenda.Text);
                model.Valor = Convert.ToDouble(this.txtValorVenda.Text);

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
            mVenda model = new mVenda();
            rVenda regra = new rVenda();
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

        private void btnCdCliente_Click(object sender, EventArgs e)
        {
            frmBuscaCliente objFrmCliente = new frmBuscaCliente(this._modelCliente);
            try
            {
                objFrmCliente.ShowDialog();
                this.txtCdCliente.Text = this._modelCliente.NomeCliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objFrmCliente = null;
            }
        }

        private void btnCdMotor_Click(object sender, EventArgs e)
        {
            frmBuscaMotor objFrmBuscaMotor = new frmBuscaMotor(this._modelMotor);
            try
            {
                objFrmBuscaMotor.ShowDialog();
                this.txtCdMotor.Text = this._modelMotor.DscMotor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objFrmBuscaMotor = null;
            }
        }

        private void btnCdOrdemMotor_Click(object sender, EventArgs e)
        {
            frmBuscaOrdemMotor objFrmOrdemMotor = new frmBuscaOrdemMotor(this._modelOrdemProd);
            try
            {
                objFrmOrdemMotor.ShowDialog();
                this.txtCdOrdemMotor.Text = this._modelOrdemProd.Dsc_ordem;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objFrmOrdemMotor = null;
            }
        }

        private void btnCdKit_Click(object sender, EventArgs e)
        {
            frmBuscaKit frmForm = new frmBuscaKit(this._modelKit);
            try
            {
                frmForm.ShowDialog();
                this.txtCdKit.Text = this._modelKit.Nom_grupo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                frmForm = null;
            }
        }

        private void CdTipoProduto_Click(object sender, EventArgs e)
        {
            frmBuscaTipoProduto objForm = new frmBuscaTipoProduto(this._modelTipoProd);
            try
            {
                objForm.ShowDialog();
                this.txtCdTipoProduto.Text = this._modelTipoProd.Nom;
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