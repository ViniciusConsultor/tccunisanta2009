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
    public partial class frmCadNumeroMotor : FormPai
    {
        #region Atributos
        mNumMotor _mNumeroMotor;
        #endregion Atributos

        #region Construtor
        public frmCadNumeroMotor()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region btnLimpar Click
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
        }
        #endregion btnLimpar Click

        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVoltar Click

        #region btnAceitar Click
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnAceitar Click

        #region txtIdRealMotor TextChanged
        private void txtIdRealMotor_TextChanged(object sender, EventArgs e)
        {
            this.btnAceitar.Enabled = true;
        }
        #endregion txtIdRealMotor TextChanged
        #endregion Eventos

        #region Metodos

        #region Insere
        private void Insere()
        {
            mNumMotor model = new mNumMotor();
            rNumeroMotor regra = new rNumeroMotor();
            try
            {
                this.validaDadosNulo();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                base.LimpaDadosTela(this);
                this.btnAceitar.Enabled = false;
                MessageBox.Show("Registro Salvo com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.NumeroMotor.CodigoNumeroMotorExistenteException)
            {
                MessageBox.Show("Código Número de Motor já existe", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtIdRealMotor.Focus();
            }
            catch (BUSINESS.Exceptions.NumeroMotor.NumeroMotorVazioExeption)
            {
                MessageBox.Show("É Necessário Informar o Número de Motor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtIdRealMotor.Focus();
            }
            catch (BUSINESS.Exceptions.NumeroMotor.DescMotorVazioException)
            {
                MessageBox.Show("É Necessário Informar uma Descrição para o Número de Motor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDscNumeroMotor.Focus();
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
        #endregion Insere

        #region PegaDadosTela
        private mNumMotor PegaDadosTela()
        {

            mNumMotor model = new mNumMotor();
            rNumeroMotor regra = new rNumeroMotor();

            try
            {
                model.Id_num_motor = regra.BuscaIdMaximo();
                model.IdNumMotorReal = this.txtIdRealMotor.Text;
                model.Dsc_num_motor = this.txtDscNumeroMotor.Text;
                model.Flg_ativo = true;

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

        #region validaDadosNulo
        public void validaDadosNulo()
            {
                try 
	            {
                    if (string.IsNullOrEmpty(this.txtIdRealMotor.Text) == true)
                    {
                        throw new BUSINESS.Exceptions.NumeroMotor.NumeroMotorVazioExeption();
                    }
                    else if(string.IsNullOrEmpty(this.txtDscNumeroMotor.Text) == true)
                    {
                        throw new BUSINESS.Exceptions.NumeroMotor.DescMotorVazioException();
                    }
	            }
	            catch (Exception ex)
	            {
            		
		            throw ex ;
	            }
            }
        #endregion validaDadosNulo

        #endregion Metodos
    }
}

