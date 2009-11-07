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
        #region Atributos
        mTipoPeca _mtipoPeca;
        #endregion Atributos

        #region Construtor
        public frmCadTipoPeca()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Inserir();
        }
        #endregion Eventos

        #region Metodos
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
                model.IdTipoPeca = regra.BuscaIdMaximo();
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

        public void Inserir()
        {
            mTipoPeca model = null;
            rTipoPeca regra = new rTipoPeca();
            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                this.LimparCampos();
            }
            catch (BUSINESS.Exceptions.TipoPeca.tipoPecaVazioExeption)
            {
                MessageBox.Show("Preencher o campo Descrição do tipo de Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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

        public void ValidaDadosNulos()
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtDsTipoPeca.Text) == true)
                {
                    throw new BUSINESS.Exceptions.TipoPeca.tipoPecaVazioExeption();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Metodos
    }
}
