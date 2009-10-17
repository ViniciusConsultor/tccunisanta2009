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
    public partial class frmCadPeca : Form
    {
        mEstoque _modelEstoque;
        mTipoPeca _modelTipoPeca;
        public frmCadPeca()
        {
            InitializeComponent();
            _modelEstoque = new mEstoque();
            _modelTipoPeca = new mTipoPeca();
        }

        private void BuscaIdMaximo()
        {
            rPeca regra = new rPeca();
            try
            {
                this.txtCdPeca.Text = regra.BuscaIdMaximoPeca().ToString();
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
            this.Close();
        }

        private void btnCdTipoPeca_Click(object sender, EventArgs e)
        {
            BUSCA.frmBuscaTipoPeca objTela = new TCC.UI.BUSCA.frmBuscaTipoPeca(_modelTipoPeca);
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
            BUSCA.frmBuscaEstoque objTela = new TCC.UI.BUSCA.frmBuscaEstoque(_modelEstoque);
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
            this.LimpaDadosTela();
            this.BuscaIdMaximo();
        }

        private void LimpaDadosTela()
        {
            foreach (Control controle in this.Controls)
            {
                if (controle.GetType().Equals(new TextBox().GetType()) == true)
                {
                    controle.Text = string.Empty;
                }
            }
        }
    }
}
