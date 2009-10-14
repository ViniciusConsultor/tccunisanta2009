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
    public partial class frmBuscaFornecedor : Form
    {
        TextBox _txtParam;

        public frmBuscaFornecedor(TextBox txtFornecedor)
        {
            InitializeComponent();
            this._txtParam = txtFornecedor;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rFornecedor regra = new rFornecedor();
            try
            {
                this.dgFornecedor.DataSource = regra.BuscaFornecedor(this.txtFiltro.Text);
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
                dtSource = (DataTable)this.dgFornecedor.DataSource;
                if (this.dgFornecedor.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                        //------------------------------------------------------------------------------------
                        dvC = this.dgFornecedor["id_fornecedor", this.dgFornecedor.CurrentRow.Index];
                        this._txtParam.Text = dvC.Value.ToString();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("É necessário Cadastrar um Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário Buscar e Selecionar um Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
