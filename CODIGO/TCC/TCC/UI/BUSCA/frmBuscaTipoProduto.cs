using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.MODEL;

namespace TCC.UI
{
    public partial class frmBuscaTipoProduto : Form
    {
        mTipoProduto _model;

        public frmBuscaTipoProduto(mTipoProduto modelParam)
        {
            InitializeComponent();
            _model = modelParam;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}