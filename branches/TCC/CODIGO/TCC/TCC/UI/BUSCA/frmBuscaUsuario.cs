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
    public partial class frmBuscaUsuario : Form
    {
        bool _alteracao;

        #region Construtor
        public frmBuscaUsuario()
        {
            InitializeComponent();
            this._alteracao = true;
        }

        public frmBuscaUsuario(TextBox txtIdUsuario)
        {
            InitializeComponent();
            _txtParam = txtIdUsuario;
            this._alteracao = false;
        }
        #endregion

        #region Atributos
        TextBox _txtParam;
        #endregion

        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rUsuario regraUsuario = new rUsuario();
            DataTable dt = new DataTable();
            try
            {
                dt = regraUsuario.BuscaUsuario(this.txtFiltro.Text);
                dgUsuario.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraUsuario = null;
                dt = null;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DataGridViewCell dvC;
            try
            {
                //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                //------------------------------------------------------------------------------------
                dvC = this.dgUsuario["id_usu", this.dgUsuario.CurrentRow.Index];
                
                if (this._alteracao == false)
                {
                    this._txtParam.Text = dvC.Value.ToString();
                    this.Close();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }
        #endregion
    }
}
