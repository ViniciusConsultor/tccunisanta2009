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
    public partial class frmBuscaVenda : Form
    {
        mVenda _model;
        public frmBuscaVenda(mVenda modelVenda)
        {
            InitializeComponent();
            this._model = modelVenda;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.populaGrid();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.retornaModel();
        }

        private void populaGrid()
        {
            rVenda regra = new rVenda();
            DataTable dt = new DataTable();

            try
            {
                dt = regra.buscaVenda();
                dgVenda.DataSource = dt;
                dgVenda.Columns[0].Visible = true;

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                regra = null;
                dt = null;
            }
        }

        private void retornaModel()
        {
            DataGridViewCell dvc = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgVenda.DataSource;
                if (this.dgVenda.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        dvc = this.dgVenda["Venda", this.dgVenda.CurrentRow.Index];
                        this._model.IdVenda = Convert.ToInt32(dvc.Value);
                        dvc = this.dgVenda["Data", this.dgVenda.CurrentRow.Index];
                        this._model.DatVenda = Convert.ToDateTime(dvc.Value);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("É necessário cadastrar uma Venda", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário buscar e selecionar uma Venda!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
