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
    public partial class frmCadVendaMotor : FormPai
    {
        public frmCadVendaMotor()
        {
            InitializeComponent();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleta_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        public override void BuscaIdMaximo()
        {
            throw new NotImplementedException();
        }
    }
}
