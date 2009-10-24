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
                dgFamMotor.DataSource = dt;
                dgFamMotor.Columns[0].Visible = false;
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
            this.RetornaModel();
        }

        private void RetornaModel()
        {
            DataGridViewCell dvc = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgFamMotor.DataSource;
                if (this.dgFamMotor.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgFamMotor.CurrentRow != null)
                        {
                            dvc = this.dgFamMotor["id_fam_motor", this.dgFamMotor.CurrentRow.Index];
                            this._model.IdFamiliaMotor = Convert.ToInt32(dvc.Value);
                            dvc = this.dgFamMotor["Familia Motor", this.dgFamMotor.CurrentRow.Index];
                            this._model.DscFamiliaMotor = dvc.Value.ToString();
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
