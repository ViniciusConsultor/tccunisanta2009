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
    public partial class frmBuscaCliente : Form
    {
        TextBox _txtParam;
        public frmBuscaCliente(TextBox txtIdCliente)
        {
            InitializeComponent();
            _txtParam = txtIdCliente;
        }
        public void buscaCodigo()
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rCliente regraCliente = new rCliente();
            DataTable dt = new DataTable();
            try
            {
                dt = regraCliente.BuscaClientes (this.txtFiltro.Text);
                dgCliente.DataSource = dt;
                dgCliente.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraCliente = null;
                dt = null;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataGridViewCell dvc = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgCliente.DataSource;
                if (this.dgCliente.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        dvc = this.dgCliente["id_cli", this.dgCliente.CurrentRow.Index];
                        this._txtParam.Text = dvc.Value.ToString();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("É necessário cadastrar um Cliente", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else 
                {
                    MessageBox.Show("É necessário buscar e selecionar um Cliente!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dvc != null)
                {
                    dvc.Dispose();
                    dvc = null;
                }
                if (dtSource != null)
                {
                    dtSource.Dispose();
                    dtSource = null;
                }
            }
        }

    }
}
