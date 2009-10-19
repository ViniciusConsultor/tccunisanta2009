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
            this.BuscaIdMaximo();
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
            try
            {
                model.IdTipoPeca = Convert.ToInt32(this.txtCdTipoPeca.Text);
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
            this.BuscaIdMaximo();
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
                this.BuscaIdMaximo();
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

        protected override void BuscaIdMaximo()
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
        }
    }
}
