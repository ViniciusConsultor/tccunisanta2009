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
    public partial class frmCadFamiliaMotor : FormPai
    {
        public frmCadFamiliaMotor()
        {
            InitializeComponent();
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this.BuscaIdMaximo();
        }

        protected override void BuscaIdMaximo()
        {
            rFamiliaMotor regra = new rFamiliaMotor();
            try
            {
                this.txtCdMotor.Text = regra.BuscaIdMaximo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
            }
        }

        private void frmCadFamiliaMotor_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {

        }

        private void Insere()
        {
            mFamiliaMotor model;
            rFamiliaMotor regra = new rFamiliaMotor();
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
                model = null;
            }
        }

        private void btnBuscaCdNumMotor_Click(object sender, EventArgs e)
        {

        }

        private void btnCdKit_Click(object sender, EventArgs e)
        {

        }

        private void btnCdMotorCompra_Click(object sender, EventArgs e)
        {

        }

        private void btnCdTipoMotor_Click(object sender, EventArgs e)
        {

        }

        private void btnCdEstoque_Click(object sender, EventArgs e)
        {

        }
    }
}
