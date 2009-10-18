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
    public partial class frmCadUsinagem : FormPai
    {
        public frmCadUsinagem()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this.BuscaIdMaximo();
        }

        private void frmCadUsinagem_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }

        protected override void BuscaIdMaximo()
        {
            rUsinagem regra = new rUsinagem();
            try
            {
                this.txtCdUsinagem.Text = regra.BuscaIdMaximoUsinagem().ToString();
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
    }
}
