using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;
using TCC.MODEL;

namespace TCC.UI
{
    public partial class frmBuscaMotor : Form
    {
        mMotor _model;
        public frmBuscaMotor(mMotor modelMotor)
        {
            InitializeComponent();
            this._model = modelMotor;
        }
        public void BuscaCodigo()
        {

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }

        private void PopulaGrid()
        {
            rMotor regraMotor = new rMotor();
            DataTable dt = new DataTable();
            try
            {
                dt = regraMotor.BuscaMotores(this.txtFiltro.Text);
                dgMotor.DataSource = dt;
                this.dgMotor.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                regraMotor = null;
                dt = null;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.RetornaModel();
        }

        private void RetornaModel()
        {
            DataGridViewCell dvc = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgMotor.DataSource;
                if (this.dgMotor.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        dvc = this.dgMotor["id_motor", this.dgMotor.CurrentRow.Index];
                        _model.IdMotor = Convert.ToInt32(dvc.Value);
                        dvc = this.dgMotor["Motor", this.dgMotor.CurrentRow.Index];
                        _model.DscMotor = dvc.Value.ToString();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("É necessário cadastrar um motor!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário buscar e selecionar um motor!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
