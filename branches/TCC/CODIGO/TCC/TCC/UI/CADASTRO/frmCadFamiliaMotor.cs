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
    public partial class frmCadFamiliaMotor : FormPai
    {
        public frmCadFamiliaMotor()
        {
            InitializeComponent();
        }

        private void frmFamiliaMotor_Load(object sender, EventArgs e)
        {

        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
        }

        protected override void BuscaIdMaximo()
        {
            base.BuscaIdMaximo();
        }
    }
}
