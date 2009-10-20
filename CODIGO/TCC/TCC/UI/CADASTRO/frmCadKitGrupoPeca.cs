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
    public partial class frmCadKitGrupoPeca : FormPai
    {
        mPeca _modelPeca;

        public frmCadKitGrupoPeca()
        {
            InitializeComponent();
            _modelPeca = new mPeca();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this.BuscaIdMaximo();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnCdPeca_Click(object sender, EventArgs e)
        {
            frmBuscaPeca objFrmPeca = new frmBuscaPeca(this._modelPeca);
            try
            {
                objFrmPeca.ShowDialog();
                this.txtCdPeca.Text = this._modelPeca.Nom;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objFrmPeca = null;
            }
        }

        private void btnCdItemPeca_Click(object sender, EventArgs e)
        {

        }

        protected override void BuscaIdMaximo()
        {
            rKitGrupoPeca regra = new rKitGrupoPeca();
            try
            {
                this.txtCdKit.Text = regra.BuscaIdMaximo();
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

        private void frmCadKitGrupoPeca_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }
    }
}
