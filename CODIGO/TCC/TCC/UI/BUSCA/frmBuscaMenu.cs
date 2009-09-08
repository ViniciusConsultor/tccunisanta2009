using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;

namespace TCC.UI.BUSCA
{
    public partial class frmBuscaMenu : Form
    {
        TextBox _txtParam = new TextBox();

        public frmBuscaMenu(TextBox txtParam)
        {
            InitializeComponent();
            this._txtParam = txtParam;
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
            DataGridViewCell dvC = this.dgMenu["id_menu", this.dgMenu.CurrentRow.Index];
            this._txtParam.Text = dvC.Value.ToString();
            this.Close();
        }
    }
}
