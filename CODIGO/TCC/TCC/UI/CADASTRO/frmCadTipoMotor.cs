using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.MODEL;
using TCC.BUSINESS;

namespace TCC.UI
{
    public partial class frmCadTipoMotor : FormPai
    {
        public frmCadTipoMotor()
        {
            InitializeComponent();
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
            rTipoMotor regra = new rTipoMotor();
            try
            {
                this.txtCdTipoMotor.Text = regra.BuscaIdMaximo();
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

        private void frmCadTipoMotor_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Insere();
        }

        private void Insere()
        {
            mTipoMotor model;
            rTipoMotor regra = new rTipoMotor();
            try
            {
                model = this.PedaDadosTela();
                regra.ValidarInsere(model);
                base.LimpaDadosTela(this);
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

        private mTipoMotor PedaDadosTela()
        {
            mTipoMotor model = new mTipoMotor();
            try
            {
                model.DscTipoMotor = this.txtNmTipoMotor.Text;
                model.FlgAtivo = true;
                model.IdTipoMotor = this.txtCdTipoMotor.Text;

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