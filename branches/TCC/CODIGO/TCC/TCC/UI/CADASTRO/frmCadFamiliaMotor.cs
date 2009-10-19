using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;

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
    }
}
