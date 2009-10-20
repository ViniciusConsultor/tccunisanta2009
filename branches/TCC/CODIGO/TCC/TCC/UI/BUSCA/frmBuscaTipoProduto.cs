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
    public partial class frmBuscaTipoProduto : Form
    {
        mTipoProduto _model;

        public frmBuscaTipoProduto(mTipoProduto modelParam)
        {
            InitializeComponent();
            _model = modelParam;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }

        private void PopulaGrid()
        {
            rTipoProduto regra = new rTipoProduto();
            DataTable dt = new DataTable();
            try
            {
                dt = regra.BuscaTipoProduto(this.txtFiltro.Text);
                this.dgTipoProduto.DataSource = dt;
                dgTipoProduto.Columns[0].Visible = false;
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataGridViewCell dvc = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgTipoProduto.DataSource;
                if (this.dgTipoProduto.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        dvc = this.dgTipoProduto["id_tipo_prod", this.dgTipoProduto.CurrentRow.Index];
                        this._model.IdTipoProd = Convert.ToInt32(dvc.Value);
                        dvc = this.dgTipoProduto["Tipo Produto", this.dgTipoProduto.CurrentRow.Index];
                        this._model.Nom = dvc.Value.ToString();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("É necessário cadastrar um Tipo de Produto", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário buscar e selecionar um Tipo de Produto", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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