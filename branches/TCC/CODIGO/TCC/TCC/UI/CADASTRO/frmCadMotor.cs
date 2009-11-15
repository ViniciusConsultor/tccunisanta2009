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
            mMotor model = this.PegaDadosTela();
            CADASTRO.frmCadMotorFornecedor obj = new TCC.UI.CADASTRO.frmCadMotorFornecedor(model.IdMotor, model.DscMotor);
            obj.ShowDialog();
        }
        #endregion btnRelacionarFornecedor Click

        #endregion Eventos

        #region Metodos

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
            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                base.LimpaDadosTela(this);
                this.btnAceitar.Enabled = false;
            }
            catch (BUSINESS.Exceptions.Motor.DescMotorExistenteException)
            {
                MessageBox.Show("Descrição para o Motor já existente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDsMotor.Focus();
            }
            catch (BUSINESS.Exceptions.Motor.DescMotorVazioException)
            {
                MessageBox.Show("É necessário digitar uma Descrição para o Motor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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

        #endregion Metodos
    }
}
