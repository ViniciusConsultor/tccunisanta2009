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

        #region Atributos
        mTipoProduto _model;
        #endregion

        #region Construtor
        public frmBuscaTipoProduto(mTipoProduto modelParam)
        {
            InitializeComponent();
            _model = modelParam;
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

        private void RetornaModel()
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
                        if (this.dgTipoProduto.CurrentRow != null)
                        {
                            dvc = this.dgTipoProduto["id_tipo_prod", this.dgTipoProduto.CurrentRow.Index];
                            this._model.IdTipoProd = Convert.ToInt32(dvc.Value);
                            dvc = this.dgTipoProduto["Tipo Produto", this.dgTipoProduto.CurrentRow.Index];
                            this._model.Nom = dvc.Value.ToString();
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
        #endregion
    }
}