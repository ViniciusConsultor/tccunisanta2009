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
    public partial class frmCadVenda : FormPai
    {
        public frmCadVenda()
        {
            InitializeComponent();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }


        public override void BuscaIdMaximo()
        {
            throw new NotImplementedException();
        }
    }
}
