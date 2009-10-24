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
    public partial class frmCadNumeroMotor : FormPai
    {
        public frmCadNumeroMotor()
        {
            InitializeComponent();
        }

        private void frmNumeroMotor_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
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

        /*protected override void BuscaIdMaximo()
        {
            rNumeroMotor regra = new rNumeroMotor();
            try
            {
                this.txtCdNumeroMotor.Text = regra.BuscaIdMaximo();
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

        private void frmCadNumeroMotor_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Insere();
        }

        private void Insere()
        {
            mNumMotor model;
            rNumeroMotor regra = new rNumeroMotor();
            try
            {
                model = this.PegaDadoosTela();
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

        private mNumMotor PegaDadoosTela()
        {
            mNumMotor model = new mNumMotor();
            rNumeroMotor regra = new rNumeroMotor();

            try
            {
                model.Dsc_num_motor = this.txtDscNumeroMotor.Text;
                model.Flg_ativo = true;
                model.Id_num_motor = Convert.ToInt32(regra.BuscaIdMaximo());

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
