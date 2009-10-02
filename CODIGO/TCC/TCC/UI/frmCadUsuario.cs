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

        #region Form Load
        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            this.BuscaCodigoUsuarioMax();
        }
        #endregion Form Load

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
            rUsuarioPerfil regraUsuarioPerfil = new rUsuarioPerfil();
            mUsuarioPerfil modelUsuarioPerfil = new mUsuarioPerfil();
            try
            {
                //Insere o usuário
                //----------------
                modelUsu = this.PegaDadosTela();
                regraUsu.Insere(modelUsu);
                //Insere associação usuarioPerfil
                //-------------------------------
                modelUsuarioPerfil = this.PegaDadosUsuarioPerfil();
                regraUsuarioPerfil.Insere(modelUsuarioPerfil);
                this.LimpaControles();
                this.BuscaCodigoUsuarioMax();
            }
            catch (BUSINESS.Exceptions.LoginVazioException)
            {
                MessageBox.Show("É necessário preenchimento do campo Login", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtLogin.Focus();
            }
            catch (BUSINESS.Exceptions.SenhaVaziaException)
            {
                MessageBox.Show("É necessário preenchimento do campo Senha", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtSenha.Focus();
            }
            catch (BUSINESS.Exceptions.PerfilSemIdExeception)
            {
                MessageBox.Show("Não é Possivel Cadastrar um usuário sem o Codigo do Perfil", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                regraUsu.Deleta(modelUsu);
                btnBuscaPerfilUsuario.Focus();
            }
            catch (BUSINESS.Exceptions.UsuarioSemIdException)
            {
                MessageBox.Show("Não é Possivel Cadastrar um usuário sem Codigo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                regraUsu = null;
                regraUsuarioPerfil = null;
                modelUsuarioPerfil = null;
                modelUsu = null;
            }
        }
        #endregion btnAceitar Click

        #region btnBuscaPerfilUsuario Click
        private void btnBuscaPerfilUsuario_Click(object sender, EventArgs e)
        {
            BUSCA.frmBuscaPerfil buscar = new BUSCA.frmBuscaPerfil(this.txtPerfilUsuario);
            try
            {
                buscar.MdiParent = this.MdiParent;
                buscar.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                buscar = null;
            }
        }
        #endregion btnBuscaPerfilUsuario Click

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
                    if (controle.Name.Equals("txtCodigo") == false)
                    {
                        controle.Text = string.Empty;
                    }
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
            model.Senha = TCC.BUSINESS.UTIL.Auxiliar.CriptografaSenha(this.txtSenha.Text);
            model.FlgAtivo = true;
            return model;
            
        }
        #endregion Pega Dados Tela

        #region Pega Dados Usuario Perfil
        private mUsuarioPerfil PegaDadosUsuarioPerfil()
        {
            mUsuarioPerfil model = new mUsuarioPerfil();
            if (string.IsNullOrEmpty(this.txtPerfilUsuario.Text) == false)
            {
                model.IdPerfil = Convert.ToInt32(this.txtPerfilUsuario.Text);
            }
            else
            {
                throw new BUSINESS.Exceptions.PerfilSemIdExeception();
            }
            model.IdUsuario = Convert.ToInt32(this.txtCodigo.Text);
            model.DatTrans = DateTime.Now;
            model.FlgAtivo = true;
            return model;
        }
        #endregion Pega Dados Usuario Perfil

        #region Busca Codigo Usuario Max
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
        #endregion Busca Codigo Usuario Max

        #endregion Metodos
    }
}
