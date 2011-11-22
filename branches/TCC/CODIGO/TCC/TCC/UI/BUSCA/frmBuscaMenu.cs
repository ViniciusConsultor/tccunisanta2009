using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.Regra;
using TCC.Mapper;

namespace TCC.UI
{
    public partial class frmBuscaMenu : Form
    {
        #region Atributos
        mMenu _model;
        #endregion

        #region Construtor
        public frmBuscaMenu(mMenu modelMenu)
        {
            InitializeComponent();
            this._model = modelMenu;
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
            rMenu regraMenu = new rMenu();
            DataTable dt;
            try
            {
                dt = regraMenu.TelaBuscaMenu(this.txtFiltro.Text);
                this.dgMenu.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraMenu = null;
            }
        }

        private void RetornaModel()
        {
            DataGridViewCell dvc = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgMenu.DataSource;
                if (this.dgMenu.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgMenu.CurrentRow != null)
                        {
                            dvc = this.dgMenu["id_menu", this.dgMenu.CurrentRow.Index];
                            this._model.IdMenu = Convert.ToInt32(dvc.Value);
                            dvc = this.dgMenu["Menu", this.dgMenu.CurrentRow.Index];
                            this._model.DscMenu = dvc.Value.ToString();
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
