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
    public partial class frmCadDepartamento : Form
    {
        public frmCadDepartamento()
        {
            InitializeComponent();
        }

        private void frmCadDepartamento_Load(object sender, EventArgs e)
        {
            this.BuscaUltimoIdDepartamento();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            BUSINESS.rDepartamento regraDep = new TCC.BUSINESS.rDepartamento();
            try
            {
                regraDep.CadastraDepartamento(this.PegaDadosTela());
                this.ApagaControles();
                this.BuscaUltimoIdDepartamento();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.ApagaControles();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private MODEL.mDepartamento PegaDadosTela()
        {
            MODEL.mDepartamento model = new TCC.MODEL.mDepartamento();
            try
            {
                
                model.DscDepto = this.txtDescricaoDepartamento.Text;
                model.FlgAtivo = true;
                model.DatAtl = DateTime.Now;
                model.IdDepto = Convert.ToInt32(this.txtCodigoDepartamento.Text);
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BuscaUltimoIdDepartamento()
        {
            rDepartamento regraDepartamento = new rDepartamento();
            try
            {
                this.txtCodigoDepartamento.Text = regraDepartamento.BuscaIdMaximoDepartamento().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraDepartamento = null;
            }
        }

        private void ApagaControles()
        {
            foreach (Control contr in this.Controls)
            {
                if (contr.GetType().Equals(new TextBox().GetType()) == true)
                {
                    if (contr.Name.Equals("txtCodigoDepartamento") == false)
                    {
                        contr.Text = string.Empty;
                    }
                }
            }
        }
    }
}
