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
    public partial class frmCadKitGrupoPeca : FormPai
    {
        public frmCadKitGrupoPeca()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this.BuscaIdMaximo();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnCdPeca_Click(object sender, EventArgs e)
        {

        }

        private void btnCdItemPeca_Click(object sender, EventArgs e)
        {

        }

        protected override void BuscaIdMaximo()
        {
            base.BuscaIdMaximo();
        }
    }
}
