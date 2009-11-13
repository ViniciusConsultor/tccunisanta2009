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
    public partial class frmCadUsinagem : FormPai
    {
        #region Atributos
        List<mPeca> _modelPeca;
        #endregion Atributos

        #region Construtor
        public frmCadUsinagem()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVoltar Click

        #region btnLimpar Click
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelPeca = null;
        }
        #endregion btnLimpar Click

        #region frmCadUsinagem Load
        private void frmCadUsinagem_Load(object sender, EventArgs e)
        {
        }
        #endregion frmCadUsinagem Load

        #region txtQtdPecasDefeito TextChanged
        private void txtQtdPecasDefeito_TextChanged(object sender, EventArgs e)
        {
            this.btnAceitar.Enabled = true;
        }
        #endregion txtQtdPecasDefeito TextChanged

        #region btnAceitar Click
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnAceitar Click

        #region btnCdPeca Click
        private void btnCdPeca_Click(object sender, EventArgs e)
        {
            mUsinagem modelUsinagem = new mUsinagem();
            rUsinagem regraUsinagem = new rUsinagem();

            this._modelPeca = new List<mPeca>();
            frmBuscaPeca objForm = new frmBuscaPeca(this._modelPeca, true, false);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelPeca = null;
                }
                else
                {
                    this.txtCdPeca.Text = this._modelPeca[0].Nom;
                }

                this.ValidaDadosNulos();
                modelUsinagem = this.PegaDadosTela();
                regraUsinagem.ValidarInsere(modelUsinagem);

            }
            catch (BUSINESS.Exceptions.CodigoPecaVazioExeception)
            {
                MessageBox.Show("É Necessário Buscar o código da Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }

            catch (BUSINESS.Exceptions.Validacoes.MaskedInvalidaException)
            {
                MessageBox.Show("É Necessário Selecionar o check de Peça OK", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                //throw ex;
            }
            finally
            {
                objForm = null;
            }
        }
        #endregion btnCdPeca Click

        #endregion Eventos

        #region Metodos

        #region Insere
        private void Insere()
        {
            mUsinagem model;
            rUsinagem regra = new rUsinagem();
            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                base.LimpaDadosTela(this);
                this.btnAceitar.Enabled = false;
            }
            catch (BUSINESS.Exceptions.CodigoPecaVazioExeception)
            {
                MessageBox.Show("É Necessário Buscar o código da Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
        #endregion Insere

        #region PegaDadosTela
        private mUsinagem PegaDadosTela()
        {
            mUsinagem model = new mUsinagem();
            rUsinagem regra = new rUsinagem();
            try
            {
                model.DtaEnvio = DateTime.Now;
                //model.FlgStatus = this.chkPecaOk.Checked;
                model.IdPeca = Convert.ToInt32(this._modelPeca[0].IdPeca);

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
        #endregion PegaDadosTela

        #region ValidaDadosNulos
        private void ValidaDadosNulos()
        {
            if (this._modelPeca == null)
            {
                throw new BUSINESS.Exceptions.CodigoPecaVazioExeception();
            }
        }
        #endregion ValidaDadosNulos

        #endregion Metodos
    }
}
