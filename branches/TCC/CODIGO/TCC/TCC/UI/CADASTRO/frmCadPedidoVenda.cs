using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;

namespace TCC.UI
{
    public partial class frmCadPedidoVenda : FormPai
    {
        public frmCadPedidoVenda()
        {
            InitializeComponent();
        }

        private void frmCadPedidoVenda_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
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

        protected override void BuscaIdMaximo()
        {
            rPedidoVenda regra = new rPedidoVenda();
            try
            {
                this.txtCdPedidoVenda.Text = regra.BuscaidMaximo();
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
 