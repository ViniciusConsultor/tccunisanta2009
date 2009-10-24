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
            this._modelDepartamento = null;
            this._modelFornecedor = null;
            this._modelMotor = null;
            this._modelPeca = null;
            this._modelTipoProd = null;
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
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                this.btnLimpar_Click(null, null);
                this.BuscaIdMaximo();
            }
            catch (BUSINESS.Exceptions.CodigoDepartamentoVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código do Departamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoFornecedorVazioExeception)
            {
                MessageBox.Show("É Necessário Buscar o código do Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoTipoProdutoVazioExeception)
            {
                MessageBox.Show("É Necessário Buscar o código do Tipo de Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Compra.CompraQuantidadeVaziaException)
            {
                MessageBox.Show("É Necessário preencher o campo Quantidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Compra.CompraValorVazioException)
            {
                MessageBox.Show("É Necessário preencher o campo Valor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Compra.CompraMotorPecaVazioException)
            {
                MessageBox.Show("É Necessário busca o código do Motor ou da Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
            rCompra regra = new rCompra();

            try
            {
                if (string.IsNullOrEmpty(this.txtDataCompra.Text) == true)
                {
                    model.Dat = null;
                }
                else
                {
                    model.Dat = Convert.ToDateTime(this.txtDataCompra.Text);
                }
                model.IdCompra = Convert.ToInt32(regra.BuscaIdMaximoCompra());
                model.IdDepto = this._modelDepartamento.IdDepto;
                model.IdFornecedor = this._modelFornecedor.IdFornecedor;
                model.IdMotorCompra = this._modelMotor.IdMotor;
                model.IdTipoProduto = this._modelTipoProd.IdTipoProd;
                if (string.IsNullOrEmpty(this.txtNotaFiscal.Text) == true)
                {
                    model.NotaFiscal = null;
                }
                else
                {
                    model.NotaFiscal = this.txtNotaFiscal.Text;
                }
                if (string.IsNullOrEmpty(this.txtObservacao.Text) == true)
                {
                    model.Obs = null;
                }
                else
                {
                    model.Obs = this.txtObservacao.Text;
                }
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
                throw new BUSINESS.Exceptions.CodigoDepartamentoVazioException();
            }
            else if (this._modelFornecedor == null)
            {
                throw new BUSINESS.Exceptions.CodigoFornecedorVazioExeception();
            }
            else if (this._modelMotor == null && this._modelPeca == null)
            {
                throw new BUSINESS.Exceptions.Compra.CompraMotorPecaVazioException();
            }
            else if (this._modelTipoProd == null)
            {
                throw new BUSINESS.Exceptions.CodigoTipoProdutoVazioExeception();
            }
            else if (string.IsNullOrEmpty(this.txtQtdCompra.Text) == true)
            {
                throw new BUSINESS.Exceptions.Compra.CompraQuantidadeVaziaException();
            }
            else if (string.IsNullOrEmpty(this.txtVlCompra.Text) == true)
            {
                throw new BUSINESS.Exceptions.Compra.CompraValorVazioException();
            }
        }
    }
}
