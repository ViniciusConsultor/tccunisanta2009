using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.Mapper;
using TCC.Regra;

namespace TCC.UI.BUSCA
{
    public partial class frmBuscaUsinagem : Form
    {
        mUsinagem _model;

        public frmBuscaUsinagem(mUsinagem modelUsinagem)
        {
            InitializeComponent();
            this._model = modelUsinagem;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void PopulaGrid()
        {
            rUsinagem regra = new rUsinagem();
            DataTable dt = new DataTable();
            try
            {
                dt = regra.BuscaUsinagem(this.txtFiltro.Text);
                dgUsinagem.DataSource = dt;
                dgUsinagem.Columns[0].Visible = false;
                dgUsinagem.Columns[1].Visible = false;
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
                dtSource = (DataTable)this.dgUsinagem.DataSource;
                if (this.dgUsinagem.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgUsinagem.CurrentRow != null)
                        {
                            dvc = this.dgUsinagem["id_usinagem", this.dgUsinagem.CurrentRow.Index];
                            this._model.IdUsinagem = Convert.ToInt32(dvc.Value);
                            dvc = this.dgUsinagem["id_peca", this.dgUsinagem.CurrentRow.Index];
                            this._model.IdPeca = Convert.ToInt32(dvc.Value.ToString());
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("É necessário Selecionar um item de Usinagem", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("É necessário cadastrar um item de Usinagem", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário buscar e selecionar um item de Usinagem!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
