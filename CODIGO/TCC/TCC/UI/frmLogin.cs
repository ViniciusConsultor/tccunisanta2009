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
    public partial class frmLogin : FormPai
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
                int idPerfil = 0;
                int idUsuario = 0;

                senha = TCC.BUSINESS.UTIL.Auxiliar.CriptografaSenha(this.txtSenha.Text);
                dt = regraUsuario.VerificaLoginUsuario(this.txtLogin.Text, senha);
                idUsuario = Convert.ToInt32(dt.Rows[0]["id_usu"]);
                
                // Valida usuaário e senha
                if (idUsuario == 0)
                {
                    MessageBox.Show("Usuário ou Senha inválidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dt = regraUsuario.BuscaUsuario(txtLogin.Text);
                    // Valida usuario ativo
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Usuário inativo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        idPerfil = Convert.ToInt32(dt.Rows[0]["id_perfil"]);
                        // Valida perifl do usuario
                        if (idPerfil == 0)
                        {
                            MessageBox.Show("Usuário não possui um perfil!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            frmInicial.IdPerfil = Convert.ToInt32(dt.Rows[0]["id_perfil"]);
                            frmInicial inicial = new frmInicial();
                            this.Visible = false;
                            DialogResult resultado = inicial.ShowDialog();
                            if (resultado == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                            else
                            {
                                this.btnLimpar_Click(null, null);
                                this.Visible = true;
                                this.txtLogin.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
        }


    }
}
