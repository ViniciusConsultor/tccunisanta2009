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
    public partial class frmBuscaMotor : Form
    {
        TextBox _txtParam;
        public frmBuscaMotor(TextBox txtIdMotor)
        {
            InitializeComponent();
            _txtParam = txtIdMotor;
        }
        public void BuscaCodigo()
        {

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rMotor regraMotor = new rMotor();
            DataTable dt = new DataTable();
            try
            {
                dt = regraMotor.BuscaMotores(this.txtFiltro.Text);
                dgMotor.DataSource = dt;
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
            DataGridViewCell dvc = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgMotor.DataSource;
                if (this.dgMotor.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        dvc = this.dgMotor["id_motor_compra", this.dgMotor.CurrentRow.Index];
                        this._txtParam.Text = dvc.Value.ToString();
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
            catch (Exception ex )
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
