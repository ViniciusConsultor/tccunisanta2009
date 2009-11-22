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
    public partial class frmCadfornecedorDepto : FormPai
    {
        #region Atributos
        mFornecedor _modelFornecedor;
        List<mFornecedorDepto> _listaModelFornecedorDepto;
        int? _idForn;
        /// <summary>
        /// True - Veio da Tela Fornecedor
        /// False - Veio do menu principal
        /// </summary>
        bool _telaFornecedor;
        #endregion Atributos

        #region Construtor
        public frmCadfornecedorDepto()
        {
            InitializeComponent();
        }

        public frmCadfornecedorDepto(mFornecedor modelForn, List<mFornecedorDepto> listaFornecedorDepto)
        {
            InitializeComponent();
            this.btnBuscaFornecedor.Visible = false;
            this._modelFornecedor = modelForn;
            this._listaModelFornecedorDepto = listaFornecedorDepto;
            this.txtFornecedor.Text = modelForn.NomeFornecedor;
            this._telaFornecedor = true;
        }
        #endregion Construtor

        #region Eventos

        #region btnConfirma Click
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnConfirma Click

        #region btnBuscarDepartamentoDtGrid Click
        private void btnBuscarDepartamentoDtGrid_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }
        #endregion btnBuscarDepartamentoDtGrid Click

        #region btnBuscaFornecedor Click
        private void btnBuscaFornecedor_Click(object sender, EventArgs e)
        {
            this._modelFornecedor = new mFornecedor();
            frmBuscaFornecedor objForm = new frmBuscaFornecedor(this._modelFornecedor);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelFornecedor = null;
                }
                else
                {
                    this.txtFornecedor.Text = this._modelFornecedor.NomeFornecedor;
                    this._idForn = this._modelFornecedor.IdFornecedor;
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
        #endregion btnBuscaFornecedor Click

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

        #region txtFornecedor TextChanged
        private void txtFornecedor_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion txtFornecedor TextChanged

        #region btnVolta Click
        private void btnVolta_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion btnVolta Click

        #endregion Eventos

        #region Metodos

        #region Insere
        /// <summary>
        /// Insere os dados que estão no model
        /// </summary>
        private void Insere()
        {
            rFornecedorDepto regra = new rFornecedorDepto();

            try
            {
                this.PopulaListaModel();
                this.ValidaDadosNulos();
                if (this._telaFornecedor == false)
                {
                    foreach (mFornecedorDepto modelFornecedorDepto in this._listaModelFornecedorDepto)
                    {
                        regra.ValidarInsere(modelFornecedorDepto);
                    }
                    this.btnLimpa_Click(null, null);
                    this.btnConfirma.Enabled = false;
                    MessageBox.Show("Registro Salvo com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    base.FechaTela(this);
                }
            }
            catch (BUSINESS.Exceptions.FornecedorDepto.FornecedorVazioException)
            {
                MessageBox.Show("É Necessário Buscar um Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscaFornecedor.Focus();
            }
            catch (BUSINESS.Exceptions.FornecedorDepto.DepartamentoNaoEscolhidoException)
            {
                MessageBox.Show("É Necessário Selecionar um Departamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscarDepartamentoDtGrid.Focus();
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
            mFornecedorDepto modelFornecedorDepto;
            try
            {
                dtSource = (DataTable)this.dgDeptos.DataSource;
                if (this.dgDeptos.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgDeptos.CurrentRow != null)
                        {
                            //Varre o DataGrid linha por linha
                            //--------------------------------
                            foreach (DataGridViewRow linha in this.dgDeptos.Rows)
                            {
                                //Verifica se a linha é nula
                                //--------------------------
                                if (linha.Cells[0].Value != null)
                                {
                                    //Converte o valor para Boolean e verifica se está checado
                                    //--------------------------------------------------------
                                    if (Convert.ToBoolean(linha.Cells[0].Value) != false)
                                    {
                                        modelFornecedorDepto = new mFornecedorDepto();

                                        //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                                        //------------------------------------------------------------------------------------
                                        //Pega id Depto
                                        dvC = linha.Cells[1];
                                        modelFornecedorDepto.IdDepto = Convert.ToInt32(dvC.Value);
                                        //Pega Depto
                                        if (this._telaFornecedor == false)
                                        {
                                            modelFornecedorDepto.IdFornecedor = this._idForn;
                                        }
                                        else
                                        {
                                            modelFornecedorDepto.IdFornecedor = null;
                                        }
                                        modelFornecedorDepto.DatAtl = DateTime.Now;
                                        modelFornecedorDepto.FlgAtivo = true;

                                        //Atribui o model à lista de models
                                        if (this._listaModelFornecedorDepto == null)
                                        {
                                            this._listaModelFornecedorDepto = new List<mFornecedorDepto>();
                                        }
                                        else
                                        {
                                            this._listaModelFornecedorDepto.Add(modelFornecedorDepto);
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

        #region Busca Deptos
        /// <summary>
        /// Busca Departamentos atravez do filtro escolhido pelo usuario
        /// </summary>
        /// <param name="nomeDepto">o filtro passado pelo usuário pode ser Vazio</param>
        /// <returns>DataTable com o resultado da query</returns>
        private DataTable BuscaDeptos(string nomeDepto)
        {
            rDepartamento regraDepto = new rDepartamento();
            try
            {
                return regraDepto.BuscaDepartamento(nomeDepto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraDepto = null;
            }
        }
        #endregion Busca Deptos

        #region Popula Grid
        /// <summary>
        /// Utiliza os dados da busca para popular o grid
        /// </summary>
        private void PopulaGrid()
        {
            DataTable dtSource = null;
            try
            {
                dtSource = this.BuscaDeptos(this.txtBuscaFiltro.Text);
                this.dgDeptos.DataSource = dtSource;
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
            if (this._listaModelFornecedorDepto == null)
            {
                throw new BUSINESS.Exceptions.FornecedorDepto.DepartamentoNaoEscolhidoException();
            }
            else if (this._modelFornecedor == null)
            {
                throw new BUSINESS.Exceptions.FornecedorDepto.FornecedorVazioException();
            }
        }
        #endregion Valida Dados Nulos

        #endregion Metodos
    }
}
