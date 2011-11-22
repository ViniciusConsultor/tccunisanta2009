using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.Mapper;
using TCC.Regra;

namespace TCC.UI.CADASTRO
{
    public partial class frmCadMotorFornecedor : FormPai
    {
        #region Atributos
        mMotor _modelMotor;
        List<mMotorFornecedor> _listaModelMotorFornecedor;
        int? _idMotor;
        /// <summary>
        /// True - tela chamada da tela de motor;
        /// False - Tela chamada do menu principal
        /// </summary>
        bool _telaMotor;
        #endregion Atributos

        #region Construtor
        public frmCadMotorFornecedor()
        {
            InitializeComponent();
        }

        public frmCadMotorFornecedor(mMotor modelMotor)
        {
            InitializeComponent();
            this.btnBuscaMotor.Visible = false;
            _modelMotor = modelMotor;
            this._telaMotor = false;
            this.txtDescMotor.Text = modelMotor.DscMotor;
        }

        public frmCadMotorFornecedor(mMotor modelMotor, List<mMotorFornecedor> listaMotorFornecedor)
        {
            InitializeComponent();
            this.btnBuscaMotor.Visible = false;
            _modelMotor = modelMotor;
            this._listaModelMotorFornecedor = listaMotorFornecedor;
            this._telaMotor = true;
            this.txtDescMotor.Text = modelMotor.DscMotor;
        }

        #endregion Construtor

        #region Eventos

        #region btnConfirma Click
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
            this.DialogResult = DialogResult.OK;
        }
        #endregion btnConfirma Click

        #region btnBuscaAlteracaoDelecao Click
        private void btnBuscaAlteracaoDelecao_Click(object sender, EventArgs e)
        {

        }
        #endregion btnBuscaAlteracaoDelecao Click

        #region btnVolta Click
        private void btnVolta_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            base.FechaTela(this);
        }
        #endregion btnVolta Click

        #region btnLimpa Click
        private void btnLimpa_Click(object sender, EventArgs e)
        {
            
        }
        #endregion btnLimpa Click

        #region btnBuscarFornecedorDtGrid Click
        private void btnBuscarFornecedorDtGrid_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }
        #endregion btnBuscarFornecedorDtGrid Click

        #region btnBuscaMotor Click
        private void btnBuscaMotor_Click(object sender, EventArgs e)
        {
            this._modelMotor = new mMotor();
            frmBuscaMotor objForm = new frmBuscaMotor(this._modelMotor);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelMotor = null;
                    this.txtDescMotor.Text = string.Empty;
                }
                else
                {
                    this.txtDescMotor.Text = this._modelMotor.DscMotor;
                    this._idMotor = this._modelMotor.IdMotor;
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

        #endregion Eventos

        #region Metodos

        #region Insere
        /// <summary>
        /// Insere os dados que estão no model
        /// </summary>
        private void Insere()
        {
            rMotorFornecedor regra = new rMotorFornecedor();
            try
            {
                this.PopulaListaModel();
                this.ValidaDadosNulos();
                if (this._telaMotor == false)
                {
                    foreach (mMotorFornecedor modelMotorFornecedor in this._listaModelMotorFornecedor)
                    {
                        regra.ValidarInsere(modelMotorFornecedor);
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
            catch (TCC.Regra.Exceptions.MotorFornecedor.MotorVazioException)
            {
                MessageBox.Show("É Necessário Buscar um Motor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscaMotor.Focus();
            }
            catch (TCC.Regra.Exceptions.MotorFornecedor.FornecedorNaoEscolhidoException)
            {
                MessageBox.Show("É Necessário Selecionar um Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
            mMotorFornecedor modelMotorFornecedor;
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
                                        modelMotorFornecedor = new mMotorFornecedor();

                                        //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                                        //------------------------------------------------------------------------------------
                                        //Pega id Fornecedor
                                        dvC = linha.Cells["hIdForn"];
                                        modelMotorFornecedor.Id_forn = Convert.ToInt32(dvC.Value);
                                        //Completa Model FornecedorDepto
                                        if (this._telaMotor == false)
                                        {
                                            modelMotorFornecedor.Id_motor = this._modelMotor.IdMotor;
                                        }
                                        else
                                        {
                                            modelMotorFornecedor.Id_motor = null;
                                        }
                                        modelMotorFornecedor.Dat_alt = DateTime.Now;
                                        modelMotorFornecedor.Flg_ativo = true;

                                        //Atribui o model à lista de models
                                        if (this._listaModelMotorFornecedor == null)
                                        {
                                            this._listaModelMotorFornecedor = new List<mMotorFornecedor>();
                                            this._listaModelMotorFornecedor.Add(modelMotorFornecedor);
                                        }
                                        else
                                        {
                                            this._listaModelMotorFornecedor.Add(modelMotorFornecedor);
                                        }
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
                dtSource = this.BuscaFornecedores(this.txtBuscaFiltro.Text);
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
            if (this._listaModelMotorFornecedor == null)
            {
                throw new TCC.Regra.Exceptions.MotorFornecedor.FornecedorNaoEscolhidoException();
            }
            else if (this._modelMotor == null)
            {
                throw new TCC.Regra.Exceptions.MotorFornecedor.MotorVazioException();
            }
        }
        #endregion Valida Dados Nulos

        #endregion Metodos
    }
}
