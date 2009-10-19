﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;

namespace TCC.UI
{
    public partial class frmCadDepartamento : FormPai
    {
        public frmCadDepartamento()
        {
            InitializeComponent();
        }

        private void frmCadDepartamento_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            BUSINESS.rDepartamento regraDep = new TCC.BUSINESS.rDepartamento();
            try
            {
                regraDep.ValidarInsere(this.PegaDadosTela());
                base.LimpaDadosTela(this);
                this.BuscaIdMaximo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDescricaoDepartamento.Focus();
            }
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

        protected override void BuscaIdMaximo()
        {
            rDepartamento regraDepartamento = new rDepartamento();
            try
            {
                this.txtCodigoDepartamento.Text = regraDepartamento.BuscaIdMaximoDepartamento();
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
    }
}
