using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.Regra;

namespace TCC.UI
{
    public partial class frmBuscaItem : FormPai
    {
        public frmBuscaItem()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }

        private void PopulaGrid()
        {
            rItem regraItem = new rItem();
            DataTable dt = new DataTable();
            try
            {
                dt = regraItem.BuscaItemCodigo(this.txtFiltro.Text);
                dgItem.DataSource = dt;
                this.dgItem.Columns[0].Visible = false;
                this.dgItem.Columns["hQtd"].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                regraItem = null;
                dt = null;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
    }
}
