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

        mNumMotor _mNumeroMotor;

        public frmCadNumeroMotor()
        {
            InitializeComponent();
        }

        private void frmNumeroMotor_Load(object sender, EventArgs e)
        {
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        /*protected override void BuscaIdMaximo()
        {
            rNumeroMotor regra = new rNumeroMotor();
            try
            {
                this.txtCdNumeroMotor.Text = regra.BuscaIdMaximo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
            }
        }*/

        private void frmCadNumeroMotor_Load(object sender, EventArgs e)
        {
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Insere();

            mNumMotor modelNumeroMotor = new mNumMotor();
            BUSINESS.rNumeroMotor regraNumeroMotor = new BUSINESS.rNumeroMotor();

            try
            {
                if (base.Alteracao == false)
                {
                    this.validaDadosNulo();
                    modelNumeroMotor = this.PegaDadoosTela();
                    if (modelNumeroMotor != null)
                    {
                        regraNumeroMotor.ValidarInsere(modelNumeroMotor);
                    }
                    this.btnLimpar_Click(null, null);
                }
                else
                {
                    modelNumeroMotor = this.PegaDadoosTela();
                    regraNumeroMotor.ValidarAltera(modelNumeroMotor);
                }
                this.btnLimpar_Click(null, null);
            }
            catch (BUSINESS.Exceptions.NumeroMotor.NumeroMotorVazioExeption)
            {
                MessageBox.Show("inserir Numero do Motor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtIdRealMotor.Focus();
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                modelNumeroMotor=null;
            }
        }
        private void Insere()
        {
            mNumMotor model;
            rNumeroMotor regra = new rNumeroMotor();
            try
            {
                model = this.PegaDadoosTela();
                regra.ValidarInsere(model);
                base.LimpaDadosTela(this);
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

        private mNumMotor PegaDadoosTela()
        {

            mNumMotor model = new mNumMotor();
            rNumeroMotor regra = new rNumeroMotor();

            try
            {
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
            public void validaDadosNulo()
            {
                try 
	            {
                    if (this._mNumeroMotor == null)
                        throw new BUSINESS.Exceptions.NumeroMotor.NumeroMotorVazioExeption();
	            }
	            catch (Exception ex)
	            {
            		
		            throw ex ;
	            }
                 finally
                {

                }
           } 
    }
}

