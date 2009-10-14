using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using TCC.BUSINESS;
using System.Windows.Forms;

namespace TCC.UI
{
    public partial class frmCadCompra : Form
    {
        public frmCadCompra()
        {
            InitializeComponent();
        }

        private void frmCadCompra_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }

        public void BuscaIdMaximo()
        {
            rCompra regraCompra = new rCompra();
            try
            {
                this.txtCdCompra.Text = regraCompra.BuscaIdMaximoCompra().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraCompra = null;
            }
        }

        private void btnBuscaMotorCompra_Click(object sender, EventArgs e)
        {
            BUSCA.frmBuscaMotor objFrmMotor = new TCC.UI.BUSCA.frmBuscaMotor(this.txtCdMotorCompra);
            try
            {
                objFrmMotor.MdiParent = this.MdiParent;
                objFrmMotor.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objFrmMotor = null;
            }
        }

        private void btnBuscaDepartamento_Click(object sender, EventArgs e)
        {
            BUSCA.frmBuscaDepartamento objTela = new TCC.UI.BUSCA.frmBuscaDepartamento(this.txtDepartamento);
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

        private void btnBuscaFornecedor_Click(object sender, EventArgs e)
        {
            BUSCA.frmBuscaFornecedor objTela = new TCC.UI.BUSCA.frmBuscaFornecedor(this.txtFornecedor);
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
    }
}
