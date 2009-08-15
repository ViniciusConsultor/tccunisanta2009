using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCC.MODEL;

namespace TCC.UI
{
    public partial class frmCadPerfil : Form
    {
        public frmCadPerfil()
        {
            InitializeComponent();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            mPerfil modelPerfil = new mPerfil();
            BUSINESS.rPerfil regraPerfil = new BUSINESS.rPerfil();
            try
            {
                modelPerfil = this.PegaDadosTela();
                regraPerfil.cadastraPerfil(modelPerfil);
                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                modelPerfil = null;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach (Control controles in this.Controls)
            {
                if (controles.GetType().Equals(new TextBox().GetType())==true)
                {
                    controles.Text = string.Empty;
                }
            }
        }

        private mPerfil PegaDadosTela()
        {
            mPerfil model = new mPerfil();
            model.IdPerfil = Convert.ToInt32(txtIdPerfil.Text);
            model.DescPerfil = txtDescPerfil.Text;

            return model;
        }
    }
}
