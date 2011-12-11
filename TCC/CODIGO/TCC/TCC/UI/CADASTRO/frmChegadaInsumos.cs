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
    public partial class frmChegadaInsumos : FormPai
    {
        #region Atributos

        mOrdemServico _modelOrdemServico;
        mPeca _modelPeca;
        mPecaEstoque _modelPecaEstoque;
        mPecaFornecedor _modelPecaFornecedor;
        mMotor _modelMotor;
        mMotorEstoque _modelMotorEstoque;
        mMotorFornecedor _modelMotorFornecedor;
        mEstoque _modelEstoque;
        mCompra _modelCompra;

        #endregion Atributos

        #region Construtor
 
        public frmChegadaInsumos()
        {
            InitializeComponent();
        }

        #endregion Construtor

        #region Eventos

        #region btnAceitar Click
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnAceitar Click

        #region btnLimpar Click
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);

            _modelMotorEstoque = null;
            _modelMotor = null;

            //this.PopulaGrid();
        }
        #endregion btnLimpar Click

        #region btnBuscaAlteracaoDelecao Click
        private void btnBuscaAlteracaoDelecao_Click(object sender, EventArgs e)
        {

        }
        #endregion btnBuscaAlteracaoDelecao Click

        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVoltar Click

        #region btnBuscarOrdemServDtGrid Click
        private void btnBuscarOrdemServDtGrid_Click(object sender, EventArgs e)
        {
            this.AbreTelaBuscaOrdemServico();
        }
        #endregion btnBuscarOrdemServDtGrid Click

        #region btnBuscaEstoque Click
        private void btnBuscaEstoque_Click(object sender, EventArgs e)
        {
            this.AbreTelaBuscaEstoque();
        }
        #endregion btnBuscaEstoque Click

        #region btnAdicionaPeca Click
        private void btnAdicionaPeca_Click(object sender, EventArgs e)
        {

        }
        #endregion btnAdicionaPeca Click

        #region btnRemovePeca Click
        private void btnRemovePeca_Click(object sender, EventArgs e)
        {

        }
        #endregion btnRemovePeca Click

        #endregion Eventos

        #region Metodos

        #region Insere
        /// <summary>
        /// Insere os dados que estão no model
        /// </summary>
        private void Insere()
        {
            //Novamente..fazer um codigo bacanudo..^^
            /*
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
            }*/
        }
        #endregion Insere

        #region Abre Tela Busca Estoque
        private void AbreTelaBuscaEstoque()
        {
            frmBuscaEstoque telaEstoque = null;
            try
            {
                this._modelEstoque = new mEstoque();

                telaEstoque = new frmBuscaEstoque(_modelEstoque);
                DialogResult resultado = telaEstoque.ShowDialog();
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
                telaEstoque = null;
            }
        }
        #endregion Abre Tela Busca Estoque

        #region Abre Tela Busca OrdemServico
        private void AbreTelaBuscaOrdemServico()
        {
            rOrdemServico regra = new rOrdemServico();
            frmBuscaCompra telaCompra = null;
            frmBuscaOrdemServico telaOrdemServ = null;

            DialogResult resultadoOrdemServ;
            DialogResult resultadoCompra;
            try
            {
                this._modelOrdemServico = new mOrdemServico();
                this._modelCompra = new mCompra();

                if (rdbBuscaOrdemServ.Checked == true)
                {
                    telaOrdemServ = new frmBuscaOrdemServico(this._modelOrdemServico);
                    resultadoOrdemServ = telaOrdemServ.ShowDialog();

                    if (resultadoOrdemServ == DialogResult.Cancel)
                    {
                        this._modelOrdemServico = null;
                    }
                    else
                    {
                        this.txtBuscaFiltro.Text = "Ordem de Serviço nº " + Convert.ToString(this._modelOrdemServico.IdOrdemServ);
                    }
                }
                else
                {
                    telaCompra = new frmBuscaCompra(this._modelCompra);
                    resultadoCompra = telaCompra.ShowDialog();

                    if (resultadoCompra == DialogResult.Cancel)
                    {
                        this._modelCompra = null;
                    }
                    else
                    {
                        regra.buscaOrdemServicoParamVenda(Convert.ToString(this._modelCompra));
                        //buscaria o codigo da ordem de servico a partir do codigo da venda..
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                telaCompra = null;
                //telaOrdemServ = null;
            }
        }
        #endregion Abre Tela Busca OrdemServico

        #region Pega Dados Tela Insumos
        private mCompra PegaDadosTelaInsumos()
        {//Fazer algum codigo bacanudo...^^
            /*mCompra model = new mCompra();
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
            }*/
            return this._modelCompra;
            //só p/ num da erro...
        }
        #endregion Pega Dados Tela Insumos

        #region Valida Dados Nulos
        /// <summary>
        /// Verifica quais dados da tela não podem ser nulos
        /// </summary>
        private void ValidaDadosNulos()
        {
            //Fazer um codigo bacanudo..^^
            /*
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
            }*/

        }
        #endregion Valida Dados Nulos

        #endregion Metodos
    }
}
