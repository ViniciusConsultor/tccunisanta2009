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
    public partial class frmBuscaPerfil : Form
    {
        #region Atributos
        private mPerfil _model;
        #endregion Atributos

        #region Contrutor
        public frmBuscaPerfil(mPerfil modelPerfil)
        {
            InitializeComponent();
            this._model = modelPerfil;
        }
        #endregion Contrutor

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

        #endregion Eventos

        #region Metodos
        private void PopulaGrid()
        {
            rPerfil regraPerfil = new rPerfil();
            DataTable dt = new DataTable();
            try
            {
                dt = regraPerfil.BuscaPerfil(this.txtFiltro.Text);
                dgPerfil.DataSource = dt;
                this.dgPerfil.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraPerfil = null;
                dt = null;
            }
        }

        private void RetornaModel()
        {
            DataGridViewCell dvC = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgPerfil.DataSource;
                if (this.dgPerfil.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgPerfil.CurrentRow != null)
                        {
                            //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                            //------------------------------------------------------------------------------------
                            dvC = this.dgPerfil["id_perfil", this.dgPerfil.CurrentRow.Index];
                            this._model.IdPerfil = Convert.ToInt32(dvC.Value);
                            dvC = this.dgPerfil["Perfil", this.dgPerfil.CurrentRow.Index];
                            this._model.DescPerfil = dvC.Value.ToString();
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
                        MessageBox.Show("É necessário Cadastrar um Perfil", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário Buscar e Selecionar um Perfil", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
        #endregion Metodos
    }
}
