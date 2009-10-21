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
    public partial class frmBuscaFamiliaMotor : Form
    {
        mFamiliaMotor _model;

        public frmBuscaFamiliaMotor(mFamiliaMotor modelFamilia)
        {
            InitializeComponent();
            this._model = modelFamilia;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }

        private void PopulaGrid()
        {
            rFamiliaMotor regraFamiliaM = new rFamiliaMotor();
            DataTable dt = new DataTable();
            try
            {
                dt = regraFamiliaM.BuscaFamiliaMotor(this.txtFiltro.Text);
                dgCliente.DataSource = dt;
                dgCliente.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraFamiliaM = null;
                dt = null;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

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
                        dvc = this.dgCliente["id_fam_motor", this.dgCliente.CurrentRow.Index];
                        this._model.IdFamiliaMotor = Convert.ToInt32(dvc.Value);
                        dvc = this.dgCliente["Familia Motor", this.dgCliente.CurrentRow.Index];
                        this._model.DscFamiliaMotor = dvc.Value.ToString();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("É necessário cadastrar uma Familia de Motor", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário buscar e selecionar uma Familia de Motor", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
