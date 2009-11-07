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
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Inserir();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this); 
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion

        #region Metodos
        private mPerfil PegaDadosTela()
        {
            mPerfil model = new mPerfil();
            rPerfil regra = new rPerfil();

            model.IdPerfil = regra.BuscaMaxId();
            model.DescPerfil = txtDescPerfil.Text;

            return model;
        }

        private void Inserir()
        {
            rPerfil regraPerfil = new rPerfil();
            mPerfil modelPerfil = new mPerfil();
            try
            {
                this.ValidaDadosNulos();
                modelPerfil = this.PegaDadosTela();
                regraPerfil.ValidarInsere(modelPerfil);
                base.LimpaDadosTela(this);
            }
            catch (BUSINESS.Exceptions.Perfil.DescPerfilVazioException)
            {
                MessageBox.Show("É necessário informar a descrição do Perfil", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
        }

        private void ValidaDadosNulos()
        {
            if (string.IsNullOrEmpty(this.txtDescPerfil.Text) == true)
            {
                throw new BUSINESS.Exceptions.Perfil.DescPerfilVazioException();
            }
        }
        #endregion
    }
}
