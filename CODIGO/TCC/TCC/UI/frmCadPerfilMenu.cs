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
            BUSCA.frmBuscaPerfil objBuscaPerfil = new TCC.UI.BUSCA.frmBuscaPerfil(this.txtCodigoPerfil);
            try
            {
                objBuscaPerfil.MdiParent = this.MdiParent;
                objBuscaPerfil.Show();
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
            BUSCA.frmBuscaMenu objBuscaMenu = new TCC.UI.BUSCA.frmBuscaMenu(this.txtCodigoMenu);
            try
            {
                objBuscaMenu.MdiParent = this.MdiParent;
                objBuscaMenu.Show();
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                model = null;
                regraPerfilMenu = null;
            }
        }
    }
}
