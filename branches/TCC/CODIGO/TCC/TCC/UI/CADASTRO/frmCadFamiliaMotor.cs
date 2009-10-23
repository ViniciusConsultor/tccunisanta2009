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
    public partial class frmCadFamiliaMotor : FormPai
    {
        mNumMotor _modelNumeroMotor;
        mKitGrupoPeca _modelKit;
        mMotor _modelMotor;
        mTipoMotor _modelTipoMotor;
        mEstoque _modelEstoque;

        public frmCadFamiliaMotor()
        {
            InitializeComponent();
            _modelNumeroMotor = new mNumMotor();
            _modelKit = new mKitGrupoPeca();
            _modelMotor = new mMotor();
            _modelTipoMotor = new mTipoMotor();
            _modelEstoque = new mEstoque();
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this.BuscaIdMaximo();
        }

        protected override void BuscaIdMaximo()
        {
            rFamiliaMotor regra = new rFamiliaMotor();
            try
            {
                this.txtCdFamiliaMotor.Text = regra.BuscaIdMaximo();
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

        private void frmCadFamiliaMotor_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
        }

        private void Insere()
        {
            mFamiliaMotor model;
            rFamiliaMotor regra = new rFamiliaMotor();
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
                regra = null;
                model = null;
            }
        }

        private mFamiliaMotor PegaDadosTela()
        {
            mFamiliaMotor model = new mFamiliaMotor();
            try
            {
                model.DscFamiliaMotor = this.txtDsMotor.Text;
                model.FlgAtivo = true;
                model.IdEstoque = this._modelEstoque.Id_estoque;
                model.IdFamiliaMotor = Convert.ToInt32(this.txtCdFamiliaMotor.Text);
                model.IdGrupo = this._modelKit.Id_grupo;
                model.IdMotor = this._modelMotor.IdMotor;
                model.IdNumMotor = this._modelNumeroMotor.Id_num_motor;
                model.IdTipoMotor = this._modelTipoMotor.IdTipoMotor;

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

        private void btnBuscaCdNumMotor_Click(object sender, EventArgs e)
        {
            frmBuscaNumMotor objForm = new frmBuscaNumMotor(this._modelNumeroMotor);
            try
            {
                objForm.ShowDialog();
                this.txtCdNumeroMotor.Text = this._modelNumeroMotor.Dsc_num_motor;
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

        private void btnCdKit_Click(object sender, EventArgs e)
        {
            frmBuscaKit objForm = new frmBuscaKit(this._modelKit);
            try
            {
                objForm.ShowDialog();
                this.txtCdKit.Text = this._modelKit.Nom_grupo;
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

        private void btnCdMotorCompra_Click(object sender, EventArgs e)
        {
            frmBuscaMotor objForm = new frmBuscaMotor(this._modelMotor);
            try
            {
                objForm.ShowDialog();
                this.txtCdMotor.Text = this._modelMotor.DscMotor;
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

        private void btnCdTipoMotor_Click(object sender, EventArgs e)
        {
            frmBuscaTipoMotor objForm = new frmBuscaTipoMotor(this._modelTipoMotor);
            try
            {
                objForm.ShowDialog();
                this.txtCdTipoMotor.Text = this._modelTipoMotor.DscTipoMotor;
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

        private void btnCdEstoque_Click(object sender, EventArgs e)
        {
            frmBuscaEstoque objForm = new frmBuscaEstoque(this._modelEstoque);
            try
            {
                objForm.ShowDialog();
                this.txtCdEstoque.Text = this._modelEstoque.Dsc_estoque;
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
    }
}
