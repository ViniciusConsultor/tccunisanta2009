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
    public partial class frmCadPerfilMenu : FormPai
    {
        mPerfil _modelPerfil;
        mMenu _modelMenu;

        public frmCadPerfilMenu()
        {
            InitializeComponent();
        }

        private mPerfilMenu PegaDadosTela()
        {
            mPerfilMenu model = new mPerfilMenu();
            model.IdMenu = Convert.ToInt32(this.txtCodigoMenu.Text);
            model.IdPerfil = Convert.ToInt32(this.txtCodigoPerfil.Text);
            model.FlgAtivo = true;
            model.DatTrans = DateTime.Now;
            return model;
        }

        private void btnBuscaPerfil_Click(object sender, EventArgs e)
        {
            this._modelPerfil = new mPerfil();
            frmBuscaPerfil objBuscaPerfil = new frmBuscaPerfil(_modelPerfil);
            try
            {
                DialogResult resultado = objBuscaPerfil.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelPerfil = null;
                }
                else
                {
                    this.txtCodigoPerfil.Text = this._modelPerfil.DescPerfil;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objBuscaPerfil = null;
            }
        }

        private void btnBuscaMenu_Click(object sender, EventArgs e)
        {
            this._modelMenu = new mMenu();
            frmBuscaMenu objBuscaMenu = new frmBuscaMenu(_modelMenu);
            try
            {
                DialogResult resultado = objBuscaMenu.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelMenu = null;
                }
                else
                {
                    this.txtCodigoMenu.Text = this._modelMenu.DscMenu;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objBuscaMenu = null;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Insere();
        }

        private void Insere()
        {
            mPerfilMenu model;
            rPerfilMenu regraPerfilMenu = new rPerfilMenu();
            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regraPerfilMenu.ValidarInsere(model);
                this.txtCodigoMenu.Text = string.Empty;
            }
            catch (BUSINESS.Exceptions.CodigoMenuVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código do Menu", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoPerfilVazioExeception)
            {
                MessageBox.Show("É Necessário Buscar o código do Perfil", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                model = null;
                regraPerfilMenu = null;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelMenu = null;
            this._modelPerfil = null;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void ValidaDadosNulos()
        {
            if (this._modelMenu == null)
            {
                throw new BUSINESS.Exceptions.CodigoMenuVazioException();
            }
            else if (this._modelPerfil == null)
            {
                throw new BUSINESS.Exceptions.CodigoPerfilVazioExeception();
            }
        }
    }
}
