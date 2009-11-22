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
    public partial class frmCadKitGrupoPeca : FormPai
    {
        #region Atributos
        List<mPeca> _modelPeca;
        List<mItemKit> _modelItemKit;
        int _idItem;
        #endregion Atributos

        #region Construtor
        public frmCadKitGrupoPeca()
        {
            InitializeComponent();
        }
        #endregion Construtor
        
        #region Eventos

        #region Form Load
        private void frmCadKitGrupoPeca_Load(object sender, EventArgs e)
        {
        }
        #endregion Form Load
        
        #region btnLimpar Click
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelItemKit = null;
            this._modelPeca = null;
            this.txtQtdItem.Text = "";
        }
        #endregion btnLimpar Click

        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVoltar Click

        #region btnAceitar Click
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnAceitar Click

        #region btnBuscarPecaDtGrid Click
        private void btnBuscarItemDtGrid_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
            if (this._modelItemKit != null)
            {
                if (this._modelItemKit.Count > 0)
                {
                    this.ComparaDadosGrid();
                }
            }
            this.dgItems_Click(null, null);
        }
        #endregion btnBuscarPecaDtGrid Click

        #region btnAdicionaItem Click
        private void btnAdicionaItem_Click(object sender, EventArgs e)
        {
            this.AdicionarItemLista();
        }
        #endregion btnAdicionaItem Click

        #region txtCodigoKit TextChanged
        private void txtCodigoKit_TextChanged(object sender, EventArgs e)
        {
            btnAceitar.Enabled = true;
        }
        #endregion txtCodigoKit TextChanged

        #region dgItems Click
        private void dgItems_Click(object sender, EventArgs e)
        {
            this.PopulaTelaItem();
        }
        #endregion dgItems Click

        #endregion Eventos

        #region Metodos

        #region Abre Tela Resumo
        /// <summary>
        /// Abre a tela de resumo antes de gravar os dados no banco
        /// </summary>
        private void AbreTelaResumo()
        {
            Resumo.frmResumoItemKit ResumoItem = new TCC.UI.Resumo.frmResumoItemKit(_modelItemKit, this.txtNmKit.Text);
            try
            {
                DialogResult resultado;
                resultado = ResumoItem.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    throw new BUSINESS.Exceptions.KitGrupoPeca.TelaResumoCanceladaException();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                ResumoItem = null;
            }
        }
        #endregion Abre Tela Resumo

        #region Insere
        /// <summary>
        /// Insere no banco os dados do model
        /// </summary>
        private void Insere()
        {
            mKitGrupoPeca model;
            rKitGrupoPeca regra = new rKitGrupoPeca();
            rItemKit regraItemKit = new rItemKit();

            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                this.AbreTelaResumo();
                regra.ValidarInsere(model);
                this.CompletaListaModelItemKit(model);
                foreach (mItemKit modelItemKit in this._modelItemKit)
                {
                    regraItemKit.ValidarInsere(modelItemKit);
                }
                this.btnLimpar_Click(null, null);
                this.btnAceitar.Enabled = false;
                MessageBox.Show("Registro Salvo com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.KitGrupoPeca.NomeKitExistenteException)
            {
                MessageBox.Show("Nome do Kit já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNmKit.Focus();
            }
            catch (BUSINESS.Exceptions.KitGrupoPeca.CodigoRealKitExistenteException)
            {
                MessageBox.Show("Código do Kit já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCodigoKit.Focus();
            }
            catch (BUSINESS.Exceptions.KitGrupoPeca.KitSemItemException)
            {
                MessageBox.Show("É Necessário Associar um Item ao Kit", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscarItemDtGrid.Focus();
            }
            catch (BUSINESS.Exceptions.KitGrupoPeca.NomeKitVazioException)
            {
                MessageBox.Show("É Necessário Preencher o Nome do Kit", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNmKit.Focus();
            }
            catch (BUSINESS.Exceptions.KitGrupoPeca.CodigoRealKitVazioException)
            {
                MessageBox.Show("É Necessário Preencher o código do Kit", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCodigoKit.Focus();
            }
            catch (BUSINESS.Exceptions.KitGrupoPeca.TelaResumoCanceladaException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                model = null;
                regra = null;
                regraItemKit = null;
            }
        }
        #endregion Insere

        #region Valida Dados Nulos
        /// <summary>
        /// Valida os dados que não podem ser nulos na tela
        /// </summary>
        private void ValidaDadosNulos()
        {
            if (string.IsNullOrEmpty(this.txtCodigoKit.Text) == true)
            {
                throw new BUSINESS.Exceptions.KitGrupoPeca.CodigoRealKitVazioException();
            }
            else if (string.IsNullOrEmpty(this.txtNmKit.Text) == true)
            {
                throw new BUSINESS.Exceptions.KitGrupoPeca.NomeKitVazioException();
            }
            else if (this._modelItemKit == null)
            {
                throw new BUSINESS.Exceptions.KitGrupoPeca.KitSemItemException();
            }
        }
        #endregion Valida Dados Nulos

        #region Pega Dados Tela
        /// <summary>
        /// Pega os dados da tela para popular um model
        /// </summary>
        /// <returns>Model populado</returns>
        private mKitGrupoPeca PegaDadosTela()
        {
            mKitGrupoPeca model = new mKitGrupoPeca();
            rKitGrupoPeca regra = new rKitGrupoPeca();

            try
            {
                model.IdKit = regra.BuscaIdMaximo();
                model.Dat_alt = DateTime.Now;
                model.Flg_ativo = true;
                model.Nom_grupo = this.txtNmKit.Text;
                model.IdKitReal = this.txtCodigoKit.Text;

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

        #region Completa Lista Model Item Kit
        /// <summary>
        /// Completa a lista de model Item Kit com o id do kit que foi gravado no Banco de dados
        /// </summary>
        /// <param name="modelKit">model do Kit onde esta o id</param>
        private void CompletaListaModelItemKit(mKitGrupoPeca modelKit)
        {
            foreach (mItemKit model in this._modelItemKit)
            {
                model.Id_kit = modelKit.IdKit;
            }
        }
        #endregion Completa Lista Model Item Kit

        #region Busca Item
        /// <summary>
        /// Busca Item atravez do filtro escolhido pelo usuario
        /// </summary>
        /// <param name="nomeItem">o filtro passado pelo usuário pode ser Vazio</param>
        /// <returns>DataTable com o resultado da query</returns>
        private DataTable BuscaItem(string nomeItem)
        {
            rItem regraItem = new rItem();
            try
            {
                if (this.rdbCodigo.Checked == true)
                {
                    return regraItem.BuscaItemCodigo(nomeItem);
                }
                else
                {
                    return regraItem.BuscaItemNome(nomeItem);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraItem = null;
            }
        }
        #endregion Busca Item
        
        #region Popula Grid
        /// <summary>
        /// Utiliza os dados da busca para popular o grid
        /// </summary>
        private void PopulaGrid()
        {
            DataTable dtSource = null;
            try
            {
                dtSource = this.BuscaItem(this.txtBuscaFiltro.Text);
                this.dgItems.DataSource = dtSource;
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

        #region Adicionar Item Lista
        private void AdicionarItemLista()
        {
            try
            {
                this.ValidaAdicaoItem();
                if (this._modelItemKit != null)
                {
                    if (this._modelItemKit.Count > 0)
                    {
                        this.AlteraModelItemKit();
                    }
                }
                else
                {
                    this.PopulaModelItemKit();
                }
                this.AtualizaGrid();
                this.TxtNmItem.Text = "";
                this.txtQtdItem.Text = "";
            }
            catch (BUSINESS.Exceptions.KitGrupoPeca.GridItemSemDadosException)
            {
                MessageBox.Show("É Necessario buscar itens.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscarItemDtGrid.Focus();
            }
            catch (BUSINESS.Exceptions.KitGrupoPeca.QuantidadeMenorZeroException)
            {
                MessageBox.Show("Quantidade deve ser Maior que zero.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtQtdItem.Focus();
            }
        }
        #endregion Adicionar Item Lista

        #region Popula Model Item Kit
        /// <summary>
        /// Popula o model item kit com os dados que estão no painel da tela
        /// </summary>
        /// <returns>model populado</returns>
        private mItemKit PopulaModelItemKit()
        {
            mItemKit model = new mItemKit();
            try
            {
                if (this._modelItemKit == null)
                {
                    this._modelItemKit = new List<mItemKit>();
                }
                model.Dat_alt = DateTime.Now;
                model.Flg_ativo = true;
                model.Id_kit = null;
                model.Id_item = this._idItem;
                model.Qtd_item = Convert.ToInt32(this.txtQtdItem.Text);
                this._modelItemKit.Add(model);
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
        #endregion Popula Model Item Kit

        #region Existe Model Item Kit
        /// <summary>
        /// Verifica a Existencia da Item na Lista de Model
        /// </summary>
        /// <param name="idItem">Id do Item Procurado</param>
        /// <returns>Indice da pocição; Caso não encontre retorna -1</returns>
        private int ExisteModelItemKit(int idItem)
        {
            int retorno = -1;
            try
            {
                if (this._modelItemKit != null)
                {
                    for (int cont = 0; cont < this._modelItemKit.Count; cont++)
                    {
                        if (Convert.ToInt32(this._modelItemKit[cont].Id_item) == idItem)
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
        #endregion Existe Model Item Kit

        #region Popula Tela Item
        /// <summary>
        /// Pega os dados do grid para popular os TextBox na tela
        /// </summary>
        private void PopulaTelaItem()
        {
            try
            {
                this.ComparaDadosGrid();
                if (this.dgItems.Rows.Count > 0)
                {
                    int indice = this.dgItems.CurrentRow.Index;
                    this.TxtNmItem.Text = this.dgItems["hNome", indice].Value.ToString();
                    this.txtQtdItem.Text = this.dgItems["hQtd", indice].Value.ToString();
                    this._idItem = Convert.ToInt32(this.dgItems["hIdItem", indice].Value);
                    this.txtQtdItem.Focus();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Popula Tela Item

        #region Altera Model Item Kit
        /// <summary>
        /// Caso o id da item já exista no model apenas troca para a quantidade certa
        /// </summary>
        private void AlteraModelItemKit()
        {
            int indice;
            try
            {
                indice = this.ExisteModelItemKit(this._idItem);
                if (indice > -1)
                {
                    this._modelItemKit[indice].Qtd_item = Convert.ToInt32(this.txtQtdItem.Text);
                }
                else
                {
                    this.PopulaModelItemKit();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Altera Model Item Kit

        #region Atualiza Grid
        /// <summary>
        /// Atualiza o Grid com a quantidade do TextBox de quantidade
        /// </summary>
        private void AtualizaGrid()
        {
            DataTable dtSource = null;
            try
            {
                dtSource = (DataTable)this.dgItems.DataSource;
                dtSource.Columns["qtd"].ReadOnly = false;
                dtSource.Rows[this.dgItems.CurrentRow.Index]["qtd"] = this.txtQtdItem.Text;
                this.dgItems.DataSource = dtSource;
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
                dtSource = (DataTable)this.dgItems.DataSource;
                for (int contador = 0; contador < dtSource.Rows.Count; contador++)
                {
                    indice = this.ExisteModelItemKit(Convert.ToInt32(dtSource.Rows[contador]["id_item"]));
                    if (indice > -1)
                    {
                        dtSource.Columns["qtd"].ReadOnly = false;
                        dtSource.Rows[contador]["qtd"] = this._modelItemKit[indice].Qtd_item.ToString();
                    }
                }
                this.dgItems.DataSource = dtSource;
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
        
        #region Valida Adicao Item
        /// <summary>
        /// Valida a adição de Itens a lista
        /// </summary>
        private void ValidaAdicaoItem()
        {
            if (this.dgItems.DataSource == null)
            {
                throw new BUSINESS.Exceptions.KitGrupoPeca.GridItemSemDadosException();
            }
            int quantidade = Convert.ToInt32(this.txtQtdItem.Text);
            if (quantidade < 1)
            {
                throw new BUSINESS.Exceptions.KitGrupoPeca.QuantidadeMenorZeroException();
            }
        }
        #endregion Valida Adicao Item

        #endregion Metodos
    }
}