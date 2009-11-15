using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.MODEL;
using TCC.BUSINESS;

namespace TCC.UI.CADASTRO
{
    public partial class frmCadPecaEstoque : Form
    {
        #region Atributos
        mPeca _modelPeca;
        List<mPecaEstoque> _listaModelPecaEstoque;
        #endregion Atributos

        #region Construtor
        public frmCadPecaEstoque()
        {
            InitializeComponent();
        }

        public frmCadPecaEstoque(int? idPeca, string nomePeca)
        {
            InitializeComponent();
            this.btnBuscaPeca.Visible = false;
            this._modelPeca = new mPeca();
            this._modelPeca.IdPeca = idPeca;
            this._modelPeca.Nom = nomePeca;
            this.txtPeca.Text = nomePeca;
        }
        #endregion Construtor

        #region Eventos

        #region btnConfirma Click
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnConfirma Click

        #region btnLimpa Click
        private void btnLimpa_Click(object sender, EventArgs e)
        {

        }
        #endregion btnLimpa Click

        #region btnBuscaAlteracaoDelecao Click
        private void btnBuscaAlteracaoDelecao_Click(object sender, EventArgs e)
        {

        }
        #endregion btnBuscaAlteracaoDelecao Click

        #region btnVolta Click
        private void btnVolta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion btnVolta Click

        #region btnBuscaPeca Click
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
                    this.txtPeca.Text = this._modelPeca.Nom;
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
        #endregion btnBuscaPeca Click

        #region btnBuscarEstoqueDtGrid Click
        private void btnBuscarEstoqueDtGrid_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }
        #endregion btnBuscarEstoqueDtGrid Click

        #endregion Eventos

        #region Metodos

        #region Insere
        /// <summary>
        /// Insere os dados que estão no model
        /// </summary>
        private void Insere()
        {
            rPecaEstoque regra = new rPecaEstoque();

            try
            {
                this.PopulaListaModel();
                this.ValidaDadosNulos();
                foreach (mPecaEstoque modelPecaEstoque in this._listaModelPecaEstoque)
                {
                    regra.ValidarInsere(modelPecaEstoque);
                }
                this.btnLimpa_Click(null, null);
                this.btnConfirma.Enabled = false;
            }
            catch (BUSINESS.Exceptions.PecaEstoque.PecaVazioException)
            {
                MessageBox.Show("É necessário buscar uma Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscaPeca.Focus();
            }
            catch (BUSINESS.Exceptions.PecaEstoque.EstoqueNaoEscolhidoException)
            {
                MessageBox.Show("É necessário selecionar ao menos um estoque", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscarEstoqueDtGrid.Focus();
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
        #endregion Insere
        
        #region Popula Lista Model
        private void PopulaListaModel()
        {
            DataGridViewCell dvC = null;
            DataTable dtSource = new DataTable();
            mPecaEstoque modelPecaEstoque;
            try
            {
                dtSource = (DataTable)this.dgEstoques.DataSource;
                if (this.dgEstoques.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgEstoques.CurrentRow != null)
                        {
                            //Varre o DataGrid linha por linha
                            //--------------------------------
                            foreach (DataGridViewRow linha in this.dgEstoques.Rows)
                            {
                                //Verifica se a linha é nula
                                //--------------------------
                                if (linha.Cells[0].Value != null)
                                {
                                    //Converte o valor para Boolean e verifica se está checado
                                    //--------------------------------------------------------
                                    if (Convert.ToBoolean(linha.Cells[0].Value) != false)
                                    {
                                        modelPecaEstoque = new mPecaEstoque();

                                        //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                                        //------------------------------------------------------------------------------------
                                        //Pega id Estoque
                                        dvC = linha.Cells[1];
                                        modelPecaEstoque.Id_estoq = Convert.ToInt32(dvC.Value);
                                        //Pega resto model
                                        dvC = linha.Cells[3];
                                        modelPecaEstoque.Qtd_peca = Convert.ToInt32(dvC.Value);
                                        modelPecaEstoque.Id_peca = this._modelPeca.IdPeca;
                                        modelPecaEstoque.Dat_alt = DateTime.Now;
                                        modelPecaEstoque.Flg_alt = true;

                                        //Atribui o model à lista de models
                                        if (this._listaModelPecaEstoque == null)
                                        {
                                            this._listaModelPecaEstoque = new List<mPecaEstoque>();
                                            this._listaModelPecaEstoque.Add(modelPecaEstoque);
                                        }
                                        else
                                        {
                                            this._listaModelPecaEstoque.Add(modelPecaEstoque);
                                        }
                                    }
                                }
                            }
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("É necessário Selecionar uma linha", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("É necessário Cadastrar um Departamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário Buscar e Selecionar um Departamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dvC != null)
                {
                    dvC.Dispose();
                    dvC = null;
                }
                if (dtSource != null)
                {
                    dtSource.Dispose();
                    dtSource = null;
                }
            }
        }
        #endregion Popula Lista Model
        
        #region Busca Estoque
        /// <summary>
        /// Busca Estoques atravez do filtro escolhido pelo usuario
        /// </summary>
        /// <param name="nomeEstoque">o filtro passado pelo usuário pode ser Vazio</param>
        /// <returns>DataTable com o resultado da query</returns>
        private DataTable BuscaEstoque(string nomeEstoque)
        {
            rEstoque regraEstoque = new rEstoque();
            try
            {
                return regraEstoque.BuscaEstoque(nomeEstoque);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraEstoque = null;
            }
        }
        #endregion Busca Estoque
        
        #region Popula Grid
        /// <summary>
        /// Utiliza os dados da busca para popular o grid
        /// </summary>
        private void PopulaGrid()
        {
            DataTable dtSource = null;
            try
            {
                dtSource = this.BuscaEstoque(this.txtBuscaFiltroEstoque.Text);
                this.dgEstoques.DataSource = dtSource;
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

        #region Valida Dados Nulos
        /// <summary>
        /// Valida os dados que não podem ser nulos na tela
        /// </summary>
        private void ValidaDadosNulos()
        {
            if (this._listaModelPecaEstoque == null)
            {
                throw new BUSINESS.Exceptions.PecaEstoque.EstoqueNaoEscolhidoException();
            }
            else if (this._modelPeca == null)
            {
                throw new BUSINESS.Exceptions.PecaEstoque.PecaVazioException();
            }
        }
        #endregion Valida Dados Nulos

        #endregion Metodos
    }
}
