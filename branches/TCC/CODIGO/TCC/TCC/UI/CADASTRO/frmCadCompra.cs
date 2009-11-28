using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using TCC.BUSINESS;
using System.Windows.Forms;
using TCC.MODEL;

namespace TCC.UI
{
    public partial class frmCadCompra : FormPai
    {
        #region Atributos

        List<mOrdemCompra> _listaOrdemCompra;
        mMotor _modelMotor;
        mPeca _modelPeca;
        mFornecedor _modelFornecedor;
        DataTable _dtSource;
        int _id;

        #endregion Atributos

        #region Construtor
        public frmCadCompra()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region Form Load
        private void frmCadCompra_Load(object sender, EventArgs e)
        {
            IniciaDataTable();
        }
        #endregion Form Load

        #region btnRemoveItem Click
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            this.RemoveOrdemCompra();
        }
        #endregion btnRemoveItem Click

        #region btnAdicionaItem Click
        private void btnAdicionaItem_Click(object sender, EventArgs e)
        {
            rOrdemCompra regraOrdemCompra = new rOrdemCompra();
            mOrdemCompra modelOrdemCompra = null;
            try
            {
                this.ValidaAdicaoOrdemCompra();
                modelOrdemCompra = this.PegaDadosTelaOrdemCompra();
                if (this._listaOrdemCompra == null)
                {
                    this._listaOrdemCompra = new List<mOrdemCompra>();
                }
                this._listaOrdemCompra.Add(modelOrdemCompra);
                this.PopulaDataTableModelOrdemCompra(modelOrdemCompra);
                this.dgItems.DataSource = this._dtSource;
                this.LimpaGrupoOrdemCompra();
            }
            catch (BUSINESS.Exceptions.Compra.BuscaMotorException)
            {
                MessageBox.Show("É necessário busca um motor para compra", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Compra.BuscaPecaException)
            {
                MessageBox.Show("É necessário buscar uma peça para compra", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Compra.CompraQuantidadeVaziaException)
            {
                MessageBox.Show("Quantidade não pode ser vazia", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtQtdItem.Focus();
            }
            catch (BUSINESS.Exceptions.Compra.CompraQuantidadeMenorQueUmException)
            {
                MessageBox.Show("Quantidade não pode ser 0(zero)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtQtdItem.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraOrdemCompra = null;
                modelOrdemCompra = null;
            }
        }
        #endregion btnAdicionaItem Click

        #region btnBuscaFornecedor Click
        private void btnBuscaFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidaBuscas();
                this.AbreTelaBuscaFornecedor();
            }
            catch (BUSINESS.Exceptions.Compra.BuscaMotorPecaException)
            {
                MessageBox.Show("É Necessário buscar um Motor ou uma Peça antes de Buscar um Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscarItemDtGrid.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {

            }
        }
        #endregion btnBuscaFornecedor Click

        #region btnBuscarItemDtGrid Click
        private void btnBuscarItemDtGrid_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.rdbMotor.Checked == true)
                {
                    this.AbreTelaBuscaMotor();
                }
                else
                {
                    this.AbreTelaBuscaPeca();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }
        #endregion btnBuscarItemDtGrid Click

        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVoltar Click

        #region btnLimpar Click
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelFornecedor = null;
            this._modelMotor = null;
            this._modelPeca = null;
            this._listaOrdemCompra = null;
        }
        #endregion btnLimpar Click

        #region rdbPeca CheckedChanged
        private void rdbPeca_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbMotor.Checked == true)
            {
                this._modelPeca = null;
            }
            else
            {
                this._modelMotor = null;
            }
        }
        #endregion rdbPeca CheckedChanged

        #region btnNovoRegistro Click
        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            this.LimpaGrupoOrdemCompra();
        }
        #endregion btnNovoRegistro Click

        #region dgItems Click
        private void dgItems_Click(object sender, EventArgs e)
        {
            this.PopulaTelaOrdemCompra();
        }
        #endregion dgItems Click

        #region btnAceitar Click
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            rCompra regraCompra = new rCompra();
            mCompra modelCompra = null;
            rOrdemCompra regraOrdemCompra = new rOrdemCompra();
            rCompraOrdemCompra regraCompraOrdemCompra = new rCompraOrdemCompra();
            mCompraOrdemCompra modelCompraOrdemCompra = null;
            try
            {
                this.ValidaDadosNulos();
                //Insere compra
                //-------------
                modelCompra = this.PegaDadosTelaCompra();
                regraCompra.ValidarInsere(modelCompra);

                //Insere ordem Compra
                //-------------------
                foreach (mOrdemCompra modelOrdemCompra in this._listaOrdemCompra)
                {
                    this.PegaIdMaximoOrdemCompra(modelOrdemCompra);
                    regraOrdemCompra.ValidarInsere(modelOrdemCompra);
                    modelCompraOrdemCompra = this.PegaDadosTelaCompraOrdemCompra(Convert.ToInt32(modelCompra.IdCompra), Convert.ToInt32(modelOrdemCompra.Id_ordem_compra));
                    regraCompraOrdemCompra.ValidarInsere(modelCompraOrdemCompra);
                }
                this.btnLimpar_Click(null, null);
            }
            catch (BUSINESS.Exceptions.Compra.OrdemCompraSemDadosException)
            {
                MessageBox.Show("É necessário adicionar itens para a compra", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Compra.CompraValorVazioException)
            {
                MessageBox.Show("É Necessário ter um valor de compra", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtValor.Focus();
            }
            catch (BUSINESS.Exceptions.Compra.DataCompraVaziaException)
            {
                MessageBox.Show("É Necessário ter a data de Compra", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDataCompra.Focus();
            }
            catch (BUSINESS.Exceptions.Validacoes.DataInvalidaException ex)
            {
                MessageBox.Show("Erro no " + ex.TipoErro.ToString() + " da Data: " + ex.DataErrada, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDataCompra.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                regraCompra = null;
                modelCompra = null;
                regraOrdemCompra = null;
                regraCompraOrdemCompra = null;
                modelCompraOrdemCompra = null;
            }
        }
        #endregion btnAceitar Click

        #endregion Eventos

        #region Metodos

        #region Popula Tela Ordem Compra
        /// <summary>
        /// Pega os dados do grid para popular os TextBox na tela
        /// </summary>
        private void PopulaTelaOrdemCompra()
        {
            try
            {
                if (this.dgItems.Rows.Count > 0)
                {
                    this.ComparaDadosGrid();
                    int indice = this.dgItems.CurrentRow.Index;
                    this.txtBuscaFiltro.Text = this.dgItems["hNomeItem", indice].Value.ToString();
                    this.txtQtdItem.Text = this.dgItems["hQuantidade", indice].Value.ToString();
                    this.txtFornecedor.Text = this.dgItems["hFornecedor", indice].Value.ToString();
                    this._id = Convert.ToInt32(this.dgItems["hId", indice].Value);
                    this.txtQtdItem.Focus();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Popula Tela Ordem Compra

        #region Compara Dados Grid
        /// <summary>
        /// Compara os dados do Grid com os do model e substitui a quantidade caso exitam ids iguais
        /// </summary>
        private void ComparaDadosGrid()
        {
            DataTable dtSource = null;
            int indice=0;
            try
            {
                dtSource = (DataTable)this.dgItems.DataSource;
                for (int contador = 0; contador < dtSource.Rows.Count; contador++)
                {
                    indice = this.ExisteModelOrdemCompra(Convert.ToInt32(dtSource.Rows[contador]["id_item"]), Convert.ToBoolean(dtSource.Rows[contador]["flg_motor"]));
                    if (indice > -1)
                    {
                        dtSource.Columns["quantidade"].ReadOnly = false;
                        dtSource.Rows[contador]["quantidade"] = this._listaOrdemCompra[indice].Qtd.ToString();
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

        #region Existe Model Item Kit
        /// <summary>
        /// Verifica a Existencia de Item na Lista de Model
        /// </summary>
        /// <param name="idItem">Id do Item Procurado</param>
        /// <returns>Indice da pocição; Caso não encontre retorna -1</returns>
        private int ExisteModelOrdemCompra(int idItem, bool motor)
        {
            int retorno = -1;
            try
            {
                if (this._listaOrdemCompra != null)
                {
                    for (int cont = 0; cont < this._listaOrdemCompra.Count; cont++)
                    {
                        if (motor == true)
                        {
                            if (Convert.ToInt32(this._listaOrdemCompra[cont].Id_motor) == idItem)
                            {
                                retorno = cont;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(this._listaOrdemCompra[cont].Id_peca) == idItem)
                            {
                                retorno = cont;
                            }
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
        #endregion Existe Model Item Kit

        #region Abre Tela Busca Fornecedor
        /// <summary>
        /// Busca fornecedor para relacionar a compra
        /// </summary>
        private void AbreTelaBuscaFornecedor()
        {
            frmBuscaFornecedor telaFornecedor = null;
            try
            {
                this._modelFornecedor = new mFornecedor();
                if (rdbMotor.Checked == true)
                {
                    telaFornecedor = new frmBuscaFornecedor(this._modelFornecedor, this._modelMotor);
                }
                else
                {
                    telaFornecedor = new frmBuscaFornecedor(this._modelFornecedor, this._modelPeca);
                }
                DialogResult resultado = telaFornecedor.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelFornecedor = null;
                }
                else
                {
                    this.txtFornecedor.Text = this._modelFornecedor.NomeFornecedor;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                telaFornecedor = null;
            }
        }
        #endregion Abre Tela Busca Fornecedor

        #region Abre Tela Busca Peca
        /// <summary>
        /// Abre a tela para buscar uma Peça
        /// </summary>
        private void AbreTelaBuscaPeca()
        {
            frmBuscaPeca telaPeca = null;
            try
            {
                this._modelPeca = new mPeca();
                telaPeca = new frmBuscaPeca(this._modelPeca);
                DialogResult resultado = telaPeca.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelPeca = null;
                }
                else
                {
                    this.txtBuscaFiltro.Text = this._modelPeca.IdPecaReal + " - " + this._modelPeca.Nom;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                telaPeca = null;
            }
        }
        #endregion Abre Tela Busca Peca

        #region Abre Tela Busca Motor
        /// <summary>
        /// Abre a tela para buscar um motor
        /// </summary>
        private void AbreTelaBuscaMotor()
        {
            frmBuscaMotor telaMotor = null;
            try
            {
                this._modelMotor = new mMotor();
                telaMotor = new frmBuscaMotor(this._modelMotor);
                DialogResult resultado = telaMotor.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelMotor = null;
                }
                else
                {
                    this.txtBuscaFiltro.Text = this._modelMotor.DscMotor;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                telaMotor = null;
            }
        }
        #endregion Abre Tela Busca Motor

        #region Pega Dados Tela Compra
        /// <summary>
        /// Popula o model de compra com os dados que estam na tela
        /// </summary>
        /// <returns>model com dados que estam na tela</returns>
        private mCompra PegaDadosTelaCompra()
        {
            mCompra model = new mCompra();
            rCompra regra = new rCompra();
            try
            {
                model.Dat = Convert.ToDateTime(this.txtDataCompra.Text);
                model.IdCompra = regra.BuscaIdMaximo();
                model.Obs = this.txtObs.Text;
                model.Valor = Convert.ToDouble(this.txtValor.Text);
                MessageBox.Show("Registro salvo com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

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
        #endregion Pega Dados Tela Compra

        #region Pega Dados Tela Ordem Compra
        /// <summary>
        /// Pega os dados da tela e popula o model de Ordem de Compra
        /// </summary>
        /// <returns>model de ordem de compra com dados</returns>
        private mOrdemCompra PegaDadosTelaOrdemCompra()
        {
            mOrdemCompra modelOrdemCompra = new mOrdemCompra();
            rOrdemCompra regraOrdemCompra = new rOrdemCompra();
            try
            {
                modelOrdemCompra.Dat_alt = DateTime.Now;
                modelOrdemCompra.Flg_ativo = true;
                modelOrdemCompra.Id_forn = Convert.ToInt32(this._modelFornecedor.IdFornecedor);
                modelOrdemCompra.Nota_fisc = null;
                modelOrdemCompra.Ultim_preco = null;
                modelOrdemCompra.Qtd = Convert.ToInt32(this.txtQtdItem.Text);
                //Verifica se é uma compra de motor ou peça
                //-----------------------------------------
                if (this.rdbMotor.Checked == true)
                {
                    modelOrdemCompra.Id_motor = Convert.ToInt32(this._modelMotor.IdMotor);
                    modelOrdemCompra.Id_peca = null;
                }
                else
                {
                    modelOrdemCompra.Id_peca = Convert.ToInt32(this._modelPeca.IdPeca);
                    modelOrdemCompra.Id_motor = null;
                }

                return modelOrdemCompra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                modelOrdemCompra = null;
                regraOrdemCompra = null;
            }
        }
        #endregion Pega Dados Tela Ordem Compra

        #region Valida Dados Nulos
        /// <summary>
        /// Verifica quais dados da tela não podem ser nulos
        /// </summary>
        private void ValidaDadosNulos()
        {
            string data = this.txtDataCompra.Text.Replace("/", string.Empty);
            data = data.Replace(" ", string.Empty);
            data = data.Replace("_", string.Empty);
            if (string.IsNullOrEmpty(this.txtValor.Text) == true)
            {
                throw new BUSINESS.Exceptions.Compra.CompraValorVazioException();
            }
            else if (string.IsNullOrEmpty(data) == true)
            {
                throw new BUSINESS.Exceptions.Compra.DataCompraVaziaException();
            }
            else
            {
                BUSINESS.UTIL.Validacoes.ValidaData(this.txtDataCompra.Text);
            }
            if (this._listaOrdemCompra != null)
            {
                if (this._listaOrdemCompra.Count < 1)
                {
                    throw new BUSINESS.Exceptions.Compra.OrdemCompraSemDadosException();
                }
            }
            else
            {
                throw new BUSINESS.Exceptions.Compra.OrdemCompraSemDadosException();
            }
        }
        #endregion Valida Dados Nulos

        #region Valida Adicao Ordem Compra
        /// <summary>
        /// Valida adição da ordem de compra
        /// </summary>
        private void ValidaAdicaoOrdemCompra()
        {
            if (this.rdbMotor.Checked == true)
            {
                if (this._modelMotor == null)
                {
                    throw new BUSINESS.Exceptions.Compra.BuscaMotorException();
                }
            }
            else
            {
                if (this._modelPeca == null)
                {
                    throw new BUSINESS.Exceptions.Compra.BuscaPecaException();
                }
            }
            if (string.IsNullOrEmpty(this.txtQtdItem.Text) == true)
            {
                throw new BUSINESS.Exceptions.Compra.CompraQuantidadeVaziaException();
            }
            else
            {
                if (Convert.ToInt32(this.txtQtdItem.Text) < 1)
                {
                    throw new BUSINESS.Exceptions.Compra.CompraQuantidadeMenorQueUmException();
                }
            }
        }
        #endregion Valida Adicao Ordem Compra

        #region Valida Buscas
        /// <summary>
        /// Valida se o Usuário pode Buscar a peça ou o motor
        /// </summary>
        private void ValidaBuscas()
        {
            if (this._modelMotor == null && this._modelPeca == null)
            {
                throw new BUSINESS.Exceptions.Compra.BuscaMotorPecaException();
            }
        }
        #endregion Valida Buscas

        #region Inicia Data Table
        /// <summary>
        /// Atribui as Colunas no DataTable que servirá de dataSource
        /// </summary>
        private void IniciaDataTable()
        {
            this._dtSource = new DataTable();
            DataColumn[] dtColuna = new DataColumn[5];
            try
            {
                dtColuna[0] = new DataColumn("id_item");
                dtColuna[1] = new DataColumn("flg_motor");
                dtColuna[2] = new DataColumn("item");
                dtColuna[3] = new DataColumn("fornecedor");
                dtColuna[4] = new DataColumn("quantidade");

                this._dtSource.Columns.AddRange(dtColuna);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dtColuna = null;
            }
        }
        #endregion Inicia Data Table

        #region Popula Data Table Model Ordem Compra
        /// <summary>
        /// Popula o datatable com o model que foi populado anteriormente
        /// </summary>
        /// <param name="model">model que será utilizado para popular o DataTable</param>
        private void PopulaDataTableModelOrdemCompra(mOrdemCompra model)
        {
            DataRow linha;
            try
            {
                linha = this._dtSource.NewRow();
                if (this._modelMotor == null)
                {
                    linha["id_item"] = this._modelPeca.IdPeca;
                    linha["item"] = this._modelPeca.IdPecaReal + " - " + this._modelPeca.Nom;
                    linha["flg_motor"] = false;
                }
                else
                {
                    linha["id_item"] = _modelMotor.IdMotor;
                    linha["item"] = this._modelMotor.DscMotor;
                    linha["flg_motor"] = true;
                }
                linha["fornecedor"] = this._modelFornecedor.NomeFornecedor;
                linha["quantidade"] = model.Qtd;
                this._dtSource.Rows.Add(linha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                linha = null;
            }
        }
        #endregion Popula Data Table Model Ordem Compra

        #region Pega Dados Tela Compra Ordem Compra
        /// <summary>
        /// Pega os dados da tela relacionados com ordem de compra
        /// </summary>
        /// <returns>model populado</returns>
        private mCompraOrdemCompra PegaDadosTelaCompraOrdemCompra()
        {
            mCompraOrdemCompra model = new mCompraOrdemCompra();
            try
            {
                model.Dat_alt = DateTime.Now;
                model.Flg_ativo = true;
                model.Id_compra = null;
                model.Id_ordem_compra = null;

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
        #endregion Pega Dados Tela Compra Ordem Compra

        #region Limpa Grupo Ordem Compra
        /// <summary>
        /// Limpa a parte da tela de Ordem Compra
        /// </summary>
        private void LimpaGrupoOrdemCompra()
        {
            try
            {
                foreach (Control controle in this.gpbOrdemCompra.Controls)
                {
                    Type tipo = controle.GetType();
                    if (tipo.Equals(typeof(TextBox)) == true || tipo.Equals(typeof(Controles.MegaTextBox.MegaTextBox)) == true)
                    {
                        controle.Text = string.Empty;
                    }
                }
                this._modelFornecedor = null;
                this._modelMotor = null;
                this._modelPeca = null;
                this.rdbPeca.Checked = true;
                this.rdbMotor.Checked = false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion Limpa Grupo Ordem Compra

        #region Remove Ordem Compra
        /// <summary>
        /// Remove peça da lista
        /// </summary>
        private void RemoveOrdemCompra()
        {
            int indice;
            int linhaAtual;
            DataTable dtSource = null;
            try
            {
                dtSource = (DataTable)this.dgItems.DataSource;
                if (dtSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        linhaAtual = this.dgItems.CurrentRow.Index;
                        int id = Convert.ToInt32(this.dgItems["hId", linhaAtual].Value);
                        bool motor = Convert.ToBoolean(this.dgItems["hFlg_motor", linhaAtual].Value);
                        indice = this.ExisteModelOrdemCompra(id, motor);
                        if (indice > -1)
                        {
                            this.txtQtdItem.Text = "0";
                            this._listaOrdemCompra.RemoveAt(indice);
                            this._dtSource.Rows.RemoveAt(indice);
                            this.dgItems.DataSource = this._dtSource;
                            this.LimpaGrupoOrdemCompra();
                        }
                        else
                        {
                            MessageBox.Show("Peça não associada ao Item", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Remove Ordem Compra

        #region Pega Dados Tela Compra Ordem Compra
        /// <summary>
        /// Pega os dados dos models gravados
        /// </summary>
        /// <param name="idCompra">id da compra</param>
        /// <param name="idOrdemCompra">id da ordem de compra</param>
        /// <returns>retorna o model populado</returns>
        private mCompraOrdemCompra PegaDadosTelaCompraOrdemCompra(int idCompra, int idOrdemCompra)
        {
            mCompraOrdemCompra model = new mCompraOrdemCompra();
            try
            {
                model.Dat_alt = DateTime.Now;
                model.Flg_ativo = true;
                model.Id_compra = idCompra;
                model.Id_ordem_compra = idOrdemCompra;

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
        #endregion Pega Dados Tela Compra Ordem Compra

        #region Pega Id Maximo Ordem Compra
        /// <summary>
        /// Busca atribui o idmaximo de ordem de compras
        /// </summary>
        /// <param name="model">model com os dados sem o id</param>
        private void PegaIdMaximoOrdemCompra(mOrdemCompra model)
        {
            rOrdemCompra regraOrdemCompra = new rOrdemCompra();
            try
            {
                model.Id_ordem_compra = regraOrdemCompra.BuscaIdMaximo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Pega Id Maximo Ordem Compra

        #endregion Metodos
    }
}
