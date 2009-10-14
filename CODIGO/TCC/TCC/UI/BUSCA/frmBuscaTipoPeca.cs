using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;

namespace TCC.UI.BUSCA
{
    public partial class frmBuscaTipoPeca : Form
    {
        TextBox _txtParam;

        public frmBuscaTipoPeca(TextBox txtOriginal)
        {
            InitializeComponent();
            this._txtParam = txtOriginal;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rTipoPeca regra = new rTipoPeca();
            try
            {
                this.dgTipoPeca.DataSource = regra.BuscaTipoPeca(this.txtFiltro.Text);
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
                        this._txtParam.Text = dvC.Value.ToString();
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
    }
}
