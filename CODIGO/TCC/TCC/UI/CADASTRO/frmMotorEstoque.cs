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
    public partial class frmMotorEstoque : FormPai
    {
        #region Atributos
        mMotor _modelMotor;
        /// <summary>
        /// Utilizado para armazenar os itens escolhidos pelo usuário
        /// </summary>
        List<mMotorEstoque> _listaModelMotorEstoque;
        /// <summary>
        /// Diz de onde foi chamada esta tela
        /// True - tela de motor
        /// False - menu principal
        /// </summary>
        bool _telaMotor;
        #endregion Atributos

        #region Construtores
        public frmMotorEstoque()
        {
            InitializeComponent();
            this._telaMotor = false;
        }

        public frmMotorEstoque(mMotor modelMotor, List<mMotorEstoque> listaMotorEstoque)
        {
            InitializeComponent();
            this.btnBuscaMotor.Visible = false;
            this._modelMotor = modelMotor;
            this.txtMotor.Text = modelMotor.IdMotor + " - " + modelMotor.DscMotor;

            this.MarcaMotorEstoque();
            this._listaModelMotorEstoque = listaMotorEstoque;
            this._telaMotor = true;
        }
        #endregion Construtores

        #region Eventos

        #region btnConfirma Click
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnConfirma Click

        #region btnBuscaAlteracaoDelecao Click
        private void btnBuscaAlteracaoDelecao_Click(object sender, EventArgs e)
        {

        }
        #endregion btnBuscaAlteracaoDelecao Click

        #region btnLimpa Click
        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);

            _listaModelMotorEstoque = null;
            _modelMotor = null;

            this.PopulaGrid();
        }
        #endregion btnLimpa Click

        #region btnVolta Click
        private void btnVolta_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            base.FechaTela(this);
        }
        #endregion btnVolta Click

        #region btnBuscaMotor Click
        private void btnBuscaMotor_Click(object sender, EventArgs e)
        {
            this.btnLimpa_Click(null, null);
            this._modelMotor = new mMotor();
            frmBuscaMotor objForm = new frmBuscaMotor(this._modelMotor);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelMotor = null;
                }
                else
                {
                    this.txtMotor.Text = this._modelMotor.DscMotor;
                    this.MarcaMotorEstoque();
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
        #endregion btnBuscaMotor Click

        #region frmMotorEstoque Load
        private void frmMotorEstoque_Load(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }
        #endregion frmMotorEstoque Load

        #region btnAdicionar Click
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.AtualizaGrid();
        }
        #endregion btnAdicionar Click

        #region dgEstoques CellClick
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
        #endregion dgEstoques CellClick

        #region btnRemover Click
        private void btnRemover_Click(object sender, EventArgs e)
        {
            txtQtde.Text = "0";
            this.AtualizaGrid();
        }
        #endregion btnRemover Click

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
                if (this._telaMotor == false)
                {
                    this.ValidaDadosNulos();

                    // exclui antes tudo antes de inserir
                    this.DeletaTudoPorMotor();

                    foreach (mMotorEstoque modelMotorEstoque in this._listaModelMotorEstoque)
                    {
                        regra.ValidarInsere(modelMotorEstoque);
                    }
                    this.btnLimpa_Click(null, null);
                    MessageBox.Show("Registro Salvo com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    base.FechaTela(this);
                }
            }
            catch (BUSINESS.Exceptions.MotorEstoque.MotorVazioException)
            {
                MessageBox.Show("É Necessário Buscar um Motor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscaMotor.Focus();
            }
            catch (BUSINESS.Exceptions.MotorEstoque.EstoqueNaoEscolhidoException)
            {
                MessageBox.Show("É Necessário Selecionar um Estoque", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
            mMotorEstoque modelMotorEstoque;
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
                                    modelMotorEstoque = new mMotorEstoque();

                                    //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                                    //------------------------------------------------------------------------------------
                                    //Pega id Estoque
                                    dvC = linha.Cells["hIdEstoque"];
                                    modelMotorEstoque.Id_estoq = Convert.ToInt32(dvC.Value);
                                    //Pega resto model
                                    dvC = linha.Cells["hQuantidade"]; // Qtde
                                    modelMotorEstoque.Qtd = Convert.ToInt32(dvC.Value);
                                    if (this._telaMotor == true)
                                    {
                                        modelMotorEstoque.Id_motor = null;
                                    }
                                    else
                                    {
                                        modelMotorEstoque.Id_motor = this._modelMotor.IdMotor;
                                    }
                                    modelMotorEstoque.Dat_alt = DateTime.Now;
                                    modelMotorEstoque.Flg_ativo = true;

                                    //Atribui o model à lista de models
                                    if (this._listaModelMotorEstoque == null)
                                    {
                                        this._listaModelMotorEstoque = new List<mMotorEstoque>();
                                        this._listaModelMotorEstoque.Add(modelMotorEstoque);
                                    }
                                    else
                                    {
                                        this._listaModelMotorEstoque.Add(modelMotorEstoque);
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
            if (this._listaModelMotorEstoque == null)
            {
                throw new BUSINESS.Exceptions.MotorEstoque.EstoqueNaoEscolhidoException();
            }
            else if (this._modelMotor == null)
            {
                throw new BUSINESS.Exceptions.MotorEstoque.MotorVazioException();
            }
        }
        #endregion Valida Dados Nulos
        
        #region MarcaMotorEstoque
        private void MarcaMotorEstoque()
        {
            DataTable dtMotorEstoqueTela = null;
            DataTable dtMotorEstoqueBanco = null;
            rMotorEstoque regraMotorEstoque = null;

            DataTable dtTemp = new DataTable();

            try
            {
                dtTemp.Columns.Add("id_estoq");
                dtTemp.Columns.Add("Estoque");
                dtTemp.Columns.Add("qtd");
                DataRow drLinha;

                regraMotorEstoque = new rMotorEstoque();
                int idEstoqueTela, idEstoqueBanco;

                dtMotorEstoqueBanco = regraMotorEstoque.BuscaMotorEstoquePorMotor(_modelMotor);
                dtMotorEstoqueTela = (DataTable)dgEstoques.DataSource;
                if (dtMotorEstoqueTela == null)
                {
                    dtMotorEstoqueTela = new DataTable();
                }
                for (int linhaTela = 0; linhaTela < dtMotorEstoqueTela.Rows.Count; linhaTela++)
                {
                    drLinha = dtTemp.NewRow();

                    drLinha["id_estoq"] = dtMotorEstoqueTela.Rows[linhaTela]["id_estoq"];
                    drLinha["Estoque"] = dtMotorEstoqueTela.Rows[linhaTela]["Estoque"];
                    drLinha["qtd"] = dtMotorEstoqueTela.Rows[linhaTela]["qtd"];

                    idEstoqueTela = Convert.ToInt32(dtMotorEstoqueTela.Rows[linhaTela]["id_estoq"]);
                    for (int linhaBanco = 0; linhaBanco < dtMotorEstoqueBanco.Rows.Count; linhaBanco++)
                    {
                        idEstoqueBanco = Convert.ToInt32(dtMotorEstoqueBanco.Rows[linhaBanco]["id_estoq"]);
                        if (idEstoqueBanco == idEstoqueTela)
                        {
                            drLinha["qtd"] = dtMotorEstoqueBanco.Rows[linhaBanco]["qtd"];
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
                regraMotorEstoque = null;
                dtMotorEstoqueTela = null;
                dtMotorEstoqueBanco = null;
            }
        }
        #endregion MarcaPerfilMenu
        
        #region DeletaTudoPorMotor
        private void DeletaTudoPorMotor()
        {
            rMotorEstoque regraMotorEstoque = null;
            try
            {
                regraMotorEstoque = new rMotorEstoque();
                regraMotorEstoque.DeletaMotorEstoqueporMotor(_modelMotor.IdMotor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraMotorEstoque = null;
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
                dtSource.Columns["qtd"].ReadOnly = false;
                dtSource.Rows[this.dgEstoques.CurrentRow.Index]["qtd"] = this.txtQtde.Text;
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
