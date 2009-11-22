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
        mUsuario _modelUsuario;
        #endregion Atributos

        #region Construtor
        public frmCadUsuario(mUsuario modelUsu)
        {
            InitializeComponent();
            this._modelUsuario = modelUsu;
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
            this.Insere();
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

        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            base.FechaTela(this);
        }
        #endregion btnVoltar Click

        #region txtLogin TextChanged
        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            this.btnAceitar.Enabled = true;
        }
        #endregion txtLogin TextChanged

        #endregion Eventos

        #region Metodos

        #region Insere
        /// <summary>
        /// Insere os dados que estão no model
        /// </summary>
        private void Insere()
        {
            rUsuario regraUsu = new rUsuario();
            try
            {
                this.ValidaDadosNulos();
                //Insere o usuário
                //----------------
                this.PegaDadosTela();
                /*regraUsu.ValidarInsere(modelUsu);
                this._idUsuario = modelUsu.IdUsuario;
                base.LimpaDadosTela(this);
                this.btnAceitar.Enabled = false;*/
                regraUsu.ValidaDados(this._modelUsuario);
                this.DialogResult = DialogResult.OK;
                base.FechaTela(this);
                MessageBox.Show("Registro Salvo com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoPerfilVazioExeception)
            {
                MessageBox.Show("É Necessário Buscar um Perfil para o usuário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscaPerfilUsuario.Focus();
                // this.btnBuscaPerfilUsuario.PerformClick();
            }
            catch (BUSINESS.Exceptions.Login.LoginVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo Login", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtLogin.Focus();
            }
            catch (BUSINESS.Exceptions.Login.LoginExistenteException)
            {
                MessageBox.Show("Usuário já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtLogin.Text = string.Empty;
                this.txtLogin.Focus();
            }
            catch (BUSINESS.Exceptions.Login.SenhaVaziaException)
            {
                MessageBox.Show("É Necessário Preencher o campo Senha", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtSenha.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                regraUsu = null;
            }
        }
        #endregion Insere

        #region ValidaDadosNulos
        private void ValidaDadosNulos()
        {
            if (string.IsNullOrEmpty(this.txtPerfilUsuario.Text) == true)
            {
                throw new BUSINESS.Exceptions.CodigoPerfilVazioExeception();
            }
            else if (string.IsNullOrEmpty(this.txtLogin.Text) == true)
            {
                throw new BUSINESS.Exceptions.Login.LoginVazioException();
            }
            else if (string.IsNullOrEmpty(this.txtSenha.Text) == true)
            {
                throw new BUSINESS.Exceptions.Login.SenhaVaziaException();
            }
        }
        #endregion ValidaDadosNulos

        #region Pega Dados Tela
        private void PegaDadosTela()
        {
            rUsuario regra = new rUsuario();
            this._modelUsuario.IdUsuario = regra.BuscaMaxId();
            this._modelUsuario.Id_perfil = Convert.ToInt32(this._modelPerfil.IdPerfil);
            this._modelUsuario.Login = this.txtLogin.Text;
            this._modelUsuario.ObsUsuario = this.txtObservacao.Text;
            this._modelUsuario.Senha = TCC.BUSINESS.UTIL.Auxiliar.CriptografaSenha(this.txtSenha.Text);
            this._modelUsuario.FlgAtivo = true;
        }
        #endregion Pega Dados Tela

        #endregion Metodos
    }
}
