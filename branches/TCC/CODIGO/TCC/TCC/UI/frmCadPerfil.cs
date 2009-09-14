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
    public partial class frmCadPerfil : Form
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
            this.BuscaMaxDepto();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            rPerfil regraPerfil = new rPerfil();
            mPerfil modelPerfil = new mPerfil();
            try
            {
                modelPerfil = this.PegaDadosTela();
                regraPerfil.cadastraPerfil(modelPerfil);
                this.LimpaControles();
                this.BuscaMaxDepto();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.LimpaControles();
        }
        #endregion
        #region Metodos
        private mPerfil PegaDadosTela()
        {
            mPerfil model = new mPerfil();
            model.IdPerfil = Convert.ToInt32(txtIdPerfil.Text);
            model.DescPerfil = txtDescPerfil.Text;

            return model;
        }

        private void BuscaMaxDepto()
        {
            rPerfil regraPerfil = new rPerfil();
            try
            {
                this.txtIdPerfil.Text = regraPerfil.BuscaIdMaximoPerfil().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraPerfil = null;
            }
        }

        private void LimpaControles()
        {
            //Varre todos os controles da tela
            //--------------------------------
            foreach (Control controle in this.Controls)
            {
                //Se for do tipo TextBox apaga o conteudo escrito
                //-----------------------------------------------
                if (controle.GetType().Equals(new TextBox().GetType()) == true)
                {
                    if (controle.Name.Equals("txtIdPerfil") == false)
                    {
                        controle.Text = string.Empty;
                    }
                }
            }
        }
        #endregion
    }
}
