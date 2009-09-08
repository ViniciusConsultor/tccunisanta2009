using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;

namespace TCC.UI
{
    public partial class frmBuscaTipoUsuario : Form
    {
        TextBox _txtReferenciaBusca;

        public frmBuscaTipoUsuario(TextBox txtIdTipoUsuario)
        {
            InitializeComponent();
            this._txtReferenciaBusca = txtIdTipoUsuario;
        }

        private void frmBuscaTipoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rTipoUsuario regra = new rTipoUsuario();
            DataTable dt = null;
            try
            {
                dt = regra.BuscaTipoUsuario(this.txtFiltro.Text);
                this.dgTipoUsuario.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                regra = null;
                dt.Dispose();
                dt = null;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
            //------------------------------------------------------------------------------------
            DataGridViewCell dvC = this.dgTipoUsuario["id_tipo_usuario", this.dgTipoUsuario.CurrentRow.Index];
            this._txtReferenciaBusca.Text = dvC.Value.ToString();
            this.Close();
        }
    }
}
