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
    public partial class frmCadItemPeca : FormPai
    {
        #region Atributos
        List<mPeca> _modelPeca;
        List<mItemPeca> _modelItemPeca;
        int _idPeca;
        #endregion Atributos

        #region Construtor
        public frmCadItemPeca()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region btnConfirmar Click
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Insere();

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
            this._modelPeca = null;
        }
        #endregion btnLimpa Click

        #region btnBuscaPeca Click
        private void btnBuscaPeca_Click(object sender, EventArgs e)
        {
            this._modelPeca = new List<mPeca>();
            frmBuscaPeca frmTela = new frmBuscaPeca(this._modelPeca, true, false);
            try
            {
                DialogResult resultado = frmTela.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelPeca = null;
                }
                else
                {
                    for (int contador = 0; contador < this._modelPeca.Count; contador++)
                    {
                        if (contador == 0)
                        {
                            // this.txtCdPeca.Text = this._modelPeca[contador].Nom;
                        }
                        else
                        {
                            //this.txtCdPeca.Text += ", " + this._modelPeca[contador].Nom;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                frmTela = null;
            }
        }
        #endregion btnBuscaPeca Click

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
        }
        #endregion btnBuscarPecaDtGrid Click

        #region dgItems SelectionChanged
        private void dgItems_SelectionChanged(object sender, EventArgs e)
        {
            this.PopulaTelaPeca();
        }
        #endregion dgItems SelectionChanged

        #region btnAdicionaPeca Click
        private void btnAdicionaPeca_Click(object sender, EventArgs e)
        {
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
        }
        #endregion btnAdicionaPeca Click

        #endregion Eventos

        #region Metodos
        
        #region Insere
        /// <summary>
        /// Insere os dados que estão no model
        /// </summary>
        private void Insere()
        {
            List<mItemPeca> ListaModel;
            rItemPeca regra = new rItemPeca();
            try
            {
                this.ValidaDadosNulos();
                ListaModel = this.PegaDadosTela();
                foreach (mItemPeca model in ListaModel)
                {
                    regra.ValidarInsere(model);
                }
                this.btnLimpa_Click(null, null);
            }
            catch (BUSINESS.Exceptions.CodigoPecaVazioExeception)
            {
                MessageBox.Show("É Necessário Buscar o código da Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                regra = null;
            }
        }
        #endregion Insere

        #region Pega Dados Tela
        /// <summary>
        /// Pega os dados da tela e popula o model
        /// </summary>
        /// <returns>Lista com o model itempeca</returns>
        private List<mItemPeca> PegaDadosTela()
        {
            List<mItemPeca> ListaModel = new List<mItemPeca>();
            mItemPeca model;
            rItemPeca regra = new rItemPeca();
            try
            {
                int idMaximo = regra.BuscaIdMaximo();
                for (int posicao = 0; posicao < this._modelPeca.Count; posicao++)
                {
                    model = new mItemPeca();
                    model.Flg_ativo = true;
                    model.Id_peca = this._modelPeca[posicao].IdPeca;
                    //    model.Nom_item_peca = this.txtNmItem.Text;
                    model.Id_item = idMaximo;
                    ListaModel.Add(model);
                }

                return ListaModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ListaModel = null;
                model = null;
            }
        }
        #endregion Pega Dados Tela

        #region Valida Dados Nulos
        /// <summary>
        /// Valida os dados que não podem ser nulos na tela
        /// </summary>
        private void ValidaDadosNulos()
        {
            if (this._modelPeca == null)
            {
                throw new BUSINESS.Exceptions.CodigoPecaVazioExeception();
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
                //model.Id_item = 
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
                for (int cont = 0; cont < this._modelItemPeca.Count; cont++)
                {
                    if (Convert.ToInt32(this._modelItemPeca[cont].Id_peca) == idPeca)
                    {
                        retorno = cont;
                    }
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

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

        #endregion Metodos
    }
} 