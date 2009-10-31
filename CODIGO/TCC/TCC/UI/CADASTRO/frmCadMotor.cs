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
        public frmCadMotor()
        {
            InitializeComponent();
        }

        /*protected override void BuscaIdMaximo()
        {
            rMotor regraMotor = new rMotor();
            try
            {
                this.txtCdMotor.Text = regraMotor.BuscaIdMaximoMotor();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraMotor = null;
            }
        }*/

        private void frmMotor_Load(object sender, EventArgs e)
        {
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            mMotor model;
            rMotor regra = new rMotor();
            try
            {
                model = this.PegaDadosTela();
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

        private mMotor PegaDadosTela()
        {
            mMotor model = new mMotor();
            rMotor regra = new rMotor();

            try
            {
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
        }
    }
}
