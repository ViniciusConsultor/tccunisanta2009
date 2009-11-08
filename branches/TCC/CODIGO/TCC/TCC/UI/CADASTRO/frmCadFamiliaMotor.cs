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
    {/*
        #region Atributos
        List<mKitFamilia> _listaKitFamilia;
        int _idKit;
        mEstoque _modelEstoque;
        mMotor _modelMotor;
        mTipoMotor _modelTipoMotor;
        mNumMotor _modelNumeroMotor;
        #endregion Atributos

        #region Construtor
        public frmCadFamiliaMotor()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region btnVolta Click
        private void btnVolta_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVolta Click

        #region btnLimpa Click
        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelEstoque = null;
            this._modelKit = null;
            this._modelMotor = null;
            this._modelNumeroMotor = null;
            this._modelTipoMotor = null;
        }
        #endregion btnLimpa Click

        #region Form Load
        #endregion Form Load

        #region btnConfirma Click
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnConfirma Click

        #region btnBuscaCdNumMotor Click
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
                    this.txtNumeroMotor.Text = this._modelNumeroMotor.Dsc_num_motor;
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
        #endregion btnBuscaCdNumMotor Click

        #region btnCdKit Click
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
                   // this.txtCdKit.Text = this._modelKit.Nom_grupo;
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
        #endregion btnCdKit Click

        #region btnCdMotorCompra Click
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
                    this.txtMotorCompra.Text = this._modelMotor.DscMotor;
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
        #endregion btnCdMotorCompra Click

        #region btnCdTipoMotor Click
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
                    this.txtTipoMotor.Text = this._modelTipoMotor.DscTipoMotor;
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
        #endregion btnCdTipoMotor Click

        #region btnCdEstoque Click
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
                    this.txtEstoque.Text = this._modelEstoque.Dsc_estoque;
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
        #endregion btnCdEstoque Click

        #endregion Eventos

        #region Metodos

        #region Abre Tela Resumo
        /// <summary>
        /// Abre a tela de resumo antes de gravar os dados no banco
        /// </summary>
        private void AbreTelaResumo()
        {
            string nomeFamMotor=this.txtNumeroMotor.Text+this.txtTipoMotor.Text;
            string nomeMotor=this.txtMotorCompra.Text;

            Resumo.frmResumoKitFamilia ResumoKit = new TCC.UI.Resumo.frmResumoKitFamilia(this._listaKitFamilia,nomeFamMotor,nomeMotor);
            try
            {
                DialogResult resultado;
                resultado = ResumoKit.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    throw new BUSINESS.Exceptions.Item.TelaResumoCanceladaException();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                ResumoKit = null;
            }
        }
        #endregion Abre Tela Resumo

        #region Insere
        /// <summary>
        /// Cadastra no banco os dados que estão no model
        /// </summary>
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
        #endregion Insere

        #region Valida Dados Nulos
        /// <summary>
        /// Valida os dados que não podem ser nulos na tela
        /// </summary>
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
        #endregion Valida Dados Nulos

        #region Pega Dados Tela
        /// <summary>
        /// Pega os dados que estão na tela e popula o model
        /// </summary>
        /// <returns>Retorna o model populado</returns>
        private mFamiliaMotor PegaDadosTela()
        {
            mFamiliaMotor model = new mFamiliaMotor();
            rFamiliaMotor regra = new rFamiliaMotor();

            try
            {
                model.IdFamiliaMotor = regra.BuscaIdMaximo();
                model.DscFamiliaMotor = this.txtDsMotor.Text;
                model.FlgAtivo = true;
                model.IdEstoque = Convert.ToInt32(this._modelEstoque.Id_estoque);
                model.IdMotor = Convert.ToInt32(this._modelMotor.IdMotor);
                model.IdNumMotor = Convert.ToInt32(this._modelNumeroMotor.Id_num_motor);
                model.IdTipoMotor = Convert.ToInt32(this._modelTipoMotor.IdTipoMotor);

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
        #endregion Pega Dados Tela 


        #endregion Metodos
      */
    }
}
