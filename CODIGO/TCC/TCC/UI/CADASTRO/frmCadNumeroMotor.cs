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
    public partial class frmCadNumeroMotor : FormPai
    {
        public frmCadNumeroMotor()
        {
            InitializeComponent();
        }

        private void frmNumeroMotor_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
            base.LimpaDadosTela(this);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        protected override void BuscaIdMaximo()
        {
            rFamiliaMotor regra = new rFamiliaMotor();
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
        }

        private void frmCadNumeroMotor_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }
    }
}
