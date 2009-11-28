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
    public partial class frmCadItem : FormPai
    {
        #region Atributos
        List<mItemPeca> _modelItemPeca;
        int _idPeca;
        #endregion Atributos

        #region Construtor
        public frmCadItem()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region btnConfirmar Click
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidaDadosNulos();
                this.AbreTelaResumo();
                this.Insere();
            }
            catch (BUSINESS.Exceptions.Item.CodigoRealItemExistenteException)
            {
                MessageBox.Show("Código do item já existente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCodigoItem.Focus();
            }
            catch (BUSINESS.Exceptions.Item.ItemSemPecaException)
            {
                MessageBox.Show("É necessário associar uma peça ao item", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscarPecaDtGrid.Focus();
            }
            catch (BUSINESS.Exceptions.Item.NomeItemVazioException)
            {
                MessageBox.Show("É Necessário preencher o nome do Item", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNmItem.Focus();
            }
            catch (BUSINESS.Exceptions.Item.CodigoRealItemVazioException)
            {
                MessageBox.Show("É Necessário preencher o código do Item", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCodigoItem.Focus();
            }
            catch (BUSINESS.Exceptions.Item.TelaResumoCanceladaException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
        }
        #endregion btnConfirmar Click

        #region btnVolta Click
        private void btnVolta_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVolta Click

        #region btnLimpa Click
        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelItemPeca = null;
            this.txtQtdPeca.Text = "";
        }
        #endregion btnLimpa Click

        #region frmCadItemPeca Load
        private void frmCadItemPeca_Load(object sender, EventArgs e)
        {
        }
        #endregion frmCadItemPeca Load

        #region btnBuscarPecaDtGrid Click
        private void btnBuscarPecaDtGrid_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
            if (this._modelItemPeca != null)
            {
                if (this._modelItemPeca.Count > 0)
                {
                    this.ComparaDadosGrid();
                }
            }
            this.dgItems_Click(null, null);
        }
        #endregion btnBuscarPecaDtGrid Click

        #region btnAdicionaPeca Click
        private void btnAdicionaPeca_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidaAdicaoPeca();
                if (this._modelItemPeca != null)
                {
                    if (this._modelItemPeca.Count > 0)
                    {
                        this.AlteraModelItemPeca();
                    }
                }
                else
                {
                    this.PopulaModelItemPeca();
                }
                this.AtualizaGrid();
                this.TxtNmPeca.Text = "";
                this.txtQtdPeca.Text = "";
            }
            catch (BUSINESS.Exceptions.Item.GridPecaSemDadosException)
            {
                MessageBox.Show("É Necessario buscar peças.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscarPecaDtGrid.Focus();
            }
            catch (BUSINESS.Exceptions.Item.QuantidadeMenorZeroException)
            {
                MessageBox.Show("Quantidade deve ser Maior que zero.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtQtdPeca.Focus();
            }
            catch (BUSINESS.Exceptions.Item.QuantidadeVaziaException)
            {
                MessageBox.Show("Campo quantidade deve ser preenchido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtQtdPeca.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion btnAdicionaPeca Click

        #region btnRemovePeca Click
        private void btnRemovePeca_Click(object sender, EventArgs e)
        {
            this.RemovePeca();
        }
        #endregion btnRemovePeca Click

        #region txtCodigoItem TextChanged
        private void txtCodigoItem_TextChanged(object sender, EventArgs e)
        {
            this.btnConfirmar.Enabled = true;
        }
        #endregion txtCodigoItem TextChanged

        #region dgItems Click
        private void dgItems_Click(object sender, EventArgs e)
        {
            this.PopulaTelaPeca();
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
            Resumo.frmResumoItemPeca ResumoPeca = new TCC.UI.Resumo.frmResumoItemPeca(this._modelItemPeca, this.txtNmItem.Text);
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

        #region Insere
        /// <summary>
        /// Insere os dados que estão no model
        /// </summary>
        private void Insere()
        {
            mItem modelItem;
            rItem regraItem = new rItem();
            rItemPeca regraItemPeca = new rItemPeca();
            try
            {
                modelItem = this.PegaDadosTelaItem();
                regraItem.ValidarInsere(modelItem);
                this.CompletaListaModelItemPeca(modelItem);
                foreach (mItemPeca modelItemPeca in this._modelItemPeca)
                {
                    regraItemPeca.ValidarInsere(modelItemPeca);
                }
                this.btnLimpa_Click(null, null);
                this.btnConfirmar.Enabled = false;
                MessageBox.Show("Registro Salvo com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Item.NomeItemExistenteException)
            {
                MessageBox.Show("Nome do Item já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNmItem.Focus();
            }
            catch (BUSINESS.Exceptions.Item.CodigoRealItemExistenteException)
            {
                MessageBox.Show("Código do Item já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCodigoItem.Focus();
            }
            catch (BUSINESS.Exceptions.Item.ItemSemPecaException)
            {
                MessageBox.Show("É Necessário Associar uma Peça ao Item", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscarPecaDtGrid.Focus();
            }
            catch (BUSINESS.Exceptions.Item.NomeItemVazioException)
            {
                MessageBox.Show("É Necessário Preencher o nome do Item", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNmItem.Focus();
            }
            catch (BUSINESS.Exceptions.Item.CodigoRealItemVazioException)
            {
                MessageBox.Show("É Necessário Preencher o Código do Item", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCodigoItem.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                modelItem = null;
                regraItem = null;
                regraItemPeca = null;
            }
        }
        #endregion Insere

        #region Pega Dados Tela
        /// <summary>
        /// Pega os dados da tela e popula o model de Item
        /// </summary>
        /// <returns>model item populado</returns>
        private mItem PegaDadosTelaItem()
        {
            mItem model = new mItem();
            rItem regra = new rItem();
            try
            {
                model.Dat_alt = DateTime.Now;
                model.Flg_ativo = true;
                model.Id_item = regra.BuscaIdMaximo();
                model.Id_item_real = this.txtCodigoItem.Text;
                model.Nom = this.txtNmItem.Text;

                return model;
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
        #endregion Pega Dados Tela

        #region Completa Lista Model Item Peca
        /// <summary>
        /// Completa a lista de model Item peca com o id do item que foi gravado no Banco de dados
        /// </summary>
        /// <param name="modelItem">model do item onde esta o id</param>
        private void CompletaListaModelItemPeca(mItem modelItem)
        {
            foreach (mItemPeca model in this._modelItemPeca)
            {
                model.Id_item = modelItem.Id_item;
            }
        }
        #endregion Completa Lista Model Item Peca

        #region Valida Dados Nulos
        /// <summary>
        /// Valida os dados que não podem ser nulos na tela
        /// </summary>
        private void ValidaDadosNulos()
        {
            if (string.IsNullOrEmpty(this.txtCodigoItem.Text) == true)
            {
                throw new BUSINESS.Exceptions.Item.CodigoRealItemVazioException();
            }
            else if (string.IsNullOrEmpty(this.txtNmItem.Text) == true)
            {
                throw new BUSINESS.Exceptions.Item.NomeItemVazioException();
            }
            else if (this._modelItemPeca == null)
            {
                throw new BUSINESS.Exceptions.Item.ItemSemPecaException();
            }
        }
        #endregion Valida Dados Nulos

        #region Busca Peca
        /// <summary>
        /// Busca Peça atravez do filtro escolhido pelo usuario
        /// </summary>
        /// <param name="nomePeca">o filtro passado pelo usuário pode ser Vazio</param>
        /// <returns>DataTable com o resultado da query</returns>
        private DataTable BuscaPeca(string nomePeca)
        {
            rPeca regraPeca = new rPeca();
            try
            {
                if (this.rdbCodigo.Checked == true)
                {
                    return regraPeca.BuscaPecaCodigo(nomePeca);
                }
                else
                {
                    return regraPeca.BuscaPecaNome(nomePeca);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraPeca = null;
            }
        }
        #endregion Busca Peca

        #region Popula Grid
        /// <summary>
        /// Utiliza os dados da busca para popular o grid
        /// </summary>
        private void PopulaGrid()
        {
            DataTable dtSource = null;
            try
            {
                dtSource = this.BuscaPeca(this.txtFiltro.Text);
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

        #region Popula Model Item Peca
        /// <summary>
        /// Popula o model item peça com os dados que estão no painel da tela
        /// </summary>
        /// <returns>model populado</returns>
        private mItemPeca PopulaModelItemPeca()
        {
            mItemPeca model = new mItemPeca();
            try
            {
                if (this._modelItemPeca == null)
                {
                    this._modelItemPeca = new List<mItemPeca>();
                }
                model.Dat_alt = DateTime.Now;
                model.Flg_ativo = true;
                model.Id_item = null;
                model.Id_peca = this._idPeca;
                model.Qtd_peca = Convert.ToInt32(this.txtQtdPeca.Text);
                this._modelItemPeca.Add(model);
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
        #endregion Popula Model Item Peca

        #region Existe Model Item Peca
        /// <summary>
        /// Verifica a Existencia da Peça na Lista de Model
        /// </summary>
        /// <param name="idPeca">Id da Peça Procurada</param>
        /// <returns>Indice da pocição; Caso não encontre retorna -1</returns>
        private int ExisteModelItemPeca(int idPeca)
        {
            int retorno = -1;
            try
            {
                if (this._modelItemPeca != null)
                {
                    for (int cont = 0; cont < this._modelItemPeca.Count; cont++)
                    {
                        if (Convert.ToInt32(this._modelItemPeca[cont].Id_peca) == idPeca)
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

        #region Popula Tela Peca
        /// <summary>
        /// Pega os dados do grid para popular os TextBox na tela
        /// </summary>
        private void PopulaTelaPeca()
        {
            try
            {
                if (this.dgItems.Rows.Count > 0)
                {
                    this.ComparaDadosGrid();
                    int indice = this.dgItems.CurrentRow.Index;
                    this.TxtNmPeca.Text = this.dgItems["hNome", indice].Value.ToString();
                    this.txtQtdPeca.Text = this.dgItems["hQtd", indice].Value.ToString();
                    this._idPeca = Convert.ToInt32(this.dgItems["hIdPeca", indice].Value);
                    this.txtQtdPeca.Focus();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Popula Tela Peca

        #region Altera Model Item Peca
        /// <summary>
        /// Caso o id da peça já exista no model apenas troca para a quantidade certa
        /// </summary>
        private void AlteraModelItemPeca()
        {
            int indice;
            try
            {
                indice = this.ExisteModelItemPeca(this._idPeca);
                if (indice > -1)
                {
                    this._modelItemPeca[indice].Qtd_peca = Convert.ToInt32(this.txtQtdPeca.Text);
                }
                else
                {
                    this.PopulaModelItemPeca();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Altera Model Item Peca

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
                dtSource.Rows[this.dgItems.CurrentRow.Index]["qtd"] = this.txtQtdPeca.Text;
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
                    indice = this.ExisteModelItemPeca(Convert.ToInt32(dtSource.Rows[contador]["id_peca"]));
                    if (indice > -1)
                    {
                        dtSource.Columns["qtd"].ReadOnly = false;
                        dtSource.Rows[contador]["qtd"] = this._modelItemPeca[indice].Qtd_peca.ToString();
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

        #region Valida Adicao Peca
        /// <summary>
        /// Valida a adição de peças a lista
        /// </summary>
        private void ValidaAdicaoPeca()
        {
            if (this.dgItems.DataSource == null)
            {
                throw new BUSINESS.Exceptions.Item.GridPecaSemDadosException();
            }
            else if(string.IsNullOrEmpty(this.txtQtdPeca.Text) == true)
            {
                throw new BUSINESS.Exceptions.Item.QuantidadeVaziaException();
            }
            int quantidade = Convert.ToInt32(this.txtQtdPeca.Text);
            if (quantidade < 1)
            {
                throw new BUSINESS.Exceptions.Item.QuantidadeMenorZeroException();
            }
        }
        #endregion Valida Adicao Peca

        #region Remove Peca
        /// <summary>
        /// Remove peça da lista
        /// </summary>
        private void RemovePeca()
        {
            int indice;
            try
            {
                indice = this.ExisteModelItemPeca(this._idPeca);
                if (indice > -1)
                {
                    this.txtQtdPeca.Text = "0";
                    this._modelItemPeca.RemoveAt(indice);
                    this.AtualizaGrid();
                }
                else
                {
                    MessageBox.Show("Peça não associada ao Item", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Remove Peca
        #endregion Metodos
    }
}