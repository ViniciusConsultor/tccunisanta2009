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
    public partial class frmBuscaKit : Form
    {
        mKitGrupoPeca _model;

        public frmBuscaKit(mKitGrupoPeca modelKit)
        {
            InitializeComponent();
            this._model = modelKit;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }

        private void PopulaGrid()
        {
            rKitGrupoPeca regra = new rKitGrupoPeca();
            DataTable dt = new DataTable();
            try
            {
                dt = regra.BuscaKitGrupoPeca(this.txtFiltro.Text);
                dgKit.DataSource = dt;
                dgKit.Columns[0].Visible = false;
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
            this.RetornaModel();
        }

        private void RetornaModel()
        {
            DataGridViewCell dvc = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgKit.DataSource;
                if (this.dgKit.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        dvc = this.dgKit["id_grupo", this.dgKit.CurrentRow.Index];
                        this._model.Id_grupo = Convert.ToInt32(dvc.Value);
                        dvc = this.dgKit["Kit Grupo Peça", this.dgKit.CurrentRow.Index];
                        this._model.Nom_grupo = dvc.Value.ToString();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("É necessário cadastrar um Kit Grupo Peça", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário buscar e selecionar um Kit Grupo Peça", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
