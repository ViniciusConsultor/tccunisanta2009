using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCC.MODEL;
using TCC.BUSINESS;

namespace TCC.UI
{
    public partial class frmCadPerfil : FormPai
    {
        #region Construtor
        public frmCadPerfil()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void frmCadPerfil_Load(object sender, EventArgs e)
        {
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            rPerfil regraPerfil = new rPerfil();
            mPerfil modelPerfil = new mPerfil();
            try
            {
                modelPerfil = this.PegaDadosTela();
                regraPerfil.ValidarInsere(modelPerfil);
                base.LimpaDadosTela(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this); 
        }
        #endregion

        #region Metodos
        private mPerfil PegaDadosTela()
        {
            mPerfil model = new mPerfil();
            rPerfil regra = new rPerfil();

            model.IdPerfil = Convert.ToInt32(regra.BuscaIdMaximoPerfil());
            model.DescPerfil = txtDescPerfil.Text;

            return model;
        }
        #endregion

        /*protected override void BuscaIdMaximo()
        {
            rPerfil regraPerfil = new rPerfil();
            try
            {
                this.txtIdPerfil.Text = regraPerfil.BuscaIdMaximoPerfil();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraPerfil = null;
            }
        }*/

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
    }
}
