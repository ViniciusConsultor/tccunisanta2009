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
    public partial class frmBuscaDepartamento : Form
    {
        #region Construtor
        public frmBuscaDepartamento(TextBox txtIdDepartamento)
        {
            InitializeComponent();
            _txtParam = txtIdDepartamento;
        }
        #endregion
        #region Atributos
        TextBox _txtParam;
        #endregion

        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rDepartamento regraDepto = new rDepartamento();
            DataTable dt = new DataTable();
            try
            {
                dt = regraDepto.BuscaDepartamento(this.txtFiltro.Text);
                dgDepartamento.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraDepto = null;
                dt = null;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                //------------------------------------------------------------------------------------
                DataGridViewCell dvC = this.dgDepartamento["id_depto", this.dgDepartamento.CurrentRow.Index];
                this._txtParam.Text = dvC.Value.ToString();
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


    }
}
