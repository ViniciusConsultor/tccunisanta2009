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

        #endregion Atributos

        #region Construtor
        public frmCadCompra()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

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
                MessageBox.Show("Quantidade não pode ser vazia ou menor que 1", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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

        #endregion Eventos

        #region Metodos

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
                //Verifica se é uma compra de motor ou peça
                //-----------------------------------------
                if (this.rdbMotor.Checked == true)
                {
                    modelOrdemCompra.Id_motor = Convert.ToInt32(this._modelMotor.IdMotor);
                }
                else
                {
                    modelOrdemCompra.Id_peca = Convert.ToInt32(this._modelPeca.IdPeca);
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
            if (string.IsNullOrEmpty(this.txtQtdItem.Text) == true)
            {
                throw new BUSINESS.Exceptions.Compra.CompraQuantidadeVaziaException();
            }
            else
            {
                int qtd = Convert.ToInt32(this.txtQtdItem.Text);
                if (qtd < 1)
                {
                    throw new BUSINESS.Exceptions.Compra.CompraQuantidadeVaziaException();
                }
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

        private void IniciaDataTable()
        {
            this._dtSource = new DataTable();
            DataColumn[] dtColuna = new DataColumn[3];
            try
            {
                dtColuna[0] = new DataColumn("Item");
                dtColuna[1] = new DataColumn("Fornecedor");
                dtColuna[2] = new DataColumn("Quantidade");
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

        private void PopulaDataTableModelOrdemCompra(mOrdemCompra model)
        {
            DataRow linha;
            try
            {
                linha = this._dtSource.NewRow();
                if (this._modelMotor == null)
                {
                    linha["Item"] = this._modelPeca.IdPecaReal + " - " + this._modelPeca.Nom;
                }
                else
                {
                    linha["Item"] = this._modelMotor.DscMotor;
                }
                linha["Fornecedor"] = this._modelFornecedor.NomeFornecedor;
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

        private mCompraOrdemCompra PegaDadosTelaCompraOrdemCompra()
        {
            mCompraOrdemCompra model = new mCompraOrdemCompra();
            try
            {
                model.Dat_alt = DateTime.Now;
                model.Flg_ativo = true;
                model.Id_compra = null;
                model.Id_ordem_compra = null;
                model.Qtd = Convert.ToInt32(this.txtQtdItem.Text);

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

        #endregion Metodos

        private void frmCadCompra_Load(object sender, EventArgs e)
        {
            IniciaDataTable();
        }
    }
}
