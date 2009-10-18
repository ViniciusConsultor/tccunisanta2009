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
    public partial class frmCadPerfilMenu : Form
    {
        mPerfil _modelPerfil;
        mMenu _modelMenu;

        public frmCadPerfilMenu()
        {
            InitializeComponent();
            _modelPerfil = new mPerfil();
            _modelMenu = new mMenu();
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
            frmBuscaPerfil objBuscaPerfil = new frmBuscaPerfil(_modelPerfil);
            try
            {
                objBuscaPerfil.ShowDialog();
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
            frmBuscaMenu objBuscaMenu = new frmBuscaMenu(_modelMenu);
            try
            {
                objBuscaMenu.ShowDialog();
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
            mPerfilMenu model;
            rPerfilMenu regraPerfilMenu = new rPerfilMenu();
            try
            {
                model = this.PegaDadosTela();
                regraPerfilMenu.ValidarInsere(model);
                this.txtCodigoMenu.Text = string.Empty;
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
            this.LimparTela();
        }

        private void LimparTela()
        {
            foreach (Control controle in this.Controls)
            {
                if (controle.GetType().Equals(new TextBox().GetType()) == true)
                {
                    controle.Text = string.Empty;
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
