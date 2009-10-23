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
    public partial class frmBuscaTipoPeca : Form
    {
        mTipoPeca _model;

        public frmBuscaTipoPeca(mTipoPeca modelTipoPeca)
        {
            InitializeComponent();
            _model = modelTipoPeca;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }

        private void PopulaGrid()
        {
            rTipoPeca regra = new rTipoPeca();
            try
            {
                this.dgTipoPeca.DataSource = regra.BuscaTipoPeca(this.txtFiltro.Text);
                this.dgTipoPeca.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.RetornaModel();
        }

        private void RetornaModel()
        {
            DataGridViewCell dvC = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgTipoPeca.DataSource;
                if (this.dgTipoPeca.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                        //------------------------------------------------------------------------------------
                        dvC = this.dgTipoPeca["id_tipo_peca", this.dgTipoPeca.CurrentRow.Index];
                        this._model.IdTipoPeca = Convert.ToInt32(dvC.Value);
                        dvC = this.dgTipoPeca["Tipo Peça", this.dgTipoPeca.CurrentRow.Index];
                        this._model.DscTipoPeca = dvC.Value.ToString();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("É necessário Cadastrar um Tipo de Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário Buscar e Selecionar um Tipo de Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dvC != null)
                {
                    dvC.Dispose();
                    dvC = null;
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
