using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.MODEL;
using TCC.BUSINESS;

namespace TCC.UI
{
    public partial class frmBuscaCompra : Form
    {
        #region Atributos
        mCompra _model;
        #endregion

        #region Construtor
        public frmBuscaCompra(mCompra modelCompra)
        {
            InitializeComponent();
            this._model = modelCompra;
        }
        #endregion

        #region Eventos
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.RetornaModel();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

        #region Metodos
        private void PopulaGrid()
        {
            rCompra regra = new rCompra();
            DataTable dt = new DataTable();
            try
            {
                dt = regra.BuscaCompra(this.txtFiltro.Text);
                dgCompra.DataSource = dt;
                dgCompra.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
                dt = null;
            }
        }

        private void RetornaModel()
        {
            DataGridViewCell dvc = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgCompra.DataSource;
                if (this.dgCompra.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgCompra.CurrentRow != null)
                        {
                            dvc = this.dgCompra["id_compra", this.dgCompra.CurrentRow.Index];
                            this._model.IdCompra = Convert.ToInt32(dvc.Value);
                            dvc = this.dgCompra["Obs Compra", this.dgCompra.CurrentRow.Index];
                            this._model.Obs = dvc.Value.ToString();
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