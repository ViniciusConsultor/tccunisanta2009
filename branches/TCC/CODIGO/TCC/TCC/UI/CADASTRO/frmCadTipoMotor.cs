using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.MODEL;
using TCC.BUSINESS;

namespace TCC.UI
{
    public partial class frmCadTipoMotor : FormPai
    {
        #region Atributos
        mTipoMotor _mTipoMotor;
        #endregion Atributos

        #region Construtor
        public frmCadTipoMotor()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion

        #region Metodos
        private void Insere()
        {
            mTipoMotor model;
            rTipoMotor regra = new rTipoMotor();
            try
            {
                this.ValidaDadosNulos();
                model = this.PedaDadosTela();
                regra.ValidarInsere(model);
                base.LimpaDadosTela(this);
            }
            catch (BUSINESS.Exceptions.TipoMotor.NumeroTipoMotorVazioExeption)
            {
                MessageBox.Show("É necessário informar o código do Tipo do Motor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtIdReal.Focus();
            }
            catch (BUSINESS.Exceptions.TipoMotor.DescTipoMotorVazioException)
            {
                MessageBox.Show("É necessário informar uma descrição para o Tipo do Motor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNmTipoMotor.Focus();
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

        private mTipoMotor PedaDadosTela()
        {
            mTipoMotor model = new mTipoMotor();
            rTipoMotor regra = new rTipoMotor();
            try
            {
                model.IdTipoMotor = regra.BuscaMaxId();
                model.IdTipoMotorReal = this.txtIdReal.Text;
                model.DscTipoMotor = this.txtNmTipoMotor.Text;
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

        public void ValidaDadosNulos()
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtIdReal.Text) == true)
                {
                    throw new BUSINESS.Exceptions.TipoMotor.NumeroTipoMotorVazioExeption();
                }
                else if (string.IsNullOrEmpty(this.txtNmTipoMotor.Text) == true)
                {
                    throw new BUSINESS.Exceptions.TipoMotor.DescTipoMotorVazioException();
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