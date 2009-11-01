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
        mFamiliaMotor _modelFamiliaMotor;
        mKitGrupoPeca _modelKit;

        public frmCadOrdemProducao()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelDepartamento = null;
            this._modelFamiliaMotor = null;
            this._modelKit = null;
            this._modelTipoProd = null;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnCdDep_Click(object sender, EventArgs e)
        {
            this._modelDepartamento = new mDepartamento();
            frmBuscaDepartamento objFrmDepartamento = new frmBuscaDepartamento(this._modelDepartamento);
            try
            {
                DialogResult resultado = objFrmDepartamento.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelDepartamento = null;
                }
                else
                {
                    this.txtCdDepartamento.Text = this._modelDepartamento.DscDepto;
                }
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
            this._modelFamiliaMotor = new mFamiliaMotor();
            frmBuscaFamiliaMotor objFrmBuscaMotor = new frmBuscaFamiliaMotor(this._modelFamiliaMotor);
            try
            {
                DialogResult resultado = objFrmBuscaMotor.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelFamiliaMotor = null;
                }
                else
                {
                    this.txtCdMotor.Text = this._modelFamiliaMotor.DscFamiliaMotor;
                }
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
            this._modelKit = new mKitGrupoPeca();
            frmBuscaKit objFrmBuscaKit = new frmBuscaKit(this._modelKit);
            try
            {
                DialogResult resultado = objFrmBuscaKit.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelKit = null;
                }
                else
                {
                    this.txtCdKit.Text = this._modelKit.Nom_grupo;
                }
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
            this._modelTipoProd = new mTipoProduto();
            frmBuscaTipoProduto objFrmTipoProduto = new frmBuscaTipoProduto(this._modelTipoProd);
            try
            {
                DialogResult resultado = objFrmTipoProduto.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelTipoProd = null;
                }
                else
                {
                    this.txtCdTipoProduto.Text = this._modelTipoProd.Nom;
                }
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
        }

        /*protected override void BuscaIdMaximo()
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
        }*/

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
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                this.btnLimpar_Click(null, null);
            }
            catch (BUSINESS.Exceptions.CodigoDepartamentoVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código do Departamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoFamiliaMotorVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código da Familia do Motor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoKitGrupoPecaVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código do Kit Grupo Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoTipoProdutoVazioExeception)
            {
                MessageBox.Show("É Necessário Buscar o código do Tipo de Produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                model = null;
                regra = null;
            }
        }

        private void ValidaDadosNulos()
        {
            if (this._modelDepartamento == null)
            {
                throw new BUSINESS.Exceptions.CodigoDepartamentoVazioException();
            }
            else if (this._modelFamiliaMotor == null)
            {
                throw new BUSINESS.Exceptions.CodigoFamiliaMotorVazioException();
            }
            else if (this._modelKit == null)
            {
                throw new BUSINESS.Exceptions.CodigoKitGrupoPecaVazioException();
            }
            else if (this._modelTipoProd == null)
            {
                throw new BUSINESS.Exceptions.CodigoTipoProdutoVazioExeception();
            }
        }

        private mOrdemProducao PegaDadosTela()
        {
            mOrdemProducao model = new mOrdemProducao();
            rOrdemProducao regra = new rOrdemProducao();

            try
            {
                model.Dsc_ordem = this.txtDs.Text;
                model.Id_depto = Convert.ToInt32( this._modelDepartamento.IdDepto);
                model.IdKit = Convert.ToInt32(this._modelKit.IdKit);
                model.Id_motor = Convert.ToInt32( this._modelFamiliaMotor.IdFamiliaMotor);
                model.Id_tipo_produto = Convert.ToInt32(this._modelTipoProd.IdTipoProd);

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

        private void lblCdDepartamento_Click(object sender, EventArgs e)
        {

        }
    }
}
