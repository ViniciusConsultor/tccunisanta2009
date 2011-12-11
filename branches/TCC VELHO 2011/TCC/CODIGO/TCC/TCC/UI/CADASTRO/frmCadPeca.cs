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
        #region Atributos
        mTipoPeca _modelTipoPeca;
        List<mPecaEstoque> _listaPecaEstoque;
        List<mPecaFornecedor> _listaPecaFornecedor;
        #endregion Atributos

        #region Construtor
        public frmCadPeca()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVoltar Click

        #region btnCdTipoPeca Click
        private void btnCdTipoPeca_Click(object sender, EventArgs e)
        {
            this._modelTipoPeca = new mTipoPeca();
            frmBuscaTipoPeca objTela = new frmBuscaTipoPeca(_modelTipoPeca);
            try
            {
                DialogResult resultado = objTela.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelTipoPeca = null;
                    this.txtCdTipoPeca.Text = string.Empty;
                }
                else
                {
                    this.txtCdTipoPeca.Text = this._modelTipoPeca.DscTipoPeca;
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
        #endregion btnCdTipoPeca Click

        #region btnLimpar Click
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelTipoPeca = null;
            this._listaPecaEstoque = null;
            this._listaPecaFornecedor = null;
        }
        #endregion btnLimpar Click

        #region btnConfirmar Click
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnConfirmar Click

        #region txtCdTipoPeca Changed
        private void txtCdTipoPeca_TextChanged(object sender, EventArgs e)
        {
            this.btnConfirma.Enabled = true;
        }
        #endregion txtCdTipoPeca Changed

        #region btnRelacionarFornecedor Click
        private void btnRelacionarFornecedor_Click(object sender, EventArgs e)
        {
            this.AbreTelaRelacionarFornecedor();
        }
        #endregion btnRelacionarFornecedor Click

        #region btnRelacionarEstoque Click
        private void btnRelacionarEstoque_Click(object sender, EventArgs e)
        {
            this.AbreTelaRelacionarEstoque();
        }
        #endregion btnRelacionarEstoque Click

        #endregion Eventos

        #region Metodos

        #region Abre Tela Relacionar Fornecedor
        /// <summary>
        /// Abre a tela para relacionar a peça ao fornecedor
        /// </summary>
        private void AbreTelaRelacionarFornecedor()
        {
            mPeca modelPeca = null;
            frmPecaFornecedor telaPecaFornecedor = null;
            try
            {
                this._listaPecaFornecedor = new List<mPecaFornecedor>();
                this.ValidaDadosNulos();
                modelPeca = this.PegaDadosTela();
                telaPecaFornecedor = new frmPecaFornecedor(modelPeca, this._listaPecaFornecedor);
                DialogResult resultado = telaPecaFornecedor.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._listaPecaFornecedor = null;
                }
            }
            catch (BUSINESS.Exceptions.CodigoTipoPecaVazioException)
            {
                MessageBox.Show("O código do Tipo da Peça não pode ser vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnCdTipoPeca.Focus();
            }
            catch (BUSINESS.Exceptions.Peca.CodigoPecaVazioException)
            {
                MessageBox.Show("O código da Peça não pode ser vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCodigoReal.Focus();
            }
            catch (BUSINESS.Exceptions.Peca.NomePecaVazioException)
            {
                MessageBox.Show("Digitar o nome da Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNmPeca.Focus();
            }
            catch (BUSINESS.Exceptions.Peca.QtdMinimaNuloOuZeroException)
            {
                MessageBox.Show("A quantidade mínima da Peça deve ser maior que zero", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtQtdPeca.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                modelPeca = null;
                telaPecaFornecedor = null;
            }
        }
        #endregion Abre Tela Relacionar Fornecedor

        #region Abre Tela Relacionar Estoque
        /// <summary>
        /// Abre a tela de relacionar a peça com o estoque
        /// </summary>
        private void AbreTelaRelacionarEstoque()
        {
            mPeca modelPeca = null;
            frmCadPecaEstoque telaPecaEstoque = null;
            _listaPecaEstoque = new List<mPecaEstoque>();
            try
            {
                this.ValidaDadosNulos();
                modelPeca = this.PegaDadosTela();
                telaPecaEstoque = new frmCadPecaEstoque(modelPeca, _listaPecaEstoque);
                DialogResult resultado = telaPecaEstoque.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._listaPecaEstoque = null;
                }
            }
            catch (BUSINESS.Exceptions.CodigoTipoPecaVazioException)
            {
                MessageBox.Show("O código do Tipo da Peça não pode ser vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnCdTipoPeca.Focus();
            }
            catch (BUSINESS.Exceptions.Peca.CodigoPecaVazioException)
            {
                MessageBox.Show("O código da Peça não pode ser vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCodigoReal.Focus();
            }
            catch (BUSINESS.Exceptions.Peca.NomePecaVazioException)
            {
                MessageBox.Show("Digitar o nome da Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNmPeca.Focus();
            }
            catch (BUSINESS.Exceptions.Peca.QtdMinimaNuloOuZeroException)
            {
                MessageBox.Show("A quantidade mínima da Peça deve ser maior que zero", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtQtdPeca.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                modelPeca = null;
                telaPecaEstoque = null;
            }
        }
        #endregion Abre Tela Relacionar Estoque

        #region PegaDadosTela
        private mPeca PegaDadosTela()
        {
            mPeca model = new mPeca();
            rPeca regra = new rPeca();

            try
            {
                model.IdPeca = regra.BuscaIdMaximo();
                model.DatAlt = DateTime.Now;
                model.DscPeca = this.txtDsPeca.Text;
                model.FlgAtivo = true;
                model.IdPecaReal = this.txtCodigoReal.Text;
                model.IdTipoPeca = Convert.ToInt32(this._modelTipoPeca.IdTipoPeca);
                model.Nom = this.txtNmPeca.Text;
                if (string.IsNullOrEmpty(this.txtPesoPeca.Text) == true)
                {
                    model.Peso = null;
                }
                else
                {
                    model.Peso = Convert.ToDecimal(this.txtPesoPeca.Text);
                }
                if (string.IsNullOrEmpty(this.txtQtdPeca.Text) == true)
                {
                    model.QtdMin = null;
                }
                else
                {
                    model.QtdMin = Convert.ToInt32(this.txtQtdPeca.Text);
                }

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
        #endregion PegaDadosTela

        #region Insere
        private void Insere()
        {
            mPeca model;
            rPeca regra = new rPeca();
            rPecaEstoque regraPecaEstoque = new rPecaEstoque();
            rPecaFornecedor regraPecaFornecedor = new rPecaFornecedor();
            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                //Verifica se existe itens na lista de peça estoque
                //-------------------------------------------------
                if (this._listaPecaEstoque != null)
                {
                    if (this._listaPecaEstoque.Count > 0)
                    {
                        this.PopulaListaPecaEstoqueIdPeca(Convert.ToInt32(model.IdPeca));
                        foreach (mPecaEstoque modelPecaEstoque in this._listaPecaEstoque)
                        {
                            regraPecaEstoque.ValidarInsere(modelPecaEstoque);
                        }
                    }
                }
                //Verifica se existe itens na lista de peça fornecedor
                //-------------------------------------------------
                if (this._listaPecaFornecedor != null)
                {
                    if (this._listaPecaFornecedor.Count > 0)
                    {
                        this.PopulaListaPecaFornecedorIdPeca(Convert.ToInt32(model.IdPeca));
                        foreach (mPecaFornecedor modePecaFornecedor in this._listaPecaFornecedor)
                        {
                            regraPecaFornecedor.ValidarInsere(modePecaFornecedor);
                        }
                    }
                }
                base.LimpaDadosTela(this);
                this.btnConfirma.Enabled = false;
                MessageBox.Show("Registro Salvo com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Peca.CodigoPecaVazioException)
            {
                MessageBox.Show("O código da Peça não pode ser vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCodigoReal.Focus();
            }
            catch (BUSINESS.Exceptions.CodigoTipoPecaVazioException)
            {
                MessageBox.Show("O Tipo da Peça não pode ser vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnCdTipoPeca.Focus();
            }
            catch (BUSINESS.Exceptions.Peca.NomePecaVazioException)
            {
                MessageBox.Show("É Necessário Preencher o nome da Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNmPeca.Focus();
            }
            catch (BUSINESS.Exceptions.Peca.QtdMinimaNuloOuZeroException)
            {
                MessageBox.Show("A quantidade mínima da Peça deve ser maior que zero", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtQtdPeca.Focus();
            }
            catch (BUSINESS.Exceptions.Peca.PecaJaExistenteException)
            {
                MessageBox.Show("Peça já existente! Favor Cadastrar outro Código Real", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCodigoReal.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                model = null;
                regra = null;
                regraPecaEstoque = null;
            }
        }
        #endregion Insere

        #region ValidaDadosNulos
        private void ValidaDadosNulos()
        {
            if (this._modelTipoPeca == null)
            {
                throw new BUSINESS.Exceptions.CodigoTipoPecaVazioException();
            }
            else if (string.IsNullOrEmpty(this.txtCodigoReal.Text) == true)
            {
                throw new BUSINESS.Exceptions.Peca.CodigoPecaVazioException();
            }
            else if (string.IsNullOrEmpty(this.txtNmPeca.Text) == true)
            {
                throw new BUSINESS.Exceptions.Peca.NomePecaVazioException();
            }
            else if (string.IsNullOrEmpty(this.txtQtdPeca.Text) == true)
            {
                throw new BUSINESS.Exceptions.Peca.QtdMinimaNuloOuZeroException();
            }
        }
        #endregion ValidaDadosNulos

        #region Popula Lista Peca Estoque Id Peca
        /// <summary>
        /// Popula os models que estão na lista com o id da 
        /// Peça que foi cadastrada.
        /// </summary>
        /// <param name="idPeca">id da Peça cadastrada</param>
        private void PopulaListaPecaEstoqueIdPeca(int idPeca)
        {
            try
            {
                foreach (mPecaEstoque model in this._listaPecaEstoque)
                {
                    model.Id_peca = idPeca;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Popula Lista Peca Estoque Id Peca

        #region Popula Lista Peca Fornecedor Id Peca
        /// <summary>
        /// Popula os models que estão na lista com o id da 
        /// Peça que foi cadastrada.
        /// </summary>
        /// <param name="idPeca">id da Peça cadastrada</param>
        private void PopulaListaPecaFornecedorIdPeca(int idPeca)
        {
            try
            {
                foreach (mPecaFornecedor model in this._listaPecaFornecedor)
                {
                    model.Id_peca = idPeca;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Popula Lista Peca Fornecedor Id Peca

        #endregion Metodos
    }
}
