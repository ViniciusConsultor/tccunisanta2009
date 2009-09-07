using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;

namespace TCC.UI.BUSCA
{
    public partial class frmBuscaPerfil : Form
    {

        #region Atributos
        TextBox _txtParam;
        #endregion Atributos

        #region Contrutor
        public frmBuscaPerfil(TextBox txtIdPerfil)
        {
            InitializeComponent();
            _txtParam = txtIdPerfil;
        }
        #endregion Contrutor

        #region Metodos



        #endregion Metodos

        #region Eventos

        #region btnBuscar Click
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rPerfil regraPerfil = new rPerfil();
            DataTable dt = new DataTable();
            try
            {
                dt = regraPerfil.BuscaPerfil(this.txtFiltro.Text);
                dgPerfil.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraPerfil = null;
                dt = null;
            }
        }
        #endregion btnBuscar Click

        #region btnOK Click
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                //------------------------------------------------------------------------------------
                DataGridViewCell dvC = this.dgPerfil["id_perfil", this.dgPerfil.CurrentRow.Index];
                this._txtParam.Text = dvC.Value.ToString();
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }
        #endregion btnOK Click

        #endregion Eventos
    }
}
