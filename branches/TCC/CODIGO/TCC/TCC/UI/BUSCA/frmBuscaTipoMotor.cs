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
    public partial class frmBuscaTipoMotor : Form
    {
        #region Atributos
        mTipoMotor _model;
        #endregion

        #region Construtor
        public frmBuscaTipoMotor(mTipoMotor modelParam)
        {
            InitializeComponent();
            this._model = modelParam;
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
            rTipoMotor regra = new rTipoMotor();
            try
            {
                this.dgTipoMotor.DataSource = regra.BuscaTipoMotor(this.txtFiltro.Text);
                this.dgTipoMotor.Columns[0].Visible = false;
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

        private void RetornaModel()
        {
            DataGridViewCell dvC = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgTipoMotor.DataSource;
                if (this.dgTipoMotor.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgTipoMotor.CurrentRow != null)
                        {
                            //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                            //------------------------------------------------------------------------------------
                            dvC = this.dgTipoMotor["id_tipo_motor", this.dgTipoMotor.CurrentRow.Index];
                            _model.IdTipoMotor = Convert.ToInt32(dvC.Value.ToString());
                            dvC = this.dgTipoMotor["Tipo Motor", this.dgTipoMotor.CurrentRow.Index];
                            _model.DscTipoMotor = dvC.Value.ToString();
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
                        MessageBox.Show("É necessário Cadastrar um Tipo de Motor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário Buscar e Selecionar um Tipo de Motor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
