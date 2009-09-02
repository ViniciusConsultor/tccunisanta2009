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
    public partial class frmCadUsuario : Form
    {
        #region Construtor
        public frmCadUsuario()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region btnLimpar Click
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.LimpaControles();
        }
        #endregion btnLimpar Click

        #region btnAceitar Click
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            rUsuario regraUsu = new rUsuario();
            mUsuario modelUsu = new mUsuario();
            try
            {
                modelUsu = this.PegaDadosTela();
                regraUsu.CadastraUsuario(modelUsu);
                this.LimpaControles();
                this.BuscaCodigoUsuarioMax();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraUsu = null;
            }
        }
        #endregion btnAceitar Click

        #region btnBuscaTipoUsuario Click
        private void btnBuscaTipoUsuario_Click(object sender, EventArgs e)
        {
            frmBuscaTipoUsuario objFrmBusca = new frmBuscaTipoUsuario(this.txtTipoUsuario);
            objFrmBusca.MdiParent = this.MdiParent;
            objFrmBusca.Show();
        }
        #endregion btnBuscaTipoUsuario Click

        #endregion Eventos

        #region Metodos

        #region Limpa Controles
        /// <summary>
        /// Limpa os controles da tela
        /// </summary>
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
                    controle.Text = string.Empty;
                }
            }
        }
        #endregion Limpa Controles

        #region Pega Dados Tela
        private mUsuario PegaDadosTela()
        {
            mUsuario model = new mUsuario();
            model.IdUsuario = Convert.ToInt32(this.txtCodigo.Text);
            model.Login = this.txtLogin.Text;
            model.ObsUsuario = this.txtObservacao.Text;
            model.Senha = this.CriptografaSenha(this.txtSenha.Text);
            model.IdTipoUsuario = Convert.ToInt32(this.txtTipoUsuario.Text);
            model.FlgAtivo = true;
            return model;
            
        }
        #endregion Pega Dados Tela

        //TODO: Pensar em colocar em uma classe auxiliar ou algo do tipo
        #region Criptografa Senha
        /// <summary>
        /// Criptografa a senha do usuario
        /// </summary>
        /// <param name="senha">Senha a ser Criptografada</param>
        /// <returns>Senha Criptografada</returns>
        private string CriptografaSenha(string senha)
        {
            string criptografado;
            try
            {
                byte[] b = ASCIIEncoding.ASCII.GetBytes(senha);
                criptografado = Convert.ToBase64String(b);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return criptografado;
        }
        #endregion Criptografa Senha

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            this.BuscaCodigoUsuarioMax();
        }

        private void BuscaCodigoUsuarioMax()
        {
            rUsuario regraUsu = new rUsuario();
            try
            {
                this.txtCodigo.Text = regraUsu.BuscaIdMaximoUsuario().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                regraUsu = null;
            }
        }

        #endregion Metodos
    }
}
