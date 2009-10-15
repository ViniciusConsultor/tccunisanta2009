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
    public partial class frmCadUsinagem : Form
    {
        public frmCadUsinagem()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.LimparCampos();
            this.BuscaIdMaximoUsinagem();
        }

        private void BuscaIdMaximoUsinagem()
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

        private void LimparCampos()
        {
            foreach (Control controle in this.Controls)
            {
                if (controle.GetType().Equals(new TextBox().GetType()) == true)
                {
                    controle.Text = string.Empty;
                }
            }
        }

        private void frmCadUsinagem_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximoUsinagem();
        }
    }
}
