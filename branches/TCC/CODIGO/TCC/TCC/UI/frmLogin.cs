using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;

namespace TCC.UI
{
    public partial class frmLogin : Form
    {
        #region Construtor
        public frmLogin()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region btnLogin Click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt;
            rUsuario regraUsuario = new rUsuario();
            string senha;
            try
            {
                senha = TCC.BUSINESS.UTIL.Auxiliar.CriptografaSenha(this.txtSenha.Text);
                dt = regraUsuario.VerificaLoginUsuario(this.txtLogin.Text, senha);
                frmInicial.IdPerfil = Convert.ToInt32(dt.Rows[0]["id_perfil"]);
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dt = null;
                regraUsuario = null;
            }
        }
        #endregion btnLogin Click

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Eventos


    }
}
