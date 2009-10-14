using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using TCC.BUSINESS;
using System.Windows.Forms;

namespace TCC.UI
{
    public partial class frmCadCompra : Form
    {
        public frmCadCompra()
        {
            InitializeComponent();
        }

        private void frmCadCompra_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }

        public void BuscaIdMaximo()
        {
            rCompra regraCompra = new rCompra();
            try
            {
                this.txtCdCompra.Text = regraCompra.BuscaIdMaximoCompra().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraCompra = null;
            }
        }
    }
}
