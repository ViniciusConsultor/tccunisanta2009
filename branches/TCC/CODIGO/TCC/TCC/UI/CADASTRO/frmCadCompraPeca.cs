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
    public partial class frmCadCompraPeca : FormPai
    {
        public frmCadCompraPeca()
        {
            InitializeComponent();
        }

        protected override void BuscaIdMaximo()
        {
            base.BuscaIdMaximo();
        }

        private void frmCadCompraPeca_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }
    }
}
