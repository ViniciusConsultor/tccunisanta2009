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
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelEstoque = null;
            this._modelKit = null;
            this._modelMotor = null;
            this._modelNumeroMotor = null;
            this._modelTipoMotor = null;
        }

        /*protected override void BuscaIdMaximo()
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
        }*/

        private void frmCadFamiliaMotor_Load(object sender, EventArgs e)
        {
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
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                this.btnLimpa_Click(null, null);
            }
            catch (BUSINESS.Exceptions.CodigoEstoqueVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código do Estoque", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoKitGrupoPecaVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código do Kit", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoMotorVazioExeception)
            {
                MessageBox.Show("É Necessário Buscar o código do Motor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoNumeroMotorVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código do Número do Motor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoTipoMotorVazioExeception)
            {
                MessageBox.Show("É Necessário Buscar o código do Tipo de Motor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                regra = null;
                model = null;
            }
        }

        private void ValidaDadosNulos()
        {
            if (this._modelEstoque == null)
            {
                throw new BUSINESS.Exceptions.CodigoEstoqueVazioException();
            }
            else if (this._modelKit == null)
            {
                throw new BUSINESS.Exceptions.CodigoKitGrupoPecaVazioException();
            }
            else if (this._modelMotor == null)
            {
                throw new BUSINESS.Exceptions.CodigoMotorVazioExeception();
            }
            else if (this._modelNumeroMotor == null)
            {
                throw new BUSINESS.Exceptions.CodigoNumeroMotorVazioException();
            }
            else if (this._modelTipoMotor == null)
            {
                throw new BUSINESS.Exceptions.CodigoTipoMotorVazioExeception();
            }
        }

        private mFamiliaMotor PegaDadosTela()
        {
            mFamiliaMotor model = new mFamiliaMotor();
            rFamiliaMotor regra = new rFamiliaMotor();

            try
            {
                model.DscFamiliaMotor = this.txtDsMotor.Text;
                model.FlgAtivo = true;
                model.IdEstoque = this._modelEstoque.Id_estoque;
                model.IdFamiliaMotor = Convert.ToInt32(regra.BuscaIdMaximo());
                model.IdKit = this._modelKit.IdKit;
                model.IdMotor = Convert.ToInt32(this._modelMotor.IdMotor);
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
            this._modelNumeroMotor = new mNumMotor();
            frmBuscaNumMotor objForm = new frmBuscaNumMotor(this._modelNumeroMotor);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelNumeroMotor = null;
                }
                else
                {
                    this.txtCdNumeroMotor.Text = this._modelNumeroMotor.Dsc_num_motor;
                }
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
            this._modelKit = new mKitGrupoPeca();
            frmBuscaKit objForm = new frmBuscaKit(this._modelKit);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
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
                objForm = null;
            }
        }

        private void btnCdMotorCompra_Click(object sender, EventArgs e)
        {
            this._modelMotor = new mMotor();
            frmBuscaMotor objForm = new frmBuscaMotor(this._modelMotor);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelMotor = null;
                }
                else
                {
                    this.txtCdMotor.Text = this._modelMotor.DscMotor;
                }
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
            this._modelTipoMotor = new mTipoMotor();
            frmBuscaTipoMotor objForm = new frmBuscaTipoMotor(this._modelTipoMotor);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelTipoMotor = null;
                }
                else
                {
                    this.txtCdTipoMotor.Text = this._modelTipoMotor.DscTipoMotor;
                }
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
            this._modelEstoque = new mEstoque();
            frmBuscaEstoque objForm = new frmBuscaEstoque(this._modelEstoque);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelEstoque = null;
                }
                else
                {
                    this.txtCdEstoque.Text = this._modelEstoque.Dsc_estoque;
                }
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
