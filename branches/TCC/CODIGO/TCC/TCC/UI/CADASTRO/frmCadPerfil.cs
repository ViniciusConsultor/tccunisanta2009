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
    public partial class frmCadPerfil : FormPai
    {
        #region Construtor
        public frmCadPerfil()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        #region btnConfirma Click
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Inserir();
        }
        #endregion btnConfirma Click

        #region btnLimpar Click
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
        }
        #endregion btnLimpar Click

        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVoltar Click

        #region txtDescPerfil TextChanged
        private void txtDescPerfil_TextChanged(object sender, EventArgs e)
        {
            this.btnConfirma.Enabled = true;
        }
        #endregion txtDescPerfil TextChanged

        #endregion

        #region Metodos

        #region PegaDadosTela
        private mPerfil PegaDadosTela()
        {
            mPerfil model = new mPerfil();
            rPerfil regra = new rPerfil();

            model.IdPerfil = regra.BuscaMaxId();
            model.DescPerfil = txtDescPerfil.Text;

            return model;
        }
        #endregion PegaDadosTela

        #region Inserir
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
                this.btnConfirma.Enabled = false;
            }
            catch (BUSINESS.Exceptions.Perfil.DescPerfilVazioException)
            {
                MessageBox.Show("É necessário informar a descrição do Perfil", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Perfil.DescPerfilExistenteException)
            {
                MessageBox.Show("Descrição do Perfil já Cadastrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
        }
        #endregion Inserir

        #region ValidaDadosNulos
        private void ValidaDadosNulos()
        {
            if (string.IsNullOrEmpty(this.txtDescPerfil.Text) == true)
            {
                throw new BUSINESS.Exceptions.Perfil.DescPerfilVazioException();
            }
        }
        #endregion ValidaDadosNulos

        #endregion
    }
}
