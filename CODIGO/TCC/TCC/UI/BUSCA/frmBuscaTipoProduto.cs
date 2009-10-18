using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCC.UI
{
    public partial class frmBuscaTipoProduto : Form
    {
        TextBox _txt;

        public frmBuscaTipoProduto(TextBox txt)
        {
            InitializeComponent();
            this._txt = txt;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}