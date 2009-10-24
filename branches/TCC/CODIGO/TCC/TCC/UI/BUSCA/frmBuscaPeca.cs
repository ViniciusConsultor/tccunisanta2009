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
    public partial class frmBuscaPeca : Form
    {
        #region Atributos
        mPeca _model;
        #endregion

        #region Construtor
        public frmBuscaPeca(mPeca modelPeca)
        {
            InitializeComponent();
            this._model = modelPeca;
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
        }
        #endregion

        #region Metodos
        private void PopulaGrid()
        {
            rPeca regra = new rPeca();
            DataTable dt = new DataTable();
            try
            {
                dt = regra.BuscaPeca(this.txtFiltro.Text);
                dgPeca.DataSource = dt;
                this.dgPeca.Columns[0].Visible = false;
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
            DataGridViewCell dvC = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgPeca.DataSource;
                if (this.dgPeca.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgPeca.CurrentRow != null)
                        {
                            //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                            //------------------------------------------------------------------------------------
                            dvC = this.dgPeca["id_peca", this.dgPeca.CurrentRow.Index];
                            this._model.IdPeca = Convert.ToInt32(dvC.Value);
                            dvC = this.dgPeca["Peça", this.dgPeca.CurrentRow.Index];
                            this._model.Nom = dvC.Value.ToString();
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
                        MessageBox.Show("É necessário Cadastrar um Departamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário Buscar e Selecionar um Departamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
        #endregion
    }
}
