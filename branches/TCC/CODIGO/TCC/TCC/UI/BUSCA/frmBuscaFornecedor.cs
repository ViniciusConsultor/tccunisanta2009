using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.Regra;
using TCC.Mapper;

namespace TCC.UI
{
    public partial class frmBuscaFornecedor : Form
    {
        #region Atributos
        mFornecedor _model;
        mMotor _modelMotor;
        mPeca _modelPeca;
        bool _alteracao, _filtroBusca;
        #endregion

        #region Construtor
        public frmBuscaFornecedor(mFornecedor modelFornecedor)
        {
            InitializeComponent();
            _model = modelFornecedor;
            _alteracao = false;
            this._filtroBusca = false;
        }

        public frmBuscaFornecedor(mFornecedor modelFornecedor, bool Alteracao)
        {
            InitializeComponent();
            _model = modelFornecedor;
            _alteracao = Alteracao;
            this._filtroBusca = false;
        }

        public frmBuscaFornecedor(mFornecedor modelFornecedor, mMotor modelMotor)
        {
            InitializeComponent();
            _model = modelFornecedor;
            _alteracao = false;
            this._modelMotor = modelMotor;
            this._filtroBusca = true;
        }

        public frmBuscaFornecedor(mFornecedor modelFornecedor, mPeca modelPeca)
        {
            InitializeComponent();
            _model = modelFornecedor;
            _alteracao = false;
            this._modelPeca = modelPeca;
            this._filtroBusca = true;
        }
        #endregion Construtor

        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.RetornaModel();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmBuscaFornecedor_Load(object sender, EventArgs e)
        {
            this.HabilitaBotoes();
            if (this._filtroBusca == true)
            {
                this.ExecutaBuscaFornecedoresAssociados();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                this.RetornaModel();
                this.PopulaModelCompletoAlteracao();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (TCC.Regra.Exceptions.Busca.LinhaSemSelecionarException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (TCC.Regra.Exceptions.Busca.CadastrarDadoException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (TCC.Regra.Exceptions.Busca.SemBuscaESelecionarException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                this.RetornaModel();
                this.DeletaCadastro();
                this.PopulaGrid();
            }
            catch (TCC.Regra.Exceptions.Busca.LinhaSemSelecionarException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (TCC.Regra.Exceptions.Busca.CadastrarDadoException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (TCC.Regra.Exceptions.Busca.SemBuscaESelecionarException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Metodos
        private void PopulaGrid()
        {
            rFornecedor regra = new rFornecedor();
            DataTable dt = null;
            try
            {
                if (this._filtroBusca == false)
                {
                    dt = regra.BuscaFornecedor(this.txtFiltro.Text);
                }
                else
                {
                    //Verifica se o model é de motor ou de peça para filtrar quais distribuidores atendem esta "peça/motor"
                    //-----------------------------------------------------------------------------------------------------
                    if (this._modelMotor != null)
                    {
                        dt = regra.BuscaFornecedorMotor(Convert.ToInt32(this._modelMotor.IdMotor));
                        if (dt.Rows.Count <= 0)
                        {
                            DialogResult resultado = MessageBox.Show("Não existe fornecedores associados a esse motor, deseja associa-los agora?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                            if (resultado == DialogResult.Yes)
                            {
                                this.AbreTelaAssociacaoMotorFornecedor();
                                dt = regra.BuscaFornecedorMotor(Convert.ToInt32(this._modelMotor.IdMotor));
                            }
                            else
                            {
                                this.DialogResult = DialogResult.Cancel;
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        dt = regra.BuscaFornecedorPeca(Convert.ToInt32(this._modelPeca.IdPeca));
                        if (dt.Rows.Count <= 0)
                        {
                            DialogResult resultado = MessageBox.Show("Não existe fornecedores associados a essa peça, deseja associa-los agora?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                            if (resultado == DialogResult.Yes)
                            {
                                this.AbreTelaAssociacaoPecaFornecedor();
                                dt = regra.BuscaFornecedorPeca(Convert.ToInt32(this._modelPeca.IdPeca));
                            }
                            else
                            {
                                this.DialogResult = DialogResult.Cancel;
                                this.Close();
                            }
                        }
                    }
                }
                this.dgFornecedor.DataSource = dt;
                dgFornecedor.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
                if (dt != null)
                {
                    dt.Dispose();
                    dt = null;
                }
            }
        }

        private void RetornaModel()
        {
            DataGridViewCell dvC = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgFornecedor.DataSource;
                if (this.dgFornecedor.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgFornecedor.CurrentRow != null)
                        {
                            //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                            //------------------------------------------------------------------------------------
                            dvC = this.dgFornecedor["hid_forn", this.dgFornecedor.CurrentRow.Index];
                            _model.IdFornecedor = Convert.ToInt32(dvC.Value);
                            dvC = this.dgFornecedor["hnom", this.dgFornecedor.CurrentRow.Index];
                            _model.NomeFornecedor = dvC.Value.ToString();
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
                        MessageBox.Show("É necessário Cadastrar um Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário Buscar e Selecionar um Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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

        private void PopulaModelCompletoAlteracao()
        {
            rFornecedor regraFornecedor = new rFornecedor();
            DataTable dtRegistroFornecedor = null;
            try
            {
                dtRegistroFornecedor = regraFornecedor.BuscaUmRegistro(this._model);
                this._model.Deserialize(dtRegistroFornecedor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraFornecedor = null;
                if (dtRegistroFornecedor != null)
                {
                    dtRegistroFornecedor.Dispose();
                    dtRegistroFornecedor = null;
                }
            }
        }

        private void DeletaCadastro()
        {
            rFornecedor regraFornecedor = new rFornecedor();
            try
            {
                regraFornecedor.ValidarDeleta(this._model);
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

        private void HabilitaBotoes()
        {
            this.btnAlterar.Visible = this._alteracao;
            this.btnExcluir.Visible = this._alteracao;
            //Alteração negado!!
            //------------------
            this.btnOK.Visible = !this._alteracao;
            if (this._filtroBusca == true)
            {
                this.txtFiltro.Visible = false;
                this.btnBuscar.Visible = false;
            }
        }

        #endregion

        #region Executa Busca Fornecedores Associados
        /// <summary>
        /// Executa as buscas quando a tela é chamada da tela de compra
        /// </summary>
        private void ExecutaBuscaFornecedoresAssociados()
        {
            try
            {
                this.PopulaGrid();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Executa Busca Fornecedores Associados

        /// <summary>
        /// Abre a tela de associação de motor com fornecedor
        /// </summary>
        private void AbreTelaAssociacaoMotorFornecedor()
        {
            CADASTRO.frmCadMotorFornecedor telaMotorFornecedor = null;
            try
            {
                telaMotorFornecedor = new TCC.UI.CADASTRO.frmCadMotorFornecedor(this._modelMotor);
                telaMotorFornecedor.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                telaMotorFornecedor = null;
            }
        }

        /// <summary>
        /// Abre a tela de associação de Peça com Fornecedor
        /// </summary>
        private void AbreTelaAssociacaoPecaFornecedor()
        {
            frmPecaFornecedor telaPecaFornecedor = null;
            try
            {
                telaPecaFornecedor = new frmPecaFornecedor(this._modelPeca);
                telaPecaFornecedor.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                telaPecaFornecedor = null;
            }
        }
    }
}
