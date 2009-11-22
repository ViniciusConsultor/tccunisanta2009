using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;
using TCC.MODEL;

namespace TCC.UI
{
    public partial class frmCadMotor : FormPai
    {
        List<mMotorFornecedor> _listaModelMotorFornecedor;

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
            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
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

        #endregion Metodos
    }
}
