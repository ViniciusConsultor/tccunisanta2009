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
    public partial class frmCadFamiliaMotor : FormPai
    {
        #region Atributos
        List<mKitFamilia> _listaKitFamilia;
        int _idKit;
        mEstoque _modelEstoque;
        mMotor _modelMotor;
        mTipoMotor _modelTipoMotor;
        mNumMotor _modelNumeroMotor;
        #endregion Atributos

        #region Construtor
        public frmCadFamiliaMotor()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region Form Load
        private void frmCadFamiliaMotor_Load(object sender, EventArgs e)
        {

        }
        #endregion Form Load

        #region btnLimpa Click
        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._listaKitFamilia = null;
            this._modelEstoque = null;
            this._modelMotor = null;
            this._modelTipoMotor = null;
            this._modelNumeroMotor = null;
        }
        #endregion btnLimpa Click

        #region btnVolta Click
        private void btnVolta_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVolta Click

        #region btnConfirma Click
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnConfirma Click

        #region btnBuscarKit DataGrid Click
        private void btnBuscarKitDtGrid_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
            if (this._listaKitFamilia != null)
            {
                if (this._listaKitFamilia.Count > 0)
                {
                    this.ComparaDadosGrid();
                }
            }
        }
        #endregion btnBuscarKit DataGrid Click

        #region dgKits SelectionChanged
        private void dgKits_SelectionChanged(object sender, EventArgs e)
        {
            this.PopulaTelaKit();
        }
        #endregion dgKits SelectionChanged

        #region btnAdicionaKit Click
        private void btnAdicionaKit_Click(object sender, EventArgs e)
        {
            this.AdicionarKitLista();
        }
        #endregion  btnAdicionaKit Click

        #region btnBuscaNumMotor Click
        private void btnBuscaNumMotor_Click(object sender, EventArgs e)
        {
            this._modelNumeroMotor = new mNumMotor();
            frmBuscaNumMotor objForm = new frmBuscaNumMotor(this._modelNumeroMotor);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelNumeroMotor = null;
                }
                else
                {
                    this.txtNumeroMotor.Text = this._modelNumeroMotor.IdNumMotorReal + " - " + this._modelNumeroMotor.Dsc_num_motor;
                    this.lblCodigoFamiliaMotor.Text = this._modelNumeroMotor.IdNumMotorReal;
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
        #endregion btnBuscaNumMotor Click

        #region btnMotorCompra Click
        private void btnBuscaMotorCompra_Click(object sender, EventArgs e)
        {
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
                    this.txtMotorCompra.Text = this._modelMotor.DscMotor;
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
        #endregion btnMotorCompra Click

        #region btnTipoMotor Click
        private void btnBuscaTipoMotor_Click(object sender, EventArgs e)
        {
            this._modelTipoMotor = new mTipoMotor();
            frmBuscaTipoMotor objForm = new frmBuscaTipoMotor(this._modelTipoMotor);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelTipoMotor = null;
                }
                else
                {
                    this.txtTipoMotor.Text = this._modelTipoMotor.IdTipoMotorReal + " - " + this._modelTipoMotor.DscTipoMotor;
                    this.lblCodigoFamiliaMotor.Text += this._modelTipoMotor.IdTipoMotorReal;
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
        #endregion btnTipoMotor Click

        #region btnBuscaEstoque Click
        private void btnBuscaEstoque_Click(object sender, EventArgs e)
        {
            this._modelEstoque = new mEstoque();
            frmBuscaEstoque objForm = new frmBuscaEstoque(this._modelEstoque);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelEstoque = null;
                }
                else
                {
                    this.txtEstoque.Text = this._modelEstoque.Dsc_estoque;
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
        #endregion btnBuscaEstoque Click

        #region txtMotorCompra TextChanged
        private void txtMotorCompra_TextChanged(object sender, EventArgs e)
        {
            this.btnConfirma.Enabled = true;
        }
        #endregion  txtMotorCompra TextChanged

        #region txtDsMotor TextChanged
        private void txtDsMotor_TextChanged(object sender, EventArgs e)
        {
            this.btnConfirma.Enabled = true;
        }
        #endregion txtDsMotor TextChanged

        #endregion Eventos

        #region Metodos

        #region Abre Tela Resumo
        /// <summary>
        /// Abre a tela de resumo antes de gravar os dados no banco
        /// </summary>
        private void AbreTelaResumo()
        {
            string nomeFamMotor = this._modelNumeroMotor.IdNumMotorReal + this._modelTipoMotor.IdTipoMotorReal;
            string nomeMotor=this.txtMotorCompra.Text;

            Resumo.frmResumoKitFamilia ResumoKit = new TCC.UI.Resumo.frmResumoKitFamilia(this._listaKitFamilia,nomeFamMotor,nomeMotor);
            try
            {
                DialogResult resultado;
                resultado = ResumoKit.ShowDialog();
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
                ResumoKit = null;
            }
        }
        #endregion Abre Tela Resumo

        #region Insere
        /// <summary>
        /// Cadastra no banco os dados que estão no model
        /// </summary>
        private void Insere()
        {
            mFamiliaMotor model;
            rFamiliaMotor regra = new rFamiliaMotor();
            rKitFamilia regraKitFamilia = new rKitFamilia();

            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                this.AbreTelaResumo();
                regra.ValidarInsere(model);
                this.CompletaListaModelKitFamilia(model);
                foreach (mKitFamilia modelKitFamilia in this._listaKitFamilia)
                {
                    regraKitFamilia.ValidarInsere(modelKitFamilia);
                }
                this.btnLimpa_Click(null, null);
                this.btnConfirma.Enabled = false;
                MessageBox.Show("Registro salvo com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoMotorVazioExeception)
            {
                MessageBox.Show("É necessário associar um motor a familia de motores", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscaMotorCompra.Focus();
            }
            catch (BUSINESS.Exceptions.FamiliaMotor.CodigoRealFamiliaExistenteException)
            {
                MessageBox.Show("Código da Familia de Motores já existente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscaNumMotor.Focus();
            }
            catch (BUSINESS.Exceptions.FamiliaMotor.CodigoRealFamiliaVazioException)
            {
                MessageBox.Show("O Número de motor e o Tipo de motor não podem ser vazios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscaNumMotor.Focus();
            }
            catch (BUSINESS.Exceptions.FamiliaMotor.FamiliaSemKitsException)
            {
                MessageBox.Show("É necessário associar um kit a familia de motores", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscarKitDtGrid.Focus();
            }
            catch (BUSINESS.Exceptions.FamiliaMotor.TelaResumoCanceladaException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                regra = null;
                model = null;
                regraKitFamilia = null;
            }
        }
        #endregion Insere

        #region Valida Dados Nulos
        /// <summary>
        /// Valida os dados que não podem ser nulos na tela
        /// </summary>
        private void ValidaDadosNulos()
        {
            if (this._listaKitFamilia == null)
            {
                throw new BUSINESS.Exceptions.CodigoKitGrupoPecaVazioException();
            }
            else if (this._modelMotor == null)
            {
                throw new BUSINESS.Exceptions.CodigoMotorVazioExeception();
            }
            else if (this._modelNumeroMotor == null)
            {
                throw new BUSINESS.Exceptions.CodigoNumeroMotorVazioException();
            }
            else if (this._modelTipoMotor == null)
            {
                throw new BUSINESS.Exceptions.CodigoTipoMotorVazioExeception();
            }
        }
        #endregion Valida Dados Nulos

        #region Pega Dados Tela
        /// <summary>
        /// Pega os dados que estão na tela e popula o model
        /// </summary>
        /// <returns>Retorna o model populado</returns>
        private mFamiliaMotor PegaDadosTela()
        {
            mFamiliaMotor model = new mFamiliaMotor();
            rFamiliaMotor regra = new rFamiliaMotor();

            try
            {
                model.IdFamiliaMotor = regra.BuscaIdMaximo();
                string idFamReal = this._modelNumeroMotor.IdNumMotorReal + this._modelTipoMotor.IdTipoMotorReal;
                model.Id_fam_motor_real = idFamReal;
                model.DscFamiliaMotor = this.txtDsMotor.Text;
                model.FlgAtivo = true;
                string estoque= this.txtEstoque.Text;
                if (string.IsNullOrEmpty(estoque) == true)
                {
                    model.IdEstoque = null;
                }
                else
                {
                    model.IdEstoque = Convert.ToInt32(this._modelEstoque.Id_estoque);
                }
                model.IdMotor = Convert.ToInt32(this._modelMotor.IdMotor);
                model.IdNumMotor = Convert.ToInt32(this._modelNumeroMotor.Id_num_motor);
                model.IdTipoMotor = Convert.ToInt32(this._modelTipoMotor.IdTipoMotor);

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

        #region Completa Lista Model Kit Familia
        /// <summary>
        /// Completa a lista de model Kit Familia com o id da Familia que foi gravado no Banco de dados
        /// </summary>
        /// <param name="modelFamilia">model da Familia onde esta o id</param>
        private void CompletaListaModelKitFamilia(mFamiliaMotor modelFamilia)
        {
            foreach (mKitFamilia model in this._listaKitFamilia)
            {
                model.Id_farm_motor = modelFamilia.IdFamiliaMotor;
            }
        }
        #endregion Completa Lista Model Kit Familia

        #region Busca Kit
        /// <summary>
        /// Busca Kit atravez do filtro escolhido pelo usuario
        /// </summary>
        /// <param name="nomeKit">o filtro passado pelo usuário pode ser Vazio</param>
        /// <returns>DataTable com o resultado da query</returns>
        private DataTable BuscaKit(string nomeKit)
        {
            rKitGrupoPeca regraKit = new rKitGrupoPeca();
            try
            {
                if (this.rdbFiltroCodigo.Checked == true)
                {
                    return regraKit.BuscaKitCodigo(nomeKit);
                }
                else
                {
                    return regraKit.BuscaKitGrupoPecaNome(nomeKit);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraKit = null;
            }
        }
        #endregion Busca Kit

        #region Popula Grid
        /// <summary>
        /// Utiliza os dados da busca para popular o grid
        /// </summary>
        private void PopulaGrid()
        {
            DataTable dtSource = null;
            try
            {
                dtSource = this.BuscaKit(this.txtBuscaFiltro.Text);
                this.dgKits.DataSource = dtSource;
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

        #region Adicionar Kit Lista
        private void AdicionarKitLista()
        {
            try
            {
                this.ValidaAdicaoKit();
                if (this._listaKitFamilia != null)
                {
                    if (this._listaKitFamilia.Count > 0)
                    {
                        this.AlteraModelKitFamilia();
                    }
                }
                else
                {
                    this.PopulaModelKitFamilia();
                }
                this.AtualizaGrid();
                this.TxtNmKit.Text = "";
                this.txtQtdKit.Text = "";
            }
            catch (BUSINESS.Exceptions.FamiliaMotor.GridKitsSemDadosException)
            {
                MessageBox.Show("É Necessario buscar Kits", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscarKitDtGrid.Focus();
            }
            catch (BUSINESS.Exceptions.FamiliaMotor.QuantidadeMenorZeroException)
            {
                MessageBox.Show("Quantidade deve ser Maior que zero.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtQtdKit.Focus();
            }
        }
        #endregion Adicionar Kit Lista

        #region Popula Model Kit Familia
        /// <summary>
        /// Popula o model kit familia com os dados que estão no painel da tela
        /// </summary>
        /// <returns>model populado</returns>
        private mKitFamilia PopulaModelKitFamilia()
        {
            mKitFamilia model = new mKitFamilia();
            try
            {
                if (this._listaKitFamilia == null)
                {
                    this._listaKitFamilia = new List<mKitFamilia>();
                }
                model.Dat_alt = DateTime.Now;
                model.Flg_ativo = true;
                model.Id_farm_motor = null;
                model.Id_kit = this._idKit;
                model.Qtd_kit = Convert.ToInt32(this.txtQtdKit.Text);
                this._listaKitFamilia.Add(model);
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
        #endregion Popula Model Kit Familia

        #region Existe Model Kit Familia
        /// <summary>
        /// Verifica a Existencia da Kit na Lista de Model
        /// </summary>
        /// <param name="idKit">Id do Kit Procurado</param>
        /// <returns>Indice da pocição; Caso não encontre retorna -1</returns>
        private int ExisteModelKitFamilia(int idKit)
        {
            int retorno = -1;
            try
            {
                if (this._listaKitFamilia != null)
                {
                    for (int cont = 0; cont < this._listaKitFamilia.Count; cont++)
                    {
                        if (Convert.ToInt32(this._listaKitFamilia[cont].Id_kit) == idKit)
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
        #endregion Existe Model Kit Familia

        #region Popula Tela Kit
        /// <summary>
        /// Pega os dados do grid para popular os TextBox na tela
        /// </summary>
        private void PopulaTelaKit()
        {
            try
            {
                this.ComparaDadosGrid();
                if (this.dgKits.Rows.Count > 0)
                {
                    int indice = this.dgKits.CurrentRow.Index;
                    this.TxtNmKit.Text = this.dgKits["hNome", indice].Value.ToString();
                    this.txtQtdKit.Text = this.dgKits["hQtd", indice].Value.ToString();
                    this._idKit = Convert.ToInt32(this.dgKits["hIdKit", indice].Value);
                    this.txtQtdKit.Focus();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Popula Tela Kit

        #region Altera Model Kit Familia
        /// <summary>
        /// Caso o id do kit já exista no model apenas troca para a quantidade certa
        /// </summary>
        private void AlteraModelKitFamilia()
        {
            int indice;
            try
            {
                indice = this.ExisteModelKitFamilia(this._idKit);
                if (indice > -1)
                {
                    this._listaKitFamilia[indice].Qtd_kit = Convert.ToInt32(this.txtQtdKit.Text);
                }
                else
                {
                    this.PopulaModelKitFamilia();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Altera Model Kit Familia

        #region Atualiza Grid
        /// <summary>
        /// Atualiza o Grid com a quantidade do TextBox de quantidade
        /// </summary>
        private void AtualizaGrid()
        {
            DataTable dtSource = null;
            try
            {
                dtSource = (DataTable)this.dgKits.DataSource;
                dtSource.Columns["qtd"].ReadOnly = false;
                dtSource.Rows[this.dgKits.CurrentRow.Index]["qtd"] = this.txtQtdKit.Text;
                this.dgKits.DataSource = dtSource;
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
                dtSource = (DataTable)this.dgKits.DataSource;
                for (int contador = 0; contador < dtSource.Rows.Count; contador++)
                {
                    indice = this.ExisteModelKitFamilia(Convert.ToInt32(dtSource.Rows[contador]["id_kit"]));
                    if (indice > -1)
                    {
                        dtSource.Columns["qtd"].ReadOnly = false;
                        dtSource.Rows[contador]["qtd"] = this._listaKitFamilia[indice].Qtd_kit.ToString();
                    }
                }
                this.dgKits.DataSource = dtSource;
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

        #region Valida Adicao kit
        /// <summary>
        /// Valida a adição de Kits a lista
        /// </summary>
        private void ValidaAdicaoKit()
        {
            if (this.dgKits.DataSource == null)
            {
                throw new BUSINESS.Exceptions.FamiliaMotor.GridKitsSemDadosException();
            }
            int quantidade = Convert.ToInt32(this.txtQtdKit.Text);
            if (quantidade < 1)
            {
                throw new BUSINESS.Exceptions.FamiliaMotor.QuantidadeMenorZeroException();
            }
        }
        #endregion Valida Adicao Kit

        #endregion Metodos
    }
}
