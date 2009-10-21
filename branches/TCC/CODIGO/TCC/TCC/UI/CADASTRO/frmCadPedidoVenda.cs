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
    public partial class frmCadPedidoVenda : FormPai
    {
        mDepartamento _modelDepartamento;
        mVenda _modelVenda;

        public frmCadPedidoVenda()
        {
            InitializeComponent();
            _modelDepartamento = new mDepartamento();
            _modelVenda = new mVenda();
        }

        private void frmCadPedidoVenda_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
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

        protected override void BuscaIdMaximo()
        {
            rPedidoVenda regra = new rPedidoVenda();
            try
            {
                this.txtCdPedidoVenda.Text = regra.BuscaidMaximo();
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

        private void btnBuscaVendaMotor_Click(object sender, EventArgs e)
        {
            frmBuscaVenda objForm = new frmBuscaVenda(this._modelVenda);
            try
            {
                objForm.ShowDialog();
                this.txtCdVendaMotor.Text = this._modelVenda.IdVenda.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objForm = null;
            }
        }

        private void btnBuscaDepartamento_Click(object sender, EventArgs e)
        {
            frmBuscaDepartamento objForm = new frmBuscaDepartamento(this._modelDepartamento);
            try
            {
                objForm.ShowDialog();
                this.txtCdDepartamento.Text = this._modelDepartamento.DscDepto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objForm = null;
            }
        }

        private mPedidoVenda PegaDadosTela()
        {
            mPedidoVenda model = new mPedidoVenda();
            try
            {
                model.DatAlt = DateTime.Now;
                model.DscVenda = this.txtDsPedido.Text;
                model.IdDepto = this._modelDepartamento.IdDepto;
                model.IdPedido = Convert.ToInt32(this.txtCdPedidoVenda.Text);
                model.IdVenda = this._modelVenda.IdVenda;

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

        private void btnAceitar_Click(object sender, EventArgs e)
        {

        }

        private void Insere()
        {
            mPedidoVenda model;
            rPedidoVenda regra = new rPedidoVenda();
            try
            {
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                base.LimpaDadosTela(this);
                this.BuscaIdMaximo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                model = null;
                regra = null;
            }
        }
    }
}
 