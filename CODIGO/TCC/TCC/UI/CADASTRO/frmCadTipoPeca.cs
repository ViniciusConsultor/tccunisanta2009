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
    public partial class frmCadTipoPeca : FormPai
    {
        mTipoPeca _mtipoPeca;

        public frmCadTipoPeca()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
        }

        private void LimparCampos()
        {
            try
            {
                foreach (Control controle in this.Controls)
                {
                    if (controle.GetType().Equals(new TextBox().GetType()) == true)
                    {
                        controle.Text = string.Empty;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private mTipoPeca PegaDadosTela()
        {
            mTipoPeca model = new mTipoPeca();
            rTipoPeca regra = new rTipoPeca();
            try
            {
                model.DscTipoPeca = this.txtDsTipoPeca.Text;
                model.FlgAtivo = true;

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

        private void frmCadTipoPeca_Load(object sender, EventArgs e)
        {
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            mTipoPeca model = null;
            rTipoPeca regra = new rTipoPeca();
            try
            {
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                this.LimparCampos();
            }
            catch (BUSINESS.Exceptions.tipoPeca.tipoPecaVazioExeption)
            {
                MessageBox.Show("Preencher campo Descrição do tipo de Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDsTipoPeca.Focus();
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

        /*protected override void BuscaIdMaximo()
        {
            rTipoPeca regra = new rTipoPeca();
            try
            {
                this.txtCdTipoPeca.Text = regra.BuscaIdMaximoTipoPeca();
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
        public void ValidaDadosNulos()
        {
            try
            {
                if (this._mtipoPeca == null)
                {
                    throw new BUSINESS.Exceptions.tipoPeca.tipoPecaVazioExeption();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }
    }
}
