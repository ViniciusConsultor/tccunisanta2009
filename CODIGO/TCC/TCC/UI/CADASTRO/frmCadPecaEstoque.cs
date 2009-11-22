using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.MODEL;
using TCC.BUSINESS;

namespace TCC.UI
{
    public partial class frmCadPecaEstoque : FormPai
    {
        #region Atributos
        mPeca _modelPeca;
        List<mPecaEstoque> _listaModelPecaEstoque;
        #endregion Atributos

        #region Construtores
        public frmCadPecaEstoque()
        {
            InitializeComponent();
        }

        public frmCadPecaEstoque(mPeca modelPeca)
        {
            InitializeComponent();
            this.btnBuscaPeca.Visible = false;
            this._modelPeca = modelPeca;
            this.txtPeca.Text = modelPeca.DscPeca;

            this.MarcaPecaEstoque();
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
            base.LimpaDadosTela(this);
            
            _listaModelPecaEstoque = null;
            _modelPeca = null;

            this.PopulaGrid();
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
            base.FechaTela(this);
        }
        #endregion btnVolta Click

        #region btnBuscaPeca Click
        private void btnBuscaPeca_Click(object sender, EventArgs e)
        {
            this.btnLimpa_Click(null, null);
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
                    this.MarcaPecaEstoque();
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

        #region frmCadPecaEstoque_Load
        private void frmCadPecaEstoque_Load(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }
        #endregion frmCadPecaEstoque_Load
        
        #region btnAdicionar_Click
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.AtualizaGrid();
        }
        #endregion btnAdicionar_Click

        #region dgEstoques_CellClick
        private void dgEstoques_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgEstoques.CurrentRow.Index > -1)
            {
                try
                {
                    txtQtde.Text = dgEstoques["hQuantidade", dgEstoques.CurrentRow.Index].Value.ToString();
                }
                catch
                {
                    txtQtde.Text = "";
                }
            }
            txtQtde.Focus();
            txtQtde.SelectAll();
        }
        #endregion dgEstoques_CellClick

        #region btnRemover_Click
        private void btnRemover_Click(object sender, EventArgs e)
        {
            txtQtde.Text = "0";
            this.AtualizaGrid();
        }
        #endregion btnRemover_Click

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

                // exclui antes tudo antes de inserir
                this.DeletaTudoPorPeca();

                foreach (mPecaEstoque modelPecaEstoque in this._listaModelPecaEstoque)
                {
                    regra.ValidarInsere(modelPecaEstoque);
                }
                this.btnLimpa_Click(null, null);
                MessageBox.Show("Registro salvo com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.PecaEstoque.PecaVazioException)
            {
                MessageBox.Show("É necessário buscar uma Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscaPeca.Focus();
            }
            catch (BUSINESS.Exceptions.PecaEstoque.EstoqueNaoEscolhidoException)
            {
                MessageBox.Show("É necessário selecionar ao menos um estoque", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
                                //Verifica se a quantidade é maior que Zero
                                //-----------------------------------------
                                if (Convert.ToInt32(linha.Cells["hQuantidade"].Value) > 0)
                                {
                                    modelPecaEstoque = new mPecaEstoque();

                                    //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                                    //------------------------------------------------------------------------------------
                                    //Pega id Estoque
                                    dvC = linha.Cells["hIdEstoque"];
                                    modelPecaEstoque.Id_estoq = Convert.ToInt32(dvC.Value);
                                    //Pega resto model
                                    dvC = linha.Cells["hQuantidade"]; // Qtde
                                    modelPecaEstoque.Qtd_peca = Convert.ToInt32(dvC.Value);
                                    modelPecaEstoque.Id_peca = this._modelPeca.IdPeca;
                                    modelPecaEstoque.Dat_alt = DateTime.Now;
                                    modelPecaEstoque.Flg_ativo = true;

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
                dtSource = this.BuscaEstoque("");
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

        #region MarcaPecaEstoque
        private void MarcaPecaEstoque()
        {
            DataTable dtPecaEstoqueTela = null;
            DataTable dtPecaEstoqueBanco = null;
            rPecaEstoque regraPecaEstoque = null;

            DataTable dtTemp = new DataTable();

            try
            {
                dtTemp.Columns.Add("id_estoq");
                dtTemp.Columns.Add("Estoque");
                dtTemp.Columns.Add("qtd_peca");
                DataRow drLinha;

                regraPecaEstoque = new rPecaEstoque();
                int idEstoqueTela, idEstoqueBanco;

                dtPecaEstoqueBanco = regraPecaEstoque.BuscaPecaEstoquePorPeca(_modelPeca);
                dtPecaEstoqueTela = (DataTable)dgEstoques.DataSource;
                if (dtPecaEstoqueTela == null)
                {
                    dtPecaEstoqueTela = new DataTable();
                }
                for (int linhaTela = 0; linhaTela < dtPecaEstoqueTela.Rows.Count; linhaTela++)
                {
                    drLinha = dtTemp.NewRow();

                    drLinha["id_estoq"] = dtPecaEstoqueTela.Rows[linhaTela]["id_estoq"];
                    drLinha["Estoque"] = dtPecaEstoqueTela.Rows[linhaTela]["Estoque"];
                    drLinha["qtd_peca"] = dtPecaEstoqueTela.Rows[linhaTela]["qtd_peca"];

                    idEstoqueTela = Convert.ToInt32(dtPecaEstoqueTela.Rows[linhaTela]["id_estoq"]);
                    for (int linhaBanco = 0; linhaBanco < dtPecaEstoqueBanco.Rows.Count; linhaBanco++)
                    {
                        idEstoqueBanco = Convert.ToInt32(dtPecaEstoqueBanco.Rows[linhaBanco]["id_estoq"]);
                        if (idEstoqueBanco == idEstoqueTela)
                        {
                            drLinha["qtd_peca"] = dtPecaEstoqueBanco.Rows[linhaBanco]["qtd_peca"];
                            continue;
                        }
                    }

                    dtTemp.Rows.Add(drLinha);
                }

                dgEstoques.DataSource = dtTemp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraPecaEstoque = null;
                dtPecaEstoqueTela = null;
                dtPecaEstoqueBanco = null;
            }
        }
        #endregion MarcaPerfilMenu

        #region DeletaTudoPorPeca
        private void DeletaTudoPorPeca()
        {
            rPecaEstoque regraPecaEstoque = null;
            try
            {
                regraPecaEstoque = new rPecaEstoque();
                regraPecaEstoque.DeletaPecaEstoqueporPeca(_modelPeca.IdPeca);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraPecaEstoque = null;
            }
        }
        #endregion DeletaTudoPorPerfil

        #region Atualiza Grid
        /// <summary>
        /// Atualiza o Grid com a quantidade do TextBox de quantidade
        /// </summary>
        private void AtualizaGrid()
        {
            DataTable dtSource = null;
            try
            {
                dtSource = (DataTable)this.dgEstoques.DataSource;
                dtSource.Columns["qtd_peca"].ReadOnly = false;
                dtSource.Rows[this.dgEstoques.CurrentRow.Index]["qtd_peca"] = this.txtQtde.Text;
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
        #endregion Atualiza Grid

        #endregion Metodos
    }
}