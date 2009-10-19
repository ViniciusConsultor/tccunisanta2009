using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using TCC.BUSINESS;
using System.Windows.Forms;
using TCC.MODEL;

namespace TCC.UI
{
    public partial class frmCadCompra : FormPai
    {
        mMotor _modelMotor;
        mDepartamento _modelDepartamento;
        mFornecedor _modelFornecedor;
        public frmCadCompra()
        {
            InitializeComponent();
            _modelMotor = new mMotor();
            _modelDepartamento = new mDepartamento();
            _modelFornecedor = new mFornecedor();
        }

        private void frmCadCompra_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }

        protected override void BuscaIdMaximo()
        {
            rCompra regraCompra = new rCompra();
            try
            {
                this.txtCdCompra.Text = regraCompra.BuscaIdMaximoCompra();
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
            frmBuscaMotor objFrmMotor = new frmBuscaMotor(_modelMotor);
            try
            {
                objFrmMotor.ShowDialog();
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
            frmBuscaDepartamento objTela = new frmBuscaDepartamento(_modelDepartamento);
            try
            {
                objTela.ShowDialog();
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
            frmBuscaFornecedor objTela = new frmBuscaFornecedor(_modelFornecedor);
            try
            {
                objTela.ShowDialog();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this.BuscaIdMaximo();
        }
    }
}
