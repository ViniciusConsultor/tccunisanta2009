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

        public frmCadVenda()
        {
            InitializeComponent();
            _modelCliente = new mCliente();
            _modelMotor = new mMotor();
            _modelOrdemProd = new mOrdemProducao();
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
                model.IdCli = this._modelCliente.IdCliente;
                model.IdGrupo = Convert.ToInt32(this.txtCdKit.Text);
                model.IdMotor = this._modelMotor.IdMotor;
                model.IdOrdem = Convert.ToInt32(this.txtCdOrdemMotor.Text);
                model.IdTipoProduto = Convert.ToInt32(this.txtCdTipoProduto.Text);
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

        }
    }
}