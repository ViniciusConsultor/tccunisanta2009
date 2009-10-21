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
        mTipoProduto _modelTipoProd;
        mMotor _modelMotor;
        mKitGrupoPeca _modelKit;

        public frmCadOrdemProducao()
        {
            InitializeComponent();
            this._modelDepartamento = new mDepartamento();
            this._modelTipoProd = new mTipoProduto();
            this._modelMotor = new mMotor();
            this._modelKit = new mKitGrupoPeca();
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
            frmBuscaMotor objFrmBuscaMotor = new frmBuscaMotor(this._modelMotor);
            try
            {
                objFrmBuscaMotor.ShowDialog();
                this.txtCdMotor.Text = this._modelMotor.DscMotor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objFrmBuscaMotor = null;
            }
        }

        private void btnCdKit_Click(object sender, EventArgs e)
        {
            frmBuscaKit objFrmBuscaKit = new frmBuscaKit(this._modelKit);
            try
            {
                objFrmBuscaKit.ShowDialog();
                this.txtCdKit.Text = this._modelKit.Nom_grupo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objFrmBuscaKit = null;
            }
        }

        private void btnCdTipoProduto_Click(object sender, EventArgs e)
        {
            frmBuscaTipoProduto objFrmTipoProduto = new frmBuscaTipoProduto(this._modelTipoProd);
            try
            {
                objFrmTipoProduto.ShowDialog();
                this.txtCdTipoProduto.Text = this._modelTipoProd.Nom;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objFrmTipoProduto = null;
            }
        }

        private void frmCadOrdemProducao_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }

        protected override void BuscaIdMaximo()
        {
            rOrdemProducao regra = new rOrdemProducao();
            try
            {
                this.txtCdOrdemMotor.Text = regra.BuscaIdMaximo();
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

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Insere();
        }

        private void Insere()
        {
            mOrdemProducao model;
            rOrdemProducao regra = new rOrdemProducao();
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

        private mOrdemProducao PegaDadosTela()
        {
            mOrdemProducao model = new mOrdemProducao();
            try
            {
                model.Dsc_ordem = this.txtDs.Text;
                model.Id_depto = this._modelDepartamento.IdDepto;
                model.Id_grupo = this._modelKit.Id_grupo;
                model.Id_motor = this._modelMotor.IdMotor;
                model.Id_ordem = Convert.ToInt32(this.txtCdOrdemMotor.Text);
                model.Id_tipo_produto = this._modelTipoProd.IdTipoProd;

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
    }
}
