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
        #region Atributos
        List<mFamiliaMotor> _listaFamMotor;
        List<mKitGrupoPeca> _listaKitGrupo;
        mCliente _modelCliente;
        mMotor _modelMotor;
        mProduto _modelProduto;
        mTipoProduto _modelTipoProd;
        mKitGrupoPeca _modelKit;
        #endregion Atributos

        #region Construtor
        public frmCadVenda()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos
        #region Form Load
        private void frmCadVenda_Load(object sender, EventArgs e)
        {
            this.PopulaComboTipoProduto();
        }
        #endregion Form Load

        #region btnConfirma Click
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnConfirma Click

        #region btnLimpa Click
        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelCliente = null;
            this._modelKit = null;
            this._modelMotor = null;
            this._modelProduto = null;
            this._modelTipoProd = null;
        }
        #endregion btnLimpa Click

        #region btnVolta Click
        private void btnVolta_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVolta Click

        #region btnCdCliente Click
        private void btnCdCliente_Click(object sender, EventArgs e)
        {
            this._modelCliente = new mCliente();
            frmBuscaCliente objFrmCliente = new frmBuscaCliente(this._modelCliente);
            try
            {
                DialogResult resultado = objFrmCliente.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelCliente = null;
                }
                else
                {
                    this.txtCdCliente.Text = this._modelCliente.NomeCliente;
                }
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
        #endregion btnCdCliente Click

        #region btnBuscarItemDtGrid Click
        private void btnBuscarItemDtGrid_Click(object sender, EventArgs e)
        {
            try
            {
                this.PopulaGrid();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }
        #endregion btnBuscarItemDtGrid Click

        #region btnAdicionaProdutos Click
        private void btnAdicionaProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                int tipoProd = Convert.ToInt32(this.cboTipoProduto.SelectedValue);
                this.ValidaAdicaoProduto();
                //Se for Motor
                //------------
                if (tipoProd == 1)
                {
                    if (this._listaFamMotor != null)
                    {
                        if (this._listaFamMotor.Count > 0)
                        {

                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (this._listaKitGrupo != null)
                    {
                        if (this._listaKitGrupo.Count > 0)
                        {

                        }
                    }
                    else
                    {

                    }
                }
                this.AtualizaGrid();
            }
            catch (BUSINESS.Exceptions.Venda.QuantidadeVendaZeroOuNuloException)
            {
                MessageBox.Show("Campo quantidade não pode ser 0 (Zero) ou Vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtQtdProdutos.Focus();
            }
            catch (BUSINESS.Exceptions.Venda.GridProdutoSemDadosException)
            {
                MessageBox.Show("É Necessário buscar Produtos para adicionar a Venda.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscarItemDtGrid.Focus();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion btnAdicionaProdutos Click

        #endregion Eventos

        #region Metodos

        #region Popula Combo Tipo Produto
        /// <summary>
        /// Popula o combo com os tipos de produto
        /// </summary>
        private void PopulaComboTipoProduto()
        {
            rTipoProduto regraTipoProd = new rTipoProduto();
            DataTable dtSource = null;
            try
            {
                dtSource = regraTipoProd.BuscaTipoProduto(string.Empty);
                this.cboTipoProduto.DisplayMember = "Tipo Produto";
                this.cboTipoProduto.ValueMember = "id_tipo_prod";
                this.cboTipoProduto.DataSource = dtSource;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraTipoProd = null;
            }
        }
        #endregion Popula Combo Tipo Produto

        #region Pega Dados Tela
        /// <summary>
        /// Pega os dados que estão na tela e popula o model Venda
        /// </summary>
        /// <returns>model populado de acordo com os dados da tela</returns>
        private mVenda PegaDadosTela()
        {
            mVenda model = new mVenda();
            rVenda regra = new rVenda();

            try
            {
                if (string.IsNullOrEmpty(this.txtDataVenda.Text) == true || this.txtDataVenda.Modified == false)
                {
                    model.DatVenda = null;
                }
                else
                {
                    model.DatVenda = Convert.ToDateTime(this.txtDataVenda.Text);
                }
                model.DatSaida = DateTime.Now;
                model.IdCli = this._modelCliente.IdCliente;
                model.IdOrdem = Convert.ToInt32(this._modelProduto.Id_produto);
                model.IdTipoProduto = Convert.ToInt32(this._modelTipoProd.IdTipoProd);
                model.NotaFisc = this.txtNotaFiscal.Text;
                if (string.IsNullOrEmpty(this.txtQtdProdutos.Text) == true)
                {
                    //   model.Qtd = null;
                }
                else
                {
                    //    model.Qtd = Convert.ToInt32(this.txtQtdVenda.Text);
                }
                if (string.IsNullOrEmpty(this.txtValorVenda.Text) == true)
                {
                    model.Valor = null;
                }
                else
                {
                    model.Valor = Convert.ToDouble(this.txtValorVenda.Text);
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
        #endregion Pega Dados Tela

        #region Insere
        /// <summary>
        /// Insere os dados que estão no model
        /// </summary>
        private void Insere()
        {
            mVenda model = new mVenda();
            rVenda regra = new rVenda();
            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                this.btnLimpa_Click(null, null);
            }
            catch (BUSINESS.Exceptions.CodigoClienteVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código do Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoKitGrupoPecaVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código do Kit Grupo Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Venda.VendaMotorGrupoVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código do Motor ou do Grupo de Peças", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoTipoProdutoVazioExeception)
            {
                MessageBox.Show("É Necessário Buscar o código do Tipo Produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Venda.QuantidadeVendaZeroOuNuloException)
            {
                MessageBox.Show("O campo Quantidade Venda não pode se Zero ou Vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtQtdProdutos.Focus();
            }
            catch (BUSINESS.Exceptions.Venda.ValorVendaZeroOuNuloException)
            {
                MessageBox.Show("O campo Valor não pode se Zero ou Vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtValorVenda.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                model = null;
                regra = null;
            }
        }
        #endregion Insere

        #region Valida Dados Nulos
        /// <summary>
        /// Valida os dados que não pode ser nulos ou vazios
        /// </summary>
        private void ValidaDadosNulos()
        {
            if (this._modelCliente == null)
            {
                throw new BUSINESS.Exceptions.CodigoClienteVazioException();
            }
            else if (this._modelProduto == null)
            {
                throw new BUSINESS.Exceptions.CodigoOrdemProducaoVazioException();
            }
            else if (this._modelTipoProd == null)
            {
                throw new BUSINESS.Exceptions.CodigoTipoProdutoVazioExeception();
            }
            else if (this._modelKit == null && this._modelMotor == null)
            {
                throw new BUSINESS.Exceptions.Venda.VendaMotorGrupoVazioException();
            }
        }
        #endregion Valida Dados Nulos

        #region Busca Dados Grid
        /// <summary>
        /// Verifica as seleções de filtro que o usuario escolheu e retorna um DataTable populado com os dados
        /// </summary>
        /// <returns>DataTable com os dados escolhidos para o filtro</returns>
        private DataTable BuscaDadosGrid()
        {
            rFamiliaMotor regraFamMotor = null;
            rKitGrupoPeca regraKit = null;
            int idTipoProduto;
            try
            {
                idTipoProduto = Convert.ToInt32(this.cboTipoProduto.SelectedValue);
                //Veririfica se o Indice Selecionado é Motor (id 1)
                //-------------------------------------------------
                if (idTipoProduto == 1)
                {
                    regraFamMotor = new rFamiliaMotor();
                    if (rdbCodigo.Checked == true)
                    {
                        return regraFamMotor.BuscaFamiliaMotorCodigo(this.txtBuscaFiltro.Text);
                    }
                    else
                    {
                        return regraFamMotor.BuscaFamiliaMotorNome(this.txtBuscaFiltro.Text);
                    }
                }
                //Não verifica outro id pois, sistema abrange apenas venda de Motores e kits, por enquanto
                //----------------------------------------------------------------------------------------
                else
                {
                    regraKit = new rKitGrupoPeca();
                    if (rdbCodigo.Checked == true)
                    {
                        return regraKit.BuscaKitGrupoPecaCodigo(this.txtBuscaFiltro.Text);
                    }
                    else
                    {
                        return regraKit.BuscaKitGrupoPecaNome(this.txtBuscaFiltro.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraKit = null;
                regraFamMotor = null;
            }
        }
        #endregion Busca Dados Grid

        #region Popula Grid
        /// <summary>
        /// Popula o grid com dados
        /// </summary>
        private void PopulaGrid()
        {
            DataTable dtSource = null;
            try
            {
                dtSource = this.BuscaDadosGrid();
                this.dgProdutos.DataSource = dtSource;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dtSource != null)
                {
                    dtSource.Dispose();
                    dtSource = null;
                }
            }
        }
        #endregion Popula Grid

        #region Valida Adicao Produto
        /// <summary>
        /// Verifica se existe algum problema para adicionar o motor ou o kit para venda
        /// </summary>
        private void ValidaAdicaoProduto()
        {
            if (this.dgProdutos.DataSource == null)
            {
                throw new BUSINESS.Exceptions.Venda.GridProdutoSemDadosException();
            }
            else if (string.IsNullOrEmpty(this.txtQtdProdutos.Text) == true)
            {
                throw new BUSINESS.Exceptions.Venda.QuantidadeVendaZeroOuNuloException();
            }
            int quantidade = Convert.ToInt32(this.txtQtdProdutos.Text);
            if (quantidade < 1)
            {
                throw new BUSINESS.Exceptions.Venda.QuantidadeVendaZeroOuNuloException();
            }
        }
        #endregion Valida Adicao Produto

        #region Atualiza Grid
        /// <summary>
        /// Atualiza o Grid com a quantidade do TextBox de quantidade
        /// </summary>
        private void AtualizaGrid()
        {
            DataTable dtSource = null;
            try
            {
                dtSource = (DataTable)this.dgProdutos.DataSource;
                dtSource.Columns["qtd"].ReadOnly = false;
                dtSource.Rows[this.dgProdutos.CurrentRow.Index]["qtd"] = this.txtQtdProdutos.Text;
                this.dgProdutos.DataSource = dtSource;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dtSource != null)
                {
                    dtSource.Dispose();
                    dtSource = null;
                }
            }
        }
        #endregion Atualiza Grid

        #endregion Metodos
    }
}