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
    public partial class frmBuscaEstoque : Form
    {
        mEstoque _model;

        public frmBuscaEstoque(mEstoque modelEstoque)
        {
            InitializeComponent();
            _model = modelEstoque;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rEstoque regra = new rEstoque();
            try
            {
                this.dgEstoque.DataSource = regra.BuscaEstoque(this.txtFiltro.Text);
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
                dtSource = (DataTable)this.dgEstoque.DataSource;
                if (this.dgEstoque.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                        //------------------------------------------------------------------------------------
                        dvC = this.dgEstoque["id_estoque", this.dgEstoque.CurrentRow.Index];
                        _model.Id_estoque = Convert.ToInt32(dvC.Value);
                        dvC = this.dgEstoque["Estoque", this.dgEstoque.CurrentRow.Index];
                        _model.Dsc_estoque = dvC.Value.ToString(); 
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
