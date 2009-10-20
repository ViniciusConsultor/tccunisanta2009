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
    public partial class frmCadOrdemProducao : FormPai
    {
        mDepartamento _modelDepartamento;

        public frmCadOrdemProducao()
        {
            InitializeComponent();
            this._modelDepartamento = new mDepartamento();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            base.BuscaIdMaximo();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnCdDep_Click(object sender, EventArgs e)
        {
            frmBuscaDepartamento objFrmDepartamento = new frmBuscaDepartamento(this._modelDepartamento);
            try
            {
                objFrmDepartamento.ShowDialog();
                this.txtCdDepartamento.Text = this._modelDepartamento.DscDepto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objFrmDepartamento = null;
            }
        }

        private void btnCdMotor_Click(object sender, EventArgs e)
        {

        }

        private void btnCdKit_Click(object sender, EventArgs e)
        {

        }

        private void btnCdTipoProduto_Click(object sender, EventArgs e)
        {
            frmBuscaTipoProduto objFrmTipoProduto = new frmBuscaTipoProduto
        }
    }
}
