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
        #region Atributos

        mMotor _modelMotor;
        mDepartamento _modelDepartamento;
        mFornecedor _modelFornecedor;
        List<mPeca> _modelPeca;
        mTipoProduto _modelTipoProd;
        mCompra _modelCompra;

        #endregion Atributos

        #region Construtor
        public frmCadCompra()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region Form Load
        private void frmCadCompra_Load(object sender, EventArgs e)
        {
        }
        #endregion Form Load

        #region btnBuscaFornecedor Click
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
        #endregion btnBuscaFornecedor Click

        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVoltar Click

        #region btnLimpar Click
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelDepartamento = null;
            this._modelFornecedor = null;
            this._modelMotor = null;
            this._modelPeca = null;
            this._modelTipoProd = null;

            this._modelCompra = null;
            base.Alteracao = false;
        }
        #endregion btnLimpar Click

        #region btnBuscaAlteracaoDelecao Click
        private void btnBuscaAlteracaoDelecao_Click(object sender, EventArgs e)
        {
            this.btnLimpar_Click(null, null);
            this._modelCompra = new mCompra();
            frmBuscaCompra objCompra = new frmBuscaCompra(_modelCompra, true);
            try
            {
                DialogResult resultado = objCompra.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelCompra = null;
                }
                else
                {
                    this.PopulaTelaComModelAlteracao();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objCompra = null;
            }
        }
        #endregion btnBuscaAlteracaoDelecao Click

        #region btnAceitar Click
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnAceitar Click

        #endregion Eventos

        #region Metodos

        #region Pega Dados Tela
        /// <summary>
        /// Pega os dados da tela e Popula o model
        /// </summary>
        /// <returns></returns>
        private mCompra PegaDadosTela()
        {
            mCompra model = new mCompra();
            rCompra regra = new rCompra();

            try
            {
                model.IdCompra = regra.BuscaIdMaximo();
                model.Dat = DateTime.Now;
                model.IdFornecedor = Convert.ToInt32(this._modelFornecedor.IdFornecedor);
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
                model.Valor = Convert.ToDouble(this.txtVlCompra.Text);

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

        #region Valida Dados Nulos
        /// <summary>
        /// Valida os dados vazios
        /// </summary>
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
            else if (string.IsNullOrEmpty(this.txtVlCompra.Text) == true)
            {
                throw new BUSINESS.Exceptions.Compra.CompraValorVazioException();
            }
        }
        #endregion Valida Dados Nulos

        #region Popula Tela Com Model Alteracao
        /// <summary>
        /// Pega os dados do model de alteração e popula a tela
        /// </summary>
        private void PopulaTelaComModelAlteracao()
        {
            if (this._modelCompra != null)
            {
                base.Alteracao = true;
                this.txtCdFornecedor.Text = this._modelCompra.IdFornecedor.ToString();
                this.txtNotaFiscal.Text = this._modelCompra.NotaFiscal;
                this.txtVlCompra.Text = this._modelCompra.Valor.ToString();
                this.txtObservacao.Text = this._modelCompra.Obs;
            }
        }
        #endregion Popula Tela Com Model Alteracao

        #region Insere
        /// <summary>
        /// Insere os dados que estão no model
        /// </summary>
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
        #endregion Insere

        #endregion Metodos
    }
}
