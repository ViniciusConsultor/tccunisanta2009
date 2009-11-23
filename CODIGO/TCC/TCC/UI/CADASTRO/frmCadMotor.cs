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
    public partial class frmCadMotor : FormPai
    {
        #region Atributos
        mMotor _modelMotor;
        List<mMotorFornecedor> _listaModelMotorFornecedor;
        List<mMotorEstoque> _listaModelMotorEstoque;
        #endregion Atributos

        #region Construtor
        public frmCadMotor()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos
        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVoltar Click

        #region btnAceitar Click
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Inserir();
        }
        #endregion btnAceitar Click

        #region btnLimpar Click
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
        }
        #endregion btnLimpar Click

        #region txtDsMotor TextChanged
        private void txtDsMotor_TextChanged(object sender, EventArgs e)
        {
            this.btnAceitar.Enabled = true;
        }
        #endregion txtDsMotor TextChanged

        #region btnRelacionarFornecedor Click
        private void btnRelacionarFornecedor_Click(object sender, EventArgs e)
        {
            this.AbreTelaMotorFornecedor();
        }
        #endregion btnRelacionarFornecedor Click

        #region btnRelacioranEstoque Click
        private void btnRelacioranEstoque_Click(object sender, EventArgs e)
        {
            this.AbreTelaRelacionarEstoque();
        }
        #endregion btnRelacioranEstoque Click

        #endregion Eventos

        #region Metodos

        #region Abre Tela Motor Fornecedor
        /// <summary>
        /// Abre tela motor fornecedor
        /// </summary>
        private void AbreTelaMotorFornecedor()
        {
            mMotor model = null;
            CADASTRO.frmCadMotorFornecedor telaMotorFornecedor = null;
            try
            {
                this.ValidaDadosNulos();
                _listaModelMotorFornecedor = new List<mMotorFornecedor>();
                model = this.PegaDadosTela();
                telaMotorFornecedor = new TCC.UI.CADASTRO.frmCadMotorFornecedor(model, this._listaModelMotorFornecedor);
                DialogResult resultado = telaMotorFornecedor.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._listaModelMotorFornecedor = null;
                }
            }
            catch (BUSINESS.Exceptions.Motor.DescMotorVazioException)
            {
                MessageBox.Show("É necessário digitar uma Descrição para o Motor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDsMotor.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                model = null;
                telaMotorFornecedor = null;
            }
        }
        #endregion Abre Tela Motor Fornecedor

        #region Abre Tela Relacionar Estoque
        /// <summary>
        /// Abre a tela de relacionar a peça com o estoque
        /// </summary>
        private void AbreTelaRelacionarEstoque()
        {
            mMotor modelMotor = null;
            frmMotorEstoque telaMotorEstoque = null;
            _listaModelMotorEstoque = new List<mMotorEstoque>();
            try
            {
                this.ValidaDadosNulos();
                modelMotor = this.PegaDadosTela();
                telaMotorEstoque = new frmMotorEstoque(modelMotor, _listaModelMotorEstoque);
                DialogResult resultado = telaMotorEstoque.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._listaModelMotorEstoque = null;
                }
            }
            catch (BUSINESS.Exceptions.Motor.DescMotorExistenteException)
            {
                MessageBox.Show("Descrição para o Motor já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDsMotor.Focus();
            }
            catch (BUSINESS.Exceptions.Motor.DescMotorVazioException)
            {
                MessageBox.Show("É Necessário Digitar uma Descrição para o Motor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDsMotor.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                modelMotor = null;
                telaMotorEstoque = null;
            }
        }
        #endregion Abre Tela Relacionar Estoque

        #region PegaDadosTela
        private mMotor PegaDadosTela()
        {
            mMotor model = new mMotor();
            rMotor regra = new rMotor();

            try
            {
                model.IdMotor = regra.BuscaMaxId();
                model.DscMotor = this.txtDsMotor.Text;
                model.FlgAtivo = true;

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
        #endregion PegaDadosTela

        #region ValidaDadosNulos
        private void ValidaDadosNulos()
        {
            if (string.IsNullOrEmpty(this.txtDsMotor.Text))
            {
                throw new BUSINESS.Exceptions.Motor.DescMotorVazioException();
            }
        }
        #endregion ValidaDadosNulos

        #region Inserir
        private void Inserir()
        {
            mMotor model;
            rMotor regra = new rMotor();
            rMotorFornecedor regraMotorForn = new rMotorFornecedor();
            rMotorEstoque regraMotorEstoque = new rMotorEstoque();
            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);

                //Verifica se existe itens na lista de motor estoque
                //-------------------------------------------------
                if (this._listaModelMotorEstoque != null)
                {
                    if (this._listaModelMotorEstoque.Count > 0)
                    {
                        this.PopulaListaMotorEstoqueIdMotor(Convert.ToInt32(model.IdMotor));
                        foreach (mMotorEstoque modelMotorEstoque in this._listaModelMotorEstoque)
                        {
                            regraMotorEstoque.ValidarInsere(modelMotorEstoque);
                        }
                    }
                }
                //Verifica se existe itens na lista de motor fornecedor
                //-------------------------------------------------
                if (this._listaModelMotorFornecedor != null)
                {
                    if (this._listaModelMotorFornecedor.Count > 0)
                    {
                        this.PopulaListaMotorFornecedorIdMotor(Convert.ToInt32(model.IdMotor));
                        foreach (mMotorFornecedor modelMotorForn in this._listaModelMotorFornecedor)
                        {
                            regraMotorForn.ValidarInsere(modelMotorForn);
                        }
                    }
                }
                base.LimpaDadosTela(this);
                this.btnAceitar.Enabled = false;
                MessageBox.Show("Registro Salvo com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Motor.DescMotorExistenteException)
            {
                MessageBox.Show("Descrição para o Motor já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDsMotor.Focus();
            }
            catch (BUSINESS.Exceptions.Motor.DescMotorVazioException)
            {
                MessageBox.Show("É Necessário Digitar uma Descrição para o Motor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDsMotor.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                model = null;
                regra = null;
            }
        }
        #endregion Inserir

        #region PopulaListaMotorFornecedorIdMotor
        private void PopulaListaMotorFornecedorIdMotor(int idMotor)
        {
            try
            {
                foreach (mMotorFornecedor model in this._listaModelMotorFornecedor)
                {
                    model.Id_motor = idMotor;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion PopulaListaMotorFornecedorIdMotor

        #region Popula Lista Motor Estoque Id Motor
        /// <summary>
        /// Popula os models que estão na lista com o id do 
        /// Motor que foi cadastrado.
        /// </summary>
        /// <param name="idMotor">id da Motor cadastrado</param>
        private void PopulaListaMotorEstoqueIdMotor(int idMotor)
        {
            try
            {
                foreach (mMotorEstoque model in this._listaModelMotorEstoque)
                {
                    model.Id_motor = idMotor;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Popula Lista Motor Estoque Id Motor

        #endregion Metodos
    }
}
