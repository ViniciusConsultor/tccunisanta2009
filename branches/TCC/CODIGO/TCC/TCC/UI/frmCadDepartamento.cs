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
    public partial class frmCadDepartamento : Form
    {
        public frmCadDepartamento()
        {
            InitializeComponent();
        }

        private void frmCadDepartamento_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            BUSINESS.rDepartamento regraDep = new TCC.BUSINESS.rDepartamento();
            try
            {
                regraDep.CadastraDepartamento(this.PegaDadosTela());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach (Control contr in this.Controls)
            {
                if (contr.GetType().Equals(new TextBox().GetType()) == true)
                {
                    contr.Text = string.Empty;
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private MODEL.mDepartamento PegaDadosTela()
        {
            MODEL.mDepartamento model = new TCC.MODEL.mDepartamento();
            try
            {
                //model.DatAtl
                model.DscDepto = this.txtDescricaoDepartamento.Text;
                //model.FlgAtivo
                model.IdDepto = Convert.ToInt32(this.txtCodigoDepartamento.Text);
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
