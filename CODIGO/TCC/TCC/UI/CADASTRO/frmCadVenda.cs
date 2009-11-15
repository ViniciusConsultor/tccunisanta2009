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
        List<mVendaProduto> _listaModelVendaProduto;
        mCliente _modelCliente;
        mVenda _modelVenda;
        int _idProduto;
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
            mVenda modelVenda = null;
            try
            {
                this.ValidaDadosNulos();
                this.AbreTelaResumo();
                this.Insere(ref modelVenda);
                this.AbrirOrdemProducao(ref modelVenda);
            }
            catch (BUSINESS.Exceptions.Venda.DataVaziaException)
            {
                MessageBox.Show("É necessário preencher o campo data de venda", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDataVenda.Focus();
            }
            catch (BUSINESS.Exceptions.Venda.ValorVendaVaziaException)
            {
                MessageBox.Show("É necessário preencher o campo valor de venda", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtValorVenda.Focus();
            }
            catch (BUSINESS.Exceptions.Venda.VendaSemProdutoException)
            {
                MessageBox.Show("É necessário associar um Produto a venda", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscarItemDtGrid.Focus();
            }
            catch (BUSINESS.Exceptions.CodigoClienteVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código do Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Venda.ValorVendaZeroOuNuloException)
            {
                MessageBox.Show("Valor da Venda não pode ser menor que 0(zero)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Item.TelaResumoCanceladaException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                modelVenda = null;
            }
        }
        #endregion btnConfirma Click

        #region btnLimpa Click
        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelCliente = null;
            this._listaModelVendaProduto = null;
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
                if (this._listaModelVendaProduto != null)
                {
                    if (this._listaModelVendaProduto.Count > 0)
                    {
                        this.ComparaDadosGrid();
                    }
                }
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
                this.ValidaAdicaoProduto();
                if (this._listaModelVendaProduto != null)
                {
                    if (this._listaModelVendaProduto.Count > 0)
                    {
                        this.AlteraModelItemPeca();
                    }
                }
                else
                {
                    this.PopulaModelVendaProduto();
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

        #region cboTipoProduto SelectedIndexChanged
        private void cboTipoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.cboTipoProduto.SelectedValue) == 0)
            {
                this.HabilitaControles(false);
            }
            else
            {
                this.HabilitaControles(true);
            }
        }
        #endregion cboTipoProduto SelectedIndexChanged

        #region dgProdutos SelectionChanged
        private void dgProdutos_SelectionChanged(object sender, EventArgs e)
        {
            this.PopulaTelaProduto();
        }
        #endregion dgProdutos SelectionChanged

        #region btnRemovePeca Click
        private void btnRemovePeca_Click(object sender, EventArgs e)
        {
            this.RemoveProduto();
        }
        #endregion btnRemovePeca Click

        #region btnBuscaAlteracaoDelecao Click
        private void btnBuscaAlteracaoDelecao_Click(object sender, EventArgs e)
        {

        }
        #endregion btnBuscaAlteracaoDelecao Click

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
                this.AdicionaTodosTipoProduto(dtSource);
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

        #region Adiciona Todos Tipo Produto
        /// <summary>
        /// Adiciona Campo TODOS no combo
        /// </summary>
        /// <param name="dt">DataTable que sera o DataSource do combo</param>
        private void AdicionaTodosTipoProduto(DataTable dt)
        {
            DataRow linha = null;
            try
            {
                linha = dt.NewRow();
                linha["id_tipo_prod"] = 0;
                linha["Tipo Produto"] = "TODOS";
                dt.Rows.InsertAt(linha, 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                linha = null;
            }
        }
        #endregion Adiciona Todos Tipo Produto

        #region Pega Dados Tela Venda
        /// <summary>
        /// Pega os dados que estão na tela e popula o model Venda
        /// </summary>
        /// <returns>model populado de acordo com os dados da tela</returns>
        private mVenda PegaDadosTelaVenda()
        {
            mVenda model = new mVenda();
            rVenda regra = new rVenda();

            try
            {
                model.IdVenda = regra.BuscaIdMaximo();
                model.DatVenda = Convert.ToDateTime(this.txtDataVenda.Text);
                model.DatSaida = DateTime.Now;
                model.IdCli = this._modelCliente.IdCliente;
                model.Valor = Convert.ToDouble(this.txtValorVenda.Text);
                if (string.IsNullOrEmpty(this.txtNotaFiscal.Text) == true)
                {
                    model.NotaFisc = null;
                }
                else
                {
                    model.NotaFisc = this.txtNotaFiscal.Text;
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
        #endregion Pega Dados Tela Venda

        #region Insere
        /// <summary>
        /// Insere os dados que estão no model
        /// </summary>
        private void Insere(ref mVenda modelVenda)
        {
            rVenda regraVenda = new rVenda();
            rVendaProduto regraVendaPedido = new rVendaProduto();
            try
            {
                modelVenda = this.PegaDadosTelaVenda();
                regraVenda.ValidarInsere(modelVenda);
                this.CompletaListaModelVendaPedido(modelVenda);
                foreach (mVendaProduto modelVendaProduto in this._listaModelVendaProduto)
                {
                    regraVendaPedido.ValidarInsere(modelVendaProduto);
                }
                this.btnLimpa_Click(null, null);
                MessageBox.Show("Registro salvo com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                regraVenda = null;
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
            string data = this.txtDataVenda.Text.Replace("/", string.Empty);
            data = data.Replace(" ", string.Empty);
            if(string.IsNullOrEmpty(data) == true)
            {
                throw new BUSINESS.Exceptions.Venda.DataVaziaException();
            }
            else if (string.IsNullOrEmpty(this.txtValorVenda.Text) == true)
            {
                throw new BUSINESS.Exceptions.Venda.ValorVendaVaziaException();
            }
            else if (this._listaModelVendaProduto == null)
            {
                throw new BUSINESS.Exceptions.Venda.VendaSemProdutoException();
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
            rProduto regraProduto = new rProduto();
            int idTipoProduto;
            try
            {
                idTipoProduto = Convert.ToInt32(this.cboTipoProduto.SelectedValue);
                //Veririfica se o Indice Selecionado é Motor (id 1)
                //-------------------------------------------------
                if (idTipoProduto == 1)
                {
                    if (rdbCodigo.Checked == true)
                    {
                        return regraProduto.BuscaProdutoFamiliaMotorCodigo(this.txtBuscaFiltro.Text);
                    }
                    else
                    {
                        return regraProduto.BuscaProdutoFamiliaMotorNome(this.txtBuscaFiltro.Text);
                    }
                }
                //Não verifica outro id pois, sistema abrange apenas venda de Motores e kits, por enquanto
                //----------------------------------------------------------------------------------------
                else if (idTipoProduto == 2)
                {
                    if (rdbCodigo.Checked == true)
                    {
                        return regraProduto.BuscaProdutoKitCodigo(this.txtBuscaFiltro.Text);
                    }
                    else
                    {
                        return regraProduto.BuscaProdutoKitNome(this.txtBuscaFiltro.Text);
                    }
                }
                else
                {
                    return regraProduto.BuscaTodosProdutos();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraProduto = null;
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

        #region Habilita Controles
        /// <summary>
        /// Habilita ou desabilita controles de busca
        /// </summary>
        /// <param name="habilitar">True Habilita, caso contrario false</param>
        private void HabilitaControles(bool habilitar)
        {
            this.rdbCodigo.Checked = habilitar;
            this.rdbCodigo.Enabled = habilitar;
            this.rdbNome.Checked = false;
            this.rdbNome.Enabled = habilitar;
            this.txtBuscaFiltro.Text = string.Empty;
            this.txtBuscaFiltro.Enabled = habilitar;
        }
        #endregion Habilita Controles

        #region Popula Tela Produto
        /// <summary>
        /// Pega os dados do grid para popular os TextBox na tela
        /// </summary>
        private void PopulaTelaProduto()
        {
            try
            {
                this.ComparaDadosGrid();
                if (this.dgProdutos.Rows.Count > 0)
                {
                    int indice = this.dgProdutos.CurrentRow.Index;
                    this.TxtNmProduto.Text = this.dgProdutos["hDescricao", indice].Value.ToString();
                    this.txtQtdProdutos.Text = this.dgProdutos["hQtd", indice].Value.ToString();
                    this._idProduto = Convert.ToInt32(this.dgProdutos["hId", indice].Value);
                    this.txtQtdProdutos.Focus();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Popula Tela Produto

        #region Compara Dados Grid
        /// <summary>
        /// Compara os dados do Grid com os do model e substitui a quantidade caso exitam ids iguais
        /// </summary>
        private void ComparaDadosGrid()
        {
            DataTable dtSource = null;
            int indice;
            try
            {
                dtSource = (DataTable)this.dgProdutos.DataSource;
                for (int contador = 0; contador < dtSource.Rows.Count; contador++)
                {
                    indice = this.ExisteModelProduto(Convert.ToInt32(dtSource.Rows[contador]["id_prdto"]));
                    if (indice > -1)
                    {
                        dtSource.Columns["Qtd"].ReadOnly = false;
                        dtSource.Rows[contador]["Qtd"] = this._listaModelVendaProduto[indice].Qtd.ToString();
                    }
                }
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
        #endregion Compara Dados Grid

        #region Existe Model Produto
        /// <summary>
        /// Verifica a Existencia do Produto na Lista de Model
        /// </summary>
        /// <param name="idPeca">Id do Produto Procurado</param>
        /// <returns>Indice da pocição; Caso não encontre retorna -1</returns>
        private int ExisteModelProduto(int idProduto)
        {
            int retorno = -1;
            try
            {
                if (this._listaModelVendaProduto != null)
                {
                    for (int cont = 0; cont < this._listaModelVendaProduto.Count; cont++)
                    {
                        if (Convert.ToInt32(this._listaModelVendaProduto[cont].IdProduto) == idProduto)
                        {
                            retorno = cont;
                        }
                    }
                    return retorno;
                }
                else
                {
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Existe Model Item Peca

        #region Popula Model Venda Produto
        /// <summary>
        /// Popula o model venda produto com os dados que estão no painel da tela
        /// </summary>
        /// <returns>model populado</returns>
        private void PopulaModelVendaProduto()
        {
            mVendaProduto model = new mVendaProduto();
            try
            {
                if (this._listaModelVendaProduto == null)
                {
                    this._listaModelVendaProduto = new List<mVendaProduto>();
                }
                model.DatAlt = DateTime.Now;
                model.FlgAtivo = true;
                model.IdProduto = this._idProduto;
                model.IdVenda = null;
                model.Qtd = Convert.ToInt32(this.txtQtdProdutos.Text);

                this._listaModelVendaProduto.Add(model);
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
        #endregion Popula Model Item Peca

        #region Altera Model Venda Produto
        /// <summary>
        /// Caso o id do produto já exista no model apenas troca para a quantidade certa
        /// </summary>
        private void AlteraModelItemPeca()
        {
            int indice;
            try
            {
                indice = this.ExisteModelProduto(this._idProduto);
                if (indice > -1)
                {
                    this._listaModelVendaProduto[indice].Qtd = Convert.ToInt32(this.txtQtdProdutos.Text);
                }
                else
                {
                    this.PopulaModelVendaProduto();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Altera Model Item Peca

        #region Remove Produto
        /// <summary>
        /// Remove produto da lista
        /// </summary>
        private void RemoveProduto()
        {
            int indice;
            try
            {
                indice = this.ExisteModelProduto(this._idProduto);
                if (indice > -1)
                {
                    this.txtQtdProdutos.Text = "0";
                    this._listaModelVendaProduto.RemoveAt(indice);
                    this.AtualizaGrid();
                }
                else
                {
                    MessageBox.Show("Produto não associado a Venda", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Remove Produto

        #region Completa Lista Model Venda Pedido
        /// <summary>
        /// Completa a lista de model VendaPedido com o id da venda que foi gravado no Banco de dados
        /// </summary>
        /// <param name="modelItem">model da venda onde esta o id</param>
        private void CompletaListaModelVendaPedido(mVenda modelVenda)
        {
            foreach (mVendaProduto model in this._listaModelVendaProduto)
            {
                model.IdVenda = modelVenda.IdVenda;
            }
        }
        #endregion Completa Lista Model Venda Pedido

        #region Abre Tela Resumo
        /// <summary>
        /// Abre a tela de resumo antes de gravar os dados no banco
        /// </summary>
        private void AbreTelaResumo()
        {
            Resumo.frmResumoVendaProduto ResumoPeca = new TCC.UI.Resumo.frmResumoVendaProduto(this._listaModelVendaProduto, this.txtDataVenda.Text);
            try
            {
                DialogResult resultado;
                resultado = ResumoPeca.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    throw new BUSINESS.Exceptions.Item.TelaResumoCanceladaException();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                ResumoPeca = null;
            }
        }
        #endregion Abre Tela Resumo

        #region Abrir Ordem de Producao
        /// <summary>
        /// Abre a tela que cria a ordem de produção
        /// </summary>
        private void AbrirOrdemProducao(ref mVenda modelVenda)
        {
            Resumo.frmResumoOrdemProducao resumoOrdemProducao = new TCC.UI.Resumo.frmResumoOrdemProducao(modelVenda.IdVenda);
            try
            {
                DialogResult resultado;
                resultado = MessageBox.Show("Deseja criar uma ordem de produção?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    resumoOrdemProducao.ShowDialog();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                resumoOrdemProducao = null;
            }
        }
        #endregion Abrir Ordem de Producao

        #endregion Metodos

    }
}