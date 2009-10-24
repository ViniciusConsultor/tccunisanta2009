using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;
using TCC.MODEL;

namespace TCC.UI
{
    public partial class frmBuscaCliente : Form
    {
        #region Atributos
        mCliente _model;
        #endregion

        #region Construtor
        public frmBuscaCliente(mCliente modelCliente)
        {
            InitializeComponent();
            this._model = modelCliente;
        }
        #endregion

        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.RetornaModel();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

        #region Metodos
        public void buscaCodigo()
        {

        }

        private void PopulaGrid()
        {
            rCliente regraCliente = new rCliente();
            DataTable dt = new DataTable();
            try
            {
                dt = regraCliente.BuscaClientes(this.txtFiltro.Text);
                dgCliente.DataSource = dt;
                dgCliente.Columns[0].Visible = false;
                dgCliente.Rows[0].Selected = true;
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

        private void RetornaModel()
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
                        if (this.dgCliente.CurrentRow != null)
                        {
                            dvc = this.dgCliente["id_cli", this.dgCliente.CurrentRow.Index];
                            this._model.IdCliente = Convert.ToInt32(dvc.Value);
                            dvc = this.dgCliente["Cliente", this.dgCliente.CurrentRow.Index];
                            this._model.NomeCliente = dvc.Value.ToString();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("É necessário Selecionar uma linha", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        }
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
        #endregion
    }
}
