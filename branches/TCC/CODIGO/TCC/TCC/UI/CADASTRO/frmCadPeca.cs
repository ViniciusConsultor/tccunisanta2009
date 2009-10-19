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
    public partial class frmCadPeca : FormPai
    {
        mEstoque _modelEstoque;
        mTipoPeca _modelTipoPeca;
        public frmCadPeca()
        {
            InitializeComponent();
            _modelEstoque = new mEstoque();
            _modelTipoPeca = new mTipoPeca();
        }

        protected override void  BuscaIdMaximo()
        {
            rPeca regra = new rPeca();
            try
            {
                this.txtCdPeca.Text = regra.BuscaIdMaximoPeca();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnCdTipoPeca_Click(object sender, EventArgs e)
        {
            frmBuscaTipoPeca objTela = new frmBuscaTipoPeca(_modelTipoPeca);
            try
            {
                objTela.MdiParent = this.MdiParent;
                objTela.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objTela = null;
            }
        }

        private void btnCdEstoque_Click(object sender, EventArgs e)
        {
            frmBuscaEstoque objTela = new frmBuscaEstoque(_modelEstoque);
            try
            {
                objTela.MdiParent = this.MdiParent;
                objTela.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objTela = null;
            }
        }

        private void frmCadPeca_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this.BuscaIdMaximo();
        }
    }
}
