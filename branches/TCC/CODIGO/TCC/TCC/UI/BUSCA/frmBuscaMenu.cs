using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;
using TCC.MODEL;

namespace TCC.UI.BUSCA
{
    public partial class frmBuscaMenu : Form
    {
        mMenu _model;

        public frmBuscaMenu(mMenu modelMenu)
        {
            InitializeComponent();
            this._model = modelMenu;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rMenu regraMenu = new rMenu();
            DataTable dt;
            try
            {
                dt = regraMenu.TelaBuscaMenu(this.txtFiltro.Text);
                this.dgMenu.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraMenu = null;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataGridViewCell dvC;
            dvC = this.dgMenu["id_menu", this.dgMenu.CurrentRow.Index];
            _model.IdMenu = Convert.ToInt32(dvC.Value);
            dvC = this.dgMenu["Menu", this.dgMenu.CurrentRow.Index];
            _model.DscMenu = dvC.Value.ToString();
            this.Close();
        }
    }
}
