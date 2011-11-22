using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.Mapper;
using TCC.Regra;

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
                DialogResult resultado;
                this.ValidaDadosNulos();
                modelPerfil = this.PegaDadosTela();
                regraPerfil.ValidarInsere(modelPerfil);

                resultado = MessageBox.Show("Deseja associar este perfil aos menus agora?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    AbreTelaRelacionaPerfilMenu(modelPerfil);
                }
                base.LimpaDadosTela(this);
                this.btnConfirma.Enabled = false;
                MessageBox.Show("Registro Salvo com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (TCC.Regra.Exceptions.Perfil.DescPerfilVazioException)
            {
                MessageBox.Show("É Necessário Informar a descrição do Perfil", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDescPerfil.Focus();
            }
            catch (TCC.Regra.Exceptions.Perfil.DescPerfilExistenteException)
            {
                MessageBox.Show("Descrição do Perfil já Cadastrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDescPerfil.Focus();
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
                throw new TCC.Regra.Exceptions.Perfil.DescPerfilVazioException();
            }
        }
        #endregion ValidaDadosNulos

        #region Abre tela Relaciona PerfilMenu
        private void AbreTelaRelacionaPerfilMenu(mPerfil modelPerfil)
        {
            try
            {
                frmPerfilMenu frm = new frmPerfilMenu(modelPerfil);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        #endregion Abre tela Relaciona PerfilMenu

        #endregion
    }
}
