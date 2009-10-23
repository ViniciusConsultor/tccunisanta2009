using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using TCC.BUSINESS;
using System.Windows.Forms;
using TCC.MODEL;

namespace TCC.UI
{
    public partial class frmCadCompra : FormPai
    {
        mMotor _modelMotor;
        mDepartamento _modelDepartamento;
        mFornecedor _modelFornecedor;
        mPeca _modelPeca;
        mTipoProduto _modelTipoProd;

        public frmCadCompra()
        {
            InitializeComponent();
        }

        private void frmCadCompra_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }

        protected override void BuscaIdMaximo()
        {
            rCompra regraCompra = new rCompra();
            try
            {
                this.txtCdCompra.Text = regraCompra.BuscaIdMaximoCompra();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraCompra = null;
            }
        }

        private void btnBuscaMotorCompra_Click(object sender, EventArgs e)
        {
            this._modelMotor = new mMotor();
            frmBuscaMotor objFrmMotor = new frmBuscaMotor(_modelMotor);
            try
            {
                DialogResult resultado = objFrmMotor.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelMotor = null;
                }
                else
                {
                    this.txtCdMotorCompra.Text = this._modelMotor.DscMotor;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objFrmMotor = null;
            }
        }

        private void btnBuscaDepartamento_Click(object sender, EventArgs e)
        {
            this._modelDepartamento = new mDepartamento();
            frmBuscaDepartamento objTela = new frmBuscaDepartamento(_modelDepartamento);
            try
            {
                DialogResult resultado = objTela.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelDepartamento = null;
                }
                else
                {
                    this.txtDepartamento.Text = this._modelDepartamento.DscDepto;
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

        private void btnBuscaFornecedor_Click(object sender, EventArgs e)
        {
            _modelFornecedor = new mFornecedor();
            frmBuscaFornecedor objTela = new frmBuscaFornecedor(_modelFornecedor);
            try
            {
                DialogResult resultado = objTela.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelFornecedor = null;
                }
                else
                {
                    this.txtCdFornecedor.Text = this._modelFornecedor.NomeFornecedor;
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this.BuscaIdMaximo();
        }

        private void btnBuscaPeca_Click(object sender, EventArgs e)
        {
            this._modelPeca = new mPeca();
            frmBuscaPeca objForm = new frmBuscaPeca(this._modelPeca);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelPeca = null;
                }
                else
                {
                    this.txtCdPeca.Text = this._modelPeca.Nom;
                }
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

        private void btnBuscaTipoProduto_Click(object sender, EventArgs e)
        {
            this._modelTipoProd = new mTipoProduto();
            frmBuscaTipoProduto objForm = new frmBuscaTipoProduto(this._modelTipoProd);
            try
            { 
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelTipoProd = null;
                }
                else
                {
                    this.txtCdTipoProduto.Text = this._modelTipoProd.Nom;
                }
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

        private void Insere()
        {
            mCompra model;
            rCompra regra = new rCompra();
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

        private mCompra PegaDadosTela()
        {
            mCompra model = new mCompra();
            try
            {
                model.Dat = Convert.ToDateTime(this.txtDataCompra.Text);
                model.IdCompra = Convert.ToInt32(this.txtCdCompra.Text);
                model.IdDepto = this._modelDepartamento.IdDepto;
                model.IdFornecedor = this._modelFornecedor.IdFornecedor;
                model.IdMotorCompra = this._modelMotor.IdMotor;
                model.IdTipoProduto = this._modelTipoProd.IdTipoProd;
                model.NotaFiscal = this.txtNotaFiscal.Text;
                model.Obs = this.txtObservacao.Text;
                model.Qtd = Convert.ToInt32(this.txtQtdCompra.Text);
                model.Valor = Convert.ToDouble(this.txtVlCompra.Text);
                model.IdPeca = this._modelPeca.IdPeca;

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

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Insere();
        }

        private void ValidaDadosNulos()
        {
            if (this._modelDepartamento == null)
            {

            }
            else if (this._modelFornecedor == null)
            {

            }
            else if (this._modelMotor == null)
            {

            }
            else if (this._modelPeca == null)
            {

            }
            else if (this._modelTipoProd == null)
            {

            }
        }
    }
}
