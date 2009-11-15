using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;
using TCC.MODEL;

namespace TCC.UI.CADASTRO
{
    public partial class frmPecaFornecedor : Form
    {
        #region Atributos
        mPeca _modelPeca;
        List<mPecaFornecedor> _listaModelPecaFornecedor;
        #endregion Atributos

        #region Construtor
        public frmPecaFornecedor()
        {
            InitializeComponent();
        }

        public frmPecaFornecedor(int? idPeca,string nomePeca)
        {
            InitializeComponent();
            this.btnBuscaPeca.Visible = false;
            _modelPeca = new mPeca();
            _modelPeca.IdPeca = idPeca;
            _modelPeca.Nom = nomePeca;
            this.txtNomePeca.Text = nomePeca;
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
                    this.txtNomePeca.Text = this._modelPeca.Nom;
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

        #region btnBuscarFornecedorDtGrid Click
        private void btnBuscarFornecedorDtGrid_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }
        #endregion btnBuscarFornecedorDtGrid Click

        #endregion Eventos

        #region Metodos

        #region Insere
        /// <summary>
        /// Insere os dados que estão no model
        /// </summary>
        private void Insere()
        {
            rPecaFornecedor regra = new rPecaFornecedor();

            try
            {
                this.PopulaListaModel();
                this.ValidaDadosNulos();
                foreach (mPecaFornecedor modelPecaFornecedor in this._listaModelPecaFornecedor)
                {
                    regra.ValidarInsere(modelPecaFornecedor);
                }
                this.btnLimpa_Click(null, null);
                this.btnConfirma.Enabled = false;
            }
            catch (BUSINESS.Exceptions.PecaFornecedor.PecaVazioException)
            {
                MessageBox.Show("É necessário buscar uma Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscaPeca.Focus();
            }
            catch (BUSINESS.Exceptions.PecaFornecedor.FornecedorNaoEscolhidoException)
            {
                MessageBox.Show("É necessário selecionar ao menos um fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscarFornecedorDtGrid.Focus();
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
            mPecaFornecedor modelPecaFornecedor;
            try
            {
                dtSource = (DataTable)this.dgFornecedores.DataSource;
                if (this.dgFornecedores.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgFornecedores.CurrentRow != null)
                        {
                            //Varre o DataGrid linha por linha
                            //--------------------------------
                            foreach (DataGridViewRow linha in this.dgFornecedores.Rows)
                            {
                                //Verifica se a linha é nula
                                //--------------------------
                                if (linha.Cells[0].Value != null)
                                {
                                    //Converte o valor para Boolean e verifica se está checado
                                    //--------------------------------------------------------
                                    if (Convert.ToBoolean(linha.Cells[0].Value) != false)
                                    {
                                        modelPecaFornecedor = new mPecaFornecedor();

                                        //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                                        //------------------------------------------------------------------------------------
                                        //Pega id Fornecedor
                                        dvC = linha.Cells[1];
                                        modelPecaFornecedor.Id_forn = Convert.ToInt32(dvC.Value);
                                        //Pega resto model
                                        modelPecaFornecedor.Id_peca = this._modelPeca.IdPeca;
                                        modelPecaFornecedor.DatInc = DateTime.Now;
                                        modelPecaFornecedor.FlgAtivo = true;

                                        //Atribui o model à lista de models
                                        if (this._listaModelPecaFornecedor == null)
                                        {
                                            this._listaModelPecaFornecedor = new List<mPecaFornecedor>();
                                            this._listaModelPecaFornecedor.Add(modelPecaFornecedor);
                                        }
                                        else
                                        {
                                            this._listaModelPecaFornecedor.Add(modelPecaFornecedor);
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
        
        #region Busca Fornecedores
        /// <summary>
        /// Busca Fornecedores atravez do filtro escolhido pelo usuario
        /// </summary>
        /// <param name="nomeFornecedores">o filtro passado pelo usuário pode ser Vazio</param>
        /// <returns>DataTable com o resultado da query</returns>
        private DataTable BuscaFornecedores(string nomeFornecedor)
        {
            rFornecedor regraFornecedor = new rFornecedor();
            try
            {
                return regraFornecedor.BuscaFornecedor(nomeFornecedor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraFornecedor = null;
            }
        }
        #endregion Busca Fornecedores

        #region Popula Grid
        /// <summary>
        /// Utiliza os dados da busca para popular o grid
        /// </summary>
        private void PopulaGrid()
        {
            DataTable dtSource = null;
            try
            {
                dtSource = this.BuscaFornecedores(this.txtBuscaFiltroFornecedor.Text);
                this.dgFornecedores.DataSource = dtSource;
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
            if (this._listaModelPecaFornecedor == null)
            {
                throw new BUSINESS.Exceptions.PecaFornecedor.FornecedorNaoEscolhidoException();
            }
            else if (this._modelPeca == null)
            {
                throw new BUSINESS.Exceptions.PecaFornecedor.PecaVazioException();
            }
        }
        #endregion Valida Dados Nulos

        #endregion Metodos
    }
}
