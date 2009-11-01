using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Transactions;
using TCC.MODEL;
using TCC.BUSINESS;

namespace TCC.UI
{
    public partial class frmCadUsuario : FormPai
    {
        #region Atributos
        mPerfil _modelPerfil;
        #endregion

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
        }
        #endregion Form Load

        #region btnLimpar Click
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
        }
        #endregion btnLimpar Click

        #region btnAceitar Click
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            rUsuario regraUsu = new rUsuario();
            mUsuario modelUsu = new mUsuario();
            rUsuarioPerfil regraUsuarioPerfil = new rUsuarioPerfil();
            try
            {
                this.ValidaDadosNulos();
                //Insere o usuário
                //----------------
                modelUsu = this.PegaDadosTela();
                regraUsu.ValidarInsere(modelUsu);
            }
            catch(BUSINESS.Exceptions.CodigoPerfilVazioExeception)
            {
                MessageBox.Show("É Necessário Buscar o código do Perfil", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Login.LoginExistenteException)
            {
                MessageBox.Show("Usuário já existente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtLogin.Text = string.Empty;
                this.txtLogin.Focus();
            }
            catch (BUSINESS.Exceptions.Login.LoginVazioException)
            {
                MessageBox.Show("É necessário preenchimento do campo Login", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtLogin.Focus();
            }
            catch (BUSINESS.Exceptions.Login.SenhaVaziaException)
            {
                MessageBox.Show("É necessário preenchimento do campo Senha", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtSenha.Focus();
            }
            catch (BUSINESS.Exceptions.CodigoUsuarioVazioExeception)
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
                modelUsu = null;
               
            }
        }
        #endregion btnAceitar Click

        #region btnBuscaPerfilUsuario Click
        private void btnBuscaPerfilUsuario_Click(object sender, EventArgs e)
        {
            this._modelPerfil = new mPerfil();
            frmBuscaPerfil buscar = new frmBuscaPerfil(this._modelPerfil);
            try
            {
                DialogResult resultado = buscar.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelPerfil = null;
                }
                else
                {
                    this.txtPerfilUsuario.Text = this._modelPerfil.DescPerfil;
                }
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
        private void ValidaDadosNulos()
        {
            if (this._modelPerfil == null)
            {
                throw new BUSINESS.Exceptions.CodigoPerfilVazioExeception();
            }
        }

        #region Pega Dados Tela
        private mUsuario PegaDadosTela()
        {
            mUsuario model = new mUsuario();
            rUsuario regra = new rUsuario();
            model.Login = this.txtLogin.Text;
            model.ObsUsuario = this.txtObservacao.Text;
            model.Senha = TCC.BUSINESS.UTIL.Auxiliar.CriptografaSenha(this.txtSenha.Text);
            model.FlgAtivo = true;
            return model;
            
        }
        #endregion Pega Dados Tela

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        #endregion Metodos
    }
}
